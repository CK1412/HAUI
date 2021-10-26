using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ho ten: ");
            string ten = Console.ReadLine();
            Console.Write("Thu nhap tinh thue: ");
            double tien = Convert.ToDouble(Console.ReadLine());

            Action<string, double> del1 = HienThiThue;

            del1(ten, tien);

            Console.ReadKey();
        }
        static void HienThiThue(string ten, double tien)
        {
            if (tien <= 5000000)
                Console.WriteLine($"{ten} phai nop {tien * 0.05} tien thue");
            else if (tien <= 10000000)
                Console.WriteLine($"{ten} phai nop {tien * 0.1} tien thue");
            else
                Console.WriteLine($"{ten} phai nop {tien * 0.2} tien thue");
        }
    }
}
