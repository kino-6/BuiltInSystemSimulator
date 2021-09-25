#include "all.h"

#include "interface_for_ui.h"
#include "interface_for_target_source.h"

#include "Logger.h"
#include "Ecu.h"

Logger g_logger;
double progress = 0.0;

DLLEXPORT std::size_t get_log(char* str, std::uint_fast64_t length) {
    std::size_t size = g_logger.log_que.size();
    sprintf_s(str, length, g_logger.pop_log().c_str());
    return size;
}

DLLEXPORT double get_progress(void) {
    return progress;
}


DLLEXPORT void sim_main(void)
{
    Ecu ecu[2];

    const uint64_t sim_time = 2000; // 50us * 2000
    ecu[0].task->register_task(TASK_TYPE::TASK_ONE_TIME, task_init);
    ecu[0].task->register_task(TASK_TYPE::TASK_100US, task_100us_1);
    ecu[0].task->register_task(TASK_TYPE::TASK_100US, task_100us_2);
    ecu[0].task->register_task(TASK_TYPE::TASK_100US, task_100us_3);
    ecu[0].task->register_task(TASK_TYPE::TASK_1MS, task_1ms_1);
    ecu[0].task->register_task(TASK_TYPE::TASK_1MS, task_1ms_2);
    ecu[0].task->register_task(TASK_TYPE::TASK_4MS, task_4ms_1);
    ecu[0].task->register_task(TASK_TYPE::TASK_20MS, task_20ms_1);

    ecu[1].task->register_task(TASK_TYPE::TASK_ONE_TIME, task_init);
    ecu[1].task->register_task(TASK_TYPE::TASK_100US, task_100us_1);
    ecu[1].task->register_task(TASK_TYPE::TASK_100US, task_100us_2);
    ecu[1].task->register_task(TASK_TYPE::TASK_100US, task_100us_3);
    ecu[1].task->register_task(TASK_TYPE::TASK_1MS, task_1ms_1);
    ecu[1].task->register_task(TASK_TYPE::TASK_1MS, task_1ms_2);
    ecu[1].task->register_task(TASK_TYPE::TASK_4MS, task_4ms_1);
    ecu[1].task->register_task(TASK_TYPE::TASK_20MS, task_20ms_1);

    for(auto i=0; i<sim_time; i++){
        ecu[0].Main();
        ecu[1].Main();
        progress = (double)((double)i/(double)sim_time)*100.0;
    }

    g_logger.push_log("Simulation time[0] = " + std::to_string(ecu[0].timer->get_ticks(SimTimerIdx::SimTimerAllTime) / 1000) + " [ms]");
    g_logger.push_log("Simulation time[1] = " + std::to_string(ecu[1].timer->get_ticks(SimTimerIdx::SimTimerAllTime) / 1000) + " [ms]");

    std::string task_call_cnt = "task call counter[0] + [1]: ";
    for(int32_t i=0; i<TASK_NUM; i++){
        task_call_cnt += std::to_string(g_task_cnt[i]) + " ";
    }
    g_logger.push_log(task_call_cnt);
    g_logger.push_log("Simulation Completed!");
}
