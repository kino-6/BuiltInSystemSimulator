#pragma once
#include "all.h"

enum class TASK_TYPE : std::uint_fast32_t {
	TASK_100US = 0,
	TASK_1MS,
	TASK_4MS,
	TASK_20MS,
	TASK_CALLBACK,
	TASK_ONE_TIME,
	TASK_NUM
};

enum class CPU_TYPE : std::uint_fast32_t {
	CPU1 = 0,
	CPU2,
	CPUNum
};

enum class SimTimerIdx : std::uint_fast32_t{
	SimTimerAllTime,
	SimTimer100us,
	SimTimer1ms,
	SimTimer4ms,
	SimTimer20ms,
	SimTimerOneTime,
	SimTimerNum
};


class BaseModel
{
public:
	std::uint_fast64_t idx;		// this model idx
	BaseModel();
	~BaseModel();
	virtual void Main(void);
	virtual void Reset(void);
	virtual void SetIdx(std::uint_fast64_t idx);
};