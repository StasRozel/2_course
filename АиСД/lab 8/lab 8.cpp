#include <iostream>
#include <string>
#include <Windows.h>

using namespace std;

void main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	int volume_backpack, amount_product;
	do
	{
		cout << "Введите вместительность рюкзака: ";
		cin >> volume_backpack;
		cin.clear();
		cin.ignore(32767, '\n');
	} while (volume_backpack <= 0);
	do
	{
		cout << "Введите количество предметов: ";
		cin >> amount_product;
		cin.clear();
		cin.ignore(32767, '\n');
	} while (amount_product <= 0);


	string* name = new string[amount_product];
	int* cost = new int[amount_product];
	int* ves = new int[amount_product];

	for (int i = 0; i < amount_product; i++)
	{
		cout << "Введите название " << i + 1 << " предмета: ";
		cin >> name[i];
		do
		{
			cout << "Введите стоимость " << i + 1 << " предмета: ";
			cin >> cost[i];
			cin.clear();
			cin.ignore(32767, '\n');
		} while (cost[i] <= 0);
		do
		{
			cout << "Введите вес " << i + 1 << " предмета: ";
			cin >> ves[i];
			cin.clear();
			cin.ignore(32767, '\n');
		} while (ves[i] <= 0);
	}

	int** A = new int* [amount_product + 1]; 
	for (int i = 0; i < amount_product + 1; i++)
	{
		A[i] = new int[volume_backpack + 1];
	}

	for (int i = 0; i < amount_product + 1; i++)
	{
		for (int j = 0; j < volume_backpack + 1; j++)
		{
			A[i][j] = 0;
		}
	}

	for (int i = 1; i < amount_product + 1; i++)
	{
		for (int j = 1; j < volume_backpack + 1; j++)
		{
			if (j < ves[i - 1])
			{
				A[i][j] = A[i - 1][j]; 
			}
			else
			{
				A[i][j] = max(A[i - 1][j], A[i - 1][j - ves[i - 1]] + cost[i - 1]);
			}
		}
	}
	cout << "Максимальная стоимость предметов, положенных в рюкзак: " << A[amount_product][volume_backpack] << "\n"
		<< "Предметы, положенные в рюкзак: \n";
	int i = amount_product, j = volume_backpack;
	while (i > 0 && j > 0)
	{
		if (A[i][j] != A[i - 1][j])
		{
			cout << name[i - 1] << "\n";
			j -= ves[i - 1];
		}
		i--;
	}
	cout << endl;
	for (int i = 0; i < amount_product + 1; i++)
	{
		delete[] A[i];
	}
	delete[] A;
	delete[] name;
	delete[] cost;
	delete[] ves;
}