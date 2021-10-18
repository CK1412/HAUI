using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            bool isDone = true;

            while (isDone)
            {
                try
                {
                    Console.Write("a = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("c = ");
                    c = Convert.ToInt32(Console.ReadLine());


                    if (kiemTra(a, b, c))
                    {
                        int chuVi = a + b + c;
                        double p = (double)chuVi / 2;
                        double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                        Console.WriteLine("Chu vi tam giac: " + chuVi);
                        Console.WriteLine("Dien tich tam giac: " + dienTich);
                    }
                    else
                    {
                        Console.WriteLine("3 canh khong tao thanh tam giac.");
                    }
                    isDone = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    isDone = true;
                }
            }
        }

        static bool kiemTra(int a, int b, int c)
        {
            if (a + b > c && b + c > a && a + c > b)
            {
                return true;
            }
            return false;
        }
    }
}
