using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public class Role
    {
        public int ID { get; set; }
        public string name { get; set; }

        public string description { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

    }
}