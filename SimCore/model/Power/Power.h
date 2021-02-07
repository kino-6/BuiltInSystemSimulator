#pragma once
#include "BaseModel.h"
class Power :
    public BaseModel
{
public:
    long double input_v;
    long double output_v;

    Power();
    ~Power();

    void input(long double input_v);
    long double output(void);
    void Main(void);
    void Reset(void);
};

