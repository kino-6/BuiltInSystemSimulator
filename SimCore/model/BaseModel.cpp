#include "BaseModel.h"

BaseModel::BaseModel(){
	this->idx = 0;
}

BaseModel::~BaseModel(){}
void BaseModel::Main(void) {}
void BaseModel::Reset(void) {}

void BaseModel::SetIdx(std::uint_fast64_t idx) {
	this->idx = idx;
}

