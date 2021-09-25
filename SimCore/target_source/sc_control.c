#include "sc_control.h"
unsigned int g_task_cnt[TASK_NUM] = { 0 };

void task_init(void) {
	unsigned int i;
	for (i = 0; i < TASK_NUM; i++) {
		g_task_cnt[i] = 0;
	}
	g_task_cnt[TASK_INIT] ++;
}

void task_100us_1(void){
	SMR = 1;

	g_task_cnt[TASK_100US_1] ++;
}

void task_100us_2(void){
	g_task_cnt[TASK_100US_2] ++;
}

void task_100us_3(void){
	g_task_cnt[TASK_100US_3] ++;
}

void task_1ms_1(void){
	g_task_cnt[TASK_1MS_1] ++;
}

void task_1ms_2(void){
	g_task_cnt[TASK_1MS_2] ++;
}

void task_4ms_1(void){
	g_task_cnt[TASK_4MS_1] ++;
}

void task_4ms_2(void){
	g_task_cnt[TASK_4MS_2] ++;
}

void task_4ms_3(void){
	g_task_cnt[TASK_4MS_3] ++;
}

void task_4ms_4(void){
	g_task_cnt[TASK_4MS_4] ++;
}

void task_4ms_5(void){
	g_task_cnt[TASK_4MS_5] ++;
}

void task_20ms_1(void){
	g_task_cnt[TASK_20MS_1] ++;
}

void task_20ms_2(void){
	g_task_cnt[TASK_20MS_2] ++;
}

void call_back_1(void){
	g_task_cnt[TASK_CALL_BACK_1]++;
}

void call_back_2(void){
	g_task_cnt[TASK_CALL_BACK_2]++;
}


