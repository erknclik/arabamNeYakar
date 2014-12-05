using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public partial class CarPicture
    {
        public int id { get; set; }
        public Nullable<int> picture_id { get; set; }
        public Nullable<int> catalogueinfo_id { get; set; }
        public short version { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string updateUserName { get; set; }
        public Nullable<short> status { get; set; }
    
        public virtual CatalogueInfo catalogueinfos { get; set; }
        public virtual Picture pictures { get; set; }

    }
}