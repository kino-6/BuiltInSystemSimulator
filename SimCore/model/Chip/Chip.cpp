#include "Chip.h"

SFR g_sfr;

Chip::Chip(void) {
	this->Reset();
}


Chip::~Chip(void) {

}


void Chip::Main(void) {
	this->fetch_sfr();
	this->sfr.TMR += 1;
	this->reflect_sfr();
}


void Chip::reflect_sfr(void) {
	g_sfr = this->sfr;
}


void Chip::fetch_sfr(void) {
	this->sfr = g_sfr;
}


void Chip::Reset(void) {
	this->sfr = { 0 };
	g_sfr = this->sfr;
}