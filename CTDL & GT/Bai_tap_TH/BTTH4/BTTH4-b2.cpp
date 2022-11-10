#include<bits/stdc++.h>
using namespace std;

void xuat(int a[], int n) {
	for(int i = 0; i < n; i++) {
		cout << " " << a[i];
	}
}
void selectsort(int a[], int n) {
	for(int i = 0; i < n-1; i++) {
		int m = i;
		for(int j = i+1; j < n; j++) {
			if(a[j] > a[m]) {
				m = j;
			}
		}
		if(m != i) {
			int temp = a[m];
			a[m] = a[i];
			a[i] = temp;
		}
	}
}
int main()
{
	int x[] = {34, 14, 24, 54, 84, 64, 94, 74, 04};
	int n = sizeof(x)/sizeof(int);
	
	cout << "day sap xep giam dan bang select sort: ";
	selectsort(x, n);
	xuat(x, n);
	return 0;
}

