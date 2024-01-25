#include <iostream>
#include <vector>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Rus");

	vector<int> sequence;
	vector<int> subseq;
	vector<int> subseqBuff;

	int count = 0;
	int countBuff = 0;
	int N;

	cout << "Сколько элементов будет в последовательности?\n";
	cin >> N;
	cout << "Введите последовательность: ";
	for (int i = 0; i < N; i++)
	{
		int number;
		cin >> number;
		sequence.push_back(number);
	}

	for (int i = 0; i < sequence.size(); i++)
	{

		if (!subseq.empty())
			subseq.clear();

		subseq.push_back(sequence[i]);

		for (int j = 1; j < sequence.size(); j++)
		{

			if (!subseq.empty()) {
				subseq.clear();

				subseq.push_back(sequence[i]);
			}
				
			if (i != j) {
				subseq.push_back(sequence[j]);
			}
			else {
				continue;
			}

			int diff = abs(subseq[0] - subseq[1]);

			for (int k = 0; k < sequence.size(); k++)
			{
				count = 0;
				if (k != i && k != j && k > j && j > i) {
					if (subseq.back() + diff == sequence[k]) {
						subseq.push_back(sequence[k]);
						count++;
						
					}
				}
			}

			if (countBuff < count) {
				subseqBuff = subseq;
				countBuff = count;
			}
		}
	}
	cout << "Последовательность: \n";
	for (int i = 0; i < subseqBuff.size(); i++)
	{
		cout << subseqBuff[i] << " ";
		cout << "\n";
		
	}
	cout << subseqBuff.size() << " ";
}

