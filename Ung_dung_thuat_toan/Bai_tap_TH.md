# Mục lục

1. [BÀI THỰC HÀNH SỐ 1: GIẢI THUẬT ĐỆ QUY](#giai_thuat_de_quy)
2. BÀI THỰC HÀNH SỐ 2: GIẢI THUẬT QUAY LUI

## BÀI THỰC HÀNH SỐ 1: GIẢI THUẬT ĐỆ QUY <a name="giai_thuat_de_quy"></a>

**Bài tập 1:** Cài đặt chương trình sinh các chuỗi nhị phân độ dài n.

<details>
  <summary><i>Xem chi tiết</i></summary>
  
  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  int n;
  int x[100];

  void show() {
      for(int i = 0; i < n; i++)
          cout << x[i];
      cout << endl;
  }

  void action(int k) {
      if(k == n) {
          show();	
      }
      else {
          for(int i = 0; i <= 1; i++) {
              x[k] = i;
              action(k+1);
          }	
      }
  }

  int main() {
      cout << "Nhap n = "; cin >> n;

      action(0);

      return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200872735-36cf4c41-ca23-4e7b-8e76-a2656fcba2fa.png)

</details>
  
**Bài tập 2:** Cài đặt chương trình sinh các chuỗi ký tự độ dài n chỉ chứa 2 ký tự ‘a’ và ký tự ‘b’.
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  
  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  int length = 2;
  char data[] = {'a','b'};

  int n;
  char x[100];

  void show() {
    for(int i = 0; i < n; i++) 
      cout << x[i];
    cout << endl;
  }

  void action(int k) {
    if(k == n) {
      show();
    }
    else {
      for(int i = 0; i < length; i++) {
        x[k] = data[i];
        action(k+1);
      }	
    }
  } 


  int main() {
    cout << "Nhap n = "; cin >> n;

    action(0);

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200874758-e3d29c4c-bbeb-49ea-ac44-973505bfa392.png)

</details>  
