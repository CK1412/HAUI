using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_7._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-----Su dung Func va anonymous method-----\n");

            Func<int, int, int> del1 = delegate (int x, int y) { return x + y; };

            Console.WriteLine("6 + 9 = " + del1(6, 9));

            Console.WriteLine("\n-----Su dung Action va Expression lambda-----\n");

            Action<double> del2;

            del2 = (double diemTB) =>
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
            };

            del2(9);

            Console.ReadKey();
        }
    }
}
