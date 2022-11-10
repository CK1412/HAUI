#include<bits/stdc++.h>
using namespace std;

void nhap(long &x) {
	do {
		cout << "nhap so nguyen duong x: ";
		cin >> x;
	} while(x<1);
}
int dem(long x) {
	if(x < 10) return 1;
	return dem(x/10) + 1;
}
int main() {
	long x;
	nhap(x);
	cout << "so chu so cua x la: " << dem(x);
	cout << endl;
	return 0;
}

