using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.Write("Nhap chuoi: ");
            s = Console.ReadLine();

            if (kiemTraDoiXung(s))
            {
                Console.WriteLine("Chuoi doi xung.");
            }
            else
            {
                Console.WriteLine("Chuoi khong doi xung.");
            }
        }

        static bool kiemTraDoiXung(string s)
        {
            int n = s.Length;

            for (int i = 0; i < n / 2; i++)
            {
                if (s[i] != s[n - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
