using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public class UserRole
    {
        public int ID { get; set; }

        public Role Role { get; set; }

        public virtual User user { get; set; }
    }
}