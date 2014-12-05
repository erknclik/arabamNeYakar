using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public class CarComment
    {
        public int ID { get; set; }
        public DateTime commentDate { get; set; }
        public User user { get; set; }
        public int point { get; set; }
        public string comment { get; set; }
        public int weight { get; set; }
        public string season { get; set; }
        public int fuelConsCity { get; set; }
        public int fuelConsLongTerm { get; set; }

    }
}