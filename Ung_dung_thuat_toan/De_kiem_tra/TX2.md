# TX2

## Đề 01

Cho danh sách d gồm n màn hình máy tính của n hãng sản xuất khác nhau, thông tin về mỗi chiếc màn hình máy tính gồm: tên hãng sản xuất, kích thước màn hình (inch), khối lượng (kg). Một chiếc xe có trọng tải m. Cài đặt chương trình thực hiện:

1. 
- Khởi tạo n (7 <= n) và danh sách d (dữ liệu của danh sách d có tính thực tiễn). Tìm màn hình có kích thước lớn nhất theo phương pháp chia để trị. Hiển thị đầy đủ thông tin của màn hình tìm được và vị trí của nó trong danh sách d.

2.
- Khởi tạo m (12 <= m <= 20). Sử dụng chiến lược quy hoạch động để cho biết cần xếp những màn hình nào lên xe tài sao cho tổng kích thước các màn hình xếp được là lớn nhất và không vượt quá tải trọng của xe. Hiển thị bảng phương án và thông tin về các màn hình được xếp lên xe tải, mỗi màn hình hiển thị đầy đủ thông tin của nó.

<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Phân tích:**
  
  - Chưa thực hiện được yêu cầu hiển thị bảng phương án

  **Code:**

  ```c++
  #include<bits/stdc++.h>
  using namespace std;

  class ManHinh {
    public:
      string hangSX;
      int kichThuoc;
      int khoiLuong;

      ManHinh() {
      }

      ManHinh(string hangSX, int kichThuoc, int khoiLuong) {
        this->hangSX = hangSX;
        this->kichThuoc = kichThuoc;
        this->khoiLuong = khoiLuong;
      }

      int soSanhKichThuoc(ManHinh a) {
        if(this->kichThuoc < a.kichThuoc) {
          return -1;
        }
        else if(this->kichThuoc > a.kichThuoc) {
          return 1;
        }
        else {
          return 0;
        }
      }

      void hienThi() {
        cout << setw(20) << this->hangSX  
          << setw(20) << this->kichThuoc 
          << setw(20) << this->khoiLuong << endl; 
      }
  };

  int n;
  ManHinh *ds;

  int m;

  // Cau 1
  void khoiTaoDS() {
    n = 7;
    ds = new ManHinh[n];
    ds[0] = ManHinh("DELL", 14, 3);
    ds[1] = ManHinh("LG", 15, 4);
    ds[2] = ManHinh("ASUS", 32, 5);
    ds[3] = ManHinh("SAMSUNG", 24, 4);
    ds[4] = ManHinh("HP", 27, 5);
    ds[5] = ManHinh("Lenovo", 24, 5);
    ds[6] = ManHinh("Acer", 17, 4);
  }

  void hienThiTieuDe() {
    cout << setw(20) << "HANG SX" << setw(20) << "KICH THUOC" 
      << setw(20) << "KHOI LUONG" << endl; 
  }
  void hienThiDSMaHinh() {
    for(int i = 0; i < n; i++) {
      ds[i].hienThi();
    }
    cout << endl;
  }

  // Tim man hinh co kich thuoc lon nhat
  void timKichThuocMax(int left, int right, ManHinh &max, int &viTri) {
    ManHinh max1, max2;

    if(left == right) {
      max = ds[left];
      viTri = left;
    }
    else {
      int mid = (left + right) / 2;
      max1 = ds[mid];
      max2 = ds[right];

      int v1, v2;

      timKichThuocMax(left, mid, max1, v1);
      timKichThuocMax(mid+1, right, max2, v2);

      if(max1.soSanhKichThuoc(max2) > 0) {
        max = max1;
        viTri = v1;
      }
      else {
        max = max2;
        viTri = v2;
      }
    }
  }

  // Cau 2
  int kq[100][21];

  int xepManHinh(int n, int m) {
    for(int i = 1; i <= n; i++) {
      for(int w = 1; w <= m; w++) {
        if(ds[i-1].khoiLuong <= w) {
          int a = kq[i-1][w - ds[i-1].khoiLuong] + ds[i-1].kichThuoc;
          int b = kq[i-1][w];

          kq[i][w] = a > b ? a : b;
        }
        else {
          kq[i][w] = kq[i-1][w];
        }
      } 
    }

    return kq[n][m];
  }

  void truyVetManHinh() {
    int i = n, j = m;

    while(i != 0) {
      if(kq[i][j] != kq[i-1][j]) {
        ds[i-1].hienThi();
        j -= ds[i-1].khoiLuong;	
      }
      i--;
    }
  }

  int main() {
    // Cau 1
    khoiTaoDS();

    cout << "Danh sach man hinh:\n";
    hienThiTieuDe();
    hienThiDSMaHinh();

    ManHinh max = ds[n-1];
    int viTri = n-1; 
    timKichThuocMax(0, n-1, max, viTri);
    cout << "Man hinh co kich thuoc lon nhat la: \n";
    cout << " Hang SX: " << max.hangSX 
          << "\n Kich thuoc man hinh: " << max.kichThuoc
          << "\n Khoi luong: " << max.khoiLuong << endl;
    cout << " => Vi tri thu " << viTri+1 << " trong ds. \n";

    // Cau 2
    m = 15; 
    cout << "\nTai trong m cua xe: " << m << endl;

    int kichThuocMax = xepManHinh(n, m);
    cout << "Kich thuoc man hinh xep duoc lon nhat la: " << kichThuocMax << endl;
    cout << "Thong tin cac man hinh duoc xep len xe:\n";
    hienThiTieuDe();
    truyVetManHinh();

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  <img width="500px" src="https://user-images.githubusercontent.com/65481655/208630558-c29d8a7e-b0a0-4aa6-b757-e04b2cf71632.png">

</details>

## Đề 02

Cho danh sách n gồm n cuốn giáo trình khác nhau, thông tin về mỗi cuốn giáo trình gồm: tên giáo trình, họ và tên tác giả, giá bìa. Cài đặt chương trình thực hiện.

1. 
- Khởi tạo n (7 <= n) và danh sách d (dữ liệu của danh sách d có tính thực tiễn). Tính tổng giá bán của các cuốn giáo trình có giá bìa dưới 100000 bằng phương pháp chia để trị. Hiển thị đầy đủ thông tin của những cuốn giáo trình này và tổng giá bán của chúng (nếu có).

2.
- Gọi t là tên của một người (không chứa họ đệm). Khởi tạo t. Hãy cho biết có bao nhiêu giáo trình của tác giả có tên t. Hiển thị thông tin đầy đủ của những cuốn giáo trình của tác giả có tên t.

<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Code:**

  ```c++
  #include<bits/stdc++.h>
  using namespace std;

  class GiaoTrinh {
    public:
      string tenGT;
      string tacGia;
      int giaBia;

      GiaoTrinh(){
      }

      GiaoTrinh(string tenGT, string tacGia, int giaBia) {
        this->tenGT = tenGT;
        this->tacGia = tacGia;
        this->giaBia = giaBia;
      }

      void hienThi() {
        cout << setw(30) << this->tenGT 
          << setw(30) << this->tacGia
          << setw(20) << this->giaBia << endl;
      }

      bool kiemTraTenTG(string ten) {
        int n = this->tacGia.size();
        int m = ten.size();

        string tacGia = this->tacGia;

        int i = n - 1;
        while(m > 0) {
          if(tolower(tacGia[i]) != tolower(ten[m-1])) {
            return false;
          }
          i--;
          m--;
        }

        if(tacGia[i] == ' ') {
          return true;
        }
        else {
          return false;
        }
      }
  };

  void tieuDe() {
    cout << setw(30) << "TEN GIAO TRINH"
      << setw(30) << "TAC GIA"
      << setw(20) << "GIA BAN" << endl;
  }

  int n = 8;
  GiaoTrinh *ds;

  void hienThiDS(GiaoTrinh *ds, int n) {
    for(int i = 0; i < n; i++) {
      ds[i].hienThi();
    }
    cout << endl;
  } 

  void khoiTaoDS() {
    ds = new GiaoTrinh[n];
    ds[0] = GiaoTrinh("Lap trinh huong doi tuong", "Vu Thi Duong", 138000);
    ds[1] = GiaoTrinh("Kiem thu phan mem", "Hoang Quang Huy", 30000);
    ds[2] = GiaoTrinh("Lap trinh Java", "Ha Manh Dao", 130000);
    ds[3] = GiaoTrinh("Lap trinh di dong", "Nguyen Thai Cuong", 45000);
    ds[4] = GiaoTrinh("Co so du lieu", "Nguyen Thi Huong Lan", 32000);
    ds[5] = GiaoTrinh("Lap trinh Game", "Vu Minh Yen", 129000);
    ds[6] = GiaoTrinh("Cong cu phan mem", "Ha Manh DAO", 100000);
    ds[7] = GiaoTrinh("Mang may tinh", "Pham Van Hiep", 30000);
  }

  GiaoTrinh dsDuocChon[7];
  int dem = 0;

  // tong gia cua cac cuon co gia bia < 100000
  int tongGiaBan(int l, int r) {
    if(l == r) {
      if(ds[l].giaBia < 100000) {
        dsDuocChon[dem++] = ds[l];
        return ds[l].giaBia;
      }
      else {
        return 0;
      }
    }
    else {
      int mid = (l + r) / 2;
      return tongGiaBan(l, mid) + tongGiaBan(mid+1, r);
    }
  }

  void hienThiTenTacGia(string ten) {
    GiaoTrinh dsCungTen[7];
    int dem1 = 0;
    for(int i = 0; i < n; i++) {
      if(ds[i].kiemTraTenTG(ten)) {
        dsCungTen[dem1++] = ds[i];
      }
    }
    if(dem1 > 0) {
      cout << "So luong giao trinh co tac gia ten t la: " << dem1 << endl;
      cout << "Thong tin cac cuon giao trinh do la:\n";
      tieuDe();
      hienThiDS(dsCungTen, dem1);
    }
    else {
      cout << "Khong co giao trinh nao co tac gia ten t\n";
    }
  }

  int main() {
    khoiTaoDS();

    cout << "Danh sach giao trinh\n";
    tieuDe();
    hienThiDS(ds, n);

    // Cau 1
    int tong = tongGiaBan(0, n-1);
    if(dem > 0) {
      cout << "Cac cuon giao trinh co gia bia duoi 100000:\n";
      hienThiDS(dsDuocChon, dem);
      cout << "=> Tong gia ban cua chung la: " << tong << endl;
    }
    else {
      cout << "Khong co cuon giao trinh co gia bia duoi 100000\n";
    }

    // Cau 2
    string t = "Dao";
    cout << "\nt = " << t << endl;
    hienThiTenTacGia(t);

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  <img width="500px" src="https://user-images.githubusercontent.com/65481655/208681494-3e305c70-24fb-45d6-9615-25391e3b253c.png">

</details>
