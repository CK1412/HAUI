#include<bits/stdc++.h>
using namespace std;

int n;

// buoc di cua quan ma
int dem = 0;

// mang danh dau thu tu di chuyen tuong ung voi moi o
int **a;

// co 8 cach di chuyen cua quan ma theo toa do Oxy
int X[8] = {-2,-2,-1,-1, 1, 1, 2, 2}; 
int Y[8] = {-1, 1,-2, 2,-2, 2,-1, 1};


void xuat() {
	for(int i = 0; i < n; i++) {
		for(int j = 0; j < n; j++) {
			cout << a[i][j] << "\t";
		}
		cout << endl << endl;
	}
}
void dichuyen(int x, int y) {
	dem++;
	a[x][y] = dem;
	
	// xet lan luot 8 cach di chuyen
	for(int i = 0; i < 8; i++) {
		if(dem == n*n) {
			cout << "\nThu tu di chuyen tren ban co nhu sau:\n\n";
			xuat();
			exit(0);
		}
		int u = x + X[i];
		int v = y + Y[i];
		if(u >= 0 && u < n && v >= 0 && v < n && a[u][v] == 0) {
			dichuyen(u, v);
		}
	}
	// neu k cach nao t/m thi tra v gia tri ban dau
	dem--;
	a[x][y] = 0;
}
int main()
{
	cout << "nhap n: "; 
	cin >> n;
	cout << "Ban co co kich thuoc " << n << " x " << n << endl;

	a = new int*[n];
	for(int i = 0; i < n; i++) {
		a[i] = new int[n]();  // khoi tao cac phan tu co gia tri la 0
	}
	int a, b;
	cout << "Nhap toa do xuat phat:\n";
	cout << " x = "; cin >> a;
	cout << " y = "; cin >> b;
	dichuyen(a, b);
	
	cout << "\nKhong co duong di.\n";
	return 0;
}

