using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore; 

namespace EFTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            if (!File.Exists("Customers.sqlite")) {
                using (var db = new DatabaseContext()) {
                    db.Database.Migrate();

                    db.Add(
                        new DataTypes.Customer() {
                            UserName = "admin",
                            FirstName = "Demo",
                            LastName = "Admin",
                            PasswordHash = "cYnsvE5m+9OpbgOK69x76wozBJuYV5Jm:uccBM5nX041hFULOsL/1adJg+UmY5/Jy61iV1QP6xiWX6eTwuxGJ81Dlal8y0gtVYaXE26orCGU+gNxeKZbx1Q==", // Password!
                            IsAdmin = true
                        }
                    );

                    var rnd = new Random();

                    for (int i = 1; i <= 10; i++) {
                        db.Add(DummyCustomer.GetRandomDummy(rnd));
                    }

                    db.Add(
                        new DataTypes.Customer() {
                            UserName = "admin",
                            FirstName = "Demo",
                            LastName = "Admin",
                            PasswordHash = "cYnsvE5m+9OpbgOK69x76wozBJuYV5Jm:uccBM5nX041hFULOsL/1adJg+UmY5/Jy61iV1QP6xiWX6eTwuxGJ81Dlal8y0gtVYaXE26orCGU+gNxeKZbx1Q==", // Password!
                            IsAdmin = true
                        }
                    );

                    db.SaveChanges();
                }
            }
        }

        public class DatabaseContext : DbContext {
            public DbSet<DataTypes.Customer> Customers { get; set; }
            public DbSet<DataTypes.Booking> Bookings { get; set; }

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
}
