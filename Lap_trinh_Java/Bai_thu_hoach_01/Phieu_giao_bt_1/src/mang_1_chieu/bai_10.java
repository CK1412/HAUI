package mang_1_chieu;

/*
 * Tìm tất cả các số nguyên tố trong một mảng nguyên đặt lên đầu và có sắp xếp
 */
public class bai_10 {

	public static void main(String[] args) {
		int n = 10;
		int arr[] = new int[n];

		// tạo ngẫu nhiên 1 mảng n phần tử có giá trị thuộc đoạn [1, 100]:
		for (int i = 0; i < n; i++) {
			arr[i] = (int) (Math.random() * 100 + 1);
		}
		System.out.print("Mảng đã tạo:");
		showArr(arr, n);

		// đưa tất cả các số nguyên tố lên đầu có sắp xếp.
		System.out.println("Mảng sau khi đặt các số nguyên tố lên đầu (có sắp xếp): ");
		SortPrime(arr, n);
		showArr(arr, n);
	}
	
	// sắp xếp mảng tăng dần
	public static void sort(int arr[], int n) {
		for (int i = 0; i < n; i++) {
			for (int j = n - 1; j > i; j--) {
				if (arr[j] < arr[j - 1]) {
					int temp = arr[j];
					arr[j] = arr[j - 1];
					arr[j - 1] = temp;
				}
			}
		}
	}

	// kiểm tra số nguyên tố
	public static boolean isPrime(int x) {
		if (x < 2)
			return false;
		for (int i = 2; i <= Math.sqrt(x); i++) {
			if (x % i == 0)
				return false;
		}
		return true;
	}

	// sắp xếp các số nguyên tố lên đầu
	public static void SortPrime(int arr[], int n) {
		int a[] = new int[n]; // lưu trữ số nguyên tố
		int b[] = new int[n]; // lưu trữ số không nguyên tố
		int x = 0, y = 0; // lần lượt là độ dài mảng a, b

		// tách số nguyên tố và số không phải số nguyên tố thành 2 mảng
		for (int i : arr) {
			if (isPrime(i)) {
				a[x++] = i;
			} else {
				b[y++] = i;
			}
		}

		// sắp xếp mảng a
		sort(a, x);

		// ghép 2 mảng vào thành 1 mảng
		int j = 0;
		for (int i = 0; i < x; i++) {
			arr[j++] = a[i];
		}
		for (int i = 0; i < y; i++) {
			arr[j++] = b[i];
		}
	}

	// hiển thị mảng
	public static void showArr(int arr[], int n) {
		for (int i = 0; i < n; i++) {
			System.out.print("  " + arr[i]);
		}
		System.out.println();
	}

}
