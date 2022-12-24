
# GIẢI THUẬT XỬ LÝ XÂU KÍ TỰ

**Bài 1:** Cho 2 xâu ký tự T = "mot hai ba bon mot nam sau mot", P = "mot". Sử dụng thuật toán Boyer Moore Horspool để kiểm tra xem P Có phải là một xâu con của T hay không?

<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Code:**

  ```c++
  #include<bits/stdc++.h>
  using namespace std;

  int char_in_string(char c, string s) {
    for(int i = 0; i < s.size(); i++) {
      if (s[i] == c) {
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
      int j = i - 1,
        x = v - 1;
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
    string T = "mot hai ba bon mot nam sau mot",
      P = "mot";

    cout << "T = " << T << endl;
    cout << "P = " << P << endl;
    cout << "So lan P xuat hien trong T: " << boyer_moore_horspool(T, P) << endl;

    return 0;
  }  
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/209432864-982de0ae-fb16-4ecc-9c30-7b7ef5c0cf27.png)

</details>
  
