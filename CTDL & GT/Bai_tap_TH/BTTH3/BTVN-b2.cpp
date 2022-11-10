#include<bits/stdc++.h>
using namespace std;

struct TAISAN {
	char mats[10];
	char tents[30];
	float giatri;
	char tinhtrang[30];
};
void nhap_ds(TAISAN *ds, int &n) {
	cout << "\n----- NHAP DS ------\n";
	for(int i = 0; i < n; i++) {
		cout << "tai san thu " << i+1 << ":\n";
		cout << " ma tai san: "; fflush(stdin); gets(ds[i].mats);
		cout << " ten tai san: "; gets(ds[i].tents);
		cout << " gia tri tai san: "; cin >> ds[i].giatri;
		cout << " tinh trang: "; fflush(stdin); gets(ds[i].tinhtrang);
	}
}
void xuat_ds(TAISAN *ds, int n) {
	cout << setw(20) << left << "MA TS"
		<< setw(20) << left << "TEN TS"
		<< setw(20) << left << "GIA TRI"
		<< setw(20) << left << "TINH TRANG" << endl;
	for(int i = 0; i < n; i++) {
		cout << setw(20) << left << ds[i].mats
			<< setw(20) << left << ds[i].tents
			<< setw(20) << left << ds[i].giatri
			<< setw(20) << left << ds[i].tinhtrang << endl;
	}
}
void sapxepgiam_giatri(TAISAN *ds, int n) {
	for(int i = 0; i < n; i++) 
		for(int j = n-1; j > i; j--)
			if(ds[j].giatri > ds[j-1].giatri) {
				TAISAN temp = ds[j];
				ds[j] = ds[j-1];
				ds[j-1] = temp;
			}
}
int timkiem_tuantu(TAISAN *ds, int n, char *a) {
	for(int i = 0; i < n; i++) {
		if(strcmp(ds[i].mats, a) == 0) {
			return i;
		}
	}
	return -1;
}
int timkiem_nhiphan(TAISAN *ds, int left, int right, int k) {
	if(left > right) return -1;
	else {
		int mid = (left + right) / 2;
		if(k == ds[mid].giatri) 
			return mid;
		else if(k > ds[mid].giatri) 
			return timkiem_nhiphan(ds, left, mid-1, k);
		else 
			return timkiem_nhiphan(ds, mid+1, right, k);
	}
}
int main()
{
	int n;
	cout << "nhap so tai san: "; 
	cin >> n;
	TAISAN *ds = new TAISAN[n];
	
	nhap_ds(ds, n);
	cout << "\n---- DS DA SAP XEP GIAM THEO GIA TRI -----\n";
	sapxepgiam_giatri(ds, n);
	xuat_ds(ds, n);
	
	cout << "\n------TIM KIEM TUAN TU-------\n";
	char ma[10];
	cout << "nhap ma tai san can tim: "; fflush(stdin); gets(ma);
	int v = timkiem_tuantu(ds, n, ma);
	if(v == -1)
		cout << "\nKhong co tai san ma " << ma << endl;
	else {
		cout << "\nThong tin tai san co ma " << ma << ":\n";
		cout << " ma tai san: " << ds[v].mats << endl;
		cout << " ten tai san: " << ds[v].tents << endl;
		cout << " gia tri: " << ds[v].giatri << endl;
		cout << " tinh trang: " << ds[v].tinhtrang << endl;
	}
	
	cout << "\n------TIM KIEM NHI PHAN-------\n";
	float gt;
	cout << "nhap gia tri tai san can tim: "; cin >> gt;
	v = timkiem_nhiphan(ds, 0, n-1, gt);
	if(v == -1)
		cout << "\nKhong co tai san gia tri " << gt << endl;
	else {
		cout << "\nThong tin tai san co gia tri la " << gt << ":\n";
		cout << " ma tai san: " << ds[v].mats << endl;
		cout << " ten tai san: " << ds[v].tents << endl;
		cout << " gia tri: " << ds[v].giatri << endl;
		cout << " tinh trang: " << ds[v].tinhtrang << endl;
	}
	return 0;
}

