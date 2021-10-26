using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_7._3
{
    class Program
    {
        private delegate void HienThiThongBao(string message);
        static void Main(string[] args)
        {
            HienThiThongBao del1 = ThongBaoLoi; 
            HienThiThongBao del2 = GuiThongDiep;
            HienThiThongBao del3 = CanhBao;

            HienThiThongBao multiDel = del1 + del2;
            multiDel += del3;
            multiDel += CanhBao;
            multiDel += CanhBao;
            multiDel -= del2;

            multiDel("ABC");
        }
        private static void ThongBaoLoi(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Chuong trinh cua ban co loi bien dich sau: " + message);
            Console.ResetColor();
        }

         static void GuiThongDiep(string name)
        {
            Console.WriteLine("Thong diep da duoc gui cho " + name);
        }
        static void CanhBao(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ban nen dung phien ban " + message);
            Console.ResetColor();
        }
    }
}
