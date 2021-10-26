using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    class Program
    {
        delegate void HienThi(double x);
        static void Main(string[] args)
        {
            Console.Write("Ten sinh vien: ");
            string ten = Console.ReadLine();
            Console.Write("Diem tong ket: ");
            double diem = Convert.ToDouble(Console.ReadLine());

            HienThi del1 = diemChu;
            HienThi del2 = xepHocLuc;
            HienThi multicast = del1 + del2;

            multicast(diem);

            Console.ReadKey();
        }
        static void xepHocLuc(double x)
        {
            if (x >= 8)
                Console.WriteLine("Hoc luc: Gioi");
            else if (x >= 6.5)
                Console.WriteLine("Hoc luc: Kha");
            else if (x >= 5.0)
                Console.WriteLine("Hoc luc: Trung binh");
            else if (x >= 3.5)
                Console.WriteLine("Hoc luc: Yeu");
            else
                Console.WriteLine("Hoc luc: Kem");
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
