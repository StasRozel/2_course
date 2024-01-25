#include "stdafx.h"

void Deserializer::DeserializeData()
{

	file = ifstream("E:\\Универ\\2 курс\\КПО\\4 asm\\Serializer\\Serializer\\bin.bin");
	unsigned char marker;
	unsigned char currentLength;

	while (!file.eof())
	{
		file.read((char*)(&marker), 1);
		file.read((char*)(&currentLength), 1);

		if (marker == 0x01)
			file.read((char*)(&myBool), currentLength);
		else if (marker == 0x02)
			file.read((char*)(&myInt), currentLength);
	}

	cout << myBool << " " << myInt << endl;

	file.close();
}

void Deserializer::ConvertToAssembler()
{
	fileAsm = ofstream("E:\\Универ\\2 курс\\КПО\\4 asm\\Serializer\\ASM\\AsmFile.asm");


	fileAsm.clear();

	fileAsm ASM_HEAD;

	fileAsm << "BOOLF	BYTE " << myBool << endl;
	fileAsm << "INTF	DWORD " << myInt << endl;
	fileAsm << "STRF	DB \"" << myBool << "\t" << myInt << "\", 0" << endl << endl;

	fileAsm ASM_FOOTER;

	fileAsm.close();
}