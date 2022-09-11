using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CodeCategory { get; set; }
        public string NameCategory { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
