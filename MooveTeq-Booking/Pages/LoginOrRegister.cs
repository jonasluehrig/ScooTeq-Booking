using System;
using System.Windows.Forms;
using MooveTeqBooking.Data;
using System.Linq;

namespace MooveTeqBooking.Pages {
    public partial class LoginOrRegister : UserControl {
        private MainForm _parent;
        
        public LoginOrRegister(MainForm Parent) {
            InitializeComponent();

            _parent = Parent;
        }

        private async void loginButton_Click(object sender, System.EventArgs e) {
            Customer customer;

            using (var db = new DatabaseContext()) {
                var customers = (from c in db.Customers where (c.UserName == loginUsername.Text) select c);

                customer = customers.Count() == 1 ? customers.First() : null;
            }

            if(customer is null) {
                MessageBox.Show(this, "Benutzer nicht gefunden.", "Anmeldefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!PasswordHashing.TestPasswordAgainstHash(loginPassword.Text, customer.PasswordHash)) {
                MessageBox.Show(this, "Das angegebene Password ist falsch.", "Anmeldefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _parent.ChangeView(new TimeDistanceChoice(_parent, customer));
        }
    }
}
