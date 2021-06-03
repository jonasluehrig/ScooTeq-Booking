using Microsoft.EntityFrameworkCore;

namespace EFTest.Data {
    public class DatabaseContext : DbContext {
        public DbSet<Data.Customer> Customers { get; set; }
        public DbSet<Data.Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlite($"Data Source=Customers.sqlite");
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<DataTypes.Customer>()
                .HasIndex(c => c.UserName)
                .IsUnique();

            builder.Entity<DataTypes.Customer>()
                .Property(c => c.UserName)
                .HasColumnType("TEXT COLLATE NOCASE");
        }
    }
}
