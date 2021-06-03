using Microsoft.EntityFrameworkCore;

namespace MooveTeqBooking.Data {
    public class DatabaseContext : DbContext {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlite($"Data Source=Customers.sqlite");
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Customer>()
                .HasIndex(c => c.UserName)
                .IsUnique();

            builder.Entity<Customer>()
                .Property(c => c.UserName)
                .HasColumnType("TEXT COLLATE NOCASE");
        }
    }
}
