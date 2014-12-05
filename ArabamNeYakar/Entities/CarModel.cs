using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public class CarModel
    {
        public int ID { get; set; }
        public string name { get; set; }
        public HatchType hatchType { get; set; }

    }
}