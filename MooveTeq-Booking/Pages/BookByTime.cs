using ScooTeqBooking.Data;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace ScooTeqBooking.Pages {
    public partial class BookByTime : UserControl {
        MainForm _parent;
        Customer _customer;

        Timer _timer = new Timer() {
            Interval = 50
        };

        DateTime _startTime;
        DateTime _pauseStartTime;
        TimeSpan _totalPauseTime = new TimeSpan(0);

        public BookByTime(MainForm parent, Customer customer) {
            InitializeComponent();

            _parent = parent;
            _customer = customer;
        }

        private void BookByTime_Load(object sender, EventArgs e) {
            usernameLabel.Text = _customer.UserName;
            welcomeMessageLabel.Text = $"Gute Fahrt, {_customer.FirstName} {_customer.LastName}!";
            statusLabel.Text = "Drücke Start um die Fahrt zu beginnen.";

            timerLabel.MouseWheel += new MouseEventHandler((object _sender, MouseEventArgs _e) => {
                System.Diagnostics.Debug.Print(_e.Delta.ToString());
                _startTime -= new TimeSpan(0, 0, _e.Delta / 2);
            });
        }

        private void timer_Tick(object sender, EventArgs e) {
            timerLabel.Text = (DateTime.Now - _startTime - _totalPauseTime).ToString("hh':'mm':'ss");
        }

        private void startCounterButton_Click(object sender, EventArgs e) {
            _startTime = DateTime.Now;
            _timer.Tick += new EventHandler(timer_Tick);
            _timer.Start();
            stopCounterButton.Enabled = true;
            logoutButton.Enabled = false;

            statusLabel.Text = $"Fahrt um {_startTime.ToShortTimeString()} gestartet";

            startCounterButton.Text = "Pausieren";
            startCounterButton.ForeColor = Color.Orange;
            startCounterButton.Click -= startCounterButton_Click;
            startCounterButton.Click += pauseCounterButton_Click;
        }

        private void pauseCounterButton_Click(object sender, EventArgs e) {
            _pauseStartTime = DateTime.Now;
            _timer.Stop();
            startCounterButton.Text = "Weiter";
            statusLabel.Text = "Fahrt pausiert, Scooter gesperrt.\nDrücke auf Weiter um die Fahrt fortzusetzen";

            startCounterButton.Click -= pauseCounterButton_Click;
            startCounterButton.Click += resumeCounterButton_Click;
        }

        private void resumeCounterButton_Click(object sender, EventArgs e) {
            _totalPauseTime += DateTime.Now - _pauseStartTime;
            _timer.Start();
            startCounterButton.Text = "Pausieren";
            statusLabel.Text = "Fahrt fortgesetzt";

            startCounterButton.Click -= resumeCounterButton_Click;
            startCounterButton.Click += pauseCounterButton_Click;
        }

        private void stopCounterButton_Click(object sender, EventArgs e) {
            _timer.Stop();
            stopCounterButton.Enabled = false;

            _parent.ChangeView(
                new BookingOverview(
                    _parent,
                    _customer,
                    new TripInformation() {
                        TripStartTime = _startTime,
                        TripEndTime = DateTime.Now,
                        BillTripBy = TripInformation.BookingType.ByTime,
                        TotalTime = DateTime.Now - _startTime - _totalPauseTime
                    }
                )
            );
        }

        private void logoutButton_Click(object sender, EventArgs e) {
            _parent.ChangeView(new LoginOrRegister(_parent));
        }

        private void timerLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Middle) {
                _startTime -= new TimeSpan(0, 1, 0);
            }
        }
    }
}
