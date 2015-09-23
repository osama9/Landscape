using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LandscapeModels
{
    public interface ILandscapeContext : IDisposable
    {
        DbSet<Agent> Agents { get; set; }
        DbSet<AgentOffice> AgentOffices { get; set; }
        DbSet<Building> Buildings { get; set; }
        DbSet<BuildingDetails> BuildingDetails { get; set; }
        DbSet<BuildingAttributesMaster> BuildingAttributesMasters { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<House> Houses { get; set; }
        DbSet<HouseDetails> HouseDetails { get; set; }
        DbSet<HouseAttributesMaster> HouseAttributesMasters { get; set; }
        DbSet<HouseType> HouseTypes { get; set; }
        DbSet<Agreement> Agreements { get; set; }
        DbSet<Landlord> Landlords { get; set; }
        DbSet<Nationality> Nationalities { get; set; }
        DbSet<PaymentSchedule> PaymentSchedules { get; set; }
        DbSet<Tenant> Tenants { get; set; }
        DbSet<ContractPayment> ContractPayments { get; set; }
        DbSet<ContractType> ContractType { get; set; }

        Task<int> SaveChangesAsync(CancellationToken requestAborted);


    }
}
