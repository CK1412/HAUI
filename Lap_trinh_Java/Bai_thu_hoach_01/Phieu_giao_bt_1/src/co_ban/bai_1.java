package co_ban;

import java.util.Scanner;

/*
 * Cài đặt và vẽ lưu đồ thuật toán cho chương trình kiểm tra một số n có phải nguyên tố hay không?
 */

public class bai_1 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int n;
		System.out.print("Nhap n = ");
		n = scanner.nextInt();
		
		// số nguyên tố là nguyên dương có duy nhất 2 ước là 1 và chính nó
		
		if (n < 2) {
			System.out.println("n khong phai la so nguyen to");
			return;
		}

		for (int i = 2; i <= Math.sqrt(n); i++) {
			// nếu chia hết thì số đó sẽ có nghiệm khác 1 và chính nó
			if (n % i == 0) {
				System.out.println("n khong phai la so nguyen to");
				return;
			}
		}

		System.out.println("n la so nguyen to");

	}

}

