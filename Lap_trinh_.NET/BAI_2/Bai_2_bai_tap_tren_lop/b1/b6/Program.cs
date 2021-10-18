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
            int n;
            int[] a;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            a = new int[n];
            Console.WriteLine("Nhap mang: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nCac so le: ");
            inSoLe(a);
            Console.Write("\nCac so chan: ");
            inSoChan(a);
            Console.Write("\nCac so nguyen to: ");
            inSoNguyenTo(a);

            Console.ReadKey();
        }

        static void inSoLe(int[] a)
        {
            foreach(int i in a)
            {
                if(i %2 !=0)
                {
                    Console.Write(i + ", ");
                }
            }
        }

        static void inSoChan(int[] a)
        {
            foreach (int i in a)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
        }

        static bool kiemTraNguyenTo(int a)
        {
            if (a < 2)
            {
                return false;
            }
            else
            {
                for(int i = 2; i<=a/2;i++)
                {
                    if (a % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        static void inSoNguyenTo(int[] a)
        {
            foreach (int i in a)
            {
                if (kiemTraNguyenTo(i))
                {
                    Console.Write(i + ", ");
                }
            }
        }
    }
}
