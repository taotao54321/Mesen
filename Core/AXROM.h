#pragma once
#include "stdafx.h"
#include "BaseMapper.h"
#include "CPU.h"
#include "EPSGAudio.h"


using AudioClass = EPSGAudio;

class AXROM : public BaseMapper
{
	public:
		unique_ptr<AudioClass> _audio;

		void ProcessCpuClock() override
		{
			_audio->Clock();
		}
	protected:
		virtual uint16_t GetPRGPageSize() override { return 0x8000; }
		virtual uint16_t GetCHRPageSize() override {	return 0x2000; }

		void InitMapper() override 
		{
			SelectCHRPage(0, 0);
			WriteRegister(0, GetPowerOnByte());
			_audio.reset(new AudioClass(_console));
		}

		virtual void StreamState(bool saving) override
		{
			BaseMapper::StreamState(saving);
			SnapshotInfo audio{ _audio.get() };
			Stream(audio);
		}
		
		bool HasBusConflicts() override { return _romInfo.SubMapperID == 2; }

		void WriteRegister(uint16_t addr, uint8_t value) override
		{
			SelectPRGPage(0, value & 0x0F);

			SetMirroringType(((value & 0x10) == 0x10) ? MirroringType::ScreenBOnly : MirroringType::ScreenAOnly);
		}
		void WriteEPSG(uint16_t addr, uint8_t value) override
		{
			switch (addr & 0x4016) {
			case 0x4016:
					_audio->WriteRegister(addr, value);
				break;
			}
		}
};