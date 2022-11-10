#include<bits/stdc++.h>
using namespace std;

struct HS {
	char hoten[30];
	char gioitinh[10];
	int namsinh;
	float diemtk;
};
void nhap_ds(HS *ds, int n) {
	cout << "\n-------NHAP DS-------\n";
	for(int i = 0; i < n; i++) {
		cout << "hoc sinh " << i+1 << ":\n";
		cout << " ho va ten: "; fflush(stdin); gets(ds[i].hoten);
		cout << " gioi tinh: "; gets(ds[i].gioitinh);
		cout << " nam sinh: "; cin >> ds[i].namsinh;
		cout << " diem tong ket: "; cin >> ds[i].diemtk;
	}
}
void tieude_ds() {
	cout << setw(20) << left << "HO VA TEN"
		<< setw(20) << left << "GIOI TINH"
		<< setw(20) << left << "NAM SINH"
		<< setw(20) << left << "DIEM TK" << endl;
}
void xuat_ds(HS *ds, int n) {
	tieude_ds();
	for(int i = 0; i < n; i++) {
		cout << setw(20) << left << ds[i].hoten
			<< setw(20) << left << ds[i].gioitinh
			<< setw(20) << left << ds[i].namsinh
			<< setw(20) << left << ds[i].diemtk << endl;
	}
}
void sx_giam_diem(HS *ds, int n) {
	for(int i = 0; i < n-1; i++) {
		for(int j = n-1; j > i; j--) {
			if(ds[j].diemtk > ds[j-1].diemtk) {
				HS temp = ds[j];
				ds[j] = ds[j-1];
				ds[j-1] = temp;
			}
 		}
	}
}
int timkiem_tuantu(HS *ds, int n, char *ten, float diem) {
	for(int i = 0; i < n; i++) {
		if(strcmp(ds[i].hoten, ten) == 0 && diem == ds[i].diemtk) {
			return i;
		}
	}
	return -1;
}
int timkiem_nhiphan(HS *ds, int left, int right, int diem) {
	if(left > right) 
		return -1;
	else {
		int mid = left + (right-left) / 2;
		if(diem == ds[mid].diemtk) {
			return mid;
		}
		else if( diem > ds[mid].diemtk) {
			return timkiem_nhiphan(ds, left, mid-1, diem);
		} 
		else {
			return timkiem_nhiphan(ds, mid+1, right, diem);
		}
	}
}
int main()
{
	int n;
	cout << "nhap so hs: "; cin >> n;
	struct HS *ds = new HS[n];
	
	nhap_ds(ds, n);
	cout << "\n---DS VUA NHAP SX GIAM THEO DIEM TK---\n";
	sx_giam_diem(ds, n);
	xuat_ds(ds, n);
	
	char ten[30];
	float diem;
	
	cout << "\n------TIM KIEM TUAN TU------\n";
	cout << "nhap ten va diem tong ket cua hs can tim: \n";
	cout << " ho va ten: "; fflush(stdin); gets(ten);
	cout << " diem tk: "; cin >> diem;
	int a = timkiem_tuantu(ds, n, ten, diem);
	if(a == -1) 
		cout << "\nKhong tim thay hs co ten " << ten << " va co diem la " << diem << endl;
	else {
		cout << "\nThong tin hs co ten " << ten << " va co diem la " << diem << " nhu sau:\n";
		cout << "ho va ten: " << ds[a].hoten << endl;
		cout << "gioi tinh: " << ds[a].gioitinh << endl;
		cout << "nam sinh: " << ds[a].namsinh << endl;
		cout << "diem tk: " << ds[a].diemtk << endl;
	}	
	
	cout << "\n------TIM KIEM NHI PHAN------\n";
	cout << "nhap diem tong ket cua hs can tim: \n";
	cout << " diem tk: "; fflush(stdin); cin >> diem;
	a = timkiem_nhiphan(ds, 0, n-1, diem);
	if(a == -1) 
		cout << "\nKhong tim thay hs co diem la " << diem << endl;
	else {
		cout << "\nThong tin hs co diem la " << diem << " nhu sau:\n";
		cout << "ho va ten: " << ds[a].hoten << endl;
		cout << "gioi tinh: " << ds[a].gioitinh << endl;
		cout << "nam sinh: " << ds[a].namsinh << endl;
		cout << "diem tk: " << ds[a].diemtk << endl;
	}	
	return 0;
}

