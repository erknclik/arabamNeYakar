using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public partial class User
    {
       public User()
        {
            this.carcomments = new HashSet<CarComment>();
            this.userroles = new HashSet<UserRole>();
        }
    
        public int id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public Nullable<bool> passive { get; set; }
        public Nullable<System.DateTime> lastLogin { get; set; }
        public string email { get; set; }
        public short version { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string updateUserName { get; set; }
        public Nullable<short> status { get; set; }
    
        public virtual ICollection<CarComment> carcomments { get; set; }
        public virtual ICollection<UserRole> userroles { get; set; }


    }
}