#include <iostream>
#include <limits.h>

using namespace std;

#define INF INT_MAX

int RestorePath(int D[][6], int C[][6], int V, int a, int b)
{
	if (a >= V)
	{
		cout << "Вершина " << a << " выходит из диапозона." << endl;
		return 1;
	}
	if (b >= V)
	{
		cout << "Вершина " << b << " выходит из диапозона." << endl;
		return 1;
	}
	if (D[a][b] == INF)
	{
		cout << "Данного пути из вершины " << a << " в вершину " << b << " нет." << endl;
		return 1;
	}

	if (a == b) {
		cout << "Из вершины в ту же вершину пути нет:)" << endl;
		return 1;
	}

	int k = a;
	cout << "Путь из вершины " << a + 1 << " в вершину " << b + 1 << ": ";
	cout << " " << a + 1;
	while (k != b)
	{
		k = C[k][b];

		int numberVertex = k;

		cout << " " << numberVertex+1;
	}
	cout << endl;

	return 0;
}

void FW(int mV[][6], int D[][6], int C[][6], int V, int a, int b)
{	
	D = mV;
	for (int i = 0; i < V; i++)
	{
		for (int j = 0; j < V; j++)
		{
			if (i == j)
				D[i][j] = 0;
			C[i][j] = j;
		}
	};

	for (int k = 0; k < V; k++)
	{
		for (int i = 0; i < V; i++)
		{
			for (int j = 0; j < V; j++)
			{
				if ((D[i][k] != INF) && (D[k][j] != INF))
				{
					if (D[i][j] > D[i][k] + D[k][j])
					{
						D[i][j] = D[i][k] + D[k][j];
						C[i][j] = C[i][k];
					}
				}
			}
		}
	}

	cout << "Матрица длин кратчайших путей:" << endl;
	for (int i = 0; i < V; i++)
	{
		for (int j = 0; j < V; j++)
		{
			if (D[i][j] != INF)
				cout << D[i][j] << "\t";
			else
				cout << " ∞ ";
		}
		cout << endl;
		cout << endl;
	}

	cout << "Матрица кратчайших путей:" << endl;
	for (int i = 0; i < V; i++)
	{
		for (int j = 0; j < V; j++)
		{
			if (i == j)
				C[i][j] = -1;
			cout << " " << C[i][j] + 1 << "\t";
		}
		cout << endl;
		cout << endl;
	}

	RestorePath(D, C, V, a, b);
}

int main()
{
	setlocale(LC_ALL, "Rus");
	
	int GR[6][6] =
	{
		{0,  28,  21,  59,  12,  27},
		{7,   0,  24, INF,  21,   9},
		{9,  32,   0,  13,  11, INF},
		{8, INF,   5,   0,  16, INF},
		{14, 13,  15,  10,   0,  22},
		{15, 18, INF, INF,   6,   0}
	};

	int D[6][6], C[6][6];

	FW(GR, D, C, 6, 0, 3);
	
	return 0;
}