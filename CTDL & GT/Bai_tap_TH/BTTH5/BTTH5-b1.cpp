#include<bits/stdc++.h>
using namespace std;

void xuat(int a[], int n) {
	for(int i = 0; i < n; i++) {
		cout << " " << a[i];
	}
}
void quicksort(int a[], int left, int right) {
	if(left < right) {
		int i = left;
		int j = right;
		int k = (left+right)/2;
		int t = a[k];
		while(i <= j) {
			while(a[i] > t) i++;      
			while(a[j] < t) j--;	
			if(i <= j) {
				int temp = a[i];
				a[i] = a[j];
				a[j] = temp;
				i++;
				j--;	
			}
		}
		quicksort(a, left, j);
		quicksort(a, i, right);
	}
}
int main()
{
	int x[] = {34, 14, 24, 54, 84, 64, 94, 74, 04};
	int n = sizeof(x)/sizeof(int);
	
	cout << "day sap xep giam bang quick sort: ";
	quicksort(x, 0, n-1);
	xuat(x, n);
	return 0;
}

