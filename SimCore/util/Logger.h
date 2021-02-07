#pragma once
#include "all.h"

class Logger
{
public:
	std::queue<std::string> log_que;

public:
	Logger(void);
	~Logger(void);
	void push_log(std::string str);	// push log from other program
	std::string pop_log();		// pop log for C# UI
};

