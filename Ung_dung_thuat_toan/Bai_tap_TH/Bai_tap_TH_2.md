# BÀI THỰC HÀNH SỐ 2: ĐỆ QUY – QUAY LUI

> Quay lui (Backtracking) là một kĩ thuật thiết kế giải thuật dựa trên đệ quy. <br>
> Ý tưởng của quay lui là tìm lời giải từng bước, mỗi bước chọn một trong số các lựa chọn khả dĩ và đệ quy.

**Bài tập 1:**  Cài đặt bài toán tìm ước số chung lớn nhất theo thuật toán đệ quy
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Phân tích:**
  
  - Sử dụng giải thuật Euclid

  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  int UCLN(int a, int b) {	
    if(b == 0)
      return a;

    return UCLN(b, a%b); 
  }

  int main() {
    int a, b;
    cout << "a = "; cin >> a;
    cout << "b = "; cin >> b;

    cout << "UCLN(a, b) = " << UCLN(a, b) << endl;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200981809-4183c395-50c2-45b4-9aac-be507ddf94cb.png)

</details>  
  
**Bài tập 2:** Cài đặt bài toán tìm ước số chung lớn nhất theo thuật toán lặp (khử đệ quy)

<details>
  <summary><i>Xem chi tiết</i></summary>
 <br>

  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  int UCLN(int a, int b) {	
    int tmp;

    while(b != 0) {
      tmp = a % b;
      a = b;
      b = tmp;
    }	

    return a;
  }

  int main() {
    int a, b;
    cout << "a = "; cin >> a;
    cout << "b = "; cin >> b;

    cout << "UCLN(a, b) = " << UCLN(a, b) << endl;

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200982023-fbf4dfa8-30db-425b-b6df-7bab792a2edf.png)

</details>  
	
**Bài tập 3:** Cài đặt bài toán tìm số fibonaci theo thuật toán đệ quy
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Phân tích:**
  
  - Dãy fibonacci: 1 1 2 3 5 8 13 ...

  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  long fibonacci(int n) {
    if(n == 1 || n == 2)
      return 1;

    return fibonacci(n-1) + fibonacci(n-2);
  }

  int main() {
    int n;
    cout << "n = "; cin >> n;

    cout << "So fibonacci thu n: " << fibonacci(n) << endl;

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200982321-9d846c30-0457-4e47-9146-b7edf58ffafd.png)

</details>  
  
**Bài tập 4:** Cài đặt bài toán tìm số fibonaci theo thuật toán lặp (khử đệ quy)
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Phân tích:**
 
  - Dãy fibonacci: 1 1 2 3 5 8 13 ...

  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  long fibonacci(int n) {
    if(n == 1 || n == 2)
      return 1;

    int f1 = 1, f2 = 1;
    int f;	

    int i = 3;

    while(i <= n) {
      f = f1 + f2;
      f1 = f2;
      f2 = f;
      i++;
    }

    return f;
  }

  int main() {
    int n;
    cout << "n = "; cin >> n;

    cout << "So fibonacci thu n: " << fibonacci(n) << endl;

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200982575-ddff7ecb-d7db-4eb8-8d34-a7cc08228704.png)

</details>  
  
