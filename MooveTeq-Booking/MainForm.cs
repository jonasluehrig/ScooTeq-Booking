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
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            InitDatabase();
        }

        void InitDatabase() {
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
                        try {
                            db.Add(DummyCustomer.GetRandomDummy(rnd));
                        } catch (Exception) {
                            i--;
                        }
                    }

                    db.SaveChanges();
                }
            }
        }

        
    }
}
