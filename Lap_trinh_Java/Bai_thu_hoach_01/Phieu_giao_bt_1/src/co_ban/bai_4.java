package co_ban;

import java.util.Scanner;

/*
 * Viết chương trình tính C(m,n)
 */
public class bai_4 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int m, n;
		do {
			System.out.print("m = ");
			m = scanner.nextInt();
			System.out.print("n = ");
			n = scanner.nextInt();
		} while (m > n);
		
		System.out.println("C(m, n) = " + tinhToHop(m, n));
	}

	// tính giai thừa
	public static long giaiThua(int a) {
		long s = a;
		for (int i = 1; i < a; i++) {
			s *= i;
		}
		return s;
	}

	// tính C(m, n) = n! / (m! * (n-m)!)
	public static float tinhToHop(int m, int n) {
		if(m == n) return 1;
		
		return (float) giaiThua(n) / (giaiThua(m) * giaiThua(n - m));
	}
}
