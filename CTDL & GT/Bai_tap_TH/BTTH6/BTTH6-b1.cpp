#include<bits/stdc++.h>
using namespace std;

class SINHVIEN {
	char masv[10];
	char hodem[20];
	char ten[10];
	char gioitinh[5];
	int namsinh;
	float diemtk;
	public:
		SINHVIEN(const char*,const char*,const char*,const char*, int, float);
		void xuat();
		friend void selectsort_ten(vector<SINHVIEN> &sv);
};
SINHVIEN::SINHVIEN(const char* masv,const char* hodem,const char* ten,const char* gioitinh, int namsinh, float diemtk) {
	strcpy(this->masv, masv);
	strcpy(this->hodem, hodem);
	strcpy(this->ten, ten);
	strcpy(this->gioitinh, gioitinh);
	this->namsinh = namsinh;
	this->diemtk = diemtk;
}
void SINHVIEN::xuat() {
	cout << setw(10) << left << masv
		<< setw(20) << left << hodem
		<< setw(10) << left << ten
		<< setw(15) << left << gioitinh
		<< setw(10) << left << namsinh
		<< setw(10) << left << diemtk << endl;
}
void tieude_dssv() {
	cout << setw(10) << left << "MA SV"
		<< setw(20) << left << "HO DEM"
		<< setw(10) << left << "TEN"
		<< setw(15) << left << "GIOI TINH"
		<< setw(10) << left << "NAM SINH"
		<< setw(10) << left << "DIEM TK" << endl;
}
void nhap_dssv(vector<SINHVIEN> &sv) {
	SINHVIEN a1("SV1001","Tran Van","Thanh","nam",1999,7.5),
			 a2("SV1002","Nguyen Thi","Huong","Nu",2000,7.3),
			 a3("SV1003","Nguyen Van","Binh","Nam",1998,6.4),
			 a4("SV1004","Bui Thi","Hong","Nu",2000,5.8),
			 a5("SV1005","Duong Van","Giang","Nam",2998,8.3);
	sv.push_back(a1);
	sv.push_back(a2);
	sv.push_back(a3);
	sv.push_back(a4);
	sv.push_back(a5);
}
void xuat_dssv(vector<SINHVIEN> sv) {
	for(int i = 0; i < sv.size(); i++) 
		sv[i].xuat();
}
void selectsort_ten(vector<SINHVIEN> &sv) {
	for(int i = 0; i < sv.size()-1; i++) {
		int m = i;
		for(int j = i+1; j < sv.size(); j++) {
			if(strcmp(sv[j].ten, sv[m].ten) < 0) {
				m = j;
			}
		}
		if(m != i) {
			SINHVIEN temp = sv[m];
			sv[m] = sv[i];
			sv[i] = temp;
		}
	}
}
int main()
{
	vector<SINHVIEN> sv;
	nhap_dssv(sv);
	cout << "\n\t\t------DANH SACH SINH VIEN------\n\n";
	tieude_dssv();
	xuat_dssv(sv);
	
	// xoa phan tu dau tien trong ds
	sv.erase(sv.begin());
	cout << "\n\t\t------DANH SACH SINH VIEN SAU KHI XOA------\n\n";
	xuat_dssv(sv);
	
	// chen sv vao vi tri thu 3
	SINHVIEN a("1006", "Le Thi", "Doan", "Nu", 1998, 7.6);
	sv.insert(sv.begin() + 2, a);
	cout << "\n\t\t------DANH SACH SINH VIEN SAU KHI CHEN------\n\n";
	xuat_dssv(sv);
	
	// sap xep ds tang theo ten sv
	cout << "\n\t\t------DANH SACH SINH VIEN SX TANG THEO TEN------\n\n";
	selectsort_ten(sv);
	xuat_dssv(sv);
	
	return 0;
}

