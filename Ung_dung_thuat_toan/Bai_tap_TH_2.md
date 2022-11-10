# BÀI THỰC HÀNH SỐ 2: ĐỆ QUY – QUAY LUI

> Quay lui (Backtracking) là một kĩ thuật thiết kế giải thuật dựa trên đệ quy. <br>
> Ý tưởng của quay lui là tìm lời giải từng bước, mỗi bước chọn một trong số các lựa chọn khả dĩ và đệ quy.

**Bài tập 1:**  Cài đặt bài toán tìm ước số chung lớn nhất theo thuật toán đệ quy
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Phân tích:**
  
  - Sử dụng giải thuật Euclid

  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  int UCLN(int a, int b) {	
    if(b == 0)
      return a;

    return UCLN(b, a%b); 
  }

  int main() {
    int a, b;
    cout << "a = "; cin >> a;
    cout << "b = "; cin >> b;

    cout << "UCLN(a, b) = " << UCLN(a, b) << endl;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200981809-4183c395-50c2-45b4-9aac-be507ddf94cb.png)

</details>  
  
**Bài tập 2:** Cài đặt bài toán tìm ước số chung lớn nhất theo thuật toán lặp (khử đệ quy)

<details>
  <summary><i>Xem chi tiết</i></summary>
 <br>

  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  int UCLN(int a, int b) {	
    int tmp;

    while(b != 0) {
      tmp = a % b;
      a = b;
      b = tmp;
    }	

    return a;
  }

  int main() {
    int a, b;
    cout << "a = "; cin >> a;
    cout << "b = "; cin >> b;

    cout << "UCLN(a, b) = " << UCLN(a, b) << endl;

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200982023-fbf4dfa8-30db-425b-b6df-7bab792a2edf.png)

</details>  
	
**Bài tập 3:** Cài đặt bài toán tìm số fibonaci theo thuật toán đệ quy
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Phân tích:**
  
  - Dãy fibonacci: 1 1 2 3 5 8 13 ...

  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  long fibonacci(int n) {
    if(n == 1 || n == 2)
      return 1;

    return fibonacci(n-1) + fibonacci(n-2);
  }

  int main() {
    int n;
    cout << "n = "; cin >> n;

    cout << "So fibonacci thu n: " << fibonacci(n) << endl;

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200982321-9d846c30-0457-4e47-9146-b7edf58ffafd.png)

</details>  
  
**Bài tập 4:** Cài đặt bài toán tìm số fibonaci theo thuật toán lặp (khử đệ quy)
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Phân tích:**
 
  - Dãy fibonacci: 1 1 2 3 5 8 13 ...

  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  long fibonacci(int n) {
    if(n == 1 || n == 2)
      return 1;

    int f1 = 1, f2 = 1;
    int f;	

    int i = 3;

    while(i <= n) {
      f = f1 + f2;
      f1 = f2;
      f2 = f;
      i++;
    }

    return f;
  }

  int main() {
    int n;
    cout << "n = "; cin >> n;

    cout << "So fibonacci thu n: " << fibonacci(n) << endl;

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200982575-ddff7ecb-d7db-4eb8-8d34-a7cc08228704.png)

</details>  
  
**Bài tập 5:** Cài đặt bài toán tháp Hà Nội theo thuật toán đệ quy
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Phân tích:**
 
  - Quy ước:
	  - Có 3 cột: A, B, C
	  - Số đĩa: n > 1
	  - Mỗi lần di chuyển 1 đĩa
  - Mục tiêu: 
	  - Di chuyển n đĩa từ tháp A sang C
  - Minh hoạ:
  
  ![tower_of_hanoi](https://user-images.githubusercontent.com/65481655/200983102-e2f9913f-ae63-4cd1-92af-ae6eff6d4be7.gif)

  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  void TowerHN(int n, char a, char b, char c) {
    if(n == 1) {
      cout << "\t" << a << "------->" << c << endl;
      return;
    }

    TowerHN(n-1, a, c, b);
    TowerHN(1, a, b, c);
    TowerHN(n-1, b, a, c);
  }

  int main() {
    int n;
    cout << "Nhap so dia: "; cin >> n;

    cout << "Cac buoc di chuyen dia tu cot A sang C" << endl;
    TowerHN(n, 'A', 'B', 'C');

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200983201-330ac4ff-60ea-4d76-b568-ece4f3cd0c91.png)

</details>  
  
**Bài tập 6:** Cài đặt bài toán tháp Hà Nội theo thuật toán khử đệ quy
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  Khó😁

</details>  
  
**Bài tập 7:** Cài đặt bài toán sinh dãy nhị phân theo phương pháp quay lui
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

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
    for(int i = 0; i <= 1; i++) {
      x[k] = i;

      if(k == n-1) 
        show();
      else
        action(k+1);
    }	
  }

  int main() {
    cout << "Nhap n = "; cin >> n;

    action(0);

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200983731-fc74a411-421d-4747-b07f-e50171dda233.png)

</details>  
  
**Bài tập 8:** Cài đặt bài toán liệt kê hoán vị theo phương pháp quay lui
  
<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>

  **Phân tích:**
 
  - Chỉnh hợp (có thứ tự)

  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  int n;
  bool check[100] = {false};
  int x[100];

  void show() {
    for(int i = 1; i <= n; i++) 
      cout << x[i] << " ";
    cout << endl;
  }

  void action(int k) {
    for(int i = 1; i <= n; i++) {
      if(!check[i]) {
        x[k] = i;
        check[i] = true;

        if(k == n) 
          show();
        else
          action(k+1);

        check[i] = false;
      }
    }
  }

  int main() {
    cout << "n = "; cin >> n;

    cout << "\nSinh cac hoan vi:\n";
    action(1);

    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/200984199-0cbcbb01-8fb0-40a3-bca8-f47a14e4860f.png)

</details>  
