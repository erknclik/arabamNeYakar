using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public partial class Brand
    {
        public Brand()
        {
            this.carmodels = new HashSet<CarModel>();
        }
    
        public int id { get; set; }
        public Nullable<int> origin { get; set; }
        public string name { get; set; }
        public short version { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string updateUserName { get; set; }
        public Nullable<short> status { get; set; }
    
        public virtual Country countries { get; set; }
        public virtual ICollection<CarModel> carmodels { get; set; }
    }
}