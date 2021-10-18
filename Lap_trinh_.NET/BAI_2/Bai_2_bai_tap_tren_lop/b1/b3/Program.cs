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
            int a,s=1;

            do
            {
                Console.Write("a = ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a < 1);

            for(int i = 1; i <= a;i++)
            {
                s *= i;
            }
            Console.WriteLine($"Giai thua cua {a} la: {s}");
        }
    }
}
