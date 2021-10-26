using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_01
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
                            sapXep(nhanViens);
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
            x.nhap();
            foreach (NhanVien nhanVien in nhanViens)
            {
                if (nhanVien.MaNV == x.MaNV)
                {
                    Console.WriteLine("Trung ma nhan vien, khong the them nhan vien nay.");
                    return;
                }
            }
            nhanViens.Add(x);
            Console.WriteLine("Da them thanh cong");
        }
        static void hienThidanhSach(List<NhanVien> nhanViens)
        {
            if (nhanViens.Count == 0)
            {
                Console.WriteLine("Hien danh sach dang rong");
                return;
            }
            foreach (var x in nhanViens)
            {
                Console.WriteLine($"\t{x.MaNV}\t{x.Hoten}\t{x.DiaChi}\t{x.ChucVu}\t{x.LuongCoBan}");
            }
        }
        static void sapXep(List<NhanVien> nhanViens)
        {
            int n = nhanViens.Count;
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (nhanViens[j].heSoChucVu() < nhanViens[j - 1].heSoChucVu())
                    {
                        NhanVien temp = nhanViens[j];
                        nhanViens[j] = nhanViens[j - 1];
                        nhanViens[j - 1] = temp;
                    }
                    else if (nhanViens[j].heSoChucVu() == nhanViens[j - 1].heSoChucVu())
                    {
                        if (nhanViens[j].LuongCoBan < nhanViens[j - 1].LuongCoBan)
                        {
                            NhanVien temp = nhanViens[j];
                            nhanViens[j] = nhanViens[j - 1];
                            nhanViens[j - 1] = temp;
                        }
                    }
                }
            }
        }
    }
}
