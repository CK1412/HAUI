using System;
using System.Collections.Generic;

namespace de_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KhachHang> khachHangs = new List<KhachHang>();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------MENU-------------------------");
            Console.WriteLine("\t1. Nhap thong tin");
            Console.WriteLine("\t2. Hien thi danh sach");
            Console.WriteLine("\t3. Sap xep danh sach");
            Console.WriteLine("\t4. Thoat");

            int chucNang = 0;
            while (chucNang != 4)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("------------------------------------------------------");
                    Console.Write("Nhap chuc nang: ");
                    chucNang = Convert.ToInt32(Console.ReadLine());
                    Console.ResetColor();
                    switch (chucNang)
                    {
                        case 1:
                            nhapThongTin(khachHangs);
                            break;
                        case 2:
                            hienThiDS(khachHangs);
                            break;
                        case 3:
                            sapXepDS(khachHangs);
                            break;
                        case 4:
                            Console.WriteLine("Dong thanh cong chuong trinh.");
                            break;
                        default:
                            Console.WriteLine("Khong co chuc nang do");
                            break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Da xay ra loi, vui long thao tac lai");
                    Console.ResetColor();
                }
            }
        }

        public static void nhapThongTin(List<KhachHang> khachHangs)
        {
            Console.WriteLine("-----MENU-----");
            Console.WriteLine(" 1. Khach hang");
            Console.WriteLine(" 2. Khach hang than thiet");
            int doiTuong;
            do
            {
                Console.Write("Nhap doi tuong: ");
                doiTuong = Convert.ToInt32(Console.ReadLine());
            } while (doiTuong < 1 || doiTuong > 2);

            Console.Write(" ho ten: ");
            string hoTen = Console.ReadLine();
            Console.Write(" gioi tinh: ");
            bool gioiTinh = Convert.ToBoolean(Console.ReadLine());
            Console.Write(" so luong mua: ");
            int soLuongMua = Convert.ToInt32(Console.ReadLine());
            Console.Write(" don gia: ");
            double donGia = Convert.ToDouble(Console.ReadLine());

            if (doiTuong == 1)
            {
                KhachHang x = new KhachHang(hoTen, gioiTinh, soLuongMua, donGia);
                if (khachHangs.Contains(x))
                {
                    Console.WriteLine("Ho ten bi trung, khong the them.");
                    return;
                }
                khachHangs.Add(x);
                Console.WriteLine("Them thanh cong khach hang");
            }
            if (doiTuong == 2)
            {
                KhachHangThanThiet x = new KhachHangThanThiet(hoTen, gioiTinh, soLuongMua, donGia);
                if (khachHangs.Contains(x))
                {
                    Console.WriteLine("Ho ten bi trung, khong the them.");
                    return;
                }
                khachHangs.Add((KhachHangThanThiet)x);
                Console.WriteLine("Them thanh cong khach hang than thiet");
            }
        }
        public static void hienThiDS(List<KhachHang> khachHangs)
        {
            if (khachHangs.Count < 1)
            {
                Console.WriteLine("Danh sach rong");
                return;
            }
            Console.WriteLine($"{"HO TEN",-20}{"GIOI TINH",-15}{"SO LUONG MUA",-20}{"DON GIA",-15}{"TONG TIEN",-15}QUA TANG");
            foreach (var item in khachHangs)
            {
                if (item is KhachHangThanThiet)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine(item + "khong");
                }
            }
        }
        public static void sapXepDS(List<KhachHang> khachHangs)
        {
            int n = khachHangs.Count;
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (String.Compare(khachHangs[j].HoTen, khachHangs[j - 1].HoTen, true) < 0)
                    {
                        KhachHang temp = khachHangs[j];
                        khachHangs[j] = khachHangs[j - 1];
                        khachHangs[j - 1] = temp;
                    }
                    if (String.Compare(khachHangs[j].HoTen, khachHangs[j - 1].HoTen, true) == 0)
                    {
                        if (khachHangs[j].SoLuongMua < khachHangs[j - 1].SoLuongMua)
                        {
                            KhachHang temp = khachHangs[j];
                            khachHangs[j] = khachHangs[j - 1];
                            khachHangs[j - 1] = temp;
                        }
                    }
                }
            }
            Console.WriteLine("------------DANH SACH SAU SAP XEP-----------");
            hienThiDS(khachHangs);
        }
    }
}
