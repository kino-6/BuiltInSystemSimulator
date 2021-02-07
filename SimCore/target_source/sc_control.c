#include "sc_control.h"
int task_cnt[2];

void task_100us_1(void){
	SMR = 1;
}

void task_100us_2(void){}
void task_100us_3(void){}

void task_1ms_1(void){}
void task_1ms_2(void){}

void task_4ms_1(void){}
void task_4ms_2(void){}
void task_4ms_3(void){}
void task_4ms_4(void){}
void task_4ms_5(void){}

void task_20ms_1(void) {}
void task_20ms_2(void) {}


void call_back_1(void){
	task_cnt[0]++;
}

void call_back_2(void){
	task_cnt[1]++;
}


