using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            var arr = new TimUCLN[n];

            Console.WriteLine("----INPUT----");
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine($"Cap so thu {i + 1}:");
                arr[i] = new TimUCLN();
                arr[i].Input();
            }

            Console.WriteLine("\n----OUTPUT----");
            foreach (TimUCLN x in arr)
            {
                x.Output();
            }

            Console.ReadKey();

        }

        class TimUCLN
        {
            public int sothu1, sothu2;

            public TimUCLN()
            {
                sothu1 = sothu2 = 0;
            }

            public int UCLN()
            {
                int a = sothu1, b = sothu2;
                if (a == 0 || b == 0)
                {
                    return a + b;
                }
                while (a != b)
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }
                return a;
            }
            public void Input()
            {
                Console.Write(" so thu 1: ");
                sothu1 = Convert.ToInt32(Console.ReadLine());
                Console.Write(" so thu 2: ");
                sothu2 = Convert.ToInt32(Console.ReadLine());
            }

            public void Output()
            {
                Console.WriteLine($" UCLN({sothu1},{sothu2}) = {UCLN()}");
            }
        }
    }
}
