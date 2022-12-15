# THUẬT TOÁN QUY HOẠCH ĐỘNG

**Bài 1:** Tìm số fibonaci

<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Mô tả**
  
  Dãy fibonacci: 0 1 1 2 3 5 ...
  
  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  int fibonacci(int n) {
    int a[n+1];
    a[0] = 0;
    a[1] = 1;
    a[2] = 1;

    for(int i = 3; i < n; i++) {
      a[i] = a[i-1] + a[i-2];
    }

    return a[n-1];
  }

  int main() {
    int n;
    cout << "Nhap n = "; cin >> n;
    cout << "So Fibonacci thu n la: " << fibonacci(n) << endl;
    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/207908379-7a555d8e-233a-4030-b66b-933c3edaf46c.png)

</details>
  
**Bài 2:**  Phân tích số thành tổng.  
  n <= 100. Có bao nhiêu cách phân tích n thành tổng các số nguyên dương. Các cách là hoán vị của nhau thì chỉ tính là 1 cách.

<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Mô tả**
  
  Chẳng hạn, với n = 5 thì có 7 cách phân tích:
  > 5 = 1 + 1 + 1 + 1 + 1 <br>
    5 = 1 + 1 + 1 + 2 <br>
    5 = 1 + 1 + 3 <br>
    5 = 1 + 2 + 2 <br>
    5 = 1 + 4 <br>
    5 = 2 + 3 <br>
    5 = 5 <br>
  
  **Phân tích**
  
  Có 2 cách thực hiện:
  - Dùng quy hoạch động
  - Dùng đệ quy có nhớ
  
  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  // Cach 1: Quy hoach dong
  int soCachPhanTich(int n) {
    int a[n+1]{0};

    a[0] = 1;

    for(int i = 1; i <= n; i++) {
      for(int j = i; j <= n; j++) {
        a[j] += a[j-i];
      }
    }

    return a[n];
    // neu khong tinh chinh no thi -1 
  }

  // Cach 2: De quy co nho
  int a[100][100];

  // f(m, n) la so cach phan tich n thanh cac so nguyen duong <= m
  int f(int m, int n) {
    if(m == 0) {
      a[m][n] = (n == 0) ? 1 : 0;
    }
    else {
      if(m > n) {
        a[m][n] = f(m-1, n);
      }
      else {
        a[m][n] = f(m-1, n) + f(m, n-m);
      }
    }

    return a[m][n];
  }

  int main() {
    int n = 5;
    cout << "n = " << n << endl;
    cout << "So cach phan tich n thanh tong: " << soCachPhanTich(n) << endl;

    cout << "So cach phan tich n thanh tong: " << f(n, n) << endl;

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/207909532-4df135d2-7481-44ce-a46b-1a8762b53305.png)

</details>
  
**Bài 3:** Bài toán cái túi.

<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Mô tả**
  
  - Trong siêu thị có n gói hàng {1, 2, …, n}, gói hàng thứ i có trọng lượng là w[i] và giá trị v[i].
  - Ban đêm một tên trộm đột nhập vào siêu thị, cậu ấy mang theo một cái túi có thể mang được trọng lượng tối đa là m.
  - Hỏi cậu ấy sẽ lấy đi những gói hàng nào để đạt được tổng giá trị lớn nhất.
  
  **Code:**

  ```c++
  #include<bits/stdc++.h>
  using namespace std;

  int weight[] = {5, 10, 6, 3, 7, 8};
  int value[] = {15,61, 20, 10, 50, 23};

  int a[100][100];

  void hienThiMang(int *a, int n) {
    for(int i = 0; i < n; i++) {
      cout << a[i] << "  ";
    }
    cout << endl;
  }

  // timMax(n, m) la gia tri max nhan duoc cua n goi hang voi gioi han trong luong m 
  int timMax(int n, int max) {	
    for(int i = 1; i <= n; i++) {
      for(int w = 1; w <= max; w++) {
        if(weight[i-1] <= w) {
          int x = value[i-1] + a[i-1][w - weight[i-1]];
          int y = a[i-1][w];
          a[i][w] = x > y ? x : y;
        }
        else {
          a[i][w] = a[i-1][w];
        }
      }
    }


    return a[n][max];
  }

  void hienThiGoiHangDaLay(int n, int max) {
    cout << "Cac goi hang da lay: \n";
    int i = n, j = max;
    while(i > 0) {
      if(a[i][j] != a[i-1][j]) {
        cout << " Goi hang thu " << i
          << ", w = " << weight[i-1] 
          << ", v = " << value[i-1] << endl;
        j -= weight[i-1];
      }	
      i--;
    }
  }

  int main() {
    int n = sizeof(weight) / sizeof(int),
      max = 15;

    cout << "So goi hang: " << n << endl;
    cout << "Trong luong toi da cua tui: " << max << endl;
    cout << "Thong so cac goi hang lan luot:\n";
    cout << " Weight:\t"; hienThiMang(weight, n);
    cout << " Value: \t"; hienThiMang(value, n);

    cout << "\nTong gia tri max lay duoc: " << timMax(n, max) << endl;

    hienThiGoiHangDaLay(n, max);

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/207910809-3265bb4b-ac5c-4f95-8054-ae1cdb5d734a.png)

</details>

