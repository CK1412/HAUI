package mang_da_chieu;

import java.util.Arrays;

/*
 * Viết chương trình tạo một bản sao của một mảng n chiều, n là bất kỳ
 */
public class bai_13 {

	public static void main(String[] args) {
		int n = (int) (Math.random() * 4 + 1);
		int m = (int) (Math.random() * 4 + 1);

		int[][] arr = new int[n][m];

		// tạo ngẫu nhiên phần tử từ [0-10] cho 2 mảng 2 chiều
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				arr[i][j] = (int) (Math.random() * 10 + 1);
			}
		}
		System.out.println("Tạo ngẫu nhiên mảng 2 chiều:");
		System.out.println("\t" + Arrays.deepToString(arr));

		int[][] arr2 = new int[n][m];
		copyArr(arr2, arr);
		System.out.println("Mảng mới sao chép từ mảng vừa tạo:");
		System.out.println("\t" + Arrays.deepToString(arr2));
	}

	public static void copyArr(int[][] newArr, int[][] arr) {
		int n = newArr.length;

		for (int i = 0; i < n; i++) {
			int m = newArr[i].length;

			for (int j = 0; j < m; j++) {
				newArr[i][j] = arr[i][j];
			}
		}
	}

}
