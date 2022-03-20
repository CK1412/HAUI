package co_ban;

import java.util.Scanner;

// Viết chương trình tìm UCLN của 2 số
public class bai_5 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int a, b;
		System.out.print("a = ");
		a = scanner.nextInt();
		System.out.print("b = ");
		b = scanner.nextInt();

		System.out.println("UCLN(a, b) = " + UCLN(a, b));
	}

	public static int UCLN(int a, int b) {
		// nếu a = 0 -> UCLN(a,b) = b
		// nếu b = 0 -> UCLN(a,b) = a
		if (a == 0 || b == 0) {
			return a + b;
		}

		while (a != b) {
			if (a > b) {
				a -= b;
			} else {
				b -= a;
			}
		}
		return a; 
	}

}
