using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Windows.Forms;

namespace MooveTeqBooking {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            ChangeView(new Pages.LoginOrRegister(this));

            if (!File.Exists("Customers.sqlite")) {
                using (var db = new Data.DatabaseContext()) {
                    db.Database.Migrate();
                }
            }
        }

        public void ChangeView(Control nextControl) {
            Controls.Clear();
            Controls.Add(nextControl);
            ClientSize = nextControl.Size;
            Text = nextControl.Text;
        }

        private void button1_Click(object sender, System.EventArgs e) {
            new DistanceChooser(null).Show();
        }
    }
}
