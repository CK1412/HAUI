#include<bits/stdc++.h>
using namespace std;
#define MAX 10

void xuat(char a[][MAX], int n) {
	for(int i = 0; i < n; i++) {
		cout << a[i] << ", " ;
	}
}
void quicksort(char a[][MAX], int left, int right) {
	if(left < right) {
		int i = left;
		int j = right;
		int k = (left+right)/2;
		char t[MAX];
		strcpy(t, a[k]);
		while(i <= j) {
			while(strcmp(a[i], t) < 0) i++;      
			while(strcmp(a[j], t) > 0) j--;	
			if(i <= j) {
				char temp[MAX];
				strcpy(temp, a[i]);
				strcpy(a[i], a[j]);
				strcpy(a[j], temp);
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
	int n = 7;
	char a[n][MAX] = {"John","Try","Thor","Zil","Adam","Dany","Milk"};
	
	cout << "day sap xep theo thu tu tu dien bang quick sort: ";
	quicksort(a, 0, n-1);
	xuat(a, n);
	return 0;
}

