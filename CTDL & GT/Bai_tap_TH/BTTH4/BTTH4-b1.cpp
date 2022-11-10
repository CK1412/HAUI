#include<bits/stdc++.h>
using namespace std;

void xuat(int a[], int n) {
	for(int i = 0; i < n; i++) {
		cout << " " << a[i];
	}
}
void bubblesort(int a[], int n) {
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
int main()
{
//	int x[] = {34, 14, 24, 54, 84, 64, 94, 74, 04};
	int x[] = {57, 35, 47, 60, 108, 10, 92, 66, 2, 80, 21, 9, 26, 110, 70, 86};
	int n = sizeof(x)/sizeof(int);
	
	cout << "day sap xep giam bang bubble sort: ";
	bubblesort(x, n);
	xuat(x, n);
	return 0;
}

