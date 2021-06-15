using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Windows.Forms;

namespace ScooTeqBooking {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            ChangeView(new Pages.LoginOrRegister(this));

            if (File.Exists("Customers.sqlite")) return;

            using (var db = new Data.DatabaseContext())
            {
                db.Database?.Migrate();
            }
        }

        public void ChangeView(Control nextControl)
        {
            _ = nextControl ?? throw new ArgumentNullException(nameof(nextControl));

            Controls.Clear();
            Controls.Add(nextControl);
            ClientSize = nextControl.Size;
            Text = nextControl.Text;
        }
    }
}
