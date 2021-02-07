#pragma once
typedef unsigned long long uint64_t;

#ifdef __cplusplus
extern "C" {
#endif /* __cplusplus */

typedef struct {
	uint64_t SMR;
	uint64_t BRR;
	uint64_t SCR;
	uint64_t TDR;
	uint64_t SSR;
	uint64_t RDR;
	uint64_t TMR;
} SFR;

extern SFR g_sfr;

#ifdef __cplusplus
}
#endif /* __cplusplus */