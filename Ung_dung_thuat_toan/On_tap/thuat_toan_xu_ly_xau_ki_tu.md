
# GIẢI THUẬT XỬ LÝ XÂU KÍ TỰ

**Bài 1:** Cho 2 xâu ký tự T = "mot hai ba bon mot nam sau mot", P = "mot". Sử dụng **thuật toán Boyer Moore Horspool** để kiểm tra xem P Có phải là một xâu con của T hay không?

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
  
**Bài 2:** Cho 2 xâu ký tự S = "mot hai 3 bon mot 5 6 bay 8 mot", P = "mot". Sử dụng **thuật toán Z** để tìm vị trí xâu con P xuất hiện trong xâu S

<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Code:**

  ```c++
  #include<bits/stdc++.h>
  using namespace std;

  void z_algorithm(string s, int z[]) {
    int n = s.size(),
      l = 0,
      r = 0;

    for(int i = 1; i < n; i++) {
      if(i > r) {
        l = r = i;

        while(r < n && s[r-l] == s[r]) {
          r++;
        }

        z[i] = r - l;
        r--;
      }
      else {
        int k = i - l;

        if(z[k] < r - i + 1) {
          z[i] = z[k];
        }
        else {
          l = i;
          while(r < n && s[r-l] == s[r]) {
            r++;
          }

          z[i] = r - l;
          r--;
        }
      }	
    }
  }

  void search(string s, string subStr)
  {
    int n = s.size();
    int m = subStr.size();

    string newStr = subStr + "$" + s;

    int z[n + m];

    z_algorithm(newStr, z);

    int count = 0;

    for (int i = 0; i <= n + m; ++i) {
      if (z[i] == m) {
        cout << "\nXau con p xuat hien tai vi tri thu " << i - m << endl;
        count++;
      }	
    }

    if(count == 0) {
      cout << "\nXau con p khong xuat hien trong chuoi s";
    }
  }

  int main() {
    string s = "mot hai 3 bon mot 5 6 bay 8 mot",
        p = "mot";

    cout << "Xau s\t\t:" << s << endl;
    cout << "Xau con p\t:" << p << endl;
    search(s, p);

    return 0;
  } 
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/209432965-a6402acb-c6f8-474c-b748-22b49cacebee.png)
  
</details>

**Bài 3:** Cho biết hai xâu ký tự A và B, hãy tìm xâu ký tự C có độ dài lớn nhất và là con của cả A và B

<details>
  <summary><i>Xem chi tiết</i></summary>
  <br>
  
  **Phân tích**
  
  - sử dụng thuật toán quy hoạch động
  
  **Code:**

  ```c++
  #include<bits/stdc++.h>
  using namespace std;

  string xau_con_chung_dai_nhat(string strA, string strB) {
    int a = strA.size(),
      b = strB.size();
    int dp[a+1][b+1];

    int start = 0, 
      length = 0;

    for (int i = 0; i <= a; i++) {
          for (int j = 0; j <= b; j++) {
              dp[i][j] = 0;
          }
      }

    for(int i = 1; i <= a; i++) {
      for(int j = 1; j <= b; j++) {
        if(strA[i-1] == strB[j-1]) {
          dp[i][j] = dp[i-1][j-1] + 1;

          if(dp[i][j] > length) {
            length = dp[i][j];
            start = i - length;
          }
        }
      }
    }

    return strA.substr(start, length);
  }

  int main() {
    string strA = "mot hai 3 bon nam sau 7 tam";
    string strB = "ba bon nam 6 bay";
    cout << "Xau A: " << strA << endl;
    cout << "Xau B: " << strB << endl;

    string subStr = xau_con_chung_dai_nhat(strA, strB);
    cout << "\nXau con chung dai nhat la: " << subStr << endl; 
    return 0;
  }
  ```

  **Kết quả chạy:**
  
  ![image](https://user-images.githubusercontent.com/65481655/209463722-e34235e9-db73-457d-acc7-cbcb33b9f35e.png)

</details>
 
