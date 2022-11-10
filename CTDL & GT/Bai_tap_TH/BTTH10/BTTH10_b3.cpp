#include<bits/stdc++.h>
#include<conio.h>
using namespace std;

struct ThiSinh {
	int sbd;
	char hoten[30];
	float tongdiem;
};
struct Node {
	ThiSinh infor;
	Node* next;
};
typedef Node* TRO;
void Create(TRO &L) {
	L = NULL;
}
int Empty(TRO L) {
	return L == NULL;
}
void Add_last(TRO &L, ThiSinh x) {
	TRO P = new Node;
	P->infor = x;
	P->next = NULL;
	if(Empty(L))
		L = P;
	else {
		TRO Q = L;
		while(Q->next != NULL) {
			Q = Q->next;
		} 
		Q->next = P;
	}
}
void Nhap_tt(ThiSinh &x) {
	cout << " nhap so bao danh: "; cin >> x.sbd;
	cout << " nhap ho va ten: "; fflush(stdin); gets(x.hoten);
	cout << " nhap tong diem: "; cin >> x.tongdiem;
}
void Nhap_ds(TRO &L) {
	Create(L);
	ThiSinh x;
	char c;
	do {
		cout << "Nhap thong tin thi sinh: \n";
		Nhap_tt(x);
		Add_last(L, x);
		system("cls");
		cout << "An phim bat ki de tiep tuc them sv, dung lai an ESC.\n";
		c = getch();
	} while(c != 27);
}
void Hienthi_ds(TRO L) {
	if(Empty(L))
		cout << "\nDs sv rong.\n";
	else {
		cout << setw(15) << left << "SO BD"
			<< setw(25) << left << "HO VA TEN"
			<< setw(15) << left << "TONG DIEM" 
			<< endl;
		TRO Q = L;
		while(Q != NULL) {
			ThiSinh x = Q->infor;
			cout << setw(15) << left << x.sbd
				<< setw(25) << left << x.hoten
				<< setw(15) << left << x.tongdiem
				<< endl;
			Q = Q->next;
		}
	}
}
int Length(TRO L) {
	TRO Q = L;
	int count = 0;
	while(Q != NULL) {
		count++;
		Q = Q->next;
	}
	return count;
}
void Insert(TRO &L, int k) {
	ThiSinh x;
	cout << "\nNhap sv can chen:\n";
	Nhap_tt(x);
	if(k >= 1 && k <= Length(L)) {
		TRO Q = L;
		int i = 1;
		while(Q->next != NULL && i < k-1) {
			Q = Q->next;
			i++;
		}
		TRO P = new Node;
		P->infor = x;
		P->next = Q->next;
		Q->next = P;
	}
}
int main()
{
	TRO L;
	Nhap_ds(L);
	cout << "\t\t------DANH SACH THI SINH VUA NHAP------\n\n";
	Hienthi_ds(L);
	
	Insert(L, 3);
	cout << "\n\t\t------DANH SACH SV SAU KHI CHEN 1 SV MOI------\n\n";
	Hienthi_ds(L);
	return 0;
}

