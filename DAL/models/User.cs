using DTO;
using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class User
    {
        public User()
        {
            Invaites = new HashSet<Invaite>();
        }

        public int CodeUser { get; set; }
        public string NameUser { get; set; }
        public string PasswordUser { get; set; }
        public string EmailUser { get; set; }

        public virtual ICollection<Invaite> Invaites { get; set; }

    }
}
