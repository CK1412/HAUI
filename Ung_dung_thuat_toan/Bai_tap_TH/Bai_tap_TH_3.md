# BÀI THỰC HÀNH SỐ 3: CHIẾN LƯỢC THAM LAM

**Bài tập 1:** Cài đặt chương trình cho bài toán đổi tiền – COIN CHANGING.
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Mô tả bài toán:**
  
  Cho 5 loại tiền mệnh giá: 100, 25, 10, 5 và 1 đồng với số lượng tờ tiền mỗi loại không hạn chế. <br>
  Cho trước một số tiền **m**. <br>
  Hỏi cần lấy ít nhất bao nhiêu tờ tiền trong 5 loại mệnh giá trên để được số tiền m.
  
  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  int n = 5;
  long a[5] = {100, 25, 10, 5, 1};

  void coin_changing(long m) {
    int count = 0;
    long p = 0;

    int i = 0;

    // tai moi buoc lap, lay cac dong tien co menh gia lon nhat
    // voi so luong nhieu nhat.
    while(m != 0 && i < 5) {
      if(m >= a[i]) {
        m -= a[i];
        count++;
      }
      else {
        i++;
      }
    }

    cout << "\nCan it nhat " << count << " to tien de duoc so tien m.\n";	
  }

  int main() {	
    cout << "Co 5 loai tien menh gia: 100, 25, 10, 5 va 1.\n";
    cout << "Khong gioi han so to tien moi loai.\n";

    long m;
    cout << "\nNhap so tien m can lay: ";
    cin >> m;

    coin_changing(m);

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/201104863-79f2fdce-13e6-4593-aba3-6821cff8ac8d.png)

</details> 
  
**Bài tập 2:** Cài đặt chương trình cho bài toán đổ nước.
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Mô tả bài toán:**
  
  Một bình nước chứa đầy nước với 1 lượng nước là **n**. <br>
  Cho **m** chiếc chai rỗng (dung tích khác nhau) để chiết nước từ bình vào đầy chai. <br>
  Hỏi số lượng chai tối đa có thể được đổ đầy nước là bao nhiêu?
  
  **Quy ước:**
  - n : lượng nước trong bình.
  - arr[m]: mảng dung tích nước của m chai.
  
  **Hướng giải quyết:**
  
  - Sắp xếp các chai theo dung tích tăng dần
  - Duyệt lần lượt từ chai dung tích nhỏ, lượng nước lớn hơn hoặc bằng dung tích chai thì đổ nước vào chai đó <br> 
    và tăng số chai đã được đổ lên 1, đồng thời giảm lượng nước tương ứng với dung tích chai. 
  
  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  // sap xep tang dan
  void sort(int *arr, int m) {
    for(int i = 0; i < m; i++) {
      for(int j = m-1; j > i; j--) {
        if(arr[j] < arr[j-1]) {
          int tmp = arr[j];
          arr[j] = arr[j-1];
          arr[j-1] = tmp;
        }
      }	
    }
  }

  void pour_water(int n, int *arr, int m) {
    sort(arr, m);

    int count = 0;

    for(int i = 0; i < m; i++) {
      if(n >= arr[i]) {
        n -= arr[i];
        count++;
      } 
    }	

    cout << "So luong chai toi da co the duoc do day nuoc la " << count << endl;	
  }

  int main() {
    int n;
    cout << "Nhap dung tich nuoc trong binh: "; cin >> n;

    int m;
    cout << "Nhap so chai: "; cin >> m;

    int *arr = new int[m];
    cout << "Nhap dung tich cac chai: \n";
    for(int i = 0; i < m; i++) {
      cout << "Chai thu " << i+1 << ": ";
      cin >> arr[i];
    }

    pour_water(n, arr,m); 

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/201105898-eb9e0dc4-37ef-4bf8-b89e-afcff6c56c05.png)

</details> 
