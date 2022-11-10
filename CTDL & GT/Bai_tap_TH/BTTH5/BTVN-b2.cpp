#include<bits/stdc++.h>
using namespace std;
#define MAX 10

void xuat(char a[][MAX], int n) {
	for(int i = 0; i < n; i++) {
		cout << a[i] << ", " ;
	}
}
void swap(char a[][MAX], int k, int n) {
	int i = 2*k+1; 

	if(strcmp(a[i], a[i+1]) < 0 && i < n-1) i = i+1;        
	if(strcmp(a[k], a[i]) < 0 && i < n) {	 	     
		char temp[MAX];
		strcpy(temp, a[k]);
		strcpy(a[k], a[i]);
		strcpy(a[i], temp);
		swap(a, i, n); 
	}
}
void create_heap(char a[][MAX], int n) {
	for(int i = n/2-1; i >= 0; i--) {
		swap(a, i, n);
	}
}
void heapsort(char a[][MAX], int n) {
	create_heap(a, n);
	for(int i = n-1; i >= 1; i--) {
		char temp[MAX];
		strcpy(temp, a[0]);
		strcpy(a[0], a[i]);
		strcpy(a[i], temp);
		swap(a, 0, i); 
	}
}
int main()
{
	int n = 7;
	char a[n][MAX] = {"John","Cool","Bee","Try","Thor","Zil","Adam"};
	
	cout << "day sap xep theo thu tu tu dien bang heap sort: ";
	heapsort(a, n);
	xuat(a, n);
	return 0;
}

