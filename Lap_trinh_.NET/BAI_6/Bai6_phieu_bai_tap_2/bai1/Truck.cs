using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Truck : Vehicles
    {
        public int truckload { set; get; }
        public Truck() : base()
        {

        }
        public Truck(string id, string maker, string model, int year, double price, int truckload) : base(id, maker, model, year, price)
        {
            this.truckload = truckload;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("truckload: ");
            truckload = Convert.ToInt32(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("truckload: " + truckload);
        }
        public override string ToString()
        {
            return base.ToString() + "truckload: " + truckload;
        }
    }
}
