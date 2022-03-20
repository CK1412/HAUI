package BT_mang_2_chieu;

import java.util.Scanner;

public class bai_2 {
	static Scanner scanner = new Scanner(System.in);
	
	public static void main(String[] args) {

		// r1, c1 là số dòng, số cột của ma trận A
		// r2, c2 là số dòng, số cột của ma trận B
		int r1, c1, r2, c2;

		System.out.print("Nhap so dong cua ma tran A: ");
		r1 = scanner.nextInt();
		System.out.print("Nhap so cot cua ma tran A: ");
		c1 = scanner.nextInt();

		System.out.print("Nhap so dong cua ma tran B: ");
		r2 = scanner.nextInt();
		System.out.print("Nhap so cot cua ma tran B: ");
		c2 = scanner.nextInt();

		int[][] matrixA = new int[r1][c1];
		int[][] matrixB = new int[r2][c2];

		// kiểm tra điều kiện nhân ma trận
		do {
			if (c1 != r2) {
				System.out.println("De nhan 2 ma tran thi so cot cua ma tran A phai bang so dong cua ma tran B");
				System.out.print("Nhap lai so cot cua ma tran A:");
				c1 = scanner.nextInt();
				System.out.print("Nhap lai so dong cua ma tran B:");
				r2 = scanner.nextInt();
			} else {
				// nhập ma trận A
				System.out.println("Nhap ma tran A:");
				nhap(matrixA, r1, c1);
				
				// nhập ma trận B
				System.out.println("Nhap ma tran B:");
				nhap(matrixB, r2, c2);
				
				// C là kết quả của tích ma trận A và B
				int[][] matrixC = new int[r1][c2]; 
				
				for(int i = 0; i < r1; i++) {
					for(int j  = 0; j < c2; j++) {
						// tính từng phần tử của ma trận C
						matrixC[i][j] = 0;
						
						for(int k = 0; k < c1; k++) {
							// = các phần tử hàng của ma trận A * các phần tử cột của ma trận B tương ứng  
							matrixC[i][j] += matrixA[i][k] * matrixB[k][j];
						}
					}
				}
				
				System.out.println("Ma tran A:");
				xuat(matrixA, r1, c1);
				System.out.println("Ma tran B:");
				xuat(matrixB, r2, c2);
				System.out.println("Ket qua tich 2 ma tran A, B:");
				xuat(matrixC, r1, c2);
				break;
			}
		} while(true);
		
	}
	
	public static void nhap(int matrix[][], int n, int m) {
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				System.out.printf("[%d][%d] = ", i, j);
				matrix[i][j] = scanner.nextInt();
			}
			System.out.println();
		}
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
