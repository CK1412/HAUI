package chuoi_ki_tu;

import java.util.Scanner;

/*
 * Viết chương trình cắt ra một số lượng từ nhất định trong một chuỗi đã cho.
 */
public class bai_19 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);

		System.out.print("Nhập vào một chuỗi: ");
		String str = scanner.nextLine();
		System.out.println("Chuỗi đã nhập: " + str);
		
		int k;
		System.out.print("Nhập số từ muốn cắt: ");
		k = scanner.nextInt();
		
		System.out.printf("Cắt ra %d từ của chuỗi: %s", k, cutString(str, k));
	}

	public static String cutString(String str, int k) {
		String[] strArr = str.split("\\s+");
		int n = strArr.length;
		if (k >= n) {
			return str;
		}

		String newStr = "";
		for (int i = 0; i < k; i++) {
			newStr += " " + strArr[i];
		}
		return newStr;
	}

}
