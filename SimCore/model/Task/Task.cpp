#include "Task.h"

// this->task[call back] is not working pointer...
// replace global variable.
std::vector<std::function<void(void)>> g_call_back_task;

Task::Task() {
	this->task.clear();
	this->task.resize((std::size_t)TASK_TYPE::TASK_NUM);
	this->thread = nullptr;
	thread_state = ThereadFlag::ThreadIdle;
}

Task::~Task() {
	// cleanup task list
	this->task.clear();

	// stop thread

	// clear thread
	this->thread = nullptr;
}

void Task::add_task(TASK_TYPE type, std::function<void()> task) {
	this->task[(uint_fast32_t)type].push_back(task);
}


void Task::call_task(Timer* timer, SimTimerIdx idx, TASK_TYPE task_type, uint_fast64_t period) {
	if (timer->Timers.at((std::size_t)idx) % period == 0) {
		for (size_t i = 0; i < this->task[(std::size_t)task_type].size(); i++) {
			this->task[(std::size_t)task_type][i]();
		}
		timer->set(idx, 0);
	}
}


void Task::Main(void){}

void Task::Main(Timer* timer) {
	call_task(timer, SimTimerIdx::SimTimer100us,	TASK_TYPE::TASK_100US,	100);
	call_task(timer, SimTimerIdx::SimTimer1ms,		TASK_TYPE::TASK_1MS,	1000);
	call_task(timer, SimTimerIdx::SimTimer4ms,		TASK_TYPE::TASK_4MS,	4000);
	call_task(timer, SimTimerIdx::SimTimer20ms,		TASK_TYPE::TASK_20MS,	20000);

	if(thread_state == ThereadFlag::ThreadIdle){
		for (uint_fast32_t i = 0; i < task[(uint_fast32_t)TASK_TYPE::TASK_CALLBACK].size(); i++) {
			g_call_back_task.push_back(task[(uint_fast32_t)TASK_TYPE::TASK_CALLBACK].at(i));
		}
		
		thread_state = ThereadFlag::ThreadBusy;
		this->ThreadStart(0);
	}
}

void Task::Reset(void) {

}

////////////////////////////////////////////////////////////////////////////////////

int Task::ThreadStart(uint32_t stack_size) {
	this->thread = (HANDLE)_beginthread(
		&Task::ExcutedThread,
		stack_size,
		this);
	return 0;
}

void Task::ExcutedThread(void* args) {
	reinterpret_cast<Task*>(args)->ExcutedTask();	// force cast
}

void Task::ExcutedTask(void) {
	for (size_t i = 0; i < g_call_back_task.size(); i++) {
		g_call_back_task[i]();
	}
	g_call_back_task.clear();
	thread_state = ThereadFlag::ThreadIdle;
}

void Task::EndThread(void) {
}