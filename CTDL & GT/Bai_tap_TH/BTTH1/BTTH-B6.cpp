#include<bits/stdc++.h>
using namespace std;

void nhap(int *arr, int &n, int &x) {
	do {
		cout << "nhap n>1: ";
		cin >> n;
	} while(n < 2);
	cout << "nhap mang day so: " << endl;
	for(int i = 0; i < n; i++) {
		cout << "arr[" << i << "] = ";
		cin >> arr[i];
	}
	cout << "nhap x: ";
	cin >> x;
}
int Dem(int *arr, int dau, int cuoi, int x) {
	if(dau == cuoi) {
		if(arr[dau] == x) return 1;
		else return 0;
	}
	int giua = (dau+cuoi)/2;
	return Dem(arr, dau, giua, x) + Dem(arr, giua+1, cuoi, x);
}
int main() {
	int n = 0, x;
	int *arr = new int[n];
	nhap(arr, n, x);
	cout << "so lan xuat hien cua x trong day: " << Dem(arr, 0, n-1, x);
	cout << endl;
	return 0;
}

