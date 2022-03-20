package co_ban;

import java.util.Scanner;

/*
 * Viết chương trình tính n!
 */
public class bai_3 {
	public static void main(String args[]) {
		Scanner scanner = new Scanner(System.in);
		int n = 0;
		System.out.print("Nhập n = ");
		n = scanner.nextInt();
		
		if(n < 1) {
			System.out.println("n phải là số dương mới có n!");
			return;
		}
		long s = 1;
		for(int i = 1; i <= n; i++) {
			s *= i;
		}
		System.out.println("Ta có: n! = " + s);
	}
}
