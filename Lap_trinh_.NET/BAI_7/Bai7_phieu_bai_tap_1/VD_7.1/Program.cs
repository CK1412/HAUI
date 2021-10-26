using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_7._1
{
    class Program
    {
        private delegate void HienThiThongBao(string message);
        static void Main(string[] args)
        {
            HienThiThongBao del1 = ThongBaoLoi;

            del1("thieu");

        }

        private static void ThongBaoLoi(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Chuong trinh cua ban co loi bien dich sau: " + message);
            Console.ResetColor();
        }
    }
}
