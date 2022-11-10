#include<bits/stdc++.h>
#include<conio.h>
using namespace std;

struct SV {
	int masv;
	char hoten[30];
	int tuoi;
};
struct Node {
	SV infor;
	Node *next;	
};
typedef Node *TRO;
// Khoi tao ds rong
void Create(TRO &L) {
	L = NULL;
}
// Kiem tra ds rong
int Empty(TRO L) {
	return L == NULL;
}
// nhap 1 SV
void Nhap_sv(SV &x) {
	cout << " Nhap ma sv: "; cin >> x.masv;
	cout << " Nhap ten sv: "; fflush(stdin); gets(x.hoten);
	cout << " Nhap tuoi: "; cin >> x.tuoi;
}
// them 1 sv vao cuoi ds
void Add_last(TRO &L, SV x) {
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
// nhap ds sv
void Nhap_ds(TRO &L) {
	Create(L);
	SV x;
	int i = 1;
	char c;
	do {
		cout << "\nNhap sv thu " << i++ << endl;
		Nhap_sv(x);
		Add_last(L, x);
		system("cls");
		cout << "An phim bat ki de tiep tuc them sv, dung lai an ESC.\n";
		c = getch();
	} while(c != 27);
}
// hien thi ds sv
void Xuat_ds(TRO L) {
	if(Empty(L))
		cout << "\nDs sv rong\n";
	else {
		cout << "\n\t" << setw(20) << left << "MA SV"
		<< setw(30) << left << "HO TEN"
		<< setw(20) << left << "TUOI"
		<< endl;
		TRO Q = L;
		while(Q != NULL) {
			SV x = Q->infor;
			cout << "\t" << setw(20) << left << x.masv
			<< setw(30) << left << x.hoten
			<< setw(20) << left << x.tuoi
			<< endl;
			Q = Q->next;
		}
	}
}
// xac dinh chieu dai ds
int Length(TRO L) {
	int n = 0;
	TRO Q = L;
	while(Q != NULL) {
		Q = Q->next;
		n++;
	}
	return n;
}
// Xoa sv dau tren ds
void Delete_first(TRO &L) {
	if(!Empty(L)) {
		TRO Q = L;
		L = L->next;
		delete Q;
	}
}
// tim sv theo masv
TRO Search_masv(TRO &L, int masv) {
	TRO Q = L;
	while(Q != NULL && Q->infor.masv != masv)
		Q = Q->next;
	return Q;
}
// xoa 1 nut tro boi con tro T
void Delete(TRO &L, TRO T) {
	if(L == T)
		L = T->next;
	else {
		TRO Q = L;
		while(Q->next != T)
			Q = Q->next;
		Q->next = T->next;
	}
	delete T;
}
// xoa 1 sv theo masv
void Delete_masv(TRO &L, int masv) {
	TRO T = Search_masv(L, masv);
	if(T == NULL) {
		cout << "\nKhong co sv co ma " << masv << " trong ds." << endl;
		return;
	}
	Delete(L, T);
	cout << "\nDS SV SAU KHI XOA SV CO MASV = " << masv << ":\n";
	Xuat_ds(L); 
}
// chen 1 sv vao vi tri dau ds
void Add_first(TRO &L, SV x) {
	TRO P = new Node;
	P->infor = x;
	P->next = L;
	L = P;
} 
// chen 1 sv vao sau 1 nut
void Insert(TRO &L, TRO Q, SV x) {
	TRO P = new Node;
	P->infor = x;
	P->next = Q->next;
	Q->next = P;
}
// chen 1 sv vao vi tri k
void Insert(TRO &L, int k, SV x) {
	if(k == 1) 
		Add_first(L, x);
	else {
		TRO Q = L;
		int i = 1;
		while(i < k-1) {
			Q = Q->next;
			i++;
		}
		Insert(L, Q, x);
	}
}
// sap xep ds theo chieu giam dan cua ho ten (select_sort)
void Sort(TRO &L) {
	TRO Q, P, R;
	P = L;
	while(P->next != NULL) {
		R = P;
		Q = P->next;
		while(Q != NULL) {
			if(strcmp(Q->infor.hoten, R->infor.hoten) > 0)
				R = Q;
			Q = Q->next; 
		}
		SV temp = P->infor;
		P->infor = R->infor;
		R->infor = temp;
		P = P->next;
	}
}
// chen 1 sv khong mat tinh sap xep
void Insert_sort(TRO &L, SV x) {
	if(strcmp(x.hoten, L->infor.hoten) >= 0) 
		Add_first(L, x);
	else {
		TRO Q = L;
		while(Q->next != NULL && strcmp(Q->next->infor.hoten, x.hoten) > 0)
			Q = Q->next;
		Insert(L, Q, x);
	}
}
int main()
{
	TRO L;
	Nhap_ds(L);
	cout << "\nDS SV VUA NHAP:\n";
	Xuat_ds(L);
	
	Delete_first(L);
	cout << "\nDS SV SAU KHI XOA SV DAU TIEN:\n";
	Xuat_ds(L);
	
	int masv;
	cout << "\nNhap masv cua sv can xoa: "; cin >> masv;
	Delete_masv(L, masv);
	
	SV x;
	int k;
	cout << "\nNhap sv can chen:\n"; Nhap_sv(x);
	do {
		cout << "\nNhap vi tri can chen: "; 
		cin >> k;
	} while(k < 1 || k > Length(L));
	Insert(L, k, x);
	cout << "\nDS SV SAU KHI CHEN SV MOI:\n";
	Xuat_ds(L);
	
	cout << "\nDS SV SAU KHI SAP XEP GIAM DAN THEO TEN:\n";
	Sort(L);
	Xuat_ds(L);
	
	cout << "\nNhap sv can chen:\n"; Nhap_sv(x);
	Insert_sort(L, x);
	cout << "\nDS SV SAU KHI CHEN K MAT TINH SAP XEP:\n";
	Xuat_ds(L);
	return 0;
}

