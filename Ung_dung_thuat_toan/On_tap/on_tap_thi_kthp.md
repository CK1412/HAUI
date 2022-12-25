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
  
**Bài 2:** Cho danh sách d có n lớp học phần, mỗi lớp học gồm các thông tin: mã lớp, số học sinh, số học sinh nữ. Cho một số nguyên dương n và một phòng học p gồm k chỗ ngồi. Viết chương trình thực hiện:

  1. Khởi tạo danh sách d gồm 7 đến 10 lớp học phần (ko nhập từ bàn phím), sao cho danh sách được sắp xếp theo chiều giảm dần của số học sinh.

  2. Sử dụng chiến lược tham lam: Cho biết cần lấy từ ít nhất bao nhiêu lớp trong danh sách d để được số học sinh lớn hơn n.

  3. Sử dụng quy hoạch động: Cần ghép những lớp nào vào phòng học p để được tổng số học viên không vượt quá k mà tổng số học sinh nữ đạt được nhiều nhất.

  4. Sử dụng thuật toán xử lý xâu ký tự để xác định một xâu s có phải là xâu con của một xâu st hay không. Hiển thị thông tin các lớp học phần thuộc ngành công nghệ thông tin (mã lớp có chứa “it”)

<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Code:**

  ```c++
  #include<bits/stdc++.h>
  using namespace std;

  class LopHocPhan {
    public:
      string maLop;
      int soHS;
      int soHSNu;

      LopHocPhan(){
      }

      LopHocPhan(string a, int b, int c) {
        maLop = a;
        soHS = b;
        soHSNu = c;
      }

      void hienThi() {
        cout << setw(20) << maLop 
          << setw(20) << soHS
          << setw(20) << soHSNu << endl;
      }
  };

  int n = 8;
  LopHocPhan *ds;

  // 1

  void khoi_tao_DS() {
    ds = new LopHocPhan[n];

    ds[0] =	LopHocPhan("it6020", 73, 12);
    ds[1] =	LopHocPhan("qtlh6021", 71, 2);
    ds[2] =	LopHocPhan("kt6022", 70, 22);
    ds[3] =	LopHocPhan("qtkd6023", 68, 30);
    ds[4] =	LopHocPhan("lh6024", 66, 6);
    ds[5] =	LopHocPhan("it6025", 62, 1);
    ds[6] =	LopHocPhan("cnot6026", 60, 15);
    ds[7] =	LopHocPhan("cdt6027", 54, 10);
  }

  void tieu_de() {
    cout << setw(20) << "MA LOP" 
      << setw(20) << "SO HOC SINH"
      << setw(20) << "SO HOC SINH NU" << endl;
  }

  void hien_thi_DS(LopHocPhan *ds, int n) {
    for(int i = 0; i < n; i++) {
      ds[i].hienThi();
    }
    cout << endl;
  }

  // 2

  int so_lop_it_nhat(int m) {
    int dem = 0;
    int i = 0;

    while(i < n && m > 0) {
      if(m > 0) {
        m -= ds[i].soHS;
        dem++;
      }
      else {
        i++;
      }
    }

    return dem;
  }

  // 3

  int kq[100][1000];

  int chon_lop_vao_phong(int n, int k) {
    for(int i = 1; i <= n; i++) {
      for(int j = 1; j <= k; j++) {
        if(ds[i-1].soHS <= j) {
          int a = kq[i-1][j - ds[i-1].soHS] + ds[i-1].soHSNu;
          int b = kq[i-1][j];
          kq[i][j] = a > b ? a : b;
        }
        else {
          kq[i][j] = kq[i-1][j];
        }
      }
    }

    return kq[n][k];
  }

  void truy_vet_lop_da_chon(int n, int k) {
    int i = n, j = k;

    while(i != 0) {
      if(kq[i][j] != kq[i-1][j]) {
        ds[i-1].hienThi();
        j -= ds[i-1].soHS;
      }
      i--;
    }
  }

  // 4
  int char_in_string(char x, string s) {
    for(int i = 0; i < s.size(); i++) {
      if(s[i] == x) {
        return i;
      }
    }

    return -1;
  }

  int boyer_moore_horspool(string T, string P) {
    int count = 0,
      i = P.size(),
      v = P.size();

    while(i <= T.size()) {
      int j = i-1,
        x = v-1;

      while(P[x] == T[j] && x > -1) {
        x--;
        j--;
      }

      if(x < 0) {
        count++;
        i += v;
      }
      else {
        int k = char_in_string(T[j], P);
        if(k < 0) {
          i += v;
        }
        else {
          i += v - k - 1;
        }
      }
    }

    return count;
  }

  int main() {
    // 1
    khoi_tao_DS();
    cout << "Danh sach lop hoc phan:\n";
    tieu_de();
    hien_thi_DS(ds, n);

    // 2
    int m = 200;
    cout << "m = " << m << endl;
    cout << "So lop it nhat can lay de duoc so hoc sinh lon hon " 
      << m << " la: " << so_lop_it_nhat(m) << endl;

    // 3
    int k = 200;
    cout << "\nk = " << k << endl;
    int max = chon_lop_vao_phong(n, k);
    cout << "Cac lop duoc ghep vao phong sao cho tong so hoc vien"
      << " khong vuot qua k ma tong so hoc sinh nu nhieu nhat la: "
      << max << endl;
    cout << "Cac lop do la:\n";
    tieu_de();
    truy_vet_lop_da_chon(n, k);

    // 4
    cout << "\nCac lop hoc phan thuoc nganh cong nghe thong tin:\n";
    int count = 0;
    for(int i = 0; i < n; i++) {
      if(boyer_moore_horspool(ds[i].maLop, "it") > 0) {
        count++;
        if(count == 1) {
          tieu_de();
        }
        ds[i].hienThi();
      }
    } 
    if(count == 0) {
      cout << "KHONG CO" << endl;
    }

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  <img width="600px" src="https://user-images.githubusercontent.com/65481655/209468272-d3b5d8b3-84c0-4d69-a0a0-888241cfe840.png">

</details>
  
