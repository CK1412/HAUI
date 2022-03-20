package chuoi_ki_tu;

import java.util.Scanner;

/*
 	Đếm xem trong một chuỗi xuất hiện bao nhiêu từ. 
	VD: “Hello world” => 2
*/
public class bai_16 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);

		System.out.print("Nhập vào một chuỗi: ");
		String str = scanner.nextLine();
		System.out.println("Chuỗi đã nhập: " + str);
		
		System.out.println("Số từ xuất hiện trong chuỗi là " + countWords(str));
	}
	
	// đếm số từ trong chuỗi
	public static int countWords(String str) {
		int n = str.length();
		int count = 0;

		for (int i = 0; i < n - 1; i++) {
			if (str.charAt(i) == ' ' && str.charAt(i + 1) != ' ') {
				count++;
			}
		}
		if (str.charAt(0) != ' ')
			count++;
		
		return count;
	}
}
