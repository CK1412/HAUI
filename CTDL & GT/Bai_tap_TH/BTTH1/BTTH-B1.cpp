#include<bits/stdc++.h>
using namespace std;

long Fibonaci(int n) {
	if(n == 1) return 0;
	if(n == 2) return 1;
	return Fibonaci(n-1) + Fibonaci(n-2);
}
int main() {
	int n;
	do {
		cout << "nhap n >= 1: ";
		cin >> n;
	} while(n<1);
	cout << "so Fibonaci thu: " << n << " la: " << Fibonaci(n) << endl;
	cout << "day n so Fibonaci dau tien la: ";
	for(int i = 1; i <= n; i++) {
		cout << " "<< Fibonaci(i);
	}
	cout << endl;
	return 0;
}

