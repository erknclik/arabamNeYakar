using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public class News
    {
        public int ID { get; set; }
        public DateTime publishDate { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string imageURL { get; set; }

    }
}