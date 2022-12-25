# ÔN TẬP THI KTHP

**Bài 1:** Khởi tạo số nguyên dương k và mảng a gồm ít nhất 15 số nguyên. Tìm số nhỏ nhất m trong mảng a sao cho m > k bằng chiến lược đệ quy/ chia để trị.

<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Code:**

  ```c++
  #include<bits/stdc++.h>
  using namespace std;

  void hienThiMang(int a[], int k) {
    for(int i = 0; i < k; i++) {
      cout << a[i] << " "; 
    }
    cout << endl;
  }

  void timMin(int a[], int l, int r, int &min) {
    if(l == r) {
      min = a[l];
    }
    else {
      int mid = (l + r) / 2;
      int min1 = a[l], 
        min2 = a[mid+1];
      timMin(a, l, mid, min1);
      timMin(a, mid+1, r, min2);

      min = min1 > min2 ? min2 : min1;
    }
  }

  int main() {
    int k = 15;
    int a[k] = {3,5,7,1,8,54,31,79,5,2,7,9,21,31,10};

    int m = a[0];
    timMin(a, 0, k-1, m);

    cout << "Mang: ";
    hienThiMang(a, k);

    cout << "So nho nhat trong mang: " << m << endl;

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/209468189-abba8b77-9f4b-4ad1-b875-958d94e1fbce.png)

</details>
  
