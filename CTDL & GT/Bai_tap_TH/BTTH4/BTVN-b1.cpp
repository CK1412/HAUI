#include<bits/stdc++.h>
using namespace std;
#define MAX 10

void xuat(char a[][MAX], int n) {
	for(int i = 0; i < n; i++) {
		cout << a[i] << ", " ;
	}
}
void bubblesort(char a[][MAX], int n) {
	for(int i = 0; i < n-1; i++) {
		for(int j = n-1; j > i; j--) {
			if(strcmp(a[j], a[j-1]) < 0) {
				char temp[MAX];
				strcpy(temp, a[j]);
				strcpy(a[j], a[j-1]);
				strcpy(a[j-1], temp);
			}
		}
	}
}
int main()
{
	int n = 7;
	char a[n][MAX] = {"John","Try","Thor","Zil","Adam","Dany","Milk"};
	
	cout << "day sap xep theo thu tu tu dien bang bubble sort: ";
	bubblesort(a, n);
	xuat(a, n);
	return 0;
}

