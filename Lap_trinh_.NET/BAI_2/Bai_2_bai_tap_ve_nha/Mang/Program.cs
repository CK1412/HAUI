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

            nhapMang(out numbers, out n);

            hienThi(numbers, n);
        }

        static void nhapMang(out int[] numbers, out int n)
        {
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            numbers = new int[n];
            Console.WriteLine("Nhap mang: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"numbers[{i}] = ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }

        static void hienThi(int[] numbers, int n)
        {
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
                sum += number;
            }
            Console.WriteLine("So lon nhat: " + max);
            Console.WriteLine("So nho nhat: " + min);
            Console.WriteLine("Tong cac phan tu cua mang: " + sum);
        }
    }
}
