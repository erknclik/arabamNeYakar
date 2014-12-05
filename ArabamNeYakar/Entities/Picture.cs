using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public partial class Picture
    {
        public Picture()
        {
            this.carpictures = new HashSet<CarPicture>();
        }
    
        public int id { get; set; }
        public string alt { get; set; }
        public string desc { get; set; }
        public string url { get; set; }
        public int order { get; set; }
        public short version { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string updateUserName { get; set; }
        public Nullable<short> status { get; set; }
    
        public virtual ICollection<CarPicture> carpictures { get; set; }

    }
}