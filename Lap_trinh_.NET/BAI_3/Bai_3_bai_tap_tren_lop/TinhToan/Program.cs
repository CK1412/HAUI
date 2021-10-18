using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhToan
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;
            char pt;

            try
            {
                Console.WriteLine("Nhap 2 so thuc: ");
                Console.Write("\ta = ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("\tb = ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap phep tinh(+,-,*,/): ");
                pt = Convert.ToChar(Console.ReadLine());

                switch (pt)
                {
                    case '+':
                        Console.WriteLine($"\t{a} + {b} = {a + b}");
                        break;
                    case '-':
                        Console.WriteLine($"\t{a} - {b} = {a - b}");
                        break;
                    case '*':
                        Console.WriteLine($"\t{a} * {b} = {a * b}");
                        break;
                    case '/':
                        Console.WriteLine($"\t{a} / {b} = {a / b}");
                        break;
                    default:
                        Console.WriteLine("Ban da nhap khong dung phep tinh.");
                        break;

                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Vui long nhap dung dinh dang so thuc");
                Console.WriteLine(e.Message);
            }
        }
    }
}
