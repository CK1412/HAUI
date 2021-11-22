using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class Product
    {

        public int ID { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public string[] Colors { set; get; }
        public int Brand { set; get; }
        public Product(int id, string name, double price, string[] colors, int brand)
        {
            ID = id;
            Name = name;
            Price = price;
            Colors = colors;
            Brand = brand;
        }
        public override string ToString()
        {
            return $"{ID,-6}{Name,-16}{Price,-10}{Brand,-10}{string.Join(",", Colors)}";
        }
    }
}
