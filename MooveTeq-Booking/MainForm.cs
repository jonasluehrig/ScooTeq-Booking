using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Windows.Forms;

namespace ScooTeqBooking {
    public partial class MainForm : Form {
        public bool DisallowClosing = false;

        public MainForm() {
            InitializeComponent();

            ChangeView(new Pages.LoginOrRegister(this));

            if (! File.Exists("Customers.sqlite")) {
                using (var db = new Data.DatabaseContext()) {
                    db.Database?.Migrate();
                }
            }
        }

        public void ChangeView(Control nextControl)
        {
            _ = nextControl ?? throw new ArgumentNullException(nameof(nextControl));

            this.Controls.Clear();
            this.Controls.Add(nextControl);
            this.ClientSize = nextControl.Size;
            this.Text = string.IsNullOrEmpty(nextControl.Text) ? this.Text : nextControl.Text;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (DisallowClosing && e.CloseReason == CloseReason.UserClosing) {
                MessageBox.Show(this, "Die aktuelle Fahrt muss vor dem Schließen des Programmes beendet und abgerechnet werden!", "ScooTeq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
    }
}
