#include <bits/stdc++.h>
using namespace std;

#define MAX 10

void title() {
	cout <<	"\n\t\t\t================= THONG TIN SINH VIEN =================\n"
		 << setw(5) << left << "STT"
		 << setw(18) << left << "Ma SX"
		 << setw(18) << left << "Ho dem"
		 << setw(18) << left << "Ten"
		 << setw(18) << left << "Gioi tinh"
		 << setw(18) << left << "Nam sinh"
		 << setw(18) << left << "Diem TK" << endl;
}

struct SinhVien {
	char maSV[10];
	char hoDem[30];
	char ten[30];
	char gioiTinh[20];
	int namSinh;
	float diemTK;
};

struct List {
	int count;
	SinhVien info[MAX];
};

List L;

void create(List &L) {
	L.count = -1;
}

void show(List L) {
	title();
	for (int i = 0; i <= L.count; i++) {
		cout << setw(5) << left << i + 1
			 << setw(18) << left << L.info[i].maSV
			 << setw(18) << left << L.info[i].hoDem
			 << setw(18) << left << L.info[i].ten
			 << setw(18) << left << L.info[i].gioiTinh
			 << setw(18) << left << L.info[i].namSinh
			 << setw(18) << left << L.info[i].diemTK << endl;
	}
	system("pause");
}

void nhap(List &L) {
	while (L.count < 4) {
		L.count++;
		cout << "\nThong tin sinh vien thu " << L.count + 1 << endl;
		cout << "Ma sv: ";
		fflush(stdin);
		gets(L.info[L.count].maSV);
		cout << "Ho dem: ";
		gets(L.info[L.count].hoDem);
		cout << "Ten: ";
		gets(L.info[L.count].ten);
		cout << "Gioi tinh: ";
		gets(L.info[L.count].gioiTinh);
		cout << "Nam sinh: ";
		cin >> L.info[L.count].namSinh;
		cout << "Diem TK: ";
		cin >> L.info[L.count].diemTK;
	}
	show(L);
}

void deleteFirst(List &L) {
	for (int i = 0; i <= L.count; i++) {
		L.info[i] = L.info[i + 1];
	}
	L.count--;
	show(L);
}

void insert(List &L, SinhVien t) {
	L.count++;
	for (int i = L.count; i > 2; i--) {
		L.info[i] = L.info[i - 1];
	}
	L.info[2] = t;
	show(L);
}

void selectionSort(List L) {
	for (int i = 0; i < L.count; i++) {
		int index = i;
		for (int j = i; j <= L.count; j++) {
			if (strcmp(L.info[j].ten, L.info[index].ten) < 0) {
				index = j;
			}
		}
		SinhVien tg = L.info[i];
		L.info[i] = L.info[index];
		L.info[index] = tg;
	}
	show(L);
}

void menu() {
	while (true) {
		system("cls");
		int luaChon;
		cout << "\tNHAP LUA CHON\n"
			 << "1. Danh sach sinh vien\n"
			 << "2. Xoa sinh vien dau tien\n"
			 << "3. Chen sinh vien\n"
			 << "4. Sap xep danh sach\n"
			 << "0. Ket thuc\n"
			 << "\t---------------\n"
			 << "Lua chon: ";
		cin >> luaChon;
		if (luaChon < 0 || luaChon > 4) {
			cout << "Lua chon khong hop le";
			system("pause");
		}
		else if (luaChon == 1) {
			nhap(L);
		}
		else if (luaChon == 2) {
			deleteFirst(L);
		}
		else if (luaChon == 3) {
			SinhVien t;
			cout << "\nNhap thong tin sinh vien can chen\n";
			cout << "Ma sv: ";
			fflush(stdin);
			gets(t.maSV);
			cout << "Ho dem: ";
			gets(t.hoDem);
			cout << "Ten: ";
			gets(t.ten);
			cout << "Gioi tinh: ";
			gets(t.gioiTinh);
			cout << "Nam sinh: ";
			cin >> t.namSinh;
			cout << "Diem TK: ";
			cin >> t.diemTK;
			insert(L, t);
		}
		else if (luaChon == 4) {
			selectionSort(L);
		}
		else
			break;
	}
}

int main() {
	create(L);
	menu();
	return 0;
}

