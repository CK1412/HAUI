#include<bits/stdc++.h>
using namespace std;

struct HS {
	char hoten[30];
	char gioitinh[10];
	int namsinh;
	float diemtk;
};
void nhap_ds(HS *ds, int &n) {
	cout << "nhap so hoc sinh: ";
	cin >> n;
	cout << "nhap danh sach: \n";
	for(int i = 0; i < n; i++) {
		cout << "hoc sinh thu " << i+1 << ":\n";
		cout << " ho va ten: "; fflush(stdin); gets(ds[i].hoten);
		cout << " gioi tinh: "; gets(ds[i].gioitinh);
		cout << " nam sinh: "; cin >> ds[i].namsinh;
		cout << " diem tong ket: "; cin >> ds[i].diemtk;
	}
}
void xuat_ds(HS *ds, int n) {
	cout << setw(20) << left << "HO VA TEN"
		<< setw(20) << left << "GIOI TINH"
		<< setw(20) << left << "NAM SINH"
		<< setw(20) << left << "DIEM TONG KET" << endl;
	for(int i = 0; i < n; i++) {
		cout << setw(20) << left << ds[i].hoten
			<< setw(20) << left << ds[i].gioitinh
			<< setw(20) << left << ds[i].namsinh
			<< setw(20) << left << ds[i].diemtk << endl;
	}
}
void insertsort_ten(HS *ds, int n) {
	for(int i = 1; i < n; i++) {
		HS temp = ds[i];
		int j = i-1;
		while(j >= 0 && strcmp(ds[j].hoten, temp.hoten) > 0) {
			ds[j+1] = ds[j];
			j--;
		}
		ds[j+1] = temp;
	}
}
int main()
{
	int n;
	HS *ds = new HS[n];
	nhap_ds(ds, n);
	cout << "\n-----DANH SACH HOC SINH VUA NHAP-----\n";
	xuat_ds(ds, n);
	
	cout << "\n-----DANH SACH HOC SINH SAP XEP TANG THEO TEN-----\n";
	insertsort_ten(ds, n);
	xuat_ds(ds, n);
	
	return 0;
}

