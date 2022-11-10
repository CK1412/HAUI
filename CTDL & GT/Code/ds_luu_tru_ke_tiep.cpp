#include<bits/stdc++.h>
using namespace std;

// khai bao CTDL danh sach
#define max 100
struct SV {
	int masv;
	char hoten[30];
	int tuoi;
};
struct List {
	SV E[max];
	int count;
};
// khoi tao ds rong
void Create(List &L) {
	L.count = -1;
}
// kiem tra ds
int Empty(List L) {
	return L.count == -1;
}
int Full(List L) {
	return L.count == max-1;
}
// them sv vao cuoi ds
void Add(List &L, SV x) {
	if(Full(L))
		return;
	else {
		L.count++;
		L.E[L.count] = x;
	}	
}
// nhap 1 SV
void Nhap_sv(SV &x) {
	cout << " Nhap ma sv: "; cin >> x.masv;
	cout << " Nhap ten sv: "; fflush(stdin); gets(x.hoten);
	cout << " Nhap tuoi: "; cin >> x.tuoi;
}
// nhap ds sv
void Nhap_ds(List &L) {
	Create(L);
	SV x;
	int n;
	cout << "Nhap so sv: "; cin >> n;
	for(int i = 0; i < n; i++) {
		cout << "SV thu " << i+1 << endl;
		Nhap_sv(x);
		Add(L, x);
	}
}
// hien thi ds sv
void Xuat_ds(List L) {
	cout << "\n\t" << setw(20) << left << "MA SV"
		<< setw(30) << left << "HO TEN"
		<< setw(20) << left << "TUOI"
		<< endl;
	for(int i = 0; i <= L.count; i++) {
		cout << "\t" << setw(20) << left << L.E[i].masv
			<< setw(30) << left << L.E[i].hoten
			<< setw(20) << left << L.E[i].tuoi
			<< endl;
	}
}
// xoa sv dau ds
void Delete_first(List &L) {
	if(!Empty(L)) {
		for(int i = 0; i < L.count; i++)
			L.E[i] = L.E[i+1];
		L.count--;
	}
}
// tim kiem sv theo ma sv
int Search_masv(List L, int masv) {
	if(!Empty(L)) {
		for(int i = 0; i <= L.count; i++)
			if(L.E[i].masv == masv) 
				return i;
		return -1;
	}
}
// xoa sv theo ma sv
void Delete_masv(List &L, int masv) {
	int k = Search_masv(L, masv);
	for(int i = k; i < L.count; i++)
		L.E[i] = L.E[i+1];
	L.count--;
}
// them 1 sv vao vi tri k
void Insert_sv(List &L, int k) {
	SV x;
	if(!Full(L) && k <= L.count+1 && k >= 1) {
		cout << "\nNhap sv can them:\n";
		Nhap_sv(x); 
		L.count++;
		for(int i = L.count; i >= k; i--) 
			L.E[i] = L.E[i-1];
		L.E[k-1] = x;	
	}
}
// sap xep ds theo chieu tang dan cua ten
void Sort_hoten(List &L) {
	for(int i = 0; i < L.count; i++)
		for(int j = L.count; j > i; j--)
			if(strcmp(L.E[j].hoten, L.E[j-1].hoten) < 0) {
				SV temp = L.E[j];
				L.E[j] = L.E[j-1];
				L.E[j-1] = temp; 
			}
}
// them sv khong lam mat tinh sap xep
void Insert_sort(List &L) {
	SV x;
	if(!Full(L)) {
		cout << "\nNhap sv can them:\n";
		Nhap_sv(x); 
		int i = L.count;
		while(i >= 0 && strcmp(L.E[i].hoten, x.hoten) > 0) {
			L.E[i+1] = L.E[i];
			i--;
		}
		L.E[i+1] = x;
		L.count++;
	}
}
int main()
{
	List L;
	Nhap_ds(L);
	cout << "\nDANH SACH SV VUA NHAP:\n";
	Xuat_ds(L);
	
	cout << "\nDANH SACH SV SAU KHI XOA SV DAU TIEN:\n";
	Delete_first(L);
	Xuat_ds(L);
	
	int k;
	cout << "\nNhap ma sv cua sv can xoa: "; cin >> k;
	cout << "\nDANH SACH SV SAU KHI XOA SV CO MASV = " << k << ":\n";
	Delete_masv(L, k);
	Xuat_ds(L);
	
	Insert_sv(L, 3);
	cout << "\nDANH SACH SV SAU KHI CHEN SV MOI VAO VI TRI THU 3:\n";
	Xuat_ds(L);
	
	cout << "\nDANH SACH SV SAP XEP TANG THEO TEN:\n";
	Sort_hoten(L);
	Xuat_ds(L);
	 
	Insert_sort(L);
	cout << "\nDANH SACH SV SAU CHEN KO MAT TINH SAP XEP:\n";
	Xuat_ds(L);
	return 0;
}

