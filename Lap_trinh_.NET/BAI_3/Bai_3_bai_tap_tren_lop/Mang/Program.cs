using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] numbers;

            try
            {
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
                numbers = new int[n];
                Console.WriteLine("Nhap mang:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"numbers[{i}] = ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                int s = 0;
                foreach (int number in numbers)
                {
                    if (number % 2 != 0)
                        s += number;
                }
                Console.Write("\nTong cac phan tu le trong mang la: " + s);
                Console.WriteLine();
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
