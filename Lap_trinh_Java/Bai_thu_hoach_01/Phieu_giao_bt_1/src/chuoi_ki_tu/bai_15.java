package chuoi_ki_tu;

import java.util.Scanner;

/*
	Tìm ra những ký tự có tần suất xuất hiện lớn nhất trong một chuỗi.
	VD: “everybody” => e,y
*/
public class bai_15 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);

		System.out.print("Nhập vào một chuỗi: ");
		String str = scanner.nextLine();
		System.out.println("Chuỗi đã nhập: " + str);

		// loại bỏ khoảng trắng trong chuỗi
		str = str.replaceAll("\\s", "");

		// mảng lưu trữ mã ascii của các kí tự
		int charFrequency[] = new int[255];
		// thiết lập số lần xuất hiện các kí tự là 0
		for (int i = 0; i < 255; i++) {
			charFrequency[i] = 0;
		}
		
		showResult(str, charFrequency);

	}

	// tìm số lần ký tự xuất hiện nhiều nhất
	public static int maxFrequency(String str, int charFrequency[]) {
		int n = str.length();

		// lấy số lần xuất hiện của mỗi kí tự trong chuỗi
		for (int i = 0; i < n; i++) {
			// chỉ số là mã ASCII của kí tự
			charFrequency[(int) str.charAt(i)] += 1;
		}

		int maxIndex = 0;
		for (int i = 1; i < 255; i++) {
			if (charFrequency[i] > charFrequency[maxIndex]) {
				maxIndex = i;
			}
		}
		return charFrequency[maxIndex];
	}

	public static void showResult(String str, int charFrequency[]) {
		int n = str.length();

		int max = maxFrequency(str, charFrequency);

		// mảng lưu trữ mã ascii của kí tự có số lần xuất hiện lớn nhất
		int results[] = new int[n];
		int m = 0;

		for (int i = 0; i < 255; i++) {
			if (charFrequency[i] == max) {
				results[m++] = i;
			}
		}

		System.out.print("Ký tự có số lần xuất hiện lớn nhất trong chuỗi là: ");
		for(int i = 0; i < m; i++) {
			System.out.print((char) results[i] + ", ");
		}
	}

}
