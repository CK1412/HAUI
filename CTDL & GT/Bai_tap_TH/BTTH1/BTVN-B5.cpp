#include<bits/stdc++.h>
using namespace std;

void xuat(int *arr, int n) {
	for(int i = 0; i < n; i++)
		cout << " " << arr[i];
}
void nhap(int *arr, int &n) {
	do {
		cout << "nhap n: ";
		cin >> n;
	} while(n < 1);
	cout << "nhap day n so: \n";
	for(int i = 0; i < n; i++) {
		cin >> arr[i];
	}
}
void sapxep(int *arr, int l, int r) {
	if(l < r) {
		int i = l,
			j = r,
			m = l + (r-l)/2;
		while(i <= j) {
			while(arr[i] < arr[m]) i++;
			while(arr[j] > arr[m]) j--;
			if(i <= j) {
				int temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
				i++;
				j--;
			}
		}
		sapxep(arr, l, j);
		sapxep(arr, i, r);
	}
}
int main() {
	int n;
	int *arr = new int[n];
	nhap(arr, n);
	
	cout << "day sap xep tang:";
	sapxep(arr, 0, n-1);
	xuat(arr, n);
	
	cout << endl;
	return 0;
}

