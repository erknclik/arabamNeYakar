using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public class Car
    {
        public int ID { get; set; }
        public CarModel carModel { get; set; }
        public HatchType hatchType { get; set; }
        public FuelType fuelType { get; set; }
        public string gear { get; set; }
        public ICollection<string> comments { get; set; }

        public CatalogueInfo catalogueInfo { get; set; }


    }
}