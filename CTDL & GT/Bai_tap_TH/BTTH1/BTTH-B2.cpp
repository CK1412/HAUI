#include<bits/stdc++.h>
using namespace std;

void TowerHN(int n, char a, char b, char c) {
	if(n == 1) {
		cout << "\tchuyen " << a << " sang " << c << endl;
		return;
	}
	TowerHN(n-1, a, c, b);
	TowerHN(1, a, b, c);
	TowerHN(n-1, b, a, c);
}
int main() {
	char a = 'A', b = 'B', c = 'C';
	int n;
	cout << "nhap so dia: ";
	cin >> n;
	TowerHN(n, a, b, c);
	cout << endl;
	return 0;
}

