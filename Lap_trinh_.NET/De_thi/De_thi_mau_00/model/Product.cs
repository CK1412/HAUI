using System;
using System.Collections.Generic;

#nullable disable

namespace De_thi_mau_00.model
{
    public partial class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int? UnitPrice { get; set; }
        public int? Quantity { get; set; }
        public string CatId { get; set; }

        public virtual Category Cat { get; set; }
    }
}
