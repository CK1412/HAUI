using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double epsilon;

            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("epsilon = ");
            epsilon = Convert.ToDouble(Console.ReadLine());

            double result = 1.0;
            while (Math.Abs(result * result - a) / a >= epsilon)
            {
                result = (a / result + result) / 2;
            }

            Console.WriteLine($"Can bac 2 cua {a} la: {result}");
        }
    }
}
