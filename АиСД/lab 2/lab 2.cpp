#include <iostream>
#include <vector>
#include <stack>
#include <queue>

using namespace std;

void bfs(int start, int end, vector<vector<int>>& graph, vector<bool>& visited) {

    queue<int> q;
    q.push(start);
    visited[start] = true;
    cout << start + 1 << " ";

    while (!q.empty()) {

        int u = q.front();
        q.pop();

        for (int x : graph[u]) {
            if (!visited[x]) {
                q.push(x);
                visited[x] = true;
                cout << x + 1 << " ";
                if (visited[end])
                {
                    return;
                }
            }
        }
    }

    if (visited[end]) {
        cout << "\nЦелевая вершина " << end + 1 << " найдена!";
    }
    else {
        cout << "\nЦелевая вершина не найдена";
    }
}


void dfs(int start, int end, vector<vector<int>> graph, vector<bool> visited) {

    stack<int> s;
    s.push(start);

    while (!s.empty()) {

        int u = s.top();
        s.pop();

        if (!visited[u]) {

            visited[u] = true;
            cout << u + 1 << " ";

            if (u == end) {
                cout << "\nЦелевая вершина " << end + 1 << " найдена!";
                return;
            }

            for (int x : graph[u]) {
                if (!visited[x]) {
                    s.push(x);
                }
            }
        }
    }

    cout << "\nЦелевая вершина не найдена";
}

int main() {
    setlocale(LC_ALL, "rus");
    cout << "Введите количество вершин: ";
    int n;
    cin >> n;

    vector<vector<int>> nearby(n);
    vector<vector<int>> edgeList(n, vector<int>(n, -1));
    vector<bool> visited(n, false);
    vector<vector<int>> matrix(n, vector<int>(n));


    int verticesCount = 0;

    for (int i = 0; i < n; ++i) {
        int v, e;
        cout << "Количество ребер у вершины: " << i + 1 << ": ";
        cin >> e;
        verticesCount += e;
        cout << "Введите рёбра через пробел: ";
        for (int j = 0; j < e; ++j) {
            cin >> v;
            edgeList[i][v - 1] = 1;
            matrix[i][v - 1] = 1;
            matrix[v - 1][i] = 1;
            nearby[i].push_back(v - 1);

        }
    }

    int start, end;
    cout << "Введите начальную вершину: ";
    cin >> start;
    cout << "Введите конечную вершину: ";
    cin >> end;

    cout << "Цепочка обхода в глубину от " << start << " до " << end << endl;
    dfs(start - 1, end - 1, nearby, visited);

    cout << endl;
    cout << "Цепочка обхода в ширину от " << start << " до " << end << endl;
    bfs(start - 1, end - 1, nearby, visited);

    const int V = nearby[start - 1].size();
    const int E = verticesCount;

    cout << "V = " << V << "\t E = " << E << endl;
    cout << "O(V+E) = " << V + E << endl;

    return 0;
}