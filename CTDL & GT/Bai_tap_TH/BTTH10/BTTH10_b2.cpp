#include<bits/stdc++.h>
using namespace std;

void Xuat(int *x, int n) {
	for(int i = 0; i < n; i++)
		cout << " " << x[i];
	cout << endl;
}
void BubbleSort(int *x, int n) {
	for(int i = 0; i < n; i++)
		for(int j = n-1; j > i; j--)
			if(x[j] > x[j-1]) {
				int temp = x[j];
				x[j] = x[j-1];
				x[j-1] = temp;
			}
}
int main()
{
	int n = 6;
	int x[] = {18,73,17,56,10,86};
	
	cout << "Day ban dau: ";
	Xuat(x, n);
	
	cout << "Day sap xep giam: ";
	BubbleSort(x, n);
	Xuat(x, n);
	return 0;
}

