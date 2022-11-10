#include<bits/stdc++.h>
using namespace std;

long UCLN(long a, long b) {
	if(b == 0) return a;
	return UCLN(b, a%b);
}
int main() {
	long a, b;
	cout << "nhap 2 so a, b: ";
	cin >> a >> b;
	cout << "UCLN(a, b) = " << UCLN(a, b) << endl;
	cout << endl;
	return 0;
}

