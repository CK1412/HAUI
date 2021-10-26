using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();

            Console.WriteLine("\n------------------MENU------------------\n");
            Console.WriteLine("\t1. Them");
            Console.WriteLine("\t2. Hien thi danh sach");
            Console.WriteLine("\t3. Sap xep");
            Console.WriteLine("\t4. Thoat");

            bool isRunning = true;
            int luaChon;
            while (isRunning)
            {
                try
                {
                    Console.Write("\nNhap lua chon: ");
                    luaChon = Convert.ToInt32(Console.ReadLine());
                    switch (luaChon)
                    {
                        case 1:
                            themNhanVien(nhanViens);
                            break;
                        case 2:
                            hienThidanhSach(nhanViens);
                            break;
                        case 3:
                            nhanViens.Sort();
                            hienThidanhSach(nhanViens);
                            break;
                        case 4:
                            isRunning = false;
                            Console.WriteLine("Dong thanh cong chuong trinh.");
                            break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Da xay ra loi, vui long thao tac lai.");
                    Console.ResetColor();
                }
            }
        }
        static void themNhanVien(List<NhanVien> nhanViens)
        {
            NhanVien x = new NhanVien();
            Console.Write(" ho ten: ");
            x.HoTen = Console.ReadLine();
            Console.Write(" dia chi: ");
            x.DiaChi = Console.ReadLine();
            Console.Write(" he so luong: ");
            x.HeSoLuong = Convert.ToDouble(Console.ReadLine());
            Console.Write(" ma nhan vien: ");
            x.MaNV = Console.ReadLine();
            Console.Write(" chuc vu: ");
            x.ChucVu = Console.ReadLine();
            foreach (var item in nhanViens)
            {
                if (item.MaNV == x.MaNV)
                {
                    Console.WriteLine("Ma nhan vien bi trung, khong the them nhan vien nay");
                    return;
                }
            }
            nhanViens.Add(x);
            Console.WriteLine("Them nhan vien thanh cong");
        }
        static void hienThidanhSach(List<NhanVien> nhanViens)
        {
            if (nhanViens.Count == 0)
            {
                Console.WriteLine("Danh sach rong");
                return;
            }
            Console.WriteLine($" {"MA NV",-10}{"HO TEN",-16}{"DIA CHI",-16}{"CHUC VU",-16}{"HE SO LUONG",-16}{"TINH LUONG"}");
            foreach (var item in nhanViens)
            {
                Console.WriteLine($" {item.MaNV,-10}{item.HoTen,-16}{item.DiaChi,-16}{item.ChucVu,-16}{item.HeSoLuong,-16}{item.tinhLuong()}");
            }
        }
    }
}
