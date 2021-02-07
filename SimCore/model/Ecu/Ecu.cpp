#include "Ecu.h"

Ecu::Ecu(void){
    this->Reset();
}

Ecu::~Ecu(void) {

}

void Ecu::Main() {
    this->timer->Main();
    this->task->Main(this->timer);
    this->chip->Main();
    this->power->Main();
}

void Ecu::Reset(){
    this->timer = new Timer();
    this->task = new Task();
    this->chip = new Chip();
    this->power = new Power();

    // timer
    this->timer->Reset();

    // task
    this->task->Reset();

    // chip
    this->chip->Reset();

    // power
    this->power->Reset();
}