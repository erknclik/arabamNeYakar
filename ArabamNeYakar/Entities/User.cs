using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabamNeYakar.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool passive { get; set; }
        public DateTime lastLogin { get; set; }
        public string email { get; set; }
        public UserRole userRole { get; set; }
        public ExperiencedCar ownCars { get; set; }



    }
}