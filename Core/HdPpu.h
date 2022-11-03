#pragma once
#include "stdafx.h"
#include "PPU.h"
#include "HdData.h"

struct HdScreenInfo;
struct HdPackData;
class ControlManager;
class Console;

class HdPpu : public PPU
{
private:
	HdScreenInfo *_screenInfo[2];
	HdScreenInfo *_info;
	uint32_t _version;
	HdSpriteFrameRangeInfo _spriteFrameRanges[128];

protected:
	HdPackData *_hdData = nullptr;

	void DrawPixel() override;

public:
	HdPpu(shared_ptr<Console> console, HdPackData* hdData);
	virtual ~HdPpu();

	void SendFrame() override;
};