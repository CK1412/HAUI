package BT_co_ban;
import java.io.*;
import java.util.Scanner;

public class bai_1 {

	public static void main(String[] args) {
		// sử dụng lớp Scanner
		Scanner scanner = new Scanner(System.in);
		System.out.println("Nhập 1 chuỗi: ");
		String str1 = scanner.nextLine();
		System.out.println("Chuỗi vừa nhập: " + str1);
			
		// Sử dụng BufferedReader 
		BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
		try {
			System.out.println("Nhập 1 chuỗi: ");
			String str2 = bufferedReader.readLine();
			System.out.println("Chuỗi vừa nhập: " + str2);
			
		}catch(IOException e) {
			e.printStackTrace();
		}
	}

}
