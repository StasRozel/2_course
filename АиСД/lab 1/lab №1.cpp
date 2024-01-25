#include <iostream>

using std::cout;
using std::cin;
using std::endl;

void hanoi(int n, int from, int to, int buff)
{
	if (n == 1)
	{
		cout << "Переместить диск " << n << " c " << from << " на " << to << endl;
	}
	else if (n > 1)
	{
		hanoi(n - 1, from, buff, to);
		cout << "Переместить диск " << n << " c " << from << " на " << to << endl;
		hanoi(n - 1, buff, to, from);
	}
}	

int main()
{

	setlocale(LC_ALL, "rus");
	int numDisk, amount;

	cout << "Число дисков на стержне: ";
	cin >> numDisk;
	cout << "С какого стержня переместить: ";
	cin >> amount;

	if (numDisk > 0 && amount > 2) {
		hanoi(numDisk, 1, amount, 2);
	}
	else {
		cout << "Данные введенны не корректно";
	}

}


