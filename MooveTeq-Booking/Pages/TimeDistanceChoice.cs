using System;
using ScooTeqBooking.Data;
using System.Windows.Forms;

namespace ScooTeqBooking.Pages {
    public partial class TimeDistanceChoice : UserControl {
        private readonly MainForm parent;

        public TimeDistanceChoice(MainForm parent) {
            this.parent = parent;
        }

        private readonly Customer customer;
        private UserManagement userManagement;

        public TimeDistanceChoice(MainForm parent, Customer customer) {
            InitializeComponent();
            this.parent = parent;
            this.customer = customer;
        }

        private void TimeDistanceChoice_Load(object sender, EventArgs e) {
            welcomeMessageLabel.Text = $"Willkommen, {customer.FirstName} {customer.LastName}!";
            usernameLabel.Text = customer.UserName;
            adminMenu.Visible = customer.IsAdmin;
        }

        private void logoutButton_Click(object sender, EventArgs e) {
            if (!(userManagement is null)) {
                userManagement.Close();
            }

            parent.ChangeView(new LoginOrRegister(parent));
        }

        private void bookByTimeButton_Click(object sender, EventArgs e) {
            if (!(userManagement is null)) {
                userManagement.Close();
            }

            parent.ChangeView(new BookByTime(parent, customer));
        }

        private void bookByDistanceButton_Click(object sender, EventArgs e) {
            if (!(userManagement is null)) {
                userManagement.Close();
            }

            parent.ChangeView(new BookByDistance(parent, customer));
        }

        private void openUserManagementButton_Click(object sender, EventArgs e) {
            if (userManagement is null) {
                userManagement = new UserManagement(SetUserManagementNull);
                userManagement.Show();
            } else {
                userManagement.Focus();
            }
        }

        private void SetUserManagementNull(object sender, EventArgs e) {
            userManagement = null;
        }
    }
}
