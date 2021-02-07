#include "Logger.h"

Logger::Logger() {

}

Logger::~Logger() {

}


void Logger::push_log(std::string str) {
	if (this->log_que.size() < UINT32_MAX) {
		this->log_que.push(str);
	}
}


std::string Logger::pop_log() {
	std::string tmp = "";
	if (!this->log_que.empty()) {
		tmp = this->log_que.front();
		this->log_que.pop();
	}
	return tmp;
}