using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapLieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool isDone = true;

            while (isDone)
            {
                try
                {
                    /*while (true)
                    {
                        Console.Write("Nhap 1 so trong khoang tu 1 den 100: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        if (n >= 1 && n <= 100)
                        {
                            isDone = false;
                            break;
                        }
                    }*/

                    do
                    {
                        Console.Write("Nhap 1 so trong khoang tu 1 den 100: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        if (n >= 1 && n <= 100)
                        {
                            isDone = false;
                            break;
                        }
                    } while (true);
                }
                catch (FormatException e)
                {
                    isDone = true;
                }
            }
           
        }
    }
}
