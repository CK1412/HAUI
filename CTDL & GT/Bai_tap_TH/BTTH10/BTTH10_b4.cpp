#include<bits/stdc++.h>
#include<conio.h>
using namespace std;
#define max 10
struct ThiSinh {
	int sbd;
	char hoten[30];
	float tongdiem;
};
struct List {
	ThiSinh E[max];
	int count;
};
void Create(List &L) {
	L.count = -1;
}
int Empty(List L) {
	return (L.count == -1);
}
int Full(List L) {
	return (L.count == max -1);
}
void Add(List &L, ThiSinh x) {
	if(Full(L))
		cout << "\nDS da day.\n";
	else {
		L.count++;
		L.E[L.count] = x;
	}
}
void Nhap_tt(ThiSinh &x) {
	cout << " nhap so bao danh: "; cin >> x.sbd;
	cout << " nhap ho va ten: "; fflush(stdin); gets(x.hoten);
	cout << " nhap tong diem: "; cin >> x.tongdiem;
}
void Nhap_ds(List &L) {
	Create(L);
	ThiSinh x;
	char c;
	do {
		cout << "Nhap thong tin thi sinh: \n";
		Nhap_tt(x);
		Add(L, x);
		system("cls");
		cout << "An phim bat ki de tiep tuc them sv, dung lai an ESC.\n";
		c = getch();
	} while(c != 27);
}
void Hienthi_ds(List &L) {
	cout << setw(15) << left << "SO BD"
			<< setw(25) << left << "HO VA TEN"
			<< setw(15) << left << "TONG DIEM" 
			<< endl;
	for(int i = 0; i <= L.count; i++) {
		cout << setw(15) << left << L.E[i].sbd
			<< setw(25) << left << L.E[i].hoten
			<< setw(15) << left << L.E[i].tongdiem
			<< endl;	
	}
}
int Insert(List &L, int k) {
	ThiSinh x;
	cout << "\nNhap sv can chen:\n";
	Nhap_tt(x);
	if(!Full(L) && k >= 1 && k <= L.count+1) {
		L.count++;
		for(int i = L.count; i >= k; i--)
			L.E[i] = L.E[i-1];
		L.E[k-1] = x;
		return 1;
	}
	return 0;
}
int main()
{
	List L;
	Nhap_ds(L);
	
	cout << "\t\t------Danh sach SV vua nhap------\n\n";
	Hienthi_ds(L);
	
	if(Insert(L,3) == 1) {
		cout << "\nDS sv sau khi chen:\n";
		Hienthi_ds(L);
	}
	else
		cout << "\nVi tri khong phu hop.\n";
	return 0;
}

