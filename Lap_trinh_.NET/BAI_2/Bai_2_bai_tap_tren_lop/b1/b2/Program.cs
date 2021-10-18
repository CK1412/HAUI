using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, count = 0, a1 = 0, a2 = 1, a3;
            do
            {
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            Console.Write($"Day {n} so fibonaci dau tien: ");
            while (count < n)
            {
                if (count <= 1)
                {
                    a3 = count;
                }
                else
                {
                    a3 = a1 + a2;
                    a1 = a2;
                    a2 = a3;
                }
                Console.Write(a3 + ", ");
                count++;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
