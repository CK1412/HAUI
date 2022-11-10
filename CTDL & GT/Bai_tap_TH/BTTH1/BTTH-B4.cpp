#include<bits/stdc++.h>
using namespace std;

void nhap(int *arr, int &n) {
	do {
		cout << "nhap n>1: ";
		cin >> n;
	} while(n < 2);
	cout << "nhap mang day so: " << endl;
	for(int i = 0; i < n; i++) {
		cout << "arr[" << i << "] = ";
		cin >> arr[i];
	}
}
void TimMax(int *arr, int dau, int cuoi, int &max) {
	int max1, max2;
	if(dau == cuoi) {
		max = arr[dau];
	}
	else {
		int giua = (dau+cuoi)/2;
		TimMax(arr, dau, giua, max1);
		TimMax(arr, giua+1, cuoi, max2);
		if(max1 > max2) {
			max = max1;
		}
		else {
			max = max2;
		}
	}
}
int main() {
	int n = 0;
	int *arr = new int[n];
	nhap(arr, n);
	int max = arr[0];
	TimMax(arr, 0, n-1, max);
	cout << "so lon nhat trong day la: " << max;
	cout << endl;
	return 0;
}

