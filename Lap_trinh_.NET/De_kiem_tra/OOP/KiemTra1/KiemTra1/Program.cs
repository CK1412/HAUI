using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> sinhViens = new List<SinhVien>();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("-----------Tran Huy Canh _ 2019605959-----------");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("---------------------MENU-----------------------");
            Console.WriteLine("\t1. Them sinh vien");
            Console.WriteLine("\t2. Hien thi danh sach");
            Console.WriteLine("\t3. Xoa sinh vien");
            Console.WriteLine("\t4. Ket thuc");

            int luaChon = 0;

            while (luaChon != 4)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("------------------------------------------------");
                    Console.Write("Chon chuc nang: ");
                    luaChon = Convert.ToInt32(Console.ReadLine());
                    Console.ResetColor();
                    switch (luaChon)
                    {
                        case 1:
                            themSV(sinhViens);
                            break;
                        case 2:
                            hienThiDS(sinhViens);
                            break;
                        case 3:
                            xoaSV(sinhViens);
                            break;
                        case 4:
                            Console.WriteLine("Thoat thanh cong chuong trinh");
                            break;
                        default:
                            Console.WriteLine("Vui long chon dung chuc nang.");
                            break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Da co loi xay ra, vui long thao tac lai");
                    Console.ResetColor();
                }
            }
        }
        public static void themSV(List<SinhVien> sinhViens)
        {
            SinhVien x = new SinhVien();
            x.nhap();
            if (sinhViens.Contains(x))
            {
                Console.WriteLine(" Ma sinh vien bi trung, khong the them.");
            }
            else
            {
                sinhViens.Add(x);
                Console.WriteLine(" Them sinh vien thanh cong");
            }
        }
        public static void hienThiDS(List<SinhVien> sinhViens)
        {
            if (sinhViens.Count < 1)
            {
                Console.WriteLine("Danh sach rong");
                return;
            }
            Console.WriteLine($"{"MA SV",-10}{"HO TEN",-20}{"DIEN THOAI",-20}{"DIEM",-15}XEP LOAI");
            foreach (var item in sinhViens)
            {
                Console.WriteLine(item);
            }
        }
        public static void xoaSV(List<SinhVien> sinhViens)
        {
            if (sinhViens.Count < 1)
            {
                Console.WriteLine("Danh sach rong");
                return;
            }
            Console.Write(" Nhap ma sv can xoa: ");
            string maSV = Console.ReadLine();
            bool check = true;
            while (check)
            {
                Console.WriteLine("Ban co chac chan muon xoa (Y/N): ");
                char xacNhan = Convert.ToChar(Console.ReadLine());
                switch (xacNhan)
                {
                    case 'y':
                    case 'Y':
                        sinhViens.Remove(new SinhVien(maSV));
                        check = false;
                        break;
                    case 'n':
                    case 'N':
                        check = false;
                        break;
                    default:
                        check = true;
                        break;
                }
            }

        }
    }
}
