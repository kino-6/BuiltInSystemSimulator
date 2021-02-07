#pragma once
#include "BaseModel.h"

class Timer :
    public BaseModel
{
public:
	std::vector<uint64_t> Timers;
	uint64_t ticks;

public:
	Timer(void);
	void reset(void);
	void reset(SimTimerIdx idx);
	void set(SimTimerIdx idx, uint64_t val);
	void set_ticks(uint64_t val);
	void tick(void);
	void tick(SimTimerIdx idx, uint64_t val);
	bool is_time_out(SimTimerIdx idx, uint64_t val);

	///////////////////////////////////////////////////////////////////////////
	void Main(void);
	void Reset(void);

	///////////////////////////////////////////////////////////////////////////

	~Timer(void);

};

