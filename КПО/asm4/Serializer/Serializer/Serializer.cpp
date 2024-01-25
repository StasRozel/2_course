#include "stdafx.h"


void Serealizer::SerealizeData()
{
	file = ofstream("E:\\Универ\\2 курс\\КПО\\4 asm\\Serializer\\Serializer\\bin.bin");

	file.clear();


	file.write((char*)&boolMarker, 1);
	file.write((char*)&boolLength, 1);
	file.write((char*)(&myBool), boolLength);

	file.write((char*)&IntMarker, 1);
	file.write((char*)&IntLength, 1);
	file.write((char*)(&myInt), IntLength);

	file.close();
}
