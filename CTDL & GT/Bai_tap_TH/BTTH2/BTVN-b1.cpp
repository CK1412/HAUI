#include<bits/stdc++.h>
using namespace std;

void doitien(long *a, long m) {
	int count = 0;
	long p = 0;
	if(m % a[4] != 0) {
		cout << "\nSo tien khong la boi cua 500.\n";
	}
	else {
		int i = 0;
		while(m != 0 && i < 5) {
			if(m >= a[i]) {
				m -= a[i];
				count++;
			}
			else {
				i++;
			}
		}
		cout << "\nCan it nhat " << count << " to tien de duoc so tien m.\n";
	}	
}
int main()
{
	long a[5] = {10000, 5000, 2000, 1000, 500};
	cout << "Co 5 loai tien menh gia: 10000, 5000, 2000, 1000, 500.\n";
	cout << "Khong gioi han so to tien moi loai.\n";
	long m;
	cout << "\nNhap so tien m can lay: ";
	cin >> m;
	
	doitien(a, m);
	return 0;
}

