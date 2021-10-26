using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ho ten: ");
            string ten = Console.ReadLine();
            Console.Write("Thu nhap tinh thue: ");
            double tien = Convert.ToDouble(Console.ReadLine());

            Action<string, double> del1 = (name, money) =>
            {
                if (money <= 5000000)
                    Console.WriteLine($"{name} phai nop {money * 0.05} tien thue");
                else if (money <= 10000000)
                    Console.WriteLine($"{name} phai nop {money * 0.1} tien thue");
                else
                    Console.WriteLine($"{name} phai nop {money * 0.2} tien thue");
            };

            del1(ten, tien);

            Console.ReadKey();
        }

    }
}
