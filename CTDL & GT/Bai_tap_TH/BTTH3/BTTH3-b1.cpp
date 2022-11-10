#include<bits/stdc++.h>
using namespace std;

int timkiem_tuantu(int x[], int n, int k) {
	for(int i = 0; i < n; i++) {
		if(k == x[i]) {
			return i+1;
		}
	}
	return -1;
}
void hienthi(int x[], int n) {
	for(int i = 0; i < n; i++) {
		cout << x[i] << " ";
	}
	cout << endl;
}
int main()
{
	int x[] = {34, 14, 24, 54, 84, 64, 94, 74, 04};
	int n = sizeof(x) / sizeof(int);
	int k1 = 94, k2 = 55;
	
	cout << "Day x: ";
	hienthi(x, n);
	cout << "k1 = " << k1 << " va k2 = " << k2 << endl;
	
	int a = timkiem_tuantu(x, n, k1);
	if(a == -1) {
		cout << "\nKhong tim thay k1 trong day.\n";
	}
	else {
		cout << "\nTim thay k1 o vi tri thu " << a << " trong day.\n";
	}
	
	int b = timkiem_tuantu(x, n, k2);
	if(b == -1) {
		cout << "\nKhong tim thay k2 trong day.\n";
	}
	else {
		cout << "\nTim thay k2 o vi tri thu " << b << " trong day.\n";
	}
		
	return 0;
}

