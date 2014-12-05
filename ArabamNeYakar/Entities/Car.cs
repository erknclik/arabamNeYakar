using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public partial class Car
    {
        public Car()
        {
            this.carcomments = new HashSet<CarComment>();
        }
    
        public int id { get; set; }
        public Nullable<int> model_id { get; set; }
        public Nullable<int> hatchtype_id { get; set; }
        public Nullable<int> fueltype_id { get; set; }
        public Nullable<int> catalogueinfo_id { get; set; }
        public short version { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string updateUserName { get; set; }
        public Nullable<short> status { get; set; }
    
        public virtual ICollection<CarComment> carcomments { get; set; }
        public virtual CarModel carmodels { get; set; }
        public virtual CatalogueInfo catalogueinfos { get; set; }
        public virtual HatchType hatchtypes { get; set; }
        public virtual FuelType fueltypes { get; set; }

    }
}