using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int b; // hệ cần chuyển sang

            /*Console.Write("So can chuyen(he 10): ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("He chuyen doi: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write($"1) So {n} chuyen tu he 10 sang he {b} la: ");
            doiTuHe10(n, b);
            Console.WriteLine();*/

            Console.Write("So can chuyen: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("So do o he: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write($"2) So {n} chuyen tu he {b} sang he 10 la: ");
            Console.WriteLine(doiVeHe10(n, b, 0));
            Console.ReadKey();
        }

        static void doiTuHe10(int n, int b)
        {

            if (n >= b)
            {
                doiTuHe10(n / b, b);
            }
            if (n % b > 9)
            {
                Console.Write((char)(n % b + 55));
            }
            else
            {
                Console.Write((n % b));
            }
        }

        static int doiVeHe10(int n, int b, int i)
        {
            if (n / 10 == 0)
            {
                return n * Convert.ToInt32(Math.Pow(b, i));
            }
            return (n % 10) * Convert.ToInt32(Math.Pow(b, i)) + doiVeHe10(n / 10, b, i + 1);
        }
    }
}
