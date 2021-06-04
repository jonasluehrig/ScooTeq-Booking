using MooveTeqBooking.Data;
using System.Windows.Forms;
using System;

namespace MooveTeqBooking.Pages {
    public partial class BookByTime : UserControl {
        MainForm _parent;
        Customer _customer;

        Timer _timer = new Timer() {
            Interval = 1000
        };

        DateTime _startTime;

        public BookByTime(MainForm parent, Customer customer) {
            InitializeComponent();

            _parent = parent;
            _customer = customer;
        }

        private void BookByTime_Load(object sender, EventArgs e) { 
        }

        private void timer_Tick(object sender, EventArgs e) {
            timerLabel.Text = (DateTime.Now - _startTime).ToString("hh':'mm':'ss");
        }

        private void startCounterButton_Click(object sender, EventArgs e) {
            _timer.Tick += new EventHandler(timer_Tick);
            _timer.Start();
            _startTime = DateTime.Now;
            startCounterButton.Enabled = false;
            stopCounterButton.Enabled = true;
        }
    }
}
