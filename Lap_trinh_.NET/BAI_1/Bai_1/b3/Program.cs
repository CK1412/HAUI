using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, p, chuVi, dienTich;
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (kiemTraTamGiac(a, b, c))
            {
                chuVi = a + b + c;
                p = chuVi / 2;
                dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Chu vi tam giac: " + chuVi);
                Console.WriteLine("Dien tich tam giac: " + dienTich);
            }
            else
            {
                Console.WriteLine("3 canh khong tao thanh tam giac.");
            }

        }

        static bool kiemTraTamGiac(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c && b + c > a && a + c > b)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
