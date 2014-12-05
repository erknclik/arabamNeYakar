using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public class Picture
    {
        public int ID { get; set; }
        public string alt { get; set; }
        public string description { get; set; }
        public int order { get; set; }
        public string url { get; set; }

    }
}