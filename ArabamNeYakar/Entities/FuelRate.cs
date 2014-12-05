using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public class FuelRate
    {
        public int ID { get; set; }
        public FuelType fuelType { get; set; }
        public City city { get; set; }
        public double price { get; set; }
        public DateTime rateDate { get; set; }

    }
}