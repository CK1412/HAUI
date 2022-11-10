#include<bits/stdc++.h>
using namespace std;

void nhap(int *arr, int &n) {
	do {
		cout << "nhap n: ";
		cin >> n;
	} while(n < 1);
	cout << "nhap day n so: \n";
	for(int i = 0; i < n; i++) {
		cin >> arr[i];
	}
}
long tinhtong(int *arr, int dau, int cuoi) {
	if(dau == cuoi) return arr[dau];
	int temp = (dau+cuoi)/2;
	return tinhtong(arr, dau, temp) + tinhtong(arr, temp+1, cuoi);
}
int main() {
	int n = 0;
	int *arr = new int[n];
	nhap(arr, n);
	cout << "tong day so tren la: " << tinhtong(arr, 0, n-1);
	cout << endl;
	return 0;
}

