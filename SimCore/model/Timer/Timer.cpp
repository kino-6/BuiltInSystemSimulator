#include "Timer.h"

Timer::Timer(void)
{
	ticks = 50;
	Timers.resize((std::size_t)SimTimerIdx::SimTimerNum);
	reset();
}


void Timer::reset(void) {
	for (auto it = std::begin(Timers); it != std::end(Timers); ++it) {
		*it = 0;
	}
	set_ticks(ticks);
}


void Timer::reset(SimTimerIdx idx) {
	Timers.at((std::size_t)idx) = 0;
}


void Timer::set(SimTimerIdx idx, uint_fast64_t val) {
	Timers.at((std::size_t)idx) = val;
}


void Timer::set_ticks(uint_fast64_t val) {
	ticks = val;
}

uint_fast64_t Timer::get_ticks(SimTimerIdx idx) {
	return Timers.at((std::size_t)idx);
}

void Timer::tick(void) {
	for (auto it = std::begin(Timers); it != std::end(Timers); ++it) {
		*it += this->ticks;
	}
}


void Timer::tick(SimTimerIdx idx, uint_fast64_t val) {
	Timers.at((std::size_t)idx) = val;
}


bool Timer::is_time_out(SimTimerIdx idx, uint_fast64_t val) {
	if (Timers.at((std::size_t)idx) > val) {
		return true;
	}
	else {
		return false;
	}
}


////////////////////////////////////////////////////////////////////////////////////
void Timer::Main(void) {
	this->tick();
}

void Timer::Reset(void) {
	this->reset();
}

////////////////////////////////////////////////////////////////////////////////////


Timer::~Timer(void)
{
}
