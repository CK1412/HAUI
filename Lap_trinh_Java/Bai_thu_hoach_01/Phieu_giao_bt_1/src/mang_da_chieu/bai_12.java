package mang_da_chieu;

import java.util.Arrays;

/*
 * Viết chương trình nhân hai mảng hai chiều
 */
public class bai_12 {
	public static void main(String args[]) {
		int r1 = 2, c1 = 3, r2 = 3, c2 = 4;
		int arr1[][] = new int[r1][c2];
		int arr2[][] = new int[r2][c2];

		// tạo ngẫu nhiên phần tử từ [0-10] cho 2 mảng 2 chiều 
		for (int i = 0; i < r1; i++) {
			for (int j = 0; j < c1; j++) {
				arr1[i][j] = (int) (Math.random() * 10 + 1);
			}
		}
		for (int i = 0; i < r2; i++) {
			for (int j = 0; j < c2; j++) {
				arr2[i][j] = (int) (Math.random() * 10 + 1);
			}
		}
		
		// nhân 2 mảng 2 chiều
		int[][] arr3 = new int[r1][c2]; 
		
		for(int i = 0; i < r1; i++) {
			for(int j  = 0; j < c2; j++) {
				// tính từng phần tử của mảng
				arr3[i][j] = 0;
				
				for(int k = 0; k < c1; k++) {
					// = các phần tử hàng của ma trận A * các phần tử cột của ma trận B tương ứng  
					arr3[i][j] += arr1[i][k] * arr2[k][j];
				}
			}
		}
		
		// hiển thị mảng và kết quả
		System.out.println("Mảng 2 chiều 1: ");
		System.out.println("\t" + Arrays.deepToString(arr1));
		System.out.println("Mảng 2 chiều 2: ");
		System.out.println("\t" + Arrays.deepToString(arr2));
		System.out.println("Tích 2 mảng: ");
		System.out.println("\t" + Arrays.deepToString(arr3));
	}

}
