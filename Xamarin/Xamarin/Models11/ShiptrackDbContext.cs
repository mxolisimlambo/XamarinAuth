using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models
{
    public class ShiptrackDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public ShiptrackDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<DeliveryItem>().HasOne(d => d.DeliveryAddress)
                                          .WithMany(a => a.Deliveries)
                                          .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<DeliveryItem>().HasOne(a => a.PickupAddress)
                                          .WithMany(b => b.Pickups)
                                          .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Trip>().HasOne(a => a.StartAddress)
                                  .WithMany(b => b.TripsStart)
                                  .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Trip>().HasOne(a => a.EndAddress)
                                  .WithMany(b => b.TripsEnd)
                                  .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<DeliveryNote>().HasOne(a => a.Trip)
                                          .WithMany(b => b.DeliveryNotes)
                                          .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<DeliveryItemScan>().HasOne(a => a.DeliveryItem)
                                          .WithMany(b => b.DeliveryItemScans)
                                          .OnDelete(DeleteBehavior.NoAction);

        }

        public DbSet<AppModule> AppModules { get; set; }
        public DbSet<AppSection> AppSections { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<CityTown> Cities { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<DeliveryItem> DeliveryItems { get; set; }
        public DbSet<DeliveryItemScan> DeliveryItemScans { get; set; }
        public DbSet<DeliveryNote> DeliveryNotes { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<TripIncident> TripIncidents { get; set; }
        public DbSet<IncidentOutcome> IncidentOutcomes { get; set; }
        public DbSet<RoleModuleRight> RoleModuleRights { get; set; }
        public DbSet<RoleSectionRight> RoleSectionRights { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<TimeShift> TimeShifts { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<EndPoint> TripPlan { get; set; }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<TruckModel> TruckModels { get; set; }
        public DbSet<UserModuleRight> UserModuleRights { get; set; }
        public DbSet<UserSectionRight> UserSectionRights { get; set; }
        //public DbSet<EmployeeTest> EmployeeTest { get; set; }


    }
}
