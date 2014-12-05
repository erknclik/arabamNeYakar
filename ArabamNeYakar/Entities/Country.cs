﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public class Country
    {
        public int ID { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public ICollection<City> cities { get; set; }

    }
}