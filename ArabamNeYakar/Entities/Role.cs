using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public partial class Role
    {
        public Role()
        {
           // this.userroles = new HashSet<UserRole>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public short version { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string updateUserName { get; set; }
        public Nullable<short> status { get; set; }
    
        //public virtual ICollection<UserRole> userroles { get; set; }
    }
}