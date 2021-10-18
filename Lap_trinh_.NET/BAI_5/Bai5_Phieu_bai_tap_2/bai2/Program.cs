using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            GiaiPhuongTrinhBac2 pt = new GiaiPhuongTrinhBac2();
            pt.Input();
            pt.Output();

            Console.ReadKey();
        }

        class GiaiPhuongTrinhBac2
        {
            int a, b, c;

            public GiaiPhuongTrinhBac2()
            {
                a = b = c = 0;
            }

            public void Input()
            {
                Console.Write("a =  ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b =  ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("c =  ");
                c = Convert.ToInt32(Console.ReadLine());
            }

            public void Output()
            {
                double delta = b * b - 4 * a * c;
                if (b > 0)
                {
                    Console.WriteLine($"Ta xet PT: {a}x^2 + {b}x + {c} = 0");
                }
                else
                {
                    Console.WriteLine($"Ta xet PT: {a}x^2 {b}x + {c} = 0");
                }

                if (delta < 0)
                {
                    Console.WriteLine("PT vo nghiem.");
                }
                else if (delta == 0)
                {
                    double x = (-b) / (2 * a);
                    Console.WriteLine("PT co nghiem kep: x = " + x.ToString("N2"));
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"PT co 2 nghiem phan biet: x1 = {x1.ToString("N2")} va x2 = {x2.ToString("N2")}");
                }
            }
        }
    }
}
