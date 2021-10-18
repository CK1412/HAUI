using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Car : Vehicles
    {
        public string color { set; get; }

        public Car() : base()
        {

        }
        public Car(string id, string maker, string model, int year, double price, string color) : base(id, maker, model, year, price)
        {
            this.color = color;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("color: ");
            color = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("color: " + color);
        }
        public override string ToString()
        {
            return base.ToString() + "color: " + color;
        }
    }
}
