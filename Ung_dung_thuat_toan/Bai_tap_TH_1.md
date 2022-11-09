# BÀI THỰC HÀNH SỐ 1: GIẢI THUẬT ĐỆ QUY

**Bài tập 1:** Cài đặt chương trình sinh các chuỗi nhị phân độ dài n.

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
      if(k == n) {
          show();	
      }
      else {
          for(int i = 0; i <= 1; i++) {
              x[k] = i;
              action(k+1);
          }	
      }
  }

  int main() {
      cout << "Nhap n = "; cin >> n;

      action(0);

      return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200872735-36cf4c41-ca23-4e7b-8e76-a2656fcba2fa.png)

</details>
  
**Bài tập 2:** Cài đặt chương trình sinh các chuỗi ký tự độ dài n chỉ chứa 2 ký tự 'a' và ký tự 'b'.
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  int length = 2;
  char data[] = {'a','b'};

  int n;
  char x[100];

  void show() {
    for(int i = 0; i < n; i++) 
      cout << x[i];
    cout << endl;
  }

  void action(int k) {
    if(k == n) {
      show();
    }
    else {
      for(int i = 0; i < length; i++) {
        x[k] = data[i];
        action(k+1);
      }	
    }
  } 


  int main() {
    cout << "Nhap n = "; cin >> n;

    action(0);

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200874758-e3d29c4c-bbeb-49ea-ac44-973505bfa392.png)

</details>  

**Bài tập 3:** Cài đặt chương trình sinh các tập con k phần tử của tập S = {1, 2, …, n}..
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Phân tích:**
  
  - Các phần tử khác nhau, không tính vị trí (xếp theo thứ tự từ điển)
  - VD: 
    - Input: n = 3, k = 2 
    - Output:	{1,2}, {1,3}, {2,3} 
  
  **Code:**

  ```c++
  #include<iostream>
  using namespace std;
  
  int n, k;
  int x[100];

  void show() {
    for(int i = 1; i <= k; i++) 
      cout << x[i] << " ";
    cout << endl;
  }

  void action(int p) {
    for(int i = x[p-1]+1; i <= n-k+p; i++) {
      x[p] = i;

      if(p == k) 
        show();
      else 
        action(p+1);
    }
  } 

  int main() {
    cout << "n = "; cin >> n;
    cout << "k = "; cin >> k;

    action(1);

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200876028-1c49cbbd-f2cf-418d-b80e-fe3e89105f8a.png)

</details>  

**Bài tập 4:** Cài đặt chương trình liệt kê các cách lấy 4 sinh viên từ 6 sinh viên gồm: Trang, Cong, Trung, Binh, Hoan, Mai.
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Phân tích:**
    
  - Sử dụng tổ hợp (không có thứ tự) 
  - Số cách = nCk = n! / (k! * (n-k)!) = 15 cách
  
  **Code:**

  ```c++
  #include<iostream>
  using namespace std;
  
  string studentList[] = {"Trang", "Cong", "Trung", "Binh", "Hoan", "Mai"};
  int n = 6;

  int k = 4;
  int x[100];

  void show() {
    for(int i = 1; i <= k; i++) {
      cout << studentList[x[i]-1] << "\t";
    }
    cout << endl;
  }

  void action(int p) {
    for(int i = x[p-1]+1; i <= n-k+p; i++) {
      x[p] = i;

      if(p == k)
        show();
      else 
        action(p+1);
    }
  }

  int main() {
    cout << "Cac cach lay 4 sv tu 6 sv:" << endl;

    action(1);

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200877168-b1a6990c-17d8-4cc7-bd9e-ed1084971094.png)

</details>  
  
