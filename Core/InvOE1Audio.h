#pragma once
#include "stdafx.h"
#include "Snapshotable.h"
#include "APU.h"
#include "BaseExpansionAudio.h"
#include "Console.h"

#include <array>

class InvOE1Audio : public BaseExpansionAudio
{
private:
	int8_t _currentOutput;
	int8_t _lastOutput;

	void UpdateOutputLevel()
	{
		if (_currentOutput != _lastOutput) {
			_console->GetApu()->AddExpansionAudioDelta(AudioChannel::InvOE1, _currentOutput - _lastOutput);
			_lastOutput = _currentOutput;
		}
	}

protected:
	void StreamState(bool saving) override
	{
	}

	void ClockAudio() override
	{
		_currentOutput = _console->_InvOE1;
		UpdateOutputLevel();
	}

public:
	InvOE1Audio(shared_ptr<Console> console) : BaseExpansionAudio(console)
	{
		_lastOutput = 0;
		_currentOutput = 0;
	}
};