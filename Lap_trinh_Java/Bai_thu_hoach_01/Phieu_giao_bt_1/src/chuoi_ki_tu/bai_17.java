package chuoi_ki_tu;

import java.util.Scanner;
import java.util.regex.Pattern;

/*
 *  Viết hoa chỉ các ký tự đầu từ trong một chuỗi. “Nguyễn Văn Abc”
 */
public class bai_17 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);

		System.out.print("Nhập vào một chuỗi: ");
		String str = scanner.nextLine();
		System.out.println("Chuỗi đã nhập: " + str);

		System.out.println("Chuỗi sau chuẩn hoá: " + standardizeString(str));
	}

	public static String standardizeString(String str) {
		char[] charArr = str.toLowerCase().toCharArray();
		int n = charArr.length;

		// kiểm tra từ đầu tiên trong chuỗi
		if (charArr[0] != ' ')
			charArr[0] = Character.toUpperCase(charArr[0]);

		// kiểm tra bắt đầu từ từ thứ 2 trong chuỗi
		for (int i = 1; i < n - 1; i++) {
			if (Pattern.matches("\\s", charArr[i] + "") && Pattern.matches("\\S", charArr[i + 1] + "")) {
				charArr[i + 1] = Character.toUpperCase(charArr[i + 1]);
			}
		}

		// chuyển mảng char thành chuỗi
		return String.valueOf(charArr);
	}

}
