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
  
 **Bài 2:** Cho một danh sách d gồm n xâu ký tự, mỗi xâu ký tự là một câu tiếng anh có chiều dài không quá 100 ký tự, các xâu ký tự đôi một khác nhau. Cài đặt chương trình thực hiện:
- Khởi tạo số n và danh sách d (5 ≤ n ≤ 10).
- Sử dụng chiến lược chia để trị thiết kế thuật toán cho biết xâu có chiều dài nhỏ nhất trong danh sách d, hiển thị xâu đó.
- Sử dụng chiến lược chia để trị để tính tổng chiều dài của tất cả các xâu trong danh sách d.
- Sắp xếp danh sách d bằng thuật toán sắp xếp trộn được thiết kế theo chiến lược chia để trị. Hiển thị danh sách sau khi sắp xếp.
- Nhập một xâu ký tự bất kì st, bằng chiến lược chia để trị hãy thiết kế thuật toán để cho biết xâu st có xuất hiện trong danh sách d hay không, nếu có thì cho biết vị trí của nó.  
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Code:**

  ```c++
  #include<bits/stdc++.h>
  using namespace std;

  int n;
  string *ds;

  void khoiTaoDS() {
    n = 6;
    ds = new string[n] {
    "I have a good day",
    "I will say no",
    "Hello bro",
    "I can fly",
    "I have a crush on you",
    "A cat is smaller than a dog",
    };
  }

  void hienThiDS(string *ds, int n) {
    for(int i = 0; i < n; i++) {
      cout << " " << ds[i] << endl; 
    }
  }

  void timXauNganNhat(int l, int r, int &viTri) {
    if(l == r) {
      viTri = l;
    }
    else {
      int mid = (l + r) / 2;
      int v1 = l, v2 = mid+1;
      timXauNganNhat(l, mid, v1);
      timXauNganNhat(mid+1, r, v2);

      if(ds[v1].size() > ds[v2].size()) {
        viTri = v2;
      }
      else {
        viTri = v1;
      }
    }
  }

  int tongChieuDaiXau(int l, int r) {
    if(l == r) {
      return ds[l].size();
    }
    else {
      int mid = (l + r) / 2;
      return tongChieuDaiXau(l, mid) + tongChieuDaiXau(mid+1, r);
    }
  }

  void tron(int l, int mid, int r) {
    int n1 = mid - l + 1,
      n2 = r - mid;

    string *a1 = new string[n1],
      *a2 = new string[n2];

    for(int i = 0; i < n1; i++) 
      a1[i] = ds[l+i];
    for(int i = 0; i < n2; i++) 
      a2[i] = ds[mid+i+1];

    int i = 0, j = 0, k = l;
    while(i < n1 && j < n2)
      ds[k++] = a1[i].compare(a2[j]) <= 0 ? a1[i++] : a2[j++];
    while(i < n1)
      ds[k++] = a1[i++];
    while(j < n2)
      ds[k++] = a2[j++];	
  }

  void sapXepTronTang(int l, int r) {
    if(l < r) {
      int mid = (l + r) / 2;
      sapXepTronTang(l, mid);
      sapXepTronTang(mid+1, r);
      tron(l, mid, r);
    }
  }

  int timXau(int l, int r, string st) {
    if(l > r)
      return -1;

    int mid = (l + r) / 2;

    int x = st.compare(ds[mid]);

    if(x == 0) 
      return mid;
    else if(x < 0) 
      return timXau(l, mid-1, st);
    else 
      return timXau(mid+1, r, st);
  }

  int main() {
    khoiTaoDS();

    cout << "Danh sach:\n";
    hienThiDS(ds, n);

    // vi tri xau ngan nhat
    int viTri = 0;
    timXauNganNhat(0, n-1, viTri);
    cout << "\nXau ngan nhat la: " << ds[viTri] << endl;

    cout << "Tong chieu dai cac xau trong ds: " << tongChieuDaiXau(0, n-1) << endl;

    sapXepTronTang(0, n-1);
    cout << "\nDanh sach sau khi sap xep tron tang dan:\n";
    hienThiDS(ds, n);

    string st = "Hello bro";
    cout << "\nCho xau: " << st << endl;
    int v = timXau(0, n-1, st);
    if(v == -1) {
      cout << "Khong tim thay xau trong ds" << endl;
    }
    else {
      cout << "Tim thay xau o vi tri thu " << v+1 << endl;
    }

    return 0;
  }
  ```

  **Kết quả chạy:**

  <image width="500px" src="https://user-images.githubusercontent.com/65481655/208052470-83f1b518-e395-4cd6-9ead-4fcc26b09190.png">

</details>
