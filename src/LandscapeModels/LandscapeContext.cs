using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeModels
{
    public class LandscapeContext : IdentityDbContext<ApplicationUser>, ILandscapeContext
    {
        public LandscapeContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static LandscapeContext Create()
        {
            return new LandscapeContext();
        }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<AgentOffice> AgentOffices { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<BuildingDetails> BuildingDetails { get; set; }
        public DbSet<BuildingAttributesMaster> BuildingAttributesMasters { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<HouseDetails> HouseDetails { get; set; }
        public DbSet<HouseAttributesMaster> HouseAttributesMasters { get; set; }
        public DbSet<HouseType> HouseTypes { get; set; }
        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<Landlord> Landlords { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<PaymentSchedule> PaymentSchedules { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<ContractPayment> ContractPayments { get; set; }
        public DbSet<ContractType> ContractType { get; set; }


    }
}