**Bài tập 5:** Cài đặt bài toán tháp Hà Nội theo thuật toán đệ quy
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Phân tích:**
 
  - Quy ước:
	  - Có 3 cột: A, B, C
	  - Số đĩa: n > 1
	  - Mỗi lần di chuyển 1 đĩa
  - Mục tiêu: 
	  - Di chuyển n đĩa từ tháp A sang C
  - Minh hoạ:
  
  ![tower_of_hanoi](https://user-images.githubusercontent.com/65481655/200983102-e2f9913f-ae63-4cd1-92af-ae6eff6d4be7.gif)

  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  void TowerHN(int n, char a, char b, char c) {
    if(n == 1) {
      cout << "\t" << a << "------->" << c << endl;
      return;
    }

    TowerHN(n-1, a, c, b);
    TowerHN(1, a, b, c);
    TowerHN(n-1, b, a, c);
  }

  int main() {
    int n;
    cout << "Nhap so dia: "; cin >> n;

    cout << "Cac buoc di chuyen dia tu cot A sang C" << endl;
    TowerHN(n, 'A', 'B', 'C');

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200983201-330ac4ff-60ea-4d76-b568-ece4f3cd0c91.png)

</details>  
  
**Bài tập 6:** Cài đặt bài toán tháp Hà Nội theo thuật toán khử đệ quy
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  Khó😁

</details>  
  
**Bài tập 7:** Cài đặt bài toán sinh dãy nhị phân theo phương pháp quay lui
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  int n;
  int x[100];

  void show() {
    for(int i = 0; i < n; i++)
      cout << x[i];
    cout << endl;
  }

  void action(int k) {
    for(int i = 0; i <= 1; i++) {
      x[k] = i;

      if(k == n-1) 
        show();
      else
        action(k+1);
    }	
  }

  int main() {
    cout << "Nhap n = "; cin >> n;

    action(0);

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200983731-fc74a411-421d-4747-b07f-e50171dda233.png)

</details>  
  
**Bài tập 8:** Cài đặt bài toán liệt kê hoán vị theo phương pháp quay lui
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Phân tích:**
 
  - Chỉnh hợp (có thứ tự)

  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  int n;
  bool check[100] = {false};
  int x[100];

  void show() {
    for(int i = 1; i <= n; i++) 
      cout << x[i] << " ";
    cout << endl;
  }

  void action(int k) {
    for(int i = 1; i <= n; i++) {
      if(!check[i]) {
        x[k] = i;
        check[i] = true;

        if(k == n) 
          show();
        else
          action(k+1);

        check[i] = false;
      }
    }
  }

  int main() {
    cout << "n = "; cin >> n;

    cout << "\nSinh cac hoan vi:\n";
    action(1);

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200984199-0cbcbb01-8fb0-40a3-bca8-f47a14e4860f.png)

</details>  
	
**Bài tập 9:** Cài đặt bài toán mã đi tuần theo phương pháp quay lui
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Phân tích:**
 
  - Minh hoạ:
  
  ![200px-Knights-Tour-Animation](https://user-images.githubusercontent.com/65481655/200987414-f83a09f4-d9cc-4b39-b32a-c660ef0f5513.gif)

  **Code:**

  ```c++
  #include<bits/stdc++.h>
  using namespace std;

  int n;

  // buoc di cua quan ma
  int dem = 0;

  // mang danh dau thu tu di chuyen tuong ung voi moi o
  int **a;

  // co 8 cach di chuyen cua quan ma theo toa do Oxy
  int X[8] = {-2,-2,-1,-1, 1, 1, 2, 2}; 
  int Y[8] = {-1, 1,-2, 2,-2, 2,-1, 1};


  void xuat() {
    for(int i = 0; i < n; i++) {
      for(int j = 0; j < n; j++) {
        cout << a[i][j] << "\t";
      }
      cout << endl << endl;
    }
  }
  void dichuyen(int x, int y) {
    dem++;
    a[x][y] = dem;

    // xet lan luot 8 cach di chuyen
    for(int i = 0; i < 8; i++) {
      if(dem == n*n) {
        cout << "\nThu tu di chuyen tren ban co nhu sau:\n\n";
        xuat();
        exit(0);
      }
      int u = x + X[i];
      int v = y + Y[i];
      if(u >= 0 && u < n && v >= 0 && v < n && a[u][v] == 0) {
        dichuyen(u, v);
      }
    }
    // neu k cach nao t/m thi tra v gia tri ban dau
    dem--;
    a[x][y] = 0;
  }
  int main()
  {
    cout << "nhap n: "; 
    cin >> n;
    cout << "Ban co co kich thuoc " << n << " x " << n << endl;

    a = new int*[n];
    for(int i = 0; i < n; i++) {
      a[i] = new int[n]();  // khoi tao cac phan tu co gia tri la 0
    }
    int a, b;
    cout << "Nhap toa do xuat phat:\n";
    cout << " x = "; cin >> a;
    cout << " y = "; cin >> b;
    dichuyen(a, b);

    cout << "\nKhong co duong di.\n";
    return 0;
  }
  ```

  **Kết quả chạy:**
  
  | Không có đường đi  | Có đường đi    |
  | :---: | :---: |
  | ![image](https://user-images.githubusercontent.com/65481655/200986687-61e89346-d4f5-4ad7-8418-c0d50aa426e9.png)   | <img width="500px" src="https://user-images.githubusercontent.com/65481655/200986782-7cff720b-e9da-475b-b431-7063eb073ef6.png"/>  |

</details> 

**Bài tập 10:** Cài đặt bài toán tám hậu theo phương pháp quay lui
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Phân tích:**
 
  - Kiểm tra điều kiện các con hậu tấn công nhau
  
  - A(xA, yA) va B(xB, yB)
  - Xét điều kiện chung hàng
    - Có yA = yB -> tấn công nhau
  - Xét điều kiện chung đường chéo.
    - Có |xA-xB| = |yA - yB| -> tấn công nhau

  **Code:**

  ```c++
  #include<bits/stdc++.h>
  using namespace std;

  // mang luu vi tri row tuong tung voi column
  int row[8] = {0}; 

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
  ```

  **Kết quả chạy:**
            
  | Kết quả | Giải thích |
  | :---: | :---: |
  | ![image](https://user-images.githubusercontent.com/65481655/200989102-03c9738f-6561-4ec1-a9a4-4ee8da7dcedd.png) | Mỗi row tương ứng với column là 1 cách sắp xếp. <br> Ví dụ với row đầu tiên ta có các vị trí đặt 8 con hậu: (1, 1), (5, 2), (8, 3), (6, 4), (3, 5), (7, 6), (2, 7), (4, 8).  <br><br> ![8_hau_ket_qua](https://user-images.githubusercontent.com/65481655/200989745-2b1e614d-332c-496e-bc5b-d9a08cb47695.jpg) |
  

</details>  
