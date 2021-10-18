using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, chuVi, dienTich;
            Console.Write("chieu dai: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("chieu rong: ");
            b = Convert.ToDouble(Console.ReadLine());
            if (a <= 0 || b <= 0 || a < b)
            {
                return;
            }
            chuVi = (a + b) * 2;
            dienTich = a * b;

            Console.WriteLine("Chu vi HCN: " + chuVi);
            Console.WriteLine("Dien tich HCN: " + dienTich);
            Console.ReadKey();
        }
    }
}
