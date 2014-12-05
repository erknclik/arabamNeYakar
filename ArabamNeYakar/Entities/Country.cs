using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public partial class Country
    {
        public Country()
        {
            this.brands = new HashSet<Brand>();
            this.cities = new HashSet<City>();
        }
    
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public short version { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string updateUserName { get; set; }
        public Nullable<short> status { get; set; }
    
        public virtual ICollection<Brand> brands { get; set; }
        public virtual ICollection<City> cities { get; set; }
    }
}