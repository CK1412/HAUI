using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Person
    {
        private static int idTemp = 0;
        public int id;
        public string name;
        public string address;

        public Person()
        {
            id = idTemp++;
        }
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public virtual void Input()
        {
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Address: ");
            address = Console.ReadLine();
        }
        public virtual void Output()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
        }

    }
}
