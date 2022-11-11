# TX1

## Đề 01

Cho danh sách n hàng hoá, thông tin hàng hoá gồm: mã hàng, giá bán.

1. 
- Khởi tạo 1 danh sách h gồm 6 đến 10 hàng hoá (không nhập từ bàn phím, 6 <= n <= 10).
- Tính tổng giá bán của tất cả n hàng hoá trong danh sách h bằng phương pháp đệ quy, hiển thị kết quả.

2.
- Khởi tạo 1 số thực dương p (không nhập từ bàn phím). Cho biết cần bán nhiều nhất bao nhiêu hàng hoá trong danh sách h, gồm những hàng hoá nào để được số tiền không vượt quá p (hiển thị mảng, giá bán).
- Hiển thị tất cả các phương án khác nhau để xếp n hàng hoá trong danh sách h vào n kệ hàng được đánh số thứ tự từ 1 đến n bằng phương pháp quay lui (mỗi phương án hiển thị mã hàng và số thự tự kệ hàng).

<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Phân tích:**
  
  

  **Code:**

  ```c++
  #include<bits/stdc++.h>
  using namespace std;

  class HangHoa {
    public:
      int maH;
      int giaBan;

      HangHoa() {
        maH = 0;
        giaBan = 0;
      }

      void nhap(int maH, int giaBan) {
        this->maH = maH;
        this->giaBan = giaBan;
      }

      void hienThi() {
        cout << setw(10) << maH
          << setw(15) << giaBan << endl; 
      }
  };

  int n;
  HangHoa *dshh;

  void hienThiTieuDe() {
    cout << setw(10) << "MA HANG"
      << setw(15) << "GIA BAN" << endl; 
  }

  void khoiTaoDanhSach() {
    int maxN = 10, minN = 6;
    srand(time(0));
    n = minN + rand() % (maxN - minN + 1);

    dshh = new HangHoa[n];

    cout << "Danh sach gom " << n << " hang hoa:\n";
    hienThiTieuDe();

    for(int i = 0; i < n; i++) {
      int gia = 1 + rand();
      dshh[i].nhap(i+1, gia);
      dshh[i].hienThi();
    }
  }

  int tongGia(int k) {
    int gia = dshh[k].giaBan;

    if(k == n-1)
      return gia;
    else 
      return gia + tongGia(k+1);
  }

  // can ban nhieu nhat bao nhieu hang hoa trong ds h
  // de duoc so tien khong vuot qua p

  void sapXepGiaTangDan() {
    for(int i = 0; i < n; i++) {
      for(int j = n-1; j > i; j--) {
        if(dshh[j].giaBan < dshh[j-1].giaBan) {
          HangHoa tmp = dshh[j];
          dshh[j] = dshh[j-1];
          dshh[j-1] = tmp;
        }
      }
    }
  }

  void canHangHoaItNhat() {
    float scale = 1 + rand() / (float) RAND_MAX;
    float p = scale * rand();

    cout << "\np = " << p << endl;

    sapXepGiaTangDan();

    int count = 0;
    HangHoa hangCanBan[n];

    for(int i = 0; i < n; i++) {
      if(p >= dshh[i].giaBan) {
        p -= dshh[i].giaBan;
        hangCanBan[count++] = dshh[i];
      }
    }

    if(count == 0) {
      cout << "Khong co gia tri nao thoa man\n";
        return;
    }

    cout << "Can ban nhieu nhat " << count << " hang hoa de so tien khong vuot qua p\n";
    cout << "Bao gom cac hang hoa sau:\n";
    hienThiTieuDe();
    for(int i = 0; i < count; i++) {
      hangCanBan[i].hienThi();
    }
  }

  // Hien thi tat cac cac phuong an khac nhau de xep n hang hoa trong danh sach h vao n ke hang 
  // duoc danh so thu tu tu 1 den n bang pp quay lui

  int x[100];
  bool check[100] = {false};
  int dem = 0;

  void hienThiSTTKeHang() {
    for(int i = 0; i < n; i++) {
      cout << "\t" << i+1;
    }
    cout << endl << endl;
  }

  void hienThiCachXep() {
    for(int i = 1; i <= n; i++) {
      cout << "\t" << dshh[x[i]-1].maH;
    }
      cout << endl;
      dem++;
  }

  void XepHangVaoKe(int k) {
    for(int i = 1; i <= n; i++) {
      if(!check[i]) {
        x[k] = i;
        check[i] = true;

        if(k == n)
          hienThiCachXep();
        else 
          XepHangVaoKe(k+1);

        check[i] = false;
      }
    }
  }

  int main() {
    khoiTaoDanhSach();

    cout << "\n--> Nhan enter de tiep tuc!\n"; getchar();
    cout << "\nTong gia ban cua tat ca n hang hoa trong danh sach: " << tongGia(0) << endl;

    cout << "\n--> Nhan enter de tiep tuc!\n"; getchar();
    canHangHoaItNhat();

    cout << "\n--> Nhan enter de tiep tuc!\n"; getchar();
    cout << "\nCac phuong an khac nhau de xep n hang hoa vao ke hang.\n";
    cout << "Dong dau tien la STT ke hang, cac dong tiep theo la cac ma hang.\n"; 
    hienThiSTTKeHang();
    XepHangVaoKe(1);
    cout << "\nTong so cach: " << dem << endl;
    // Cac phuong an se hien thi rat nhieu neu n lon
    return 0;
  }
  ```

  **Kết quả chạy:**
  
  | | |
  | -- | -- |
  | Ý 1 <br> ![image](https://user-images.githubusercontent.com/65481655/201361254-9d7fa353-1010-471e-acb1-18f3fcf2c74a.png) | Ý 2 <br> ![image](https://user-images.githubusercontent.com/65481655/201361300-7b9e8b00-cd01-4749-98e0-40e780f4abd4.png) |
  | Ý 3 <br> ![image](https://user-images.githubusercontent.com/65481655/201361364-afe561ba-57dd-4233-8b29-1f4229a6740b.png) | Ý 4 <br> ![image](https://user-images.githubusercontent.com/65481655/201361451-d6e0a6fc-c869-475b-ad00-453c11c74c73.png) <br> ![image](https://user-images.githubusercontent.com/65481655/201361516-2afff059-ac99-4c5b-932f-d27e27786bf3.png) |

</details>

## Đề 02

Cho n công việc c, mỗi công việc gồm mã công việc, thời gian bắt đầu và thời gian kết thúc.

1. 
- Tạo danh sách c gồm 6 đến 10 công việc (không nhập từ bàn phím, 6 <= n <= 10).
- Tính tổng thời gian thực hiện tất cả công việc trong danh sách c bằng đệ quy.

2.
- Một người thực hiện được nhiều nhất bao nhiêu công việc trong danh sách c? gồm những công việc nào (Hiển thị mã công việc, thời gian bắt đầu và thời gian kết thúc).
- Hiển thị tất cả các phương án lấy ra 5 công việc từ danh sách c (chỉ hiển thị mã công việc).

<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Phân tích:**
  
  - Còn ý 2.1 chưa làm được cho chưa hiểu yêu cầu.

  **Code:**

  ```c++
  #include<bits/stdc++.h>
  #include<Windows.h>
  using namespace std;

  #define maxN 10
  #define minN 6

  class Job {
    public:
      int maCV;
      int startTime;
      int finishTime;

      Job() {	
        this->maCV = 0,
        this->startTime = 0;
        this->finishTime = 0; 
      }

      void input(int maCV, int startTime, int finishTime) {
        this->maCV = maCV,
        this->startTime = startTime;
        this->finishTime = finishTime; 
      }

      void show() {
        cout << "\t" << setw(10) << left << this->maCV 
          << setw(15) << left << this->startTime
          << setw(10) << left << this->finishTime << endl;
      }
  };

  int n;
  Job *jobList;

  // Tu dong tao danh sach cong viec
  void autoCreateJobList();

  void showTitle();

  // Tinh tong thoi gian thuc hien tat ca cong viec trong ds
  int sumExecTime(int k);

  // Cac cach lay ra 5 cong viec tu ds
  int k = 5;
  int x[100]; // luu tru ma cv
  int countWays = 0;

  void showMaCV();

  void getFiveJobs(int p);

  int main() {
    autoCreateJobList();

    cout << "\nTong thoi gian thuc hien tat ca cong viec la: " << sumExecTime(0) << endl;

    Sleep(500);

    cout << "\nCac phuong an lay ra 5 cong viec tu ds c (hien thi ma cong viec):\n";
    getFiveJobs(1);
    cout << "\n===> Tong: " << countWays << " cach.\n";

    return 0;
  }

  void autoCreateJobList() {
    srand(time(0)); 
    n = minN + rand() % (maxN - minN + 1);

    jobList = new Job[n];

    showTitle();

    for(int i = 0; i < n; i++) {
      int random = rand();

      int startTime = 1 + random % 12;

      int finishTime = 1 + random % 24;
      while(finishTime <= startTime) {
        finishTime++;
      }

      jobList[i].input(i+1, startTime, finishTime);
      jobList[i].show();
    }
  }

  void showTitle() {
    cout << "\t" << setw(10) << left << "Ma CV"
      << setw(15) << left << "Start time"
      << setw(10) << left << "Finish time" << endl;
  }

  int sumExecTime(int k) {
    int execTime = jobList[k].finishTime - jobList[k].startTime;

    if(k == n-1)
      return execTime;
    else 
      return execTime + sumExecTime(k+1);
  }

  void showMaCV() {
    for(int i = 1; i <= k; i++) {
        cout << "\t" << jobList[x[i]-1].maCV;
    }
      cout << endl;

      countWays++;
  }

  void getFiveJobs(int p) {
    for(int i = x[p-1]+1; i <= n-k+p; i++) {
      x[p] = i;

      if(p == k)
        showMaCV();
      else
        getFiveJobs(p+1);
    }	
  }
  ```

  **Kết quả chạy:**
  
  |||
  |--|--|
  | ![image](https://user-images.githubusercontent.com/65481655/201362504-57830a4f-ba5a-45e6-a2bf-e57fd312e56a.png) | ![image](https://user-images.githubusercontent.com/65481655/201362547-8ea07645-31d2-439f-85f8-06cad2e045ee.png) |

</details>
