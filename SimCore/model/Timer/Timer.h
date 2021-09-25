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
	void set(SimTimerIdx idx, uint_fast64_t val);
	void set_ticks(uint_fast64_t val);
	uint_fast64_t get_ticks(SimTimerIdx idx);
	void tick(void);
	void tick(SimTimerIdx idx, uint_fast64_t val);
	bool is_time_out(SimTimerIdx idx, uint_fast64_t val);

	///////////////////////////////////////////////////////////////////////////
	void Main(void);
	void Reset(void);

	///////////////////////////////////////////////////////////////////////////

	~Timer(void);

};

