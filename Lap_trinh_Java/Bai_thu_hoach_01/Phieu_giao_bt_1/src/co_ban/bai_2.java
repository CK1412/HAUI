package co_ban;

import java.util.Scanner;

/*
 * Cài đặt và vẽ lưu đồ thuật toán cho chương trình giải phương trình bậc 2, có tính tới nghiệm phức
 */

public class bai_2 {
	public static void main(String args[]) {
		Scanner scanner = new Scanner(System.in);
			
		System.out.println("PT bậc 2 có dạng ax^2 +bx + c = 0");
		
		float a, b,c;
		System.out.print("Nhập hệ số bậc 2, a = ");
		a = scanner.nextFloat();
		System.out.print("Nhập hệ số bậc 1, b = ");
		b = scanner.nextFloat();
		System.out.print("Nhập hằng số tự do, c = ");
		c = scanner.nextFloat();
		
		float delta = b*b - 4*a*c;
		if(delta < 0) {
			System.out.println("PT vô nghiệm.");
		}
		if(delta == 0) {
			float x =(float) (-b) / (2*a);
			System.out.println("PT có nghiệm kép x = " + x);
		}
		if(delta > 0) {
			float x1 = (float) (-b + Math.sqrt(delta) )/ (2*a);
			float x2 = (float) (-b - Math.sqrt(delta) )/ (2*a);
			System.out.printf("PT có 2 nghiệm phân biệt x1 = %.2f, x2 = %.2f", x1, x2);
		}
		
	}
}
