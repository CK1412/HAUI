using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class Brand
    {
        public int ID { set; get; }
        public string Name { set; get; }

        public Brand(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
