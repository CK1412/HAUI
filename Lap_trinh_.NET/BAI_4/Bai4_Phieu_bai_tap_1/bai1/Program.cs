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
            Person p1 = new Person();
            p1.Input();
            p1.Output();
            p1.CheckAge();

        }

        class Person
        {
            string id { get; set; }
            string name { get; set; }
            int age { get; set; }
            string email { get; set; }
            string address { get; set; }

            public void CheckAge()
            {
                if (age >= 18)
                {
                    Console.WriteLine("Ban du tuoi bau cu.");
                }
                else
                {
                    Console.WriteLine("Ban con nho.");
                }
            }

           public void Input()
            {
                Console.Write("id: ");
                id = Console.ReadLine();
                Console.Write("name: ");
                name = Console.ReadLine();
                Console.Write("age: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.Write("email: ");
                email = Console.ReadLine();
                Console.Write("address: ");
                address = Console.ReadLine();
            }

            public void Output()
            {
                Console.WriteLine("-------PERSON INFORMATION--------");
                Console.WriteLine("id: " + id);
                Console.WriteLine("name: " + name);
                Console.WriteLine("age: " + age);
                Console.WriteLine("email: " + email);
                Console.WriteLine("address: " + address);
            }

        }
    }
}
