#include<bits/stdc++.h>
using namespace std;

void in_nguoc_xau(char *str, int n) {
	cout << str[n];
	if(n != 0) in_nguoc_xau(str, n-1);
}
int main() {
	char str[1000];
	cout << "nhap chuoi: ";
	fflush(stdin);
	gets(str);
	
	int n = strlen(str)-1;
	cout << "chuoi dao nguoc: ";
	in_nguoc_xau(str, n);

	return 0;
}

