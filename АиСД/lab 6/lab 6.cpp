#include <iostream>
#include <string>
#include <queue>
#include <unordered_map>

using namespace std;

struct Node
{
	char ch;
	int freq;
	Node* left, * right;
};

Node* getNode(char ch, int freq, Node* left, Node* right)
{
	Node* node = new Node();

	node->ch = ch;
	node->freq = freq;
	node->left = left;
	node->right = right;

	return node;
}

struct comp
{
	bool operator()(Node* l, Node* r)
	{
		return l->freq > r->freq;
	}
};

void encode(Node* root, string str,
	unordered_map<char, string>& huffmanCode, int level = 1)
{
	if (root == nullptr)
		return;

	if (!root->left && !root->right) {
		huffmanCode[root->ch] = str;
	}

	

	encode(root->left, str + "0", huffmanCode, level + 1);

	for (int i = 0; i < level; i++)
		cout << "     ";

	cout << root->ch << " " << root->freq << " " << str << '\n';
	cout << endl;

	encode(root->right, str + "1", huffmanCode, level + 1);
}

void decode(Node* root, int& index, string str)
{
	if (root == nullptr) {
		return;
	}

	if (!root->left && !root->right)
	{
		cout << root->ch;
		return;
	}

	index++;

	if (str[index] == '0')
		decode(root->left, index, str);
	else
		decode(root->right, index, str);
}

void buildHuffmanTree(string text)
{
	unordered_map<unsigned char, int> freq;
	for (unsigned char ch : text) {
		freq[ch]++;
	}

	std::vector<std::pair<char, int>> sorted(freq.begin(), freq.end());

	std::sort(sorted.begin(), sorted.end(),
		[](const std::pair<char, int>& a, const std::pair<char, int>& b) {
			return a.second > b.second;
		});

	priority_queue<Node*, vector<Node*>, comp> pq;

	for (auto pair : sorted) {
		pq.push(getNode(pair.first, pair.second, nullptr, nullptr));
	}
	
	while (pq.size() != 1)
	{
		
		Node* left = pq.top(); pq.pop();
		Node* right = pq.top();	pq.pop();

		int sum = left->freq + right->freq;
		pq.push(getNode('\0', sum, left, right));


	}

	Node* root = pq.top();

	unordered_map<char, string> huffmanCode;
	encode(root, "", huffmanCode);


	cout << "Количество повторений каждого символа: \n";

	for (auto element : sorted )
	{
		cout << element.first << " - " << element.second << endl;
	}

	cout << "\nКоды символов :\n" << '\n';
	for (auto pair : huffmanCode) {
		cout << pair.first << " " << pair.second << '\n';
	}

	cout << "\nВведенная строка :\n" << text << '\n';

	string str = "";
	string strBuff = "";
	for (char ch : text) {
		strBuff += "|";
		strBuff += huffmanCode[ch];
		str += huffmanCode[ch];
	}

	cout << "\nЗакодированная строка:\n" << strBuff << '\n';

	int index = -1;
	cout << "\nДекодированная строка: \n";
	while (index < (int)str.size() - 2) {
		decode(root, index, str);
	}
}



int main()
{
	setlocale(LC_ALL, "Rus");
	string text = "хахахаха_не_работает";

	buildHuffmanTree(text);

	return 0;
}