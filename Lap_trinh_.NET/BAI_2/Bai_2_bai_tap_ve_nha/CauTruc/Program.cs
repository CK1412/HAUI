using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTruc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            HocSinh[] hocSinhs = new HocSinh[n];

            NhapMang(hocSinhs, n);
            TongSoTuoi(hocSinhs);
            Console.ReadKey();
        }

        public struct HocSinh
        {
            public string hoTen;
            public int tuoi;
            public bool gioiTinh;
        };

        public static void NhapMang(HocSinh[] hocSinhs, int n)
        {
            Console.WriteLine("Nhap mang:\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Hoc sinh {i}:");
                try
                {
                    Console.Write(" ho va ten: ");
                    hocSinhs[i].hoTen = Console.ReadLine();
                    Console.Write(" tuoi: ");
                    hocSinhs[i].tuoi = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Gioi tinh: ");
                    hocSinhs[i].gioiTinh = Convert.ToBoolean(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("*****Ban da nhap sai du lieu******");
                }
            }
        }

        static void TongSoTuoi(HocSinh[] hocSinhs)
        {
            int totalAge = 0;
            foreach(HocSinh hocSinh in hocSinhs)
            {
                totalAge += hocSinh.tuoi;
            }
            Console.WriteLine("\nTong so tuoi cua cac hoc sinh trong mang: " + totalAge);
        }

    }
}
