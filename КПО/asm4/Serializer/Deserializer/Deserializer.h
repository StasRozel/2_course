#pragma once
#include "stdafx.h"

class Deserializer
{
protected:
	std::ifstream file;
	std::ofstream fileAsm;
	unsigned char boolMarker = 0x01;
	unsigned char intMarker = 0x02;

	bool myBool;
	int myInt;

public:

	Deserializer()
	{
		this->myBool = NULL;
		this->myInt = NULL;
	}

	void DeserializeData();
	void ConvertToAssembler();
};
