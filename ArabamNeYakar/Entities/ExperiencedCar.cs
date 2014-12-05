using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public class ExperiencedCar
    {
        public int ID { get; set; }
        public Car car { get; set; }

        public bool owned { get; set; }
    }
}