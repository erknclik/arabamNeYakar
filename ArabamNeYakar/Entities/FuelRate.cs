using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public partial class FuelRate
    {
        public int id { get; set; }
        public Nullable<int> fueltype_id { get; set; }
        public Nullable<int> city_id { get; set; }
        public System.DateTime rateDate { get; set; }
        public decimal price { get; set; }
        public short version { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string updateUserName { get; set; }
        public Nullable<short> status { get; set; }

        public virtual City cities { get; set; }
        public virtual FuelType fueltypes { get; set; }
    }
}