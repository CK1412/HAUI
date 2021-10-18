using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TachDay
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers=new List<int>();


            try
            {
                Console.WriteLine("Nhap day:");
                while (true)
                {
                    numbers.Add(Convert.ToInt32(Console.ReadLine()));
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Da hoan thanh nhap du lieu");

                Console.WriteLine("Xuat day:");
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        Console.Write(number + "  ");
                    }
                }
                Console.WriteLine();
                foreach (int number in numbers)
                {
                    if (number % 2 != 0)
                    {
                        Console.Write(number + "  ");
                    }
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
