using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1
{
    class Program
    {
        delegate void HienThiDiemChu(double x);
        static void Main(string[] args)
        {
            Console.Write("Ten sinh vien: "); 
            string ten = Console.ReadLine();
            Console.Write("Diem tong ket: ");
            double diem = Convert.ToDouble(Console.ReadLine());

            HienThiDiemChu del1 = diemChu;
            del1(diem);

            Console.ReadKey();
        }
        static void diemChu(double x)
        {
            if (x < 4)
                Console.WriteLine("Diem chu: F");
            else if (x < 5.5)
                Console.WriteLine("Diem chu: D");
            else if (x < 7)
                Console.WriteLine("Diem chu: C");
            else if (x < 8.5)
                Console.WriteLine("Diem chu: B");
            else if (x < 10)
                Console.WriteLine("Diem chu: A");
        }
    }
}
