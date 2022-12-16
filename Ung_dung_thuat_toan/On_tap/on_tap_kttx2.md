# ÔN TẬP KTTX2

**Bài 1:** Cho một danh sách d gồm n chiếc điện thoại, thông tin về mỗi điện thoại gồm nhãn hiệu, kích thước màn hình (inch) và giá bán. Viết chương trình thực hiện:
- Khởi tạo n và danh sách d (5 ≤ n ≤ 10).
- Cho một chiếc túi có kích thước s (inch). Bằng một thuật toán được thiết kế theo chiến lược quy hoạch động hãy cho biết có thể lấy được bao nhiêu chiếc điện thoại bỏ vào túi để được tổng giá bán lớn nhất mà không vượt quá kích thước của túi, cho biết những chiếc điện thoại đã lấy (mỗi điện thoại hiển thị nhãn hiệu, giá bán).
- Bằng chiến lược chia để trị hãy cho biết có bao nhiêu chiếc điện thoại trong danh sách d có giá bán trong tầm giá từ 3 triệu đến 6 triệu.

<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Code:**

  ```c++
  #include<bits/stdc++.h>
  using namespace std;

  class DienThoai {
    public:
      string nhanHieu;
      int kichThuoc;
      int giaBan;

      DienThoai(){
      }

      DienThoai(string a, int b, int c) {
        this->nhanHieu = a;
        this->kichThuoc = b;
        this->giaBan = c;
      }

      void hienThi() {
        cout << setw(20) << this->nhanHieu
          << setw(20) << this->kichThuoc 
          << setw(20) << this->giaBan << endl;
      }
  };

  void tieuDe() {
    cout << setw(20) << "NHAN HIEU"
      << setw(20) << "kICH THUOC"
      << setw(20) << "GIA BAN" << endl;
  }

  void hienThiDS(DienThoai *ds, int n) {
    for(int i = 0; i < n; i++) {
      ds[i].hienThi();
    }
    cout << endl;
  }

  int n;
  DienThoai *ds;

  void khoiTaoDS() {
    n = 6;
    ds = new DienThoai[n]; 

    ds[0] = DienThoai("Samsung", 6, 22000000);
    ds[1] = DienThoai("Xiaomi", 5, 5000000);
    ds[2] = DienThoai("Oppo", 7, 8000000);
    ds[3] = DienThoai("Apple", 4, 10000000);
    ds[4] = DienThoai("Huawei", 6, 4000000);
    ds[5] = DienThoai("LG", 5, 7500000);
  }

  int kq[100][100];

  int layDienThoai(int n, int s) {
    for(int i = 1; i <= n; i++) {
      for(int j = 1; j <= s; j++) {
        if(ds[i-1].kichThuoc <= j) {
          int a = kq[i-1][j - ds[i-1].kichThuoc] + ds[i-1].giaBan;
          int b = kq[i-1][j];	

          kq[i][j] = a > b ? a : b;
        }
        else {
          kq[i][j] = kq[i-1][j];	
        }
      }
    }

    return kq[n][s];
  }

  DienThoai *dsDaLay;

  int truyVetDienThoai(int n, int s) {
    int i = n, j = s;
    dsDaLay = new DienThoai[n];
    int dem = 0;

    while(i != 0) {
      if(kq[i][j] != kq[i-1][j]) {
        dsDaLay[dem++] = ds[i-1];
        j -= ds[i-1].kichThuoc;
      }
      i--;
    }

    return dem;

  }

  int demDT(int l, int r) {
    if(l == r) {
      int gia = ds[l].giaBan;
      if(gia >= 3000000 && gia <= 6000000) {
        return 1;
      }
      else {
        return 0;
      }
    }
    else {
      int mid = (l + r) / 2;

      return demDT(l, mid) + demDT(mid+1, r);
    }
  }

  int main() {
    khoiTaoDS();
    cout << "Danh sach:\n";
    tieuDe();
    hienThiDS(ds, n);

    int s = 10;
    cout << "Tui co kich thuoc " << s << " inches\n";
    int tongGia = layDienThoai(n, s);
    int sl = truyVetDienThoai(n, s);
    if(sl > 0) {
      cout << "Ta lay duoc " << sl 
        << " dien thoai de tong gia ban lon nhat la " 
        << tongGia << endl;
      cout << "Danh sach da lay gom: \n";
      tieuDe();
      hienThiDS(dsDaLay, sl);
    }
    else {
      cout << "Khong lay duoc chiec nao" << endl;
    }

    cout << "So luong dt co gia tu 3 -> 6 trieu trong danh sach la: " << demDT(0, n-1) << endl;
    return 0;
  }  
  ```

  **Kết quả chạy:**
  
  <image width="500px" src="https://user-images.githubusercontent.com/65481655/208025890-ae076aba-2bc9-4898-ba6a-e7d18e7143e6.png">

</details>
  
