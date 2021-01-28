#pragma once
#include "stdafx.h"
#include "Snapshotable.h"
#include "APU.h"
#include "BaseExpansionAudio.h"
#include "SSGAudio.h"
#include "Console.h"

#include <array>
#include "opll.h"

class Vrc7Audio : public BaseExpansionAudio
{
private:
	opll_t _chip;

	int16_t _lastOutput;
	int16_t _currentOutput;

	double _clock;

	static constexpr uint8_t cycleCount = 12;

	struct InputEntry
	{
		uint8_t addr = 0;
		uint8_t data = 0;
		uint8_t cycle = 0;
		uint8_t wrote = 0;
	};

	static constexpr uint8_t INPUT_BUFFER_SIZE = cycleCount;
	using InputBuffer = std::array<InputEntry, INPUT_BUFFER_SIZE>;
	InputBuffer _inputBuffer;

	void UpdateOutputLevel()
	{
		int16_t summedOutput = 0;
		_console->GetApu()->AddExpansionAudioDelta(AudioChannel::VRC7, _currentOutput - _lastOutput);
		_lastOutput = _currentOutput;
	}

	uint8_t GetCurrentCycle() const
	{
		return static_cast<uint8_t>(std::floor(_clock)) % cycleCount;
	}

	void WriteToChip(uint8_t a, uint8_t d)
	{
		const auto cycle = GetCurrentCycle();

		if (_inputBuffer[cycle].wrote)
		{
			std::cout << "VRC7 CHIP DOUBLE WRITE" << std::endl;
		}

		_inputBuffer[cycle] = {
			a,
			d,
			cycle,
			true
		};
	}

	uint32_t getClockFrequency()
	{
		uint32_t vrc7clock = 3579545 / 4;
		return vrc7clock;
	}

protected:
	void StreamState(bool saving) override
	{

		ValueInfo<int16_t> lastOutput{ &_lastOutput };
		ValueInfo<int16_t> currentOutput{ &_currentOutput };
		ArrayInfo<InputBuffer> inputBuffer{ &_inputBuffer };
		ValueInfo<opll_t> chip{ &_chip };
		ValueInfo<double> clock{ &_clock };
		Stream(lastOutput, currentOutput, inputBuffer, chip, clock);
	}

	void ClockAudio() override
	{

		_clock += getClockFrequency() / (double)_console->GetCpu()->GetClockRate(_console->GetModel());

		while (_clock >= cycleCount)
		{

				_currentOutput = 0;


			for (uint8_t cycle = 0; cycle < cycleCount; cycle++)
			{
				_clock--;

				int32_t samples[2];
				OPLL_Clock(&_chip, samples);

				for (uint8_t x = 0; x < 2; x++)
				{
					_currentOutput += samples[x];
				}

				auto& input = _inputBuffer[cycle];
				if (input.wrote)
				{
					input.wrote = false;

					OPLL_Write(&_chip, input.addr, input.data);
				}
			}

			UpdateOutputLevel();
		}
	}

public:
	Vrc7Audio(shared_ptr<Console> console) : BaseExpansionAudio(console)
	{
		_lastOutput = 0;
		_currentOutput = 0;
		_inputBuffer = {};

		_clock = 0;

		OPLL_Reset(&_chip, opll_type_ds1001);
	}

	void WriteRegister(uint16_t addr, uint8_t value)
	{
		switch (addr) {
		case 0x9010:
		case 0x9030:

			const uint8_t a0 = (addr & 0xF030) == 0x9030;
			WriteToChip(a0, value);

			break;
		}
	}
};