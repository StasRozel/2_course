#include "stdafx.h"


int main()
{
	int i;
	unsigned int ui;

	cin >> i;
	cin >> ui;



	Serealizer serealizer(i, ui);
	serealizer.SerealizeData();
	system("pause");
}
