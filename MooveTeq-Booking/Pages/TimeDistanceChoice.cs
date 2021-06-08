using MooveTeqBooking.Data;
using System.Windows.Forms;

namespace MooveTeqBooking.Pages {
    public partial class TimeDistanceChoice : UserControl {
        private MainForm _parent;
        private Customer _customer;
        
        public TimeDistanceChoice(MainForm parent, Customer customer) {
            InitializeComponent();
            _parent = parent;
            _customer = customer;
        }

        private void TimeDistanceChoice_Load(object sender, System.EventArgs e) {
            welcomeMessageLabel.Text = $"Willkommen, {_customer.FirstName} {_customer.LastName}!";
            usernameLabel.Text = _customer.UserName;
            adminMenu.Visible = _customer.IsAdmin;
        }

        private void logoutButton_Click(object sender, System.EventArgs e) {
            _parent.ChangeView(new LoginOrRegister(_parent));
        }

        private void bookByTimeButton_Click(object sender, System.EventArgs e) {
            _parent.ChangeView(new BookByTime(_parent, _customer));
        }

        private void bookByDistanceButton_Click(object sender, System.EventArgs e) {
            _parent.ChangeView(new BookByDistance(_parent, _customer));
        }
    }
}
