namespace ArabamNeYakar
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using ArabamNeYakar.Entities;

    public partial class ArabamNeYakarContext : DbContext
    {
        public ArabamNeYakarContext()
            : base("name=ArabamNeYakarContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Car> cars { get; set; }
        public DbSet<CarComment> carComments { get; set; }
        public DbSet<CarPicture> carPictures { get; set; }
        public DbSet<CatalogueInfo> catalogueInfos { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<FuelRate> fuelRates { get; set; }
        public DbSet<FuelType> fuelTypes { get; set; }
        public DbSet<HatchType> hatchTypes { get; set; }
        public DbSet<Picture> pictures { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<User> users { get; set; }
        //public DbSet<UserRole> userRoles { get; set; }


    }
}
