package mang_da_chieu;

import java.util.Arrays;

/*
 * Viết chương trình tìm số nguyên tố lớn nhất trong mảng hai chiều.
 */
public class bai_11 {

	public static void main(String[] args) {
		int n = 3, m = 7;
		int arr[][] = new int[n][m];

		// tạo ngẫu nhiên phần tử từ [0-100] cho mảng 2 chiếu
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				arr[i][j] = (int) (Math.random() * 100 + 1);
			}
		}
		System.out.println("Tạo ngẫu nhiên mảng 2 chiều: ");
		System.out.println("  "+Arrays.deepToString(arr));

		int max = maxPrime(arr);
		if (max == -1) {
			System.out.println("Trong mảng không có số nguyên tố");
		} else {
			System.out.println("Số nguyên tố lớn nhất trong mảng là " + max);
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

	// tìm số nguyên tố lớn nhất trong mảng
	public static int maxPrime(int arr[][]) {
		int maxPrime = -1;
		for (int[] x : arr) {
			for (int y : x) {
				if (isPrime(y) && maxPrime < y) {
					maxPrime = y;
				}
			}
		}
		return maxPrime;
	}

}
