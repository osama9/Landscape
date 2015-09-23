namespace LandscapeModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AgentOffices",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        AddressLineOne = c.String(),
                        AddressLineTwo = c.String(),
                        Latitude = c.String(),
                        Longitude = c.String(),
                        PinNumber = c.Int(),
                        PhoneNumberOne = c.String(maxLength: 10),
                        PhoneNumberTwo = c.String(maxLength: 10),
                        MobileNumber = c.String(maxLength: 10),
                        LandlineNumber = c.Int(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                        City_Id = c.Guid(),
                        Agent_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .ForeignKey("dbo.Agents", t => t.Agent_Id)
                .Index(t => t.City_Id)
                .Index(t => t.Agent_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EnglishName = c.String(),
                        ArabicName = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                        Country_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnglishName = c.String(),
                        ArabicName = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Agents",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Email = c.String(),
                        FirstName = c.String(maxLength: 30),
                        LastName = c.String(maxLength: 30),
                        Address = c.String(),
                        MobileNumber = c.String(maxLength: 10),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Agreements",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        AgreementDate = c.DateTime(nullable: false),
                        AgreementStartDate = c.DateTime(nullable: false),
                        AgreementEndDate = c.DateTime(nullable: false),
                        Deposit = c.Int(),
                        RentAmount = c.Int(nullable: false),
                        PaidAmount = c.Int(nullable: false),
                        AgreementWith = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                        Agent_Id = c.Guid(),
                        Landlord_Id = c.Guid(),
                        House_Id = c.Guid(),
                        PaymentSchedule_Id = c.Guid(),
                        Tenant_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Agents", t => t.Agent_Id)
                .ForeignKey("dbo.Landlords", t => t.Landlord_Id)
                .ForeignKey("dbo.Houses", t => t.House_Id)
                .ForeignKey("dbo.PaymentSchedules", t => t.PaymentSchedule_Id)
                .ForeignKey("dbo.Tenants", t => t.Tenant_Id)
                .Index(t => t.Agent_Id)
                .Index(t => t.Landlord_Id)
                .Index(t => t.House_Id)
                .Index(t => t.PaymentSchedule_Id)
                .Index(t => t.Tenant_Id);
            
            CreateTable(
                "dbo.ContractPayments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Amount = c.Int(nullable: false),
                        PaymentDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                        ContractType_Id = c.Guid(),
                        Agreement_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContractTypes", t => t.ContractType_Id)
                .ForeignKey("dbo.Agreements", t => t.Agreement_Id)
                .Index(t => t.ContractType_Id)
                .Index(t => t.Agreement_Id);
            
            CreateTable(
                "dbo.ContractTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        NameAr = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Landlords",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(maxLength: 10),
                        MobileNumber1 = c.String(maxLength: 10),
                        BankName = c.String(),
                        BankAccountNumber = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                        Building_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buildings", t => t.Building_Id)
                .Index(t => t.Building_Id);
            
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        HouseNo = c.String(),
                        FloorNo = c.Byte(nullable: false),
                        FlatRegisteryNumber = c.String(),
                        FlatRegisteryDate = c.DateTime(nullable: false),
                        FlatElectricityNumber = c.String(),
                        NumberOfRooms = c.Byte(nullable: false),
                        NumberOfToilets = c.Byte(nullable: false),
                        BasePrice = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                        HouseType_Id = c.Guid(),
                        Landlord_Id = c.Guid(),
                        Building_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HouseTypes", t => t.HouseType_Id)
                .ForeignKey("dbo.Landlords", t => t.Landlord_Id)
                .ForeignKey("dbo.Buildings", t => t.Building_Id)
                .Index(t => t.HouseType_Id)
                .Index(t => t.Landlord_Id)
                .Index(t => t.Building_Id);
            
            CreateTable(
                "dbo.HouseDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Description = c.String(),
                        SpaceDetails = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                        House_Id = c.Guid(),
                        HouseAttributesMaster_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Houses", t => t.House_Id)
                .ForeignKey("dbo.HouseAttributesMasters", t => t.HouseAttributesMaster_Id)
                .Index(t => t.House_Id)
                .Index(t => t.HouseAttributesMaster_Id);
            
            CreateTable(
                "dbo.HouseAttributesMasters",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Description = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HouseTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Description = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PaymentSchedules",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Schedule = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tenants",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        IDScanImage = c.String(),
                        SponsorFirstName = c.String(),
                        SponsorLastName = c.String(),
                        MobileNumber = c.String(maxLength: 10),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                        Nationality_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Nationalities", t => t.Nationality_Id)
                .Index(t => t.Nationality_Id);
            
            CreateTable(
                "dbo.Nationalities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArabicName = c.String(),
                        EnglishName = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BuildingAttributesMasters",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Description = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BuildingDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Description = c.String(),
                        SpaceDetail = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                        Building_Id = c.Guid(),
                        BuildingAttributesMaster_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buildings", t => t.Building_Id)
                .ForeignKey("dbo.BuildingAttributesMasters", t => t.BuildingAttributesMaster_Id)
                .Index(t => t.Building_Id)
                .Index(t => t.BuildingAttributesMaster_Id);
            
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        RegisteryNumber = c.String(),
                        Address = c.String(),
                        Latitude = c.String(),
                        Longitude = c.String(),
                        NumberOfFloors = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                        City_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.BuildingDetails", "BuildingAttributesMaster_Id", "dbo.BuildingAttributesMasters");
            DropForeignKey("dbo.Landlords", "Building_Id", "dbo.Buildings");
            DropForeignKey("dbo.Houses", "Building_Id", "dbo.Buildings");
            DropForeignKey("dbo.Buildings", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.BuildingDetails", "Building_Id", "dbo.Buildings");
            DropForeignKey("dbo.AgentOffices", "Agent_Id", "dbo.Agents");
            DropForeignKey("dbo.Tenants", "Nationality_Id", "dbo.Nationalities");
            DropForeignKey("dbo.Agreements", "Tenant_Id", "dbo.Tenants");
            DropForeignKey("dbo.Agreements", "PaymentSchedule_Id", "dbo.PaymentSchedules");
            DropForeignKey("dbo.Houses", "Landlord_Id", "dbo.Landlords");
            DropForeignKey("dbo.Houses", "HouseType_Id", "dbo.HouseTypes");
            DropForeignKey("dbo.HouseDetails", "HouseAttributesMaster_Id", "dbo.HouseAttributesMasters");
            DropForeignKey("dbo.HouseDetails", "House_Id", "dbo.Houses");
            DropForeignKey("dbo.Agreements", "House_Id", "dbo.Houses");
            DropForeignKey("dbo.Agreements", "Landlord_Id", "dbo.Landlords");
            DropForeignKey("dbo.ContractPayments", "Agreement_Id", "dbo.Agreements");
            DropForeignKey("dbo.ContractPayments", "ContractType_Id", "dbo.ContractTypes");
            DropForeignKey("dbo.Agreements", "Agent_Id", "dbo.Agents");
            DropForeignKey("dbo.AgentOffices", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Cities", "Country_Id", "dbo.Countries");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Buildings", new[] { "City_Id" });
            DropIndex("dbo.BuildingDetails", new[] { "BuildingAttributesMaster_Id" });
            DropIndex("dbo.BuildingDetails", new[] { "Building_Id" });
            DropIndex("dbo.Tenants", new[] { "Nationality_Id" });
            DropIndex("dbo.HouseDetails", new[] { "HouseAttributesMaster_Id" });
            DropIndex("dbo.HouseDetails", new[] { "House_Id" });
            DropIndex("dbo.Houses", new[] { "Building_Id" });
            DropIndex("dbo.Houses", new[] { "Landlord_Id" });
            DropIndex("dbo.Houses", new[] { "HouseType_Id" });
            DropIndex("dbo.Landlords", new[] { "Building_Id" });
            DropIndex("dbo.ContractPayments", new[] { "Agreement_Id" });
            DropIndex("dbo.ContractPayments", new[] { "ContractType_Id" });
            DropIndex("dbo.Agreements", new[] { "Tenant_Id" });
            DropIndex("dbo.Agreements", new[] { "PaymentSchedule_Id" });
            DropIndex("dbo.Agreements", new[] { "House_Id" });
            DropIndex("dbo.Agreements", new[] { "Landlord_Id" });
            DropIndex("dbo.Agreements", new[] { "Agent_Id" });
            DropIndex("dbo.Cities", new[] { "Country_Id" });
            DropIndex("dbo.AgentOffices", new[] { "Agent_Id" });
            DropIndex("dbo.AgentOffices", new[] { "City_Id" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Buildings");
            DropTable("dbo.BuildingDetails");
            DropTable("dbo.BuildingAttributesMasters");
            DropTable("dbo.Nationalities");
            DropTable("dbo.Tenants");
            DropTable("dbo.PaymentSchedules");
            DropTable("dbo.HouseTypes");
            DropTable("dbo.HouseAttributesMasters");
            DropTable("dbo.HouseDetails");
            DropTable("dbo.Houses");
            DropTable("dbo.Landlords");
            DropTable("dbo.ContractTypes");
            DropTable("dbo.ContractPayments");
            DropTable("dbo.Agreements");
            DropTable("dbo.Agents");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.AgentOffices");
        }
    }
}
