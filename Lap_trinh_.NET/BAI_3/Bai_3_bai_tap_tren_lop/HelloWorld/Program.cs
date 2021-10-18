using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s;
            try
            {
                Console.WriteLine("Hay nhap vao 2 so.");
                Console.Write("a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                b = Convert.ToInt32(Console.ReadLine());
                s = a + b;
                Console.WriteLine($"{a} + {b} = {s}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Vui long nhap dung dinh dang so nguyen.");
            }
        }
    }
}
