#include<bits/stdc++.h>
using namespace std;
#define MAX 10

void xuat(char a[][MAX], int n) {
	for(int i = 0; i < n; i++) {
		cout << a[i] << ", " ;
	}
}
void selectsort(char a[][MAX], int n) {
	for(int i = 0; i < n-1; i++) {
		int m = i;
		for(int j = i+1; j < n; j++) {
			if(strcmp(a[j], a[m]) < 0) {
				m = j;
			}
		}
		if(m != i) {
			char temp[MAX];
			strcpy(temp, a[i]);
			strcpy(a[i], a[m]);
			strcpy(a[m], temp);
		}
	}
}
int main()
{
	int n = 9;
	char a[n][MAX] = {"John","Cool","Bee","Try","Thor","Zil","Adam","Dany","Milk"};
	
	cout << "day sap xep theo thu tu tu dien bang select sort: ";
	selectsort(a, n);
	xuat(a, n);
	return 0;
}

