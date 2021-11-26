using HotVagoDAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoDAL.DAO.Context
{
    public class HotVagoContext : IdentityDbContext
    {
        public HotVagoContext(DbContextOptions<HotVagoContext> options)
            : base(options)
        { 

        }

        public HotVagoContext()
            : base()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=Hotvago;user=root;password=root", 
                b => b.MigrationsAssembly("HotVago"));
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Guests> Guests { get; set; }

        public DbSet<Payments> Payments { get; set; }
        public DbSet<PaymentTypes> PaymentTypes { get; set; }
        public DbSet<Property> Property { get; set; }

        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomsBooked> BookedRooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }

        public DbSet<Facilities> Facilities { get; set; }
        public DbSet<FacilityType> FacilityTypes { get; set; }

        public DbSet<RoomFacilities> RoomFacilities { get; set; }

    }
}
