#ifndef SC_CONTROL_H
#define SC_CONTROL_H

#include "Chip_access.h"

extern void task_init(void);

extern void task_100us_1(void);
extern void task_100us_2(void);
extern void task_100us_3(void);

extern void task_1ms_1(void);
extern void task_1ms_2(void);

extern void task_4ms_1(void);
extern void task_4ms_2(void);
extern void task_4ms_3(void);
extern void task_4ms_4(void);
extern void task_4ms_5(void);

extern void task_20ms_1(void);
extern void task_20ms_2(void);

extern void call_back_1(void);
extern void call_back_2(void);

typedef enum {
	TASK_INIT,
	TASK_100US_1,
	TASK_100US_2,
	TASK_100US_3,
	TASK_1MS_1,
	TASK_1MS_2,
	TASK_4MS_1,
	TASK_4MS_2,
	TASK_4MS_3,
	TASK_4MS_4,
	TASK_4MS_5,
	TASK_20MS_1,
	TASK_20MS_2,
	TASK_CALL_BACK_1,
	TASK_CALL_BACK_2,
	TASK_NUM
} task_num_e;

extern unsigned int g_task_cnt[TASK_NUM];

#endif /* SC_CONTROL_H */