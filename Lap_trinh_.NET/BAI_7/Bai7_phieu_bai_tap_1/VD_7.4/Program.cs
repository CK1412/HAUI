using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----SU DUNG FUNC----\n");
            Func<int, int, int> del1 = Cong2So;

            Console.WriteLine("3 + 5 = " + del1(3, 5));

            Console.WriteLine("\n----SU DUNG ACTION----\n");
            Action<double> del2 = XepLoaiHocSinh;

            del2(7.5);

            Console.ReadKey();
        }

        private static int Cong2So(int a, int b)
        {
            return a + b;
        }
        static void XepLoaiHocSinh(double diemTB)
        {
            if (diemTB >= 8)
                Console.WriteLine("Hoc sinh dat loai: Gioi");
            else if (diemTB >= 6.5)
                Console.WriteLine("Hoc sinh dat loai: Gioi");
            else if (diemTB >= 5)
                Console.WriteLine("Hoc sinh dat loai: Trung binh");
            else if (diemTB >= 3.5)
                Console.WriteLine("Hoc sinh dat loai: Yeu");
            else
                Console.WriteLine("Hoc sinh dat loai: Kem");
        }
    }
}
