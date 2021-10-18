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
            int n, s1 = 0;
            double s2 = 0;

            do
            {
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            for (int i = 1; i <= n; i++)
            {
                s1 += i;
                s2 += 1.0 / i;
            }

            Console.WriteLine("\na) S = 1 + 2 + 3 +...+ n = " + s1);
            Console.WriteLine("b) S = 1 + 1/2 + 1/3 +...+ 1/n = " + s2);
        }
    }
}
