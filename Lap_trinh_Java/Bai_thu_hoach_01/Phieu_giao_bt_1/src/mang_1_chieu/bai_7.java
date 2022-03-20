package mang_1_chieu;

import java.util.Scanner;

/*
 * Viết chương trình tìm kiếm một giá trị (theo thuật toán tìm kiếm nhị phân) trong mảng một chiều.
 */
public class bai_7 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		System.out.println("n = ");
		int n = scanner.nextInt();
		int arr[] = new int[n];
		System.out.print("Nhập dãy n phần tử: ");
		for (int i = 0; i < n; i++) {
			arr[i] = scanner.nextInt();
		}

		System.out.print("Nhập giá trị cần tìm: ");
		int x = scanner.nextInt();

		System.out.print("Sắp xếp lại dãy: ");
		bubbleSort(arr, n);
		showArr(arr);

		int k = binarySearch(arr, 0, n - 1, x);
		if (k == -1) {
			System.out.println("Không tìm thấy x trong dãy.");
		} else {
			System.out.println("Tìm thấy x ở vị trí thứ " + (k + 1) + " trong dãy");
		}

	}

	public static void bubbleSort(int x[], int n) {
		for (int i = 0; i < n - 1; i++) {
			for (int j = n - 1; j > i; j--) {
				if (x[j] < x[j - 1]) {
					int temp = x[j];
					x[j] = x[j - 1];
					x[j - 1] = temp;
				}
			}
		}
	}

	public static int binarySearch(int x[], int left, int right, int k) {
		if (left > right)
			return -1;
		else {
			int mid = (left + right) / 2;

			if (k == x[mid]) {
				return mid;
			}
			if (k < x[mid]) {
				return binarySearch(x, left, mid - 1, k);
			}
			return binarySearch(x, mid + 1, right, k);
		}
	}

	public static void showArr(int x[]) {
		for (int k : x) {
			System.out.print("  " + k);
		}
		System.out.println();
	}

}
