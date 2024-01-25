#include <iostream>
#include <vector>
#include <map>
#include <set>
#include <limits>

using namespace std;

const int INF = numeric_limits<int>::max();

// Структура для представления ребра графа
struct Edge {
	char to;
	int cost;
};

// Функция для ввода графа с клавиатуры
map<char, vector<Edge>> inputGraph() {
	int n, m;
	cout << "Введите количество вершин и количество рёбер: ";
	cin >> n >> m;

	cin.ignore();

	map<char, vector<Edge>> graph;

	cout << "Введите рёбра и их веса:" << endl;
	for (int i = 0; i < m; i++) {
		char from, to;
		int cost;
		
		cin >> from >> to >> cost;
		cin.ignore();
		graph[from].push_back({ to, cost });
	}

	return graph;
}

// Алгоритм Дейкстры
map<char, int> dijkstra(map<char, vector<Edge>>& graph, char start) {
	map<char, int> dist;
	for (auto& pair : graph) {
		dist[pair.first] = INF;
	}

	dist[start] = 0;

	set<char> visited;

	while (visited.size() < graph.size()) {
		char minVertex = ' ';

		for (auto& pair : dist) {
			if (visited.count(pair.first) == 0 &&
				(minVertex == ' ' || pair.second < dist[minVertex])) {
				minVertex = pair.first;
			}
		}

		if (minVertex == ' ') {
			break;
		}

		for (Edge& edge : graph[minVertex]) {
			char to = edge.to;
			int cost = edge.cost;
			if (dist[to] > dist[minVertex] + cost) {
				dist[to] = dist[minVertex] + cost;
			}
		}
		visited.insert(minVertex);
	}

	return dist;
}


	int main() {
		setlocale(LC_ALL, "rus");

		map<char, vector<Edge>> graph = inputGraph();

		char start;
		cout << "Введите начальную вершину: ";
		cin >> start;

		map<char, int> result = dijkstra(graph, start);

		// Вывод результата
		for (auto& pair : result) {
			if (pair.second != INF) {
				cout << start << " -> " << pair.first << " = " << pair.second << endl;
			}
			else {
				cout << start << " -> " << pair.first << " = Недостижимо" << endl;
			}
		}

		return 0;
	}
