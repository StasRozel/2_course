#include <iostream>
#include <vector>
#include <algorithm> 

using namespace std;

struct Edge
{
	int start;
	int end;
	int weight;
};


class Graph
{
private:
	int graphMatrix[8][8] = {
		{INT_MAX, 2, INT_MAX, 8, 2, INT_MAX, INT_MAX, INT_MAX},
		{2, INT_MAX, 3, 10, 5, INT_MAX, INT_MAX, INT_MAX},
		{INT_MAX, 3, INT_MAX, INT_MAX, 12, INT_MAX,INT_MAX, 7},
		{8, 10, INT_MAX, INT_MAX, 14, 3, 1, INT_MAX},
		{2, 5, 12, 14, INT_MAX, 11, 4, 8},
		{INT_MAX, INT_MAX, INT_MAX, 3, 11, INT_MAX, 6, INT_MAX},
		{INT_MAX, INT_MAX, INT_MAX, 1, 4, 6, INT_MAX, 9},
		{INT_MAX, INT_MAX, 7, INT_MAX, 8, INT_MAX, 9, INT_MAX}
	};

	std::vector <Edge> edgeList = {
		{1, 2, 2},{1, 5, 2},{1, 4, 8},{2, 3, 3},{2, 5, 5},{2, 4, 10},{3, 8, 7},{4, 7, 1},
		{4, 6, 3},{5, 7, 4},{5, 8, 8},{5, 6, 11},{5, 3, 12},{5, 4, 14},{6, 7, 6},{7, 8, 9}
	};
public:
	void Prim();
	void Kraskal();
};

void Graph::Prim()
{
	int visited[8];
	for (int i = 0; i < 8; i++)
		visited[i] = false;

	visited[0] = true;
	int currentEdge = 0;
	int x;
	int y;
	while (currentEdge < 7)
	{
		int min = INT_MAX;
		x = 0;
		y = 0;

		for (int i = 0; i < 8; i++)
		{
			if (visited[i])
			{
				for (int j = 0; j < 8; j++)
				{
					if (!visited[j] && min > graphMatrix[i][j])
					{
							min = graphMatrix[i][j];
							x = i;
							y = j;
					}
				}
			}
		}

		cout << "Вершина " << x + 1 << " - " << "вершина " << y + 1 << " Вес ребра: " << graphMatrix[x][y] << endl;
		visited[y] = true;
		currentEdge++;
	}
}

void Graph::Kraskal()
{
	int n = 8;

	int connectedVert[8];

	for (int i = 0; i < n; i++)
		connectedVert[i] = i;

	std::sort(edgeList.begin(), edgeList.end(), [](Edge& a, Edge& b) { return a.weight < b.weight; });

	for (Edge& e : edgeList)
	{
		if (connectedVert[e.start] != connectedVert[e.end])
		{
			cout << "Вершина " << e.start << " - " << "вершина " << e.end << " Вес ребра: " << e.weight << endl;

			int oldVert = connectedVert[e.start], newVert = connectedVert[e.end];

			for (int i = 0; i < n; i++)
			{
				if (connectedVert[i] == oldVert)
					connectedVert[i] = newVert;
			}
		}
	}
}


int main()
{
	setlocale(LC_ALL, "Rus");
	Graph graph;

	cout << "Алгоритм Прима\n";

	graph.Prim();

	cout << "\nАлгоритм Краскала\n";

	graph.Kraskal();
}
