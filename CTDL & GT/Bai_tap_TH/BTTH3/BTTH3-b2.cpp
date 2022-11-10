#include<bits/stdc++.h>
using namespace std;

void hienthi(int x[], int n) {
	for(int i = 0; i < n; i++) {
		cout << x[i] << " ";
	}
	cout << endl;
}
void bubbleSort_tang(int x[], int n) {
	for(int i = 0; i < n-1; i++) {
		for(int j = n-1; j > i; j--) {
			if(x[j] < x[j-1]) {
				int temp = x[j];
				x[j] = x[j-1];
				x[j-1] = temp;
			}
 		}
	}
}
int timkiem_nhiphan(int x[], int left, int right, int k) {
	if(left > right) 
		return -1;
	else {
		int mid = (left + right)/2;
		if(k == x[mid]) {
			return mid;
		}
		else if(k < x[mid]) {
			return timkiem_nhiphan(x, left, mid-1, k);
		} 
		else {
			return timkiem_nhiphan(x, mid+1, right, k);
		}
	}
}
int main()
{
	int x[] = {04, 14, 24, 34, 54, 64, 74, 84, 94};
	int n = sizeof(x) / sizeof(int);
	int k1 = 34, k2 = 60;
	bubbleSort_tang(x, n);
	cout << "Day x vua duoc sap: ";
	hienthi(x, n);
	cout << "k1 = " << k1 << " va k2 = " << k2 << endl;
	
	int a = timkiem_nhiphan(x, 0, n-1, k1);
	if(a == -1) {
		cout << "\nKhong tim thay k1 trong day.\n";
	}
	else {
		cout << "\nTim thay k1 o vi tri thu " << a << " trong day.\n";
	}
	
	int b = timkiem_nhiphan(x, 0, n-1, k2);
	if(b == -1) {
		cout << "\nKhong tim thay k2 trong day.\n";
	}
	else {
		cout << "\nTim thay k2 o vi tri thu " << b << " trong day.\n";
	}
	
	return 0;
}

