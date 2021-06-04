using Microsoft.EntityFrameworkCore;

namespace MooveTeqBooking.Data
{
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

            /*var customerId = 2;
            var testUsers = new Faker<Data.Customer>()
                .RuleFor(x => x.CustomerId, f => customerId++)
                .RuleFor(x => x.FirstName, f => f.Person.FirstName)
                .RuleFor(x => x.LastName, f => f.Person.LastName)
                .RuleFor(x => x.UserName, f => f.Person.UserName)
                .RuleFor(x => x.PasswordHash, f => PasswordHashing.GetPasswordHash("password"));

            var z = testUsers.Generate(100);

            builder
                .Entity<Customer>()
                .HasData(
                    new Data.Customer() {
                        CustomerId = 1,
                        UserName = "admin",
                        FirstName = "Demo",
                        LastName = "Admin",
                        PasswordHash = "cYnsvE5m+9OpbgOK69x76wozBJuYV5Jm:uccBM5nX041hFULOsL/1adJg+UmY5/Jy61iV1QP6xiWX6eTwuxGJ81Dlal8y0gtVYaXE26orCGU+gNxeKZbx1Q==", // Password!
                        IsAdmin = true
                    }
                );

            builder
                .Entity<Customer>()
                .HasData(z);*/
        }
    }
}
