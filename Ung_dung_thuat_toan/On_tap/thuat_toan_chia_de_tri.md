
# GIẢI THUẬT CHIA ĐỂ TRỊ

**Bài 1:** Tìm kiếm nhị phân trên dãy số

<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Code:**

  ```c++
    #include<iostream>
    using namespace std;

    void show(int *x, int n) {
        for(int i = 0; i < n; i++) {
            cout << x[i] << "  ";
        }
        cout << endl;
    }

    void bubbleSort(int *x, int n) {
        for(int i = 0; i < n-1; i++) {
            for(int j = n-1; j > i; j--) {
                if(x[j] < x[j-1]) {
                    int temp = x[j];
                    x[j] = x[j-1];
                    x[j-1] = temp;
                }
            }
        }
    }

    int binarySearch(int k, int*x, int left, int right){
        if(left > right)
            return -1;
        
        int mid = (left + right) / 2;
        
        if(k == x[mid]) {
            return mid;
        }
        else if(k < x[mid]) {
            return binarySearch(k, x, left, mid-1);
        }
        else {
            return binarySearch(k, x, mid+1, right);
        }
    } 

    int main() {
        int x[] = {2, 4, 7, 8, 1, 2, 6, 5, 9};
        int n = sizeof(x) / sizeof(int);
        
        bubbleSort(x, n);
        cout << "Day sau sap xep: ";
        show(x, n);
        int k = 5;
        cout << "\nk = " << k << endl;
        int index = binarySearch(k, x, 0, n-1);
        if(index == -1) {
            cout << "Khong tim thay k";
        }
        else {
            cout << "Tim thay k o vi tri thu " << index+1 << endl;
        }
        
        return 0;
    }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/207901981-49863b8f-6c78-4d83-8fcb-56ab90228316.png)

</details>
  
**Bài 2:** Tìm kiếm nhị phân trên dãy kí tự (giống như trên dãy số)

<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  void show(char *x, int n) {
    for(int i = 0; i < n; i++) {
      cout << x[i] << "  ";
    }
    cout << endl;
  }

  void bubbleSort(char *x, int n) {
    for(int i = 0; i < n-1; i++) {
      for(int j = n-1; j > i; j--) {
        if(x[j] < x[j-1]) {
          char temp = x[j];
          x[j] = x[j-1];
          x[j-1] = temp;
        }
      }
    }
  }

  int binarySearch(char k, char*x, int left, int right){
    if(left > right)
      return -1;

    int mid = (left + right) / 2;

    if(k == x[mid]) {
      return mid;
    }
    else if(k < x[mid]) {
      return binarySearch(k, x, left, mid-1);
    }
    else {
      return binarySearch(k, x, mid+1, right);
    }
  } 

  int main() {
    char x[] = {'x', 'y', 'z', 'o', 'c', 'a', 'A', '1', '5', '3'};
    int n = sizeof(x) / sizeof(char);

    bubbleSort(x, n);
    cout << "Day sau sap xep: ";
    show(x, n);
    char k = 'c';
    cout << "\nk = " << k << endl;
    int index = binarySearch(k, x, 0, n-1);
    if(index == -1) {
      cout << "Khong tim thay k";
    }
    else {
      cout << "Tim thay k o vi tri thu " << index+1 << endl;
    }

    return 0;
  }
  ```

  **Kết quả chạy:**
                                                           
  ![image](https://user-images.githubusercontent.com/65481655/207902958-0565f7f1-4ef3-48be-aac1-bf9ce162fede.png)

</details>
