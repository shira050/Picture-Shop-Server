using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Invaite
    {
        public Invaite()
        {
            Detailes = new HashSet<Detaile>();
        }

        public int CodeInvite { get; set; }
        public int? CodeUser { get; set; }
        public DateTime? DateInvite { get; set; }
        public double? PriceOfInvite { get; set; }

        public virtual User CodeUserNavigation { get; set; }
        public virtual ICollection<Detaile> Detailes { get; set; }

        //public Invaite(int? codeUser, DateTime? dateInvite, double? priceOfInvite)
        //{
           
        //    CodeUser = codeUser;
        //    DateInvite = dateInvite;
        //    PriceOfInvite = priceOfInvite;
        //}
    }
}
