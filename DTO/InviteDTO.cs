using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class InviteDTO
    {

        public int CodeInvite { get; set; }
        public int CodeUser { get; set; }
        public DateTime DateInvite { get; set; }
        public double PriceOfInvite { get; set; }
    }
}
