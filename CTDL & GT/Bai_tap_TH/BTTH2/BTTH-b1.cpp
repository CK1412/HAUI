#include<bits/stdc++.h>
using namespace std;

void nhap(int *a, int &n, int &s) {
	do {
		cout << "nhap so nguyen n: ";
		cin >> n;
	} while(n < 1);
	cout << "nhap mang:\n";
	for(int i = 0; i < n; i++) {
		cout << "a[" << i << "] = ";
		cin >> a[i];
	}
	cout << "nhap so nguyen s: "; 
	cin >> s;
}
void bubbleSort_giam(int *a, int n) {
	for(int i = 0; i < n-1; i++) {
		for(int j = n-1; j > i; j--) {
			if(a[j] > a[j-1]) {
				int temp = a[j];
				a[j] = a[j-1];
				a[j-1] = temp;
			}
		}
	}
}
int dem(int *a, int n, int s) {
	int p = 0;
	int count = 0;
	bubbleSort_giam(a, n);
	for(int i = 0; i < n; i++) {
		p += a[i];
		count++;
		if(p > s) return count;
	}
	return -1;
}
int main()
{
	int n, s;
	int *a = new int[n];
	nhap(a, n, s);
	cout << "So phan tu it nhat can lay de tong P > s la: " << dem(a, n, s) << endl;
	return 0;
}

