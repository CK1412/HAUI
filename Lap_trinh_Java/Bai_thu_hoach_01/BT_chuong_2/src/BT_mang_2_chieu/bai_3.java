package BT_mang_2_chieu;

import java.util.Scanner;

public class bai_3 {
	static Scanner scanner = new Scanner(System.in);

	public static void main(String[] args) {
		// n1, m1 là số dòng, số cột của ma trận A
		// n2, m2 là số dòng, số cột của ma trận B
		int r1 = 0, c1 = 0, r2 = 0, c2 = 0;
		
		// matrix C = matrixA * matrixB
		int[][] matrixA = null, matrixB = null, matrixC = null;

		boolean isRunning = true; // chương trình đang chạy thì có giá trị true
		int option; // lưu trữ lựa chọn của người dùng

		do {
			menu();
			System.out.print("Nhap lua chon cua ban:");
			option = scanner.nextInt();
			
			switch (option) {
			case 1:
				System.out.print("Nhap so dong cua ma tran A: ");
				r1 = scanner.nextInt();
				System.out.print("Nhap so cot cua ma tran A: ");
				c1 = scanner.nextInt();

				System.out.print("Nhap so dong cua ma tran B: ");
				r2 = scanner.nextInt();
				System.out.print("Nhap so cot cua ma tran B: ");
				c2 = scanner.nextInt();

				do {
					if (c1 != r2) {
						System.out
								.println("De nhan 2 ma tran thi so cot cua ma tran A phai bang so dong cua ma tran B");
						System.out.print("Nhap lai so cot cua ma tran A:");
						c1 = scanner.nextInt();
						System.out.print("Nhap lai so dong cua ma tran B:");
						r2 = scanner.nextInt();
					} else {
						matrixA = new int[r1][c1];
						matrixB = new int[r2][c2];
						
						// nhập ma trận A
						System.out.println("Nhap ma tran A:");
						enterMatrix(matrixA, r1, c1);

						// nhập ma trận B
						System.out.println("Nhap ma tran B:");
						enterMatrix(matrixB, r2, c2);

						break;
					}
				} while (true);
				break;
			case 2:
				if (matrixA == null || matrixB == null) {
					System.out.println("Chua nhap ma tran");
					break;
				}

				matrixC = new int[r1][c2];

				for (int i = 0; i < r1; i++) {
					for (int j = 0; j < c2; j++) {
						// tính từng phần tử của ma trận C
						matrixC[i][j] = 0;

						for (int k = 0; k < c1; k++) {
							// = các phần tử hàng của ma trận A * các phần tử cột của ma trận B tương ứng
							matrixC[i][j] += matrixA[i][k] * matrixB[k][j];
						}
					}
				}
				
				System.out.println("Da tinh thanh cong");
				break;
			case 3:
				if (matrixA == null || matrixB == null) {
					System.out.println("Chua nhap ma tran");
					break;
				}
				System.out.println("Ma tran A:");
				showMatrix(matrixA, r1, c1);
				System.out.println("Ma tran B:");
				showMatrix(matrixB, r2, c2);

				if (matrixC != null) {
					System.out.println("Ket qua tich 2 ma tran A, B:");
					showMatrix(matrixC, r1, c2);
				}
				else {
					System.out.println("Chua tinh tich 2 ma tran A, B");
				}

				break;
			case 4:
				isRunning = false;
				System.out.println("Bye");
				break;
			default:
				System.out.println("Nhap sai lua chon");
				break;
			}

		} while (isRunning);

	}

	public static void menu() {
		System.out.println("--------------------------------");
		System.out.println("CHUONG TRINH TINH TICH 2 MA TRAN");
		System.out.println("--------------------------------");
		System.out.println("\t1. Nhap ma tran A, B");
		System.out.println("\t2. Tinh tich C = A * B");
		System.out.println("\t3. Hien thi");
		System.out.println("\t4. Thoat");
	}

	public static void enterMatrix(int matrix[][], int n, int m) {
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				System.out.printf("[%d][%d] = ", i, j);
				matrix[i][j] = scanner.nextInt();
			}
			System.out.println();
		}
	}

	public static void showMatrix(int matrix[][], int n, int m) {
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				System.out.print("\t" + matrix[i][j]);
			}
			System.out.println();
		}
	}
}
