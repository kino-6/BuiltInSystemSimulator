#pragma once
#include "BaseModel.h"
#include "Power.h"
#include "Task.h"
#include "Timer.h"
#include "Chip.h"

// C I/F
#include "interface_for_target_source.h"

class Ecu :
    public BaseModel
{
public:
    Timer* timer;
    Task* task;
    Chip* chip;
    Power* power;

public:
    Ecu();
    ~Ecu();

    void Main(void);
    void Reset(void);


};

