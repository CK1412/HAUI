
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

**Bài 3:** Sắp xếp trộn

<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Code:**

  ```c++
  #include<iostream>
  using namespace std;

  void show(int *a, int n) {
    for(int i = 0; i < n; i++) {
      cout << a[i] << "  ";
    }
    cout << endl;
  }

  void merge(int *a, int left, int mid, int right) {
    int n1 = mid - left + 1,
      n2 = right - mid;
    int *a1 = new int[n1],
      *a2 = new int[n2];
    for(int i = 0; i < n1; i++) 
      a1[i] = a[left+i];
    for(int i = 0; i < n2; i++) 
      a2[i] = a[mid+i+1];

    int i = 0, j = 0, k = left;
    while(i < n1 && j < n2) 
      // sap xep giam sua thanh a1[i] > a2[j]
      a[k++] = (a1[i] < a2[j]) ? a1[i++] : a2[j++];			
    while(i < n1) 
      a[k++] = a1[i++];
    while(j < n2) 
      a[k++] = a2[j++];
  }
  void merge_sort(int *a, int left, int right) {
    if(left < right) {
      int mid  = left + (right-left) / 2;
      merge_sort(a, left, mid);
      merge_sort(a, mid+1,right);
      merge(a, left, mid, right);
    }
  }

  int main() {
    int a[] = {1, 4, 6, 3, 2, 8, 9, 5};
    int n = sizeof(a) / sizeof(int);

    cout << "Day ban dau: ";
    show(a, n);

    cout << "Sap xep tron tang dan: "; 
    merge_sort(a, 0, n-1); 
    show(a, n);	

    return 0;
  }

  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/207903560-5bc4d46e-f6e0-46da-86ff-76f19b6fdcf5.png)

</details>

**Bài 4:** Tìm giá trị lớn nhất/ nhỏ nhất của mảng 

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

  int min_max(int *a, int left, int right, int &min, int &max) {
    int min1, min2, max1, max2;

    if(left == right) {
      min = a[left];
      max = a[left];
    }
    else {
      int mid = (left + right) / 2;
      min1 = a[left]; max1 = a[mid];
      min2 = a[mid+1]; max2 = a[right];

      min_max(a, left, mid, min1, max1);
      min_max(a, mid+1, right, min2, max2);

      min = min1 < min2 ? min1 : min2;
      max = max1 < max2 ? max2 : max1;
    }
  }

  int main() {
    int a[] = {3, 6, 8, 2, 82, 8, 9, 75, 1, 35, 6};
    int n = sizeof(a) / sizeof(int);

    cout << "Day so: "; 
    show(a, n); 

    int min = a[0];
    int max = a[n-1];

    min_max(a, 0, n-1, min, max);

    cout << "So lon nhat: " << max << endl;
    cout << "So nho nhat: " << min << endl; 
    return 0;
  }
  ```

  **Kết quả chạy:**
                                          
  ![image](https://user-images.githubusercontent.com/65481655/207905741-b8f7b6b0-6382-4aee-9b6d-fd9fc129378e.png)                                       

</details>
  
