#pragma once
#ifndef __ECU_SIM_H__
#define __ECU_SIM_H__

#include "all.h"

#define GET_ARRAY_SIZE(array)	sizeof(array)/sizeof(array[0])

#define DLLEXPORT extern "C" __declspec(dllexport)

DLLEXPORT void sim_main(void);
DLLEXPORT std::size_t get_log(char* str, std::uint_fast64_t length);
DLLEXPORT double get_progress(void);

#endif /* __ECU_SIM_H__ */