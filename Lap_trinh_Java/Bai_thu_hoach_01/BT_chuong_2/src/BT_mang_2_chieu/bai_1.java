package BT_mang_2_chieu;

import java.util.Scanner;

public class bai_1 {
	static Scanner scanner = new Scanner(System.in);

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int n = 0, m = 0;
		int[][] matrix = null;

		System.out.print("n = ");
		n = scanner.nextInt();
		System.out.print("m = ");
		m = scanner.nextInt();
		matrix = new int[n][m];
		
		System.out.println("Nhap ma tran n x m:");
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				System.out.printf("arr[%d][%d] = ", i, j);
				matrix[i][j] = scanner.nextInt();
			}
			System.out.println();
		}
		
		System.out.println("Hien thi ma tran:");
		xuat(matrix, n, m);
		
	}

	public static void xuat(int matrix[][], int n, int m) {
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				System.out.print("\t" + matrix[i][j]);
			}
			System.out.println();
		}
	}

}
