package chuoi_ki_tu;

import java.util.Scanner;

/*
 	Viết chương trình đếm số lượng các ký tự khác nhau có trong một chuỗi.
*/
public class bai_14 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);

		System.out.print("Nhập vào một chuỗi: ");
		String str = scanner.nextLine();
		System.out.println("Chuỗi đã nhập: " + str);

		System.out.print("\nSố ký tự khác nhau: " + count(str));

	}

	// đếm số ký tự khác nhau trong chuỗi
	static int count(String str) {
		// loại bỏ tất cả khoảng trắng trong chuỗi
		str = str.replaceAll("\\s", "");

		// tạo mảng lưu trữ tạm các ký tự khác nhau
		char tempStr[] = new char[str.length()];
		int m = 0;
		tempStr[m++] = str.charAt(0);

		// duyệt lần lượt các kí tự của chuỗi cần kiểm tra
		for (int i = 1; i < str.length(); i++) {
			int count = 0;
			// kiểm tra xem kí tự đã tồn tại trong mảng lưu trữ tạm chưa
			for (int j = 0; j < m; j++) {
				if (str.charAt(i) == tempStr[j])
					count++;
			}
			// nếu chưa thì thêm kí tự đó vào, rồi thì bỏ qua
			if (count == 0)
				tempStr[m++] = str.charAt(i);
		}
		// trả về độ dài mảng tạm, chính là số ký tự khác nhau trong chuỗi
		return m;
	}

}
