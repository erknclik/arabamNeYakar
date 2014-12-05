using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public partial class UserRole
    {
        public int id { get; set; }
        public Nullable<int> role_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public short version { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string updateUserName { get; set; }
        public Nullable<short> status { get; set; }

        public virtual Role roles { get; set; }
        public virtual User users { get; set; }
    }
}