using Aero_booking_system.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aero_booking_system.DAL
{
    public class BsDbContext : DbContext
    {
        public BsDbContext(DbContextOptions<BsDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public BsDbContext()
        {

        }

        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<RestaurantEntity> Restaurants { get; set; }
        public DbSet<OrderTablesEntity> OrderTables { get; set; }
    }
}

