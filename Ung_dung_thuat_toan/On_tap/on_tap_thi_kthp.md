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
  
**Bài 1:** Cho danh sách d gồm n sản phẩm mỗi sản phẩm gồm mã sản phẩm, tên sản phẩm, khối lượng (là số nguyên dương), giá trị (là số nguyên dương).
Cài đặt chương trình gồm:

  1. Khởi tạo danh sách d gồm 7 đến 10 sản phẩm sao cho tên sản phẩm theo thứ tự từ điển.

  2. Khởi tạo một sản phẩm mới, sử dụng chiến lược chia để trị: cho biết có thể chèn sản phẩm mới vào vị trí nào trong danh sách d để trật tự danh sách d theo tên sản phẩm không bị thay đổi.

  3. Hai sản phẩm được gọi là giống nhau nếu tên của chúng có 10 ký tự giống nhau trở lên (xâu con chung dài nhất). Cho biết sản phẩm mã SP0088 giống sản những phẩm nào trong danh sách.

  4. Sử dụng thuật toán xử lý xâu ký tự: Thông qua tên của sản phẩm, hãy cho biết trong danh sách d có sản phẩm nào là tivi hay không (trong tên sản phẩm có từ ti vi).

<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Code:**

  ```c++
  #include<bits/stdc++.h>
  using namespace std;

  class SanPham {
    public:
      string maSP;
      string tenSP;
      int khoiLuong;
      int giaTri;

      SanPham(){
      };

      SanPham(string a, string b, int c, int d) {
        this->maSP = a;
        this->tenSP = b;
        this->khoiLuong = c;
        this->giaTri = d;
      }

      void hien_thi() {
        cout << setw(20) << this->maSP 
          << setw(20) << this->tenSP
          << setw(20) << this->khoiLuong 
          << setw(20) << this->giaTri << endl;
      }

      // 3
      bool sp_giong_nhau(SanPham sp) {
        int a = this->tenSP.size();
        int b = sp.tenSP.size();

        int dp[a+1][b+1];

        int start = 0, length = 0;	

        for(int i = 0; i <= a; i++) {
          for(int j = 0; j <= b; j++) {
            dp[i][j] = 0;
          }
        }

        for(int i = 1; i <= a; i++) {
          for(int j = 1; j <= b; j++) {
            if(this->tenSP[i-1] == sp.tenSP[j-1]) {
              dp[i][j] = dp[i-1][j-1] + 1;

              if(dp[i][j] > length) {
                length = dp[i][j];
                start = i - length;
              }
            }		
          }
        }

        return length >= 10 ? true : false;
      }

      // 4
      int char_in_string(char c, string s) {
        for(int i = 0; i < s.size(); i++) {
          if(s[i] == c) {
            return i;
          }
        }
        return -1;
      }

      bool boyer_moore_horspool(string p) {
        int count = 0,
          i = p.size(),
          v = p.size();

        while(i <= this->tenSP.size()) {
          int j = i-1,
            x = v-1;

          while(p[x] == this->tenSP[j] && x > -1) {
            x--;
            j--;
          }

          if(x < 0) {
            count++;
            i += v;
          }
          else {
            int k = char_in_string(this->tenSP[j], p);
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
  };

  void tieu_de() {
    cout << setw(20) << "MA SP" 
      << setw(20) << "TEN SP"
      << setw(20) << "KHOI LUONG" 
      << setw(20) << "GIA TRI" << endl;
  }

  // 1
  int n = 7;
  SanPham *ds;

  void khoi_tao_DS() {
    ds = new SanPham[n+1];
    ds[0] = SanPham("SP01", "ban lam viec", 20, 100);
    ds[1] = SanPham("SP02", "choi lau nha", 10, 10);
    ds[2] = SanPham("SP03", "dien thoai", 7, 30);
    ds[3] = SanPham("SP04", "dieu hoa", 26, 42);
    ds[4] = SanPham("SP05", "may tinh", 8, 60);
    ds[5] = SanPham("SP06", "ti vi", 2, 120);
    ds[6] = SanPham("SP07", "tu lanh", 15, 1);
  }

  void hien_thi_DS(SanPham *ds, int n) {
    for(int i = 0; i < n; i++) {
      ds[i].hien_thi();
    }
    cout << endl;
  }

  // 2
  int tim_vi_tri_sp(SanPham sp, int l, int r) {
    if(l > r) {
      return l;
    }	

    int mid = (l + r) / 2;
    if(sp.tenSP.compare(ds[mid].tenSP) > 0) {
      return tim_vi_tri_sp(sp, mid+1, r);
    }
    else if(sp.tenSP.compare(ds[mid].tenSP) < 0) {
      return tim_vi_tri_sp(sp, l, mid-1);
    }
    else {
      return mid;
    }
  } 

  void chen_san_pham(SanPham sp, int l, int r) {
    int vi_tri = tim_vi_tri_sp(sp, 0, n-1);

    for(int j = n; j > vi_tri; j--) {
      ds[j] = ds[j-1];
    }

    ds[vi_tri] = sp;
    n++;
  }

  // 3
  void tim_sp_giong() {
    SanPham sp2 = SanPham("SP0088", "choi lau nha da nang", 20, 12);
    cout << "San pham ma SP0088:\n";
    sp2.hien_thi();
    int count = 0;
    for(int i = 0; i < n; i++) {
      if(sp2.sp_giong_nhau(ds[i])) {
        count++;
        cout << "San pham SP0088 giong voi san pham:\n";
        ds[i].hien_thi();
      }
    }
    if(count == 0) {
      cout << "San pham SP0088 KHONG giong voi san pham nao trong ds.\n";
    }
  }

  void tim_sp_ten_ti_vi() {
    int count = 0;
    for(int i = 0; i < n; i++) {
      if(ds[i].boyer_moore_horspool("ti vi") > 0) {
        count++;
        cout << "\nSan pham ten ti vi trong ds:\n";
        ds[i].hien_thi();
      }
    }

    if(count == 0) {
      cout << "\nTrong danh sach khong co sp ten ti vi.\n";
    }
  }

  int main() {
    khoi_tao_DS();
    cout << "Danh sach san pham theo thu tu tu dien:\n";
    tieu_de();
    hien_thi_DS(ds, n);

    SanPham sp = SanPham("SP08", "may giat", 20, 12);
    cout << "Khoi tao san pham:\n";
    sp.hien_thi();
    cout << "Danh sach sau khi chen sp:\n";
    chen_san_pham(sp, 0, n-1);
    tieu_de();
    hien_thi_DS(ds, n);

    tim_sp_giong();

    tim_sp_ten_ti_vi();

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  <img width="600px" src="https://user-images.githubusercontent.com/65481655/209468380-21d3e8eb-4cfd-4bc5-826e-7ba12ec695a7.png">

</details>
  
