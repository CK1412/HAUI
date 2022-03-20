package BT_co_ban;

import java.util.*;

public class bai_3 {
	static Scanner scanner = new Scanner(System.in);

	public static void main(String[] args) {
		System.out.println("Nhap so nguyen a = ");
		int a = scanner.nextInt();
		
		System.out.println("Ta thực hiện các phép toán: ");
		System.out.println("\ta << 1 = " + (a << 1));
		System.out.println("\ta >> 1 = " + (a >> 1));
		System.out.println("\ta >>> 1 = " + (a >>> 1));
		System.out.println("\t~a = " + (~a));
	}
}
