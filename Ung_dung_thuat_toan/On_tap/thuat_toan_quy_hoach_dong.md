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
