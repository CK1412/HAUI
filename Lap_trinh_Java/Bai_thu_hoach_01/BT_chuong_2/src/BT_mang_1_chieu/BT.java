package BT_mang_1_chieu;

import java.util.Scanner;

public class BT {
	static Scanner scanner = new Scanner(System.in);

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.print("Nhap n = ");
		int n = scanner.nextInt();
		int[] arr = new int[n];
		System.out.println("Nhap day so co n phan tu: ");
		for (int i = 0; i < n; i++) {
			arr[i] = scanner.nextInt();
		}
		// ý a
		System.out.print("a) Hien thi day so:");
		hienThi(arr, n);

		// ý b
		int sum = 0;
		for (int x : arr)
			sum += x;
		System.out.println("b) Tong day so: " + sum);

		// ý c
		System.out.print("c) \nXap xep tang dan: ");
		sapXepTang(arr);
		hienThi(arr, n);
		System.out.print("Xap xep giam dan: ");
		sapXepGiam(arr);
		hienThi(arr, n);

		// ý d
		int[] odd = new int[n];
		int[] even = new int[n];
		// i, j lần lượt số phần tử mảng odd, even
		int i = 0, j = 0;
		for (int x : arr) {
			if (x % 2 == 0) {
				even[j++] = x;
			} else {
				odd[i++] = x;
			}
		}
		System.out.print("d) \nDay chua so chan: ");
		hienThi(even, j);
		System.out.print("Day chua so le: ");
		hienThi(odd, i);

	}

	public static void hienThi(int[] arr, int n) {
		for (int i = 0; i < n; i++) {
			System.out.print("\t" + arr[i]);
		}
		System.out.println("\n");
	}

	public static void sapXepTang(int[] arr) {
		int n = arr.length;
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

	public static void sapXepGiam(int[] arr) {
		int n = arr.length;
		for (int i = 0; i < n; i++) {
			for (int j = n - 1; j > i; j--) {
				if (arr[j] > arr[j - 1]) {
					int temp = arr[j];
					arr[j] = arr[j - 1];
					arr[j - 1] = temp;
				}
			}
		}
	}

}
