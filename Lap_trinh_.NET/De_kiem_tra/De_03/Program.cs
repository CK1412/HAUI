using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------MENU---------------");
            Console.WriteLine("\t1. Nhap thong tin");
            Console.WriteLine("\t2. Hien thi danh sach");
            Console.WriteLine("\t3. Sua thong tin");
            Console.WriteLine("\t4. Thoat");

            int luaChon = 0;

            while (luaChon != 4)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("----------------------------------");
                    Console.Write("Chon chuc nang: ");
                    luaChon = Convert.ToInt32(Console.ReadLine());
                    Console.ResetColor();
                    switch (luaChon)
                    {
                        case 1:
                            nhapThongTin(nhanViens);
                            break;
                        case 2:
                            hienThiDanhSach(nhanViens);
                            break;
                        case 3:
                            suaThongTin(nhanViens);
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
        public static void nhapThongTin(List<NhanVien> nhanViens)
        {
            Console.WriteLine("------MENU------");
            Console.WriteLine("\t1. Nhan vien");
            Console.WriteLine("\t2. Nhan vien ban hang");
            int loaiNV;
            do
            {
                Console.Write("Nhap lua chon cua ban: ");
                loaiNV = Convert.ToInt32(Console.ReadLine());
            } while (loaiNV > 2 || loaiNV < 1);
            Console.Write(" ma nhan vien: ");
            string maNV = Console.ReadLine();
            Console.Write(" ho ten: ");
            string hoTen = Console.ReadLine();
            Console.Write(" gioi tinh: ");
            bool gioiTinh = Convert.ToBoolean(Console.ReadLine());
            if (loaiNV == 1)
            {
                NhanVien x = new NhanVien(maNV, hoTen, gioiTinh);
                if (nhanViens.Contains(x))
                {
                    Console.WriteLine("Ma nhan vien bi trung, khong the them");
                    return;
                }
                else
                {
                    nhanViens.Add(x);
                    Console.WriteLine("Them nhan vien thanh cong");
                }
            }
            else if (loaiNV == 2)
            {
                Console.Write(" so tien ban hang: ");
                double soTienBH = Convert.ToDouble(Console.ReadLine());
                NhanVienBanHang x = new NhanVienBanHang(maNV, hoTen, gioiTinh, soTienBH);
                if (nhanViens.Contains(x))
                {
                    Console.WriteLine("Ma nhan vien bi trung, khong the them");
                    return;
                }
                else
                {
                    nhanViens.Add(x);
                    Console.WriteLine("Them nhan vien ban hang thanh cong");
                }
            }

        }
        public static void hienThiDanhSach(List<NhanVien> nhanViens)
        {
            if (nhanViens.Count < 1)
            {
                Console.WriteLine("Danh sach rong");
                return;
            }
            Console.WriteLine($"{"MA NV",-10}{"HO TEN",-20}{"GIOI TINH",-15}{"SO TIEN BAN HANG",-20}{"% HOA HONG"}");
            foreach (var item in nhanViens)
            {
                if (item is NhanVienBanHang)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine(item + $"{"-",-20}-");
                }
            }
        }
        public static void suaThongTin(List<NhanVien> nhanViens)
        {
            Console.Write("Nhap ma nhan vien can sua: ");
            string maNV = Console.ReadLine();
            var nv = new NhanVien(maNV);
            var index = nhanViens.IndexOf(nv);
            if(index != -1)
            {
                Console.Write(" ho ten: ");
                nhanViens[index].HoTen = Console.ReadLine();
                Console.Write(" gioi tinh: ");
                nhanViens[index].GioiTinh = Convert.ToBoolean(Console.ReadLine());
                if (nhanViens[index] is NhanVienBanHang)
                {
                    
                    Console.Write(" so tien ban hang: ");
                    (nhanViens[index] as NhanVienBanHang).SoTienBanHang = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("Sua thong tin thanh cong");
                Console.WriteLine("--------DANH SACH SAU KHI SUA--------");
                hienThiDanhSach(nhanViens);
            }
            else
            {
                Console.WriteLine("Khong co ma nhan vien do trong danh sach");
            }
        }

    }
}
