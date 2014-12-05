using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public class CarComment
    {
        public int id { get; set; }
        public Nullable<int> owneruser_id { get; set; }
        public Nullable<int> car_id { get; set; }
        public System.DateTime commentDate { get; set; }
        public string comment { get; set; }
        public string season { get; set; }
        public int weight { get; set; }
        public int fuelConsCity { get; set; }
        public int fuelConsLongTerm { get; set; }
        public short version { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string updateUserName { get; set; }
        public Nullable<short> status { get; set; }

        public virtual Car cars { get; set; }
        public virtual User users { get; set; }

    }
}