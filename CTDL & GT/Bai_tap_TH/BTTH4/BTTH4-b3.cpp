#include<bits/stdc++.h>
using namespace std;

void xuat(int a[], int n) {
	for(int i = 0; i < n; i++) {
		cout << " " << a[i];
	}
}
void insertsort(int a[], int n) {
	for(int i = 1; i < n; i++) {
		int t = a[i];
		int j = i-1;
		while(j >= 0 && a[j] < t) {
			a[j+1] = a[j];
			j--;
		}
		a[j+1] = t;
	}
}
int main()
{
	int x[] = {34, 14, 24, 54, 84, 64, 94, 74, 04};
	int n = sizeof(x)/sizeof(int);
	
	cout << "day sap xep giam bang insert sort: ";
	insertsort(x, n);
	xuat(x, n);
	return 0;
}

