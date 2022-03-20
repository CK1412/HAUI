package chuoi_ki_tu;

import java.util.Arrays;
import java.util.Scanner;
import java.util.regex.Pattern;

/*
 * Viết chương trình so sánh sự giống nhau của hai chuỗi ký tự bất kỳ.
 */
public class bai_18 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String str1, str2;
		System.out.print("Nhập chuỗi 1: ");
		str1 = scanner.nextLine();
		System.out.print("Nhập chuỗi 2: ");
		str2 = scanner.nextLine();
		
		int result = str1.compareTo(str2);
		
		if(result == 0) {
			System.out.println("Chuỗi 1 và 2 giống nhau.");
		}
		else {
			System.out.println("Hai chuỗi khác nhau.");
		}
	}
}
