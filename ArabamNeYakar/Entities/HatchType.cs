using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public partial class HatchType
    {
        public HatchType()
        {
            this.carmodels = new HashSet<CarModel>();
            this.cars = new HashSet<Car>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public short version { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string updateUserName { get; set; }
        public Nullable<short> status { get; set; }
    
        public virtual ICollection<CarModel> carmodels { get; set; }
        public virtual ICollection<Car> cars { get; set; }
    }
}