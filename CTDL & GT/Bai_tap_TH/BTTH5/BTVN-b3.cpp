#include<bits/stdc++.h>
using namespace std;
#define MAX 10

void xuat(char a[][MAX], int n) {
	for(int i = 0; i < n; i++) {
		cout << a[i] << ", " ;
	}
}
void merge(char a[][MAX], int left, int mid, int right) {
	int n1 = mid - left + 1;
	int n2 = right - mid;
	char a1[n1][MAX]; 
	char a2[n2][MAX];
	
	for(int i = 0; i < n1; i++) {
		strcpy(a1[i], a[left+i]);
	}
	for(int i = 0; i < n2; i++) {
		strcpy(a2[i], a[mid+i+1]);
	}
	
	int i = 0, j = 0, k = left; 
	while(i < n1 && j < n2) {
		if(strcmp(a1[i], a2[j]) < 0) {
			strcpy(a[k++], a1[i++]);
		} 
		else {
			strcpy(a[k++], a2[j++]);
		}
	}	
	while(i < n1) {
		strcpy(a[k++], a1[i++]);
	}
	while(j < n2) {
		strcpy(a[k++], a2[j++]);
	}
}
void mergesort(char a[][MAX], int left, int right) {
	if(left < right) {
		int mid = left + (right-left)/2;
		mergesort(a, left, mid);
		mergesort(a, mid+1, right);
		
		merge(a, left, mid, right);
	}
}
int main()
{
	int n = 9;
	char a[n][MAX] = {"John","Cool","Bee","Try","Thor","Zil","Adam","Dany","Milk"};
	
	cout << "day sap xep theo thu tu tu dien bang merge sort: ";
	mergesort(a, 0, n-1);
	xuat(a, n);
	return 0;
}

