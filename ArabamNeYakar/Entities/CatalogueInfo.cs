using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public partial class CatalogueInfo
    {
        public CatalogueInfo()
        {
            this.carpictures = new HashSet<CarPicture>();
            this.cars = new HashSet<Car>();
        }
    
        public int id { get; set; }
        public int engineHP { get; set; }
        public int weightInKg { get; set; }
        public int fuelConsCity { get; set; }
        public int fuelConsLongTerm { get; set; }
        public string wheelDrive { get; set; }
        public short version { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string updateUserName { get; set; }
        public Nullable<short> status { get; set; }
    
        public virtual ICollection<CarPicture> carpictures { get; set; }
        public virtual ICollection<Car> cars { get; set; }
    }
}