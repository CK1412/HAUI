using System;
using System.Collections.Generic;

#nullable disable

namespace De_thi_mau_00.model
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public string CatId { get; set; }
        public string CatName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
