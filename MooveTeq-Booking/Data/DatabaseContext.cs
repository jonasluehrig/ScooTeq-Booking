using System;
using Bogus;
using Microsoft.EntityFrameworkCore;

namespace MooveTeqBooking.Data
{
    public class DatabaseContext : DbContext {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            _ = options ?? throw new ArgumentNullException(nameof(options));
            options.UseSqlite($"Data Source=Customers.sqlite");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.Entity<Customer>()
                ?.HasIndex(c => c.UserName)
                ?.IsUnique();

            (builder.Entity<Customer>()
                    ?.Property(c => c.UserName) ?? throw new InvalidOperationException())
                .HasColumnType("TEXT COLLATE NOCASE");

            var testUserPasswordHash = PasswordHashing.GetPasswordHash("password");

            var customerId = 2;
            var testUsers = new Faker<Data.Customer>()
                .RuleFor(x => x.CustomerId, f => customerId++)
                ?.RuleFor(x => x.FirstName, f => f?.Person?.FirstName)
                ?.RuleFor(x => x.LastName, f => f?.Person?.LastName)
                ?.RuleFor(x => x.UserName, f => f?.Person?.UserName)
                ?.RuleFor(x => x.PasswordHash, f => testUserPasswordHash);

            var z = testUsers?.Generate(100);

            builder
                .Entity<Customer>()
                ?.HasData(
                    new Data.Customer() {
                        CustomerId = 1,
                        UserName = "admin",
                        FirstName = "Demo",
                        LastName = "Admin",
                        PasswordHash = PasswordHashing.GetPasswordHash("admin"),
                        IsAdmin = true
                    });

            builder
                .Entity<Customer>()
                ?.HasData(z ?? throw new InvalidOperationException());
        }
    }
}
