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

    const uint64_t sim_time = 5000;

    ecu[0].task->add_task(TASK_TYPE::TASK_100US, task_100us_1);
    ecu[0].task->add_task(TASK_TYPE::TASK_100US, task_100us_2);
    ecu[0].task->add_task(TASK_TYPE::TASK_100US, task_100us_3);
    ecu[0].task->add_task(TASK_TYPE::TASK_1MS, task_1ms_1);
    ecu[0].task->add_task(TASK_TYPE::TASK_1MS, task_1ms_2);
    ecu[0].task->add_task(TASK_TYPE::TASK_4MS, task_4ms_1);
    ecu[0].task->add_task(TASK_TYPE::TASK_20MS, task_20ms_1);
    //ecu[0].task->add_task(TASK_TYPE::TASK_CALLBACK, call_back_1);

    ecu[0].task->add_task(TASK_TYPE::TASK_100US, task_100us_1);
    ecu[0].task->add_task(TASK_TYPE::TASK_100US, task_100us_2);
    ecu[0].task->add_task(TASK_TYPE::TASK_100US, task_100us_3);
    ecu[0].task->add_task(TASK_TYPE::TASK_1MS, task_1ms_1);
    ecu[0].task->add_task(TASK_TYPE::TASK_1MS, task_1ms_2);
    ecu[0].task->add_task(TASK_TYPE::TASK_4MS, task_4ms_1);
    ecu[0].task->add_task(TASK_TYPE::TASK_20MS, task_20ms_1);

    for(auto i=0; i<sim_time; i++){
        ecu[0].Main();
        ecu[1].Main();
        progress = (double)((double)i/(double)sim_time)*100.0;
    }
}
