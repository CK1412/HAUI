using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ten nhan vien: ");
            string tenNV = Console.ReadLine();
            Console.Write("So tien ban hang: ");
            double tien = Convert.ToDouble(Console.ReadLine());

            Func<double, double> del1 = TienHoaHong;
            Console.WriteLine("So tien hoa hong nhan duoc: " + del1(tien));

            Console.ReadKey();
        }
        static double TienHoaHong(double x)
        {
            if (x < 1000) return x;
            else if (x <= 3000) return x * 0.05;
            else return x * 0.1;
        }
    }
}
