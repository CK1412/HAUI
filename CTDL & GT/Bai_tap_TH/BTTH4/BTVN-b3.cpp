#include<bits/stdc++.h>
using namespace std;
#define MAX 10

void xuat(char a[][MAX], int n) {
	for(int i = 0; i < n; i++) {
		cout << a[i] << ", " ;
	}
}
void insertsort(char a[][MAX], int n) {
	for(int i = 1; i < n; i++) {
		char *t;
		strcpy(t, a[i]);
		int j = i-1;
		while(j >= 0 && strcmp(a[j], t) > 0) {
			strcpy(a[j+1], a[j]);
			j--;
		}
		strcpy(a[j+1], t);
	}
}
int main()
{
	int n = 9;
	char a[n][MAX] = {"John","Cool","Bee","Try","Thor","Zil","Adam","Dany","Milk"};
	
	cout << "day sap xep theo thu tu tu dien bang insert sort: ";
	insertsort(a, n);
	xuat(a, n);
	return 0;
}

