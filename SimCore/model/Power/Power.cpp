#include "Power.h"

Power::Power() {
	this->Reset();
}

Power::~Power() {

}

void Power::Reset() {
	this->input_v = 0;
	this->output_v = 0;
}

void Power::input(long double input_v) {
	this->input_v = input_v;
}

long double Power::output(void) {
	this->output_v = this->input_v;
	return this->output_v;
}

void Power::Main(void) {
	this->input(42);
	this->output();
}