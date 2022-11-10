#include<bits/stdc++.h>
using namespace std;

void xuat(int a[], int n) {
	for(int i = 0; i < n; i++) {
		cout << " " << a[i];
	}
}
void swap(int a[], int k, int n) {
	int i = 2*k+1; 

	if(a[i] > a[i+1] && i < n-1) i = i+1;        
	if(a[k] > a[i] && i < n) {	 	     
		int temp = a[k];
		a[k] = a[i];
		a[i] = temp;
		swap(a, i, n); 
	}
}
void create_heap(int a[], int n) {
	for(int i = n/2-1; i >= 0; i--) {
		swap(a, i, n);
	}
}
void heapsort(int a[], int n) {
	create_heap(a, n);
	for(int i = n-1; i >= 1; i--) {
		int temp = a[0];
		a[0] = a[i];
		a[i] = temp;
		swap(a, 0, i); 
	}
}
int main()
{
	int x[] = {14, 24, 54, 84, 64, 94, 74};
	int n = sizeof(x)/sizeof(int);
	
	cout << "day sap xep giam bang heap sort: ";
	heapsort(x, n);
	xuat(x, n);
	return 0;
}

