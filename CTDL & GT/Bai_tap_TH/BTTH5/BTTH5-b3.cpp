#include<bits/stdc++.h>
using namespace std;

void xuat(int a[], int n) {
	for(int i = 0; i < n; i++) {
		cout << " " << a[i];
	}
}
void merge(int a[], int left, int mid, int right) {
	int n1 = mid - left + 1;
	int n2 = right - mid;
	int *a1 = new int[n1], 
		*a2 = new int[n2];
	
	for(int i = 0; i < n1; i++) {
		a1[i] = a[left + i];
	}
	for(int i = 0; i < n2; i++) {
		a2[i] = a[mid + i + 1];
	}
	
	int i = 0, j = 0, k = left; 
	while(i < n1 && j < n2) {
		a[k++] = (a1[i] > a2[j]) ? a1[i++] : a2[j++];  
	}	
	while(i < n1) {
		a[k++] = a1[i++];
	}
	while(j < n2) {
		a[k++] = a2[j++];
	}
}
void mergesort(int a[], int left, int right) {
	if(left < right) {
		int mid = left + (right-left)/2;
		mergesort(a, left, mid);
		mergesort(a, mid+1, right);
		
		merge(a, left, mid, right);
	}
}
int main()
{
	int x[] = {34, 14, 24, 54, 84, 64, 94, 74, 04};
	int n = sizeof(x)/sizeof(int);
	
	cout << "day sap xep giam bang merge sort: ";
	mergesort(x, 0, n-1);
	xuat(x, n);
	return 0;
}

