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
