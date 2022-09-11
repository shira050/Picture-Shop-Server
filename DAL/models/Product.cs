using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Product
    {
        public Product()
        {
            Detailes = new HashSet<Detaile>();
        }

        public int CodePicture { get; set; }
        public string NamePicture { get; set; }
        public int? CodeCategory { get; set; }
        public double? Price { get; set; }
        public string Image { get; set; }
        public int? Size { get; set; }
        public double? AcountInStore { get; set; }

        public virtual Category CodeCategoryNavigation { get; set; }
        public virtual ICollection<Detaile> Detailes { get; set; }
    }
}
