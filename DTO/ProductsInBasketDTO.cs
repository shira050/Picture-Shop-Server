using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
 public   class ProductsInBasketDTO
    {
        public int CodePicture { get; set; }
        public string NamePicture { get; set; }

        public int count { get; set; }
        public int Price { get; set; }
        public double FinalPrice { get; set; }

       


    }
}
