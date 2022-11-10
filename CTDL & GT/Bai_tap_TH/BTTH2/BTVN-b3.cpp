#include<bits/stdc++.h>
using namespace std;

// mang luu vi tri row tuong tung voi column
int row[8] = {0}; 

/* kiem tra dieu kien cac con hau  tan cong nhau

	A(xA, yA) va B(xB, yB)
	+ Xét dieu kien chung hàng
   	 - Có yA = yB -> tan cong nhau
	+ Xét dieu kien chung duong chéo.
   	- Có |xA-xB| = |yA - yB| -> tan công nhau
   	
*/
bool kt_dk(int c, int r) {
	for(int column = 0;  column < c; column++) {
		if(row[column] == r || abs(row[column] - r) == abs(column - c)) 
			return false;
	}
	return true;
}

void showRow() {
	cout << "row   : ";
	for(int column = 0; column < 8; column++) {
		cout << row[column] + 1 << " "; 
	}
	cout << endl;
} 

// sap xep 8 quan hau 
void quay_lui(int c) {
	if(c == 8) {
		showRow();
	}
	else {
		// kiem tra tung hang
		for(int r = 0; r < 8; r++) {
			if(kt_dk(c, r)) {
				row[c] = r;
				quay_lui(c+1);
			}
		}
	}
}
int main()
{
	cout << "Ban co vua 8 x 8. Co 8 quan hau.\n";
	cout << "Sap xep 8 con hau de chung khong tan cong nhau nhu sau:\n";
	cout << "\ncolumn: 1 2 3 4 5 6 7 8\n\n";
	
	// bat dau chon tai column 1
	quay_lui(0); 
	
	return 0;
}

