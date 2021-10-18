using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a;
            do
            {
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            Console.Write("Day n so fibonaci dau tien: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(fibonaci(i) + ", ");
            }

            Console.WriteLine();

            do
            {
                Console.Write("a = ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a < 1);

            Console.WriteLine($"Giai thua cua a la: {giaiThua(a)}");
        }

        static int fibonaci(int a)
        {
            if (a <= 1)
            {
                return a;
            }
            else
            {
                return fibonaci(a - 1) + fibonaci(a - 2);
            }
        }
        static int giaiThua(int a)
        {
            if (a == 0 || a == 1)
            {
                return 1;
            }
            else
            {
                return a * giaiThua(a - 1);
            }
        }
    }
}