**Bài tập 5:** Cài đặt chương trình sinh các hoán vị của tập S = {1, 2, …, n}.
  
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
  
  ![image](https://user-images.githubusercontent.com/65481655/200878711-7c6ac108-62aa-4051-8d45-76dcdf02cd5e.png)

</details> 
  
**Bài tập 6:** Cài đặt chương trình liệt kê tất cả các cách xếp 6 sinh viên gồm: Trang, Cong, Trung, Binh, Hoan, Mai 
  vào 6 chiếc ghế được đánh số thứ tự 1, 2, …, 6.
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Phân tích:**
 
  - Chỉnh hợp (có thứ tự)
  - Số cách = n! = 6! = 720 hoặc	= nAn = 6! / 0! = 720
  
  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  int count = 0;
  string studentList[] = {"Trang", "Cong", "Trung", "Binh", "Hoan", "Mai"};
  int n = 6;
  int x[100];
  bool check[100] = {false};

  void show() {
    for(int i = 1; i <= n; i++) {
      cout << studentList[x[i]-1] << "\t";
    }
    cout << endl;
    count++;
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
    cout << "Cac cach xep 6 sinh vien" << endl;

    action(1);

    cout << "\nTong so cach: " << count << endl;

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ... Kết quả rất dài (Chỉ chụp lại phần cuối)
  
  ![image](https://user-images.githubusercontent.com/65481655/200879495-53c8e659-c1de-4547-b059-8344df8edbd8.png)

</details>  

**Bài tập 7:** Cài đặt chương trình tìm số Fibonaci thứ n bằng đệ quy có nhớ
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Phân tích:**
 
  - Dãy Fibonacci: 1, 1, 2, 3, 5, 8, 13, 21, ...
  - Đệ quy có nhớ: Các giá trị được sử dụng nhiều lần ta không tính lại mà sử dụng mảng để lưu trữ.

  **Code:**

  ```c++
  #include<iostream>
  using namespace std;
  
  int temp[100] = {};

  long fibonacci(int n) {
    if(n == 1 || n == 2)
      return 1;

    if(temp[n] != 0)
      return temp[n];
    else 
      return temp[n] = fibonacci(n-1) + fibonacci(n-2);
  } 

  int main() {
    int n;
    cout << "n = "; cin >> n;

    cout << "So fibonacci thu n: " << fibonacci(n) << endl;

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200880476-0d4785a4-c67a-4c1f-8de0-5076ca774f6c.png)

</details>  
  
**Bài tập 8:** (Thuật toán loang) Khởi tạo lưới (mảng 2 chiều) kích thước 12 x 12 gồm các số ngẫu nhiên trong đoạn [0, 5], hiển thị lưới. 
  Đếm số miền liên thông chứa các ô có giá trị 5 trong lưới.
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  Không hiểu, không làm 😁
  
</details>  

**Bài tập 9:** Cài đặt chương trình tính tổng các chữ số của số nguyên dương n bằng đệ quy.
  
<details>
  <summary><i>Xem chi tiết</i></summary> 
  <br>

  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  int sumOfDigits(int n) {
    if(n < 10) 
      return n;

    return n % 10 + sumOfDigits(n/10);
  }

  int main() {
    int n;

    cout << "Nhap so nguyen duong n: "; cin >> n;

    cout << "Tong cac chu so cua n: " << sumOfDigits(n) << endl;

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200882460-5d564536-7bdf-49ca-88a9-48216692466a.png)

</details>  
  
**Bài tập 10:** Cài đặt chương trình tính tổng các số lẻ trong một dãy n số nguyên bằng đệ quy.
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  long sumOfOddNumbers(int *x, int n) {	
    if(n == 0) {
      if(x[n] % 2 == 0)
        return 0;
      else
        return x[n];
    }

    if(x[n] % 2 == 0)
      return sumOfOddNumbers(x, n-1);
    else 	
      return x[n] + sumOfOddNumbers(x, n-1);
  }

  int main() {
    int n;
    cout << "n = "; cin >> n;

    int *x = new int[n];
    cout << "Nhap mang n phan tu:\n";
    for(int i = 0; i < n; i++) {
      cout << "x[" << i << "] = ";
      cin >> x[i];
    }

    cout << "Tong cac so le trong day: " << sumOfOddNumbers(x, n-1) << endl;
  
    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200882862-94d2085b-1700-41ba-b2ad-c1270e59630e.png)

</details>  
  
