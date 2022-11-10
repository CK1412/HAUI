#include<bits/stdc++.h>
using namespace std;

double LuyThua(float a, int n) {
	if(n == 1)
		return a;
	return a * LuyThua(a,n-1);
}
int main()
{
	float a;
	int n;
	
	cout << "nhap a: "; cin >> a;
	cout << "nhap n: "; cin >> n;
	cout << "\nLuy thua a^n = " << LuyThua(a, n) << endl;
	return 0;
}

