#include<bits/stdc++.h>
using namespace std;

void nhap(int &a, int &n) {
	cout << "nhap a: ";
	cin >> a;
	cout << "nhap n: ";
	cin >> n; 
}
long long luythua(int a, int n) {
	if(n == 1) return a;
	int temp = luythua(a, n/2);
	return (n%2 == 0) ? temp * temp : temp * temp *a;
}
int main() {
	int a, n;
	nhap(a, n);
	cout << "pow(a, n) = " << luythua(a, n);
	cout << endl;
	return 0;
}

