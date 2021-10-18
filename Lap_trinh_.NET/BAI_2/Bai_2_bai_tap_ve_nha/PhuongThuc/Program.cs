using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongThuc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] numbers;

            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            numbers = new int[n];
            Console.WriteLine("Nhap mang: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"numbers[{i}] = ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nCac phan tu la so nguyen to trong mang: ");
            foreach(int number in numbers)
            {
                if (kiemTraSoNguyenTo(number))
                {
                    Console.Write(number + ", ");
                }
            }

            Console.WriteLine();

        }

        static bool kiemTraSoNguyenTo(int a)
        {
            if (a < 2)
                return false;
            for(int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
    }
}
