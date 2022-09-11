using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Detaile
    {
        public int CodeDetailesOfInvite { get; set; }
        public int? CodeInvite { get; set; }
        public int? CodeProduct { get; set; }
        public double? Count { get; set; }

        public virtual Invaite CodeInviteNavigation { get; set; }
        public virtual Product CodeProductNavigation { get; set; }

        //public Detaile(int CodeInvite, int CodeProduct, double count)
        //{
        //    this.CodeInvite = CodeInvite;
        //    this.CodeProduct = CodeProduct;
        //    this.Count = count;
        //}
    }
}
