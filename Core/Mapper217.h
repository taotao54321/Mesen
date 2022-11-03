#pragma once
#include "stdafx.h"
#include "BaseMapper.h"

class Mapper217 : public BaseMapper
{
protected:
	virtual uint16_t GetPRGPageSize() override { return 0x8000; }
	virtual uint16_t GetCHRPageSize() override { return 0x2000; }

	void InitMapper() override
	{
		WriteRegister(0, 0);
	}

	void WriteRegister(uint16_t addr, uint8_t value) override
	{
		SelectCHRPage(0, addr & 0x0F);
		addr >>= 2;
		SelectPRGPage(0, addr & 0x03);
	}
};