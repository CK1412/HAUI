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
            List<Car> cars = new List<Car>();

            Console.WriteLine("\n------------------MENU------------------\n");
            Console.WriteLine("\t1. Them");
            Console.WriteLine("\t2. Hien thi danh sach");
            Console.WriteLine("\t3. Sap xep");
            Console.WriteLine("\t4. Thoat");

            int luaChon = 0;
            while (luaChon != 4)
            {
                try
                {
                    Console.Write("\nNhap lua chon: ");
                    luaChon = Convert.ToInt32(Console.ReadLine());
                    switch (luaChon)
                    {
                        case 1:
                            them(cars);
                            break;
                        case 2:
                            hienThiDanhSach(cars);
                            break;
                        case 3:
                            sapXep(cars);
                            hienThiDanhSach(cars);
                            break;
                        case 4:
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

        public static void them(List<Car> cars)
        {
            Car x = new Car();
            x.nhap();
            foreach (var item in cars)
            {
                if (item.BienSo.Equals(x.BienSo))
                {
                    Console.WriteLine("Trung bien so, khong the them xe nay");
                    return;
                }
            }
            cars.Add(x);
            Console.WriteLine("Da them thanh cong");
        }

        public static void hienThiDanhSach(List<Car> cars)
        {
            if (cars.Count < 1)
            {
                Console.WriteLine("Danh sach rong");
                return;
            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.HangSX}\t{item.MauSac}\t{item.BienSo}\t{item.DongXe}\t{item.PhienBan}\t{item.tinhGiaXe()}");
            }
        }
        public static void sapXep(List<Car> cars)
        {
            int n = cars.Count;
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (cars[j].tinhGiaXe() < cars[j - 1].tinhGiaXe())
                    {
                        Car temp = cars[j];
                        cars[j] = cars[j - 1];
                        cars[j - 1] = temp;
                    }
                }
            }
        }
    }
}
