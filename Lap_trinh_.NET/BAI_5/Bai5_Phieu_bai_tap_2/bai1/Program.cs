using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee();
            Console.WriteLine("-----INPUT-----");
            em.Input();
            Console.WriteLine("-----OUTPUT-----");
            em.Output();

            Console.ReadKey();
        }
        const int PRICE = 50;
        class Employee
        {
            string id { set; get; }
            string name { set; get; }
            int age { set; get; }
            int workingdays { set; get; }
            double salary
            {
                get => workingdays * PRICE;
            }

            public void Input()
            {
                Console.Write(" id: ");
                id = Console.ReadLine();
                Console.Write(" name: ");
                name = Console.ReadLine();
                Console.Write(" age: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.Write(" workingdays: ");
                workingdays = Convert.ToInt32(Console.ReadLine());
            }

            public void Output()
            {
                Console.WriteLine(" id: " + id);
                Console.WriteLine(" name: " + name);
                Console.WriteLine(" age: " + age);
                Console.WriteLine(" workingdays: " + workingdays);
                Console.WriteLine(" salary: " + salary);
            }

        }
    }
}
