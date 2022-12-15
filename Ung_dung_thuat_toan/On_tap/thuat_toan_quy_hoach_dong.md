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
  
