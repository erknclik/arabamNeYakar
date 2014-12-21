namespace ArabamNeYakar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        origin = c.Int(),
                        name = c.String(),
                        version = c.Short(nullable: false),
                        updateDate = c.DateTime(),
                        updateUserName = c.String(),
                        status = c.Short(),
                        countries_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Countries", t => t.countries_id)
                .Index(t => t.countries_id);
            
            CreateTable(
                "dbo.CarModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        brand_id = c.Int(),
                        hatchtype_id = c.Int(),
                        name = c.String(),
                        version = c.Short(nullable: false),
                        updateDate = c.DateTime(),
                        updateUserName = c.String(),
                        status = c.Short(),
                        brands_id = c.Int(),
                        hatchtypes_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Brands", t => t.brands_id)
                .ForeignKey("dbo.HatchTypes", t => t.hatchtypes_id)
                .Index(t => t.brands_id)
                .Index(t => t.hatchtypes_id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        model_id = c.Int(),
                        hatchtype_id = c.Int(),
                        fueltype_id = c.Int(),
                        catalogueinfo_id = c.Int(),
                        version = c.Short(nullable: false),
                        updateDate = c.DateTime(),
                        updateUserName = c.String(),
                        status = c.Short(),
                        carmodels_id = c.Int(),
                        catalogueinfos_id = c.Int(),
                        fueltypes_id = c.Int(),
                        hatchtypes_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.CarModels", t => t.carmodels_id)
                .ForeignKey("dbo.CatalogueInfoes", t => t.catalogueinfos_id)
                .ForeignKey("dbo.FuelTypes", t => t.fueltypes_id)
                .ForeignKey("dbo.HatchTypes", t => t.hatchtypes_id)
                .Index(t => t.carmodels_id)
                .Index(t => t.catalogueinfos_id)
                .Index(t => t.fueltypes_id)
                .Index(t => t.hatchtypes_id);
            
            CreateTable(
                "dbo.CarComments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        owneruser_id = c.Int(),
                        car_id = c.Int(),
                        commentDate = c.DateTime(nullable: false),
                        comment = c.String(),
                        season = c.String(),
                        weight = c.Int(nullable: false),
                        fuelConsCity = c.Int(nullable: false),
                        fuelConsLongTerm = c.Int(nullable: false),
                        version = c.Short(nullable: false),
                        updateDate = c.DateTime(),
                        updateUserName = c.String(),
                        status = c.Short(),
                        cars_id = c.Int(),
                        users_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Cars", t => t.cars_id)
                .ForeignKey("dbo.Users", t => t.users_id)
                .Index(t => t.cars_id)
                .Index(t => t.users_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userName = c.String(nullable: false),
                        password = c.String(nullable: false),
                        passive = c.Boolean(),
                        lastLogin = c.DateTime(),
                        email = c.String(nullable: false),
                        version = c.Short(nullable: false),
                        updateDate = c.DateTime(),
                        updateUserName = c.String(),
                        status = c.Short(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        version = c.Short(nullable: false),
                        updateDate = c.DateTime(),
                        updateUserName = c.String(),
                        status = c.Short(),
                        roles_id = c.Int(),
                        users_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Roles", t => t.roles_id)
                .ForeignKey("dbo.Users", t => t.users_id)
                .Index(t => t.roles_id)
                .Index(t => t.users_id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                        version = c.Short(nullable: false),
                        updateDate = c.DateTime(),
                        updateUserName = c.String(),
                        status = c.Short(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CatalogueInfoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        engineHP = c.Int(nullable: false),
                        weightInKg = c.Int(nullable: false),
                        fuelConsCity = c.Int(nullable: false),
                        fuelConsLongTerm = c.Int(nullable: false),
                        wheelDrive = c.String(),
                        version = c.Short(nullable: false),
                        updateDate = c.DateTime(),
                        updateUserName = c.String(),
                        status = c.Short(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CarPictures",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        picture_id = c.Int(),
                        catalogueinfo_id = c.Int(),
                        version = c.Short(nullable: false),
                        updateDate = c.DateTime(),
                        updateUserName = c.String(),
                        status = c.Short(),
                        catalogueinfos_id = c.Int(),
                        pictures_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.CatalogueInfoes", t => t.catalogueinfos_id)
                .ForeignKey("dbo.Pictures", t => t.pictures_id)
                .Index(t => t.catalogueinfos_id)
                .Index(t => t.pictures_id);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        alt = c.String(),
                        desc = c.String(),
                        url = c.String(),
                        order = c.Int(nullable: false),
                        version = c.Short(nullable: false),
                        updateDate = c.DateTime(),
                        updateUserName = c.String(),
                        status = c.Short(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.FuelTypes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        version = c.Short(nullable: false),
                        updateDate = c.DateTime(),
                        updateUserName = c.String(),
                        status = c.Short(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.FuelRates",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fueltype_id = c.Int(),
                        city_id = c.Int(),
                        rateDate = c.DateTime(nullable: false),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        version = c.Short(nullable: false),
                        updateDate = c.DateTime(),
                        updateUserName = c.String(),
                        status = c.Short(),
                        cities_id = c.Int(),
                        fueltypes_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Cities", t => t.cities_id)
                .ForeignKey("dbo.FuelTypes", t => t.fueltypes_id)
                .Index(t => t.cities_id)
                .Index(t => t.fueltypes_id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        country_id = c.Int(),
                        code = c.String(),
                        name = c.String(),
                        version = c.Short(nullable: false),
                        updateDate = c.DateTime(),
                        updateUserName = c.String(),
                        status = c.Short(),
                        countries_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Countries", t => t.countries_id)
                .Index(t => t.countries_id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(),
                        name = c.String(),
                        version = c.Short(nullable: false),
                        updateDate = c.DateTime(),
                        updateUserName = c.String(),
                        status = c.Short(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.HatchTypes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        version = c.Short(nullable: false),
                        updateDate = c.DateTime(),
                        updateUserName = c.String(),
                        status = c.Short(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "hatchtypes_id", "dbo.HatchTypes");
            DropForeignKey("dbo.CarModels", "hatchtypes_id", "dbo.HatchTypes");
            DropForeignKey("dbo.FuelRates", "fueltypes_id", "dbo.FuelTypes");
            DropForeignKey("dbo.FuelRates", "cities_id", "dbo.Cities");
            DropForeignKey("dbo.Cities", "countries_id", "dbo.Countries");
            DropForeignKey("dbo.Brands", "countries_id", "dbo.Countries");
            DropForeignKey("dbo.Cars", "fueltypes_id", "dbo.FuelTypes");
            DropForeignKey("dbo.Cars", "catalogueinfos_id", "dbo.CatalogueInfoes");
            DropForeignKey("dbo.CarPictures", "pictures_id", "dbo.Pictures");
            DropForeignKey("dbo.CarPictures", "catalogueinfos_id", "dbo.CatalogueInfoes");
            DropForeignKey("dbo.Cars", "carmodels_id", "dbo.CarModels");
            DropForeignKey("dbo.UserRoles", "users_id", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "roles_id", "dbo.Roles");
            DropForeignKey("dbo.CarComments", "users_id", "dbo.Users");
            DropForeignKey("dbo.CarComments", "cars_id", "dbo.Cars");
            DropForeignKey("dbo.CarModels", "brands_id", "dbo.Brands");
            DropIndex("dbo.Cities", new[] { "countries_id" });
            DropIndex("dbo.FuelRates", new[] { "fueltypes_id" });
            DropIndex("dbo.FuelRates", new[] { "cities_id" });
            DropIndex("dbo.CarPictures", new[] { "pictures_id" });
            DropIndex("dbo.CarPictures", new[] { "catalogueinfos_id" });
            DropIndex("dbo.UserRoles", new[] { "users_id" });
            DropIndex("dbo.UserRoles", new[] { "roles_id" });
            DropIndex("dbo.CarComments", new[] { "users_id" });
            DropIndex("dbo.CarComments", new[] { "cars_id" });
            DropIndex("dbo.Cars", new[] { "hatchtypes_id" });
            DropIndex("dbo.Cars", new[] { "fueltypes_id" });
            DropIndex("dbo.Cars", new[] { "catalogueinfos_id" });
            DropIndex("dbo.Cars", new[] { "carmodels_id" });
            DropIndex("dbo.CarModels", new[] { "hatchtypes_id" });
            DropIndex("dbo.CarModels", new[] { "brands_id" });
            DropIndex("dbo.Brands", new[] { "countries_id" });
            DropTable("dbo.HatchTypes");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.FuelRates");
            DropTable("dbo.FuelTypes");
            DropTable("dbo.Pictures");
            DropTable("dbo.CarPictures");
            DropTable("dbo.CatalogueInfoes");
            DropTable("dbo.Roles");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Users");
            DropTable("dbo.CarComments");
            DropTable("dbo.Cars");
            DropTable("dbo.CarModels");
            DropTable("dbo.Brands");
        }
    }
}
