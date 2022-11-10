/*  
w la khoi luong toi da cua balo
n la so do vat
a[i][0]; a[i][1] lan luot la khoi luong, gia tri
*/

#include<bits/stdc++.h>
using namespace std;

void nhap(int a[][2], int &n, int &w) {
	cout << "Tong khoi luong toi da cua balo w = ";
	cin >> w;
	cout << "so do vat n = ";
	cin >> n;
	cout << "khoi luong va gia tri moi do vat:\n";
	for(int i = 0; i < n; i++) {
		for(int j = 0; j < 2; j++) {
			cout << "a[" << i << "][" << j << "] = ";
			cin >> a[i][j];	
		}
	}
}
void sapxepgiam_giatri(int a[][2], int n, int w) {
	for(int i = 0; i < n-1; i++) {
		for(int j = n-1; j > i; j--) {
			if(a[j][2] > a[j-1][2]) {
				int temp = a[j][0];
				a[j][0] = a[j-1][0];
				a[j-1][0] = temp;
				temp = a[j][1];
				a[j][1] = a[j-1][1];
				a[j-1][1] = temp;
			}
		}
	}
}
void hienthi(int a[][2], int n, int w) {
	cout << "\nKhoi luong: ";
	for(int i = 0; i < n; i++) {
		cout << a[i][0] << "\t";
	}
	cout << "\nGia tri:    ";
	for(int i = 0; i < n; i++) {
		cout << a[i][1] << "\t";
	}
}
int xep_balo(int a[][2], int n, int w) {
	sapxepgiam_giatri(a, n, w);
	int max = 0;
	for(int i = 0; i < n; i++) {
		if(a[i][0] < w) {
			w -= a[i][0];
			max += a[i][1];
		}
	}
	return max;
}
int main()
{
	int w;
	int n;
	int a[100][2];
	nhap(a, n, w);
	hienthi(a, n, w);
	cout << "\n\nTa xep duoc cac do vat vao balo voi tong gia tri lon nhat la: " << xep_balo(a, n, w) << endl;
	return 0;
}

