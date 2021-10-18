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
            Circle c1 = new Circle();
            c1.radius = 5;
            Console.WriteLine("CIRCLE 1:");
            Console.WriteLine(" radius: " + c1.radius);
            Console.WriteLine(" area: " + c1.Area().ToString("N2"));
            Console.WriteLine(" perimeter: " + c1.Perimeter().ToString("N2"));
            Console.WriteLine();
            Circle c2 = new Circle(3);
            Console.WriteLine("CIRCLE 2");
            Console.WriteLine(" radius: " + c2.radius);
            Console.WriteLine(" area: " + c2.Area().ToString("N2"));
            Console.WriteLine(" perimeter: " + c2.Perimeter().ToString("N2"));

            Console.ReadKey();
        }

        class Circle
        {
            public int radius { set; get; }

            public Circle()
            {
                radius = 0;
            }

            public Circle(int radius)
            {
                this.radius = radius;
            }

            public double Area()
            {
                return Math.PI * radius * radius;
            }

            public double Perimeter()
            {
                return Math.PI * radius * 2;
            }
        }
    }
}
