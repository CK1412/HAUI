using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "xin chao   moi   nguoi    ";
            /*Console.Write("Nhap chuoi: ");
            str = Console.ReadLine();*/

            cauA(str);
            cauB(str);
            cauC(str);

            Console.ReadKey();
        }

        static void cauA(string str)
        {
            Console.WriteLine("a) Hien thi moi ki tu trong chuoi tren 1 dong:");
            foreach (char a in str)
            {
                Console.WriteLine(a);
            }
        }

        static void cauB(string str)
        {
            string[] strList = Regex.Split(str.Trim(), @"\s+");
            Console.WriteLine("\nb) Hien thi moi tu trong chuoi tren 1 dong:");
            foreach (string a in strList)
            {
                Console.WriteLine(a);
            }
        }

        static void cauC(string str)
        {
            string coppyStr = str.Replace(" ",string.Empty);

            Console.WriteLine("\nc) Hien thi so lan xuat hien cua moi ki tu trong chuoi:");
            while (coppyStr.Length > 0)
            {
                int count = 0;
                Console.Write(coppyStr[0] + " : ");
                foreach(char a in coppyStr)
                {
                    if(coppyStr[0] == a)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                coppyStr = coppyStr.Replace(coppyStr[0].ToString(), string.Empty);
            }
        }
    }
}
