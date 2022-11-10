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

**Bài tập 3:**  Cài đặt chương trình cho bài toán lập lịch – INTERVAL SCHEDULING.
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Mô tả bài toán:**
  
  Có **n** công việc, công việc *j* bắt đầu tại thời điểm Sj và kết thúc tại Fj. <br>
  Hai công việc là tương hợp nếu thời gian thực hiện chúng không giao nhau. <br>
  Tìm 1 tập cực đại các công việc mà chúng tương hợp với nhau.
  
  - Input:  
    - n = 5,
    - S	: 8		9	  10		11		12
    - F	: 8.5	11	11.5	12.5	13
 
  - Output:  1    1   0   1   0 
  
  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  int n;
  double *s, *f; // start time and finish time
  int *schedule; // ket qua 

  void pos_swap(double &a, double &b) {
    int tmp = a;
    a = b;
    b = tmp;
  }

  void show(int *x, int n) {
    for(int i = 0; i < n; i++) {
      cout << x[i] << "\t";
    }
    cout << endl;
  }

  void show(double *x, int n) {
    for(int i = 0; i < n; i++) {
      cout << x[i] << "\t";
    }
    cout << endl;
  }

  void sort_by_f() {
    for(int i = 0; i < n; i++) {
      for(int j = n-1; j > i; j--) {
        if(f[j] < f[j-1]) {
          pos_swap(s[j], s[j-1]);
          pos_swap(f[j], f[j-1]);
        }
      }	
    }
  }

  void interval_schedule() {
    sort_by_f();

    cout << "\nSap xep tang theo chieu tang cua f\n\n";

    cout << "Start time\t";
    show(s, n);
    cout << "Finish time\t";
    show(f, n);  

    double last_f = 0;

    for(int i = 0; i < n; i++) {
      if(s[i] >= last_f) {
        schedule[i] = 1;
        last_f = f[i];
      }
    }

    cout << "\nKet qua:\t";
    show(schedule, n); 
  }

  int main() {
    cout << "Nhap so cong viec: "; cin >> n;

    s = new double[n];
    f = new double[n];

    cout << "Nhap thoi gian cho cong viec" << endl;
    for(int i = 0; i < n; i++) {
      cout << "Cong viec thu " << i+1 << ":\n";
      cout << "\tthoi gian bat dau: "; cin >> s[i];
      cout << "\tthoi gian ket thuc: "; cin >> f[i];
    }

    schedule = new int[n]{0};

    interval_schedule();

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  <img width="500px" src="https://user-images.githubusercontent.com/65481655/201108146-e4faa713-6c18-4574-b3a7-c215c6bfc5ee.png" />

</details> 
  
**Bài tập 4:** Công ty vận tải A có n chiếc xe tải với các xe có tải trọng khác nhau, 
  xe tải Ti có tải trọng là Ki chở được Ki tấn. Công ty A cần vận chuyển m tấn hàng.
  Hỏi công ty cần sử dụng bao nhiêu chiếc xe tải và gồm những chiếc xe nào? Cho biết tải trọng của xe được chọn sử dụng sao cho số xe tải cần sử dụng là ít nhất?
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Phân tích:**
  
  - Ta cũng làm tương tự như bài toán đổ nước.
  - Chú ý là khi duyệt hết các xe mà vẫn chưa chở đủ m tấn hàng thì sẽ cần chọn thêm 1 xe khác nữa để chở đủ (không cần quan tâm trọng tải).
  
  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  int m;
  int n;
  int *tonnage;

  void show(int *x, int n) {
    for(int i = 0; i < n; i++) {
      cout << "\tXe " << i+1 << ": " << x[i] << "\n";
    }
    cout << endl;
  }

  void sort_desc(int *arr, int n) {
    for(int i = 0; i < n; i++) {
      for(int j = n-1; j > i; j--) {
        if(arr[j] > arr[j-1]) {
          int tmp = arr[j];
          arr[j] = arr[j-1];
          arr[j-1] = tmp;
        }
      }	
    }
  }

  void action() {
    sort_desc(tonnage, n);

    cout << "\nTrong tai cac xe:\n";
    show(tonnage, n);

    int count = 0;

    // cac xe duoc chon
    int *c1 = new int[n];  
    int k = 0;  

    // Xe khong duoc chon
    int u;

    for(int i = 0; i < n; i++) {
      if(m >= tonnage[i]) {
        m -= tonnage[i];
        c1[k++] = i;
        count++;
      }
      else {
        u = i;
      }
    }
  
    if(m > 0 & count == n) {
      cout << "Chon het " << count << " xe cung khong van chuyen du hang\n";
      return;
	  }

    if(m > 0 ) {
      count++;
      c1[k++] = u;
    }

    cout << "Can su dung it nhat " << count << " chiec xe.\n";
    cout << "Bao gom cac xe: ";
    for(int i = 0; i < k; i++) {
      cout << c1[i]+1 << "\t";
    }
    cout << endl;
  }

  int main() {
    cout << "Nhap so tan hang can van chuyen: "; cin >> m;
    cout << "Nhap so xe tai: "; cin >> n;
    cout << "Nhap trong tai cua cac xe:\n";

    tonnage = new int[n];
    for(int i = 0; i < n; i++) {
      cout << "\tTrong tai: ";
      cin >> tonnage[i];
    }

    action();

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  <img width="500px" src="https://user-images.githubusercontent.com/65481655/201110649-9c3a628e-286f-45b6-ab96-af44116670ec.png" />

</details> 
