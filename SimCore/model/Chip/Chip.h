#pragma once
#include "all.h"
#include "BaseModel.h"
#include "Chip_reg.h"

class Chip :
    public BaseModel
{
    public:
        Chip(void);
        ~Chip(void);

        void Main(void);
        void Reset(void);
        void reflect_sfr(void);
        void fetch_sfr(void);

    public:
        SFR sfr;
};

