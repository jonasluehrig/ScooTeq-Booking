using MooveTeqBooking.Data;
using System.Windows.Forms;

namespace MooveTeqBooking.Pages {
    public partial class TimeDistanceChoice : UserControl {
        private MainForm _parent;
        private Customer _customer;
        
        public TimeDistanceChoice(MainForm parent, Customer customer) {
            InitializeComponent();
            _customer = customer;
        }
    }
}
