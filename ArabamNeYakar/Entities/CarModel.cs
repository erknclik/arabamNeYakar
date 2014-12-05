using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public partial class CarModel
    {
        public CarModel()
        {
            this.cars = new HashSet<Car>();
        }
    
        public int id { get; set; }
        public Nullable<int> brand_id { get; set; }
        public Nullable<int> hatchtype_id { get; set; }
        public string name { get; set; }
        public short version { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string updateUserName { get; set; }
        public Nullable<short> status { get; set; }
    
        public virtual Brand brands { get; set; }
        public virtual ICollection<Car> cars { get; set; }
        public virtual HatchType hatchtypes { get; set; }

    }
}