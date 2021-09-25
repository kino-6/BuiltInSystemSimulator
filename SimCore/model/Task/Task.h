#pragma once
#include "BaseModel.h"
#include "Timer.h"

#include <Windows.h>
#include <process.h>

enum class ThereadFlag {
	ThreadIdle,
	ThreadBusy,
	ThreadStateNum
};

typedef enum{
	ONE_TIME_CALL_YET,
	ONE_TIME_CALL_FINISHED
} one_time_e;

class Task :
    public BaseModel
{
private:
	uint_fast8_t one_time_flag;

public:
	std::vector< std::vector<std::function< void(void) > > > task;
	HANDLE thread;
	ThereadFlag thread_state;

	Task();
	~Task();

	// taks main
	void Main(void);
	void Main(Timer* timer);
	void Reset(void);
	void register_task(TASK_TYPE type, std::function<void()> task);
	void call_task(Timer* timer, SimTimerIdx idx, TASK_TYPE task_type, uint_fast64_t period);

	// call back
	int ThreadStart(uint32_t stack_size);
	static void ExcutedThread(void* args);
	void ExcutedTask(void);
	void EndThread(void);
};

