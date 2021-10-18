using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Vehicles : IVehicle, IComparable
    {
        public string id { set; get; }
        public string maker { set; get; }
        public string model { set; get; }
        public int year { set; get; }
        public double price { set; get; }

        public Vehicles()
        {

        }
        public Vehicles(string id)
        {
            this.id = id;
        }
        public Vehicles(string id, string maker, string model, int year, double price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public virtual void Input()
        {
            Console.WriteLine("-----INPUT-----");
            Console.Write("id: ");
            id = Console.ReadLine();
            Console.Write("maker: ");
            maker = Console.ReadLine();
            Console.Write("model: ");
            model = Console.ReadLine();
            Console.Write("year: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("price: ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.WriteLine("-----OUTPUT-----");
            Console.WriteLine("id: " + id);
            Console.WriteLine("maker: " + maker);
            Console.WriteLine("model: " + model);
            Console.WriteLine("year: " + year);
            Console.WriteLine("price: " + price);
        }

        public override bool Equals(object obj)
        {
            Vehicles x = (Vehicles)obj;
            return this.id.Equals(x.id);
        }
        public override int GetHashCode()
        {
            return 0;
        }
        public override string ToString()
        {
            return string.Format("id: {0,-10}maker: {1,-12}model: {2,-12}year: {3,-10}price: {4,-15}", id, maker, model, year, price);
        }

        public int CompareTo(object obj)
        {
            Vehicles x = (Vehicles)obj;
            return this.price.CompareTo(x.price);
        }
    }

    class CompareToYear : IComparer<Vehicles>
    {
        public int Compare(Vehicles x, Vehicles y)
        {
            return x.year - y.year;
        }
    }
}
