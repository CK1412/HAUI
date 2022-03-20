package BT_co_ban;

import java.util.Random;

public class bai_2 {

	public static void main(String[] args) {
		Random random = new Random();

		// tạo ngẫu nhiên a, b trong khoảng [0, 100]
		int a = random.nextInt(100) + 1;
		int b = random.nextInt(100) + 1;

		System.out.printf("Ta có:  a = %d,  b = %d\n\n", a, b);

		System.out.println("Các phép toán số học:");
		System.out.println("\ta + b = " + (a + b));
		System.out.println("\ta - b = " + (a - b));
		System.out.println("\ta * b = " + (a * b));
		System.out.println("\ta / b = " + (a / b));
		System.out.println("\ta % b = " + (a % b));

		System.out.println("\nCác phép toán quan hệ:");
		System.out.println("\ta > b => " + (a > b));
		System.out.println("\ta >= b => " + (a >= b));
		System.out.println("\ta < b => " + (a < b));
		System.out.println("\ta <= b => " + (a <= b));
		System.out.println("\ta != b => " + (a != b));

		System.out.println("\nCác phép toán mức bit:");
		System.out.println("\t~a = " + (~a));
		System.out.println("\ta|b = " + (a | b));
		System.out.println("\ta ^ b = " + (a ^ b));
	}

}
