package mang_1_chieu;

import java.util.Scanner;

/*
 * Cho một mảng đã được sắp xếp, viết chương trình bổ sung một giá trị mới vào mảng theo đúng thứ tự
 */
public class bai_8 {

	public static void main(String[] args) {
		int n = 5;
		// tạo mảng có sẵn gồm 5 phần tử đã được sắp xếp
		int arr[] = new int[20];
		arr[0] = 3;
		arr[1] = 5;
		arr[2] = 6;
		arr[3] = 12;
		arr[4] = 32;

		System.out.print("Mảng hiện tại:");
		showArr(arr, n);

		Scanner scanner = new Scanner(System.in);
		System.out.print("Nhập giá trị mới: ");
		int a = scanner.nextInt();

		insert(arr, n, a);
		n++;
		System.out.print("Mảng sau khi chèn:");
		showArr(arr, n);
	}

	// tìm vị trí chèn
	public static int findIndex(int arr[], int n, int x) {
		for (int i = 0; i < n; i++) {
			if (arr[i] >= x) {
				return i;
			}
		}
		return n;
	}
	
	public static void insert(int arr[], int n, int x) {
		int k = findIndex(arr, n, x);
		for (int i = n; i > k; i--) {
			arr[i] = arr[i - 1];
		}
		arr[k] = x;
	}

	public static void showArr(int arr[], int n) {
		for (int i = 0; i < n; i++) {
			System.out.print("  " + arr[i]);
		}
		System.out.println();
	}

}
