#pragma once
#include "stdafx.h"

class Serealizer
{
private:

	std::ofstream file;
	unsigned char boolMarker = 0x01;
	unsigned char IntMarker = 0x02;
	unsigned char boolLength = sizeof(bool);
	unsigned char IntLength = sizeof(int);
	int myBool;
	unsigned int myInt;

public:

	Serealizer(bool myBool, int myInt)
	{
		this->myBool = myBool;
		this->myInt = myInt;
	}

	void SerealizeData();

};

