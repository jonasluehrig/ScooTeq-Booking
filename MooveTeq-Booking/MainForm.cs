using System.Windows.Forms;

namespace MooveTeqBooking {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            ChangeView(new Pages.LoginOrRegister(this));
        }

        public void ChangeView(Control nextControl) {
            Controls.Clear();
            Controls.Add(nextControl);
            ClientSize = nextControl.Size;
            Text = nextControl.Text;
        }
    }
}
