using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public class Brand
    {
        public int ID { get; set; }
        public string name { get; set; }
        public Country origin { get; set; }
        public ICollection<CarModel> carModels { get; set; }

    }
}