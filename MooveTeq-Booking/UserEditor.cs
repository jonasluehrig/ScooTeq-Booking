using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MooveTeqBooking.Data;

namespace MooveTeqBooking {
    public partial class UserEditor : Form {
        public Customer EditedCustomer { get; internal set; }
        
        public UserEditor(Customer customer) {
            InitializeComponent();
            EditedCustomer = customer;
        }

        private void UserEditor_Load(object sender, EventArgs e) {
            usernameTextbox.Text = EditedCustomer.UserName;
            firstnameTextbox.Text = EditedCustomer.FirstName;
            lastnameTextbox.Text = EditedCustomer.LastName;
            isAdminCheckbox.Checked = EditedCustomer.IsAdmin;
        }

        private void saveChangesButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(usernameTextbox.Text)) {
                MessageBox.Show(this, "Der Benutzername darf nicht leer sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(firstnameTextbox.Text)) {
                MessageBox.Show(this, "Der Vorname darf nicht leer sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(lastnameTextbox.Text)) {
                MessageBox.Show(this, "Der Nachname darf nicht leer sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EditedCustomer.UserName = usernameTextbox.Text;
            EditedCustomer.FirstName = firstnameTextbox.Text;
            EditedCustomer.LastName = lastnameTextbox.Text;
            EditedCustomer.IsAdmin = isAdminCheckbox.Checked;

            Close();
        }
    }
}
