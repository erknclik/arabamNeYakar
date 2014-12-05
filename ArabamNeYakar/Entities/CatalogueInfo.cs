using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public class CatalogueInfo
    {

        public int ID { get; set; }
        public int cylinder { get; set; }
        public int engineHP { get; set; }
        public string wheelDrive { get; set; }
        public int fuelConsCity { get; set; }
        public int fuelConsLongTerm { get; set; }
        public ICollection<CarPicture> carPictures { get; set; }
        public int weight { get; set; }

    }
}