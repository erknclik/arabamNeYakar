using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public class City
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int plateCode { get; set; }
        //public ICollection<Distinct> distincts { get; set; }
    }
}