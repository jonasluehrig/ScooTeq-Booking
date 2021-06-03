﻿using System;
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

namespace MooveTeqBooking {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            InitDatabase();

            ChangeView(new Pages.LoginOrRegister(this));
        }

        public void ChangeView(Control NextControl) {
            Controls.Clear();
            Controls.Add(NextControl);
            ClientSize = NextControl.Size;
            Text = NextControl.Text;
        }

        void InitDatabase() {
            if (!File.Exists("Customers.sqlite")) {
                using (var db = new Data.DatabaseContext()) {
                    db.Database.Migrate();

                    db.Add(
                        new Data.Customer() {
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
                            db.Add(Data.DummyCustomer.GetRandomDummy(rnd));
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
