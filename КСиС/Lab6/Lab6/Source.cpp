#include <iostream>
#include <bitset>

unsigned long ip, mask;

using namespace std;

bool checkIP(char* ip) {
	int pointer = 0;
	int count = 0;
	char* buff = new char[3];

	for (int i = 0; ip[i] != '\0'; i++)
	{
		if (ip[i] <= '9' && ip[i] >= '0') {

			if (count >= 3) return false;

			buff[count++] = ip[i];

		}
		else {
			if (ip[i] == '.') {

				pointer++;

				count = 0;

				if (atoi(buff) > 255 && atoi(buff) < 0) return false;

				delete[] buff;
				buff = new char[3];
			}
			else return false;
		}
	}

	if (pointer != 3) return false;

	return true;
}

long charToLong(char* mask) {
	long out = 0;
	char* buff = new char[3];

	for (int i = 0, j = 0; mask[i] != '\0'; i++, j++)
	{
		if (mask[i] != '.')
			buff[j] = mask[i];
		if (mask[i] == '.' || mask[i + 1] == '\0') {
			if (atoi(buff) > 255) return NULL;
				
			out <<= 8;
			out += (long)atoi(buff);

			j = -1;

			delete[] buff;
			buff = new char[3];
			
		}
	}

	return out;
}

bool checkMask(char* mask) {
	int pointer = 0;
	int count = 0;
	char* buff = new char[3];

	for (int i = 0; mask[i] != '\0'; i++)
	{
		if (mask[i] <= '9' && mask[i] >= '0') {

			if (count > 3) return false;

			buff[count++] = mask[i];

		}
		else {
			if (mask[i] == '.') {
				pointer++;

				if (atoi(buff) > 255) return false;

				if (count == 0) return false;

				count = 0;

				delete[] buff;
				buff = new char[3];
			}
			else {
				return false;
			}
		} 
		
	}

	if (pointer != 3) return false;

	long mask_ = charToLong(mask);
	bitset<32> bytemask = (bitset<32>(mask_));

	for (size_t i = 31; i >= 1; i--)
	{
		if (bytemask[i] == 0 && bytemask[i - 1] == 1) {
			return false;
		}
	}

	return true;
}

int main() {
	setlocale(LC_ALL, "Rus");

	bool flagIp = true;
	bool flagMask = true;
	char* ip_ = new char[15];
	char* mask_ = new char[15];

	do {
		if (!flagIp) cout << "IP-адрес введен не верно" << endl;
		cout << "Введите IP-адрес: " << endl;
		cin >> ip;
	} while (!(flagIp = checkIP(ip_)));


	do {
		if (!flagMask) cout << "Маска введена не верно" << endl;
		cout << "Введите маску: " << endl;
		cin >> mask;
	} while (!(flagMask = checkMask(mask_)));

	mask = charToLong(mask_);
	ip = charToLong(ip_);

	bitset<32> byteip = (bitset<32>(ip));
	bitset<32> bytemask = (bitset<32>(mask));

	bitset<32>subnet = byteip & bytemask;
	bitset<32>host = byteip & ~bytemask;
	bitset<32> broadcast = (subnet | ~bytemask);



	bitset<8> byte1, byte2, byte3, byte4, byte5, byte6, byte7, byte8;
	bitset<8> broadcast1, broadcast2, broadcast3, broadcast4;

	for (short i = 31, j = 7; i >= 24; i--, j--)
	{
		byte1[j] = subnet[i];
		byte2[j] = subnet[i - 8];
		byte3[j] = subnet[i - 16];
		byte4[j] = subnet[i - 24];

		byte5[j] = host[i];
		byte6[j] = host[i - 8];
		byte7[j] = host[i - 16];
		byte8[j] = host[i - 24];

		broadcast1[j] = broadcast[i];
		broadcast2[j] = broadcast[i - 8];
		broadcast3[j] = broadcast[i - 16];
		broadcast4[j] = broadcast[i - 24];

	}
	cout << "Ваш Network ID: " << byte1.to_ulong() << "." << byte2.to_ulong() << "." << byte3.to_ulong() << "." << byte4.to_ulong() << endl;
	cout << "Ваш Host ID: " << byte5.to_ulong() << "." << byte6.to_ulong() << "." << byte7.to_ulong() << "." << byte8.to_ulong() << endl;

	cout << "Ваш Broadcast ID: " << broadcast1.to_ulong() << "." << broadcast2.to_ulong() << "." << broadcast3.to_ulong() << "." << broadcast4.to_ulong() << endl;

	return 0;
}