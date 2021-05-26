#include<bits/stdc++.h>
using namespace std;

void doicho(int &x, int &y) {
	int temp = x;
	x = y;
	y = temp;
}
void xuat(int *a, int n) {
	for(int i = 0; i < n; i++)
		cout << "  " << a[i];
	cout << endl;
}
//
void bubble_sort(int *a, int n) {
	for(int i = 0; i < n-1; i++)
		for(int j = n-1; j > i; j--)
			if(a[j] < a[j-1]) {
				doicho(a[j], a[j-1]);
			}
}
//
void select_sort(int *a, int n) {
	for(int i = 0; i < n-1; i++) {
		int m = i;
		for(int j = i+1; j < n; j++)
			if(a[j] < a[m]) 
				m = j;
		if(m != i) 
			doicho(a[m], a[i]);
	}
}
//
void insert_sort(int *a, int n) {
	for(int i = 1; i < n; i++) {
		int t = a[i];
		int j = i-1;
		while(j >= 0 && t < a[j]) {
			a[j+1] = a[j];
			j--;
		}
		a[j+1] = t;
	}
}
//
void quick_sort(int *a, int left, int right) {
	if(left < right) {
		int i = left,
			j = right,
			m = left + (right - left)/2,
			k = a[m];
		while(i <= j) {
			while(a[i] < k) i++;
			while(a[j] > k) j--;
			if(i <= j) {
				doicho(a[j], a[i]);
				i++;
				j--;
			}
		}
		quick_sort(a, left, j);
		quick_sort(a, i, right);
	}
}
//
void swap(int *a, int k, int n) {
	int i = 2*k + 1;
	if(a[i] < a[i+1] && i+1 < n)
		i++;
	if(a[k] < a[i] && i < n) {
		doicho(a[k], a[i]);
		swap(a, i, n);
	} 
}
void create_heap(int *a, int n) {
	for(int i = n/2 - 1; i >= 0; i--) {
		swap(a, i, n);
	}
}
void heap_sort(int *a, int n) {
	create_heap(a, n);
	for(int i = n-1; i >= 1; i--) {
		doicho(a[0], a[i]);
		swap(a, 0, i);
	}
}
//
void merge(int *a, int left, int mid, int right) {
	int n1 = mid - left + 1,
		n2 = right - mid;
	int *a1 = new int[n1],
		*a2 = new int[n2];
	for(int i = 0; i < n1; i++) 
		a1[i] = a[left+i];
	for(int i = 0; i < n2; i++) 
		a2[i] = a[mid+i+1];
		
	int i = 0, j = 0, k = left;
	while(i < n1 && j < n2) 
		a[k++] = (a1[i] < a2[j]) ? a1[i++] : a2[j++];
	while(i < n1) 
		a[k++] = a1[i++];
	while(j < n2) 
		a[k++] = a2[j++];
}
void merge_sort(int *a, int left, int right) {
	if(left < right) {
		int mid  = left + (right-left) / 2;
		merge_sort(a, left, mid);
		merge_sort(a, mid+1,right);
		merge(a, left, mid, right);
	}
}
int main()
{
	int a[] = {1,4,6,3,2,8,9,5};
	int n = 8;
	 
//	cout << " bubble_sort: "; bubble_sort(a, n); xuat(a, n);
//	cout << " select_sort: "; select_sort(a, n); xuat(a, n);
//	cout << " insert_sort: "; insert_sort(a, n); xuat(a, n);
//	cout << " quick_sort: "; quick_sort(a, 0, n-1); xuat(a, n);
//	cout << " heap_sort: "; heap_sort(a, n); xuat(a, n);
	cout << " merge_sort: "; merge_sort(a, 0, n-1); xuat(a, n);
	return 0;
}

