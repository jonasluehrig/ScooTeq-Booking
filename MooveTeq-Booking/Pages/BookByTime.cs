using System;
using System.Drawing;
using System.Windows.Forms;
using ScooTeqBooking.Data;

namespace ScooTeqBooking.Pages {
    public partial class BookByTime : UserControl {
        private readonly MainForm parent;
        private readonly Customer customer;
        private readonly Timer timer = new Timer() {
            Interval = 50
        };

        private DateTime startTime;
        private DateTime pauseStartTime;
        private TimeSpan totalPauseTime = new TimeSpan(0);

        public BookByTime(MainForm parent, Customer customer) {
            InitializeComponent();

            this.parent = parent;
            this.customer = customer;
        }

        private void BookByTime_Load(object sender, EventArgs e) {
            usernameLabel.Text = customer.UserName;
            welcomeMessageLabel.Text = $"Gute Fahrt, {customer.FirstName} {customer.LastName}!";
            statusLabel.Text = "Drücke Start um die Fahrt zu beginnen.";

            timerLabel.MouseWheel += new MouseEventHandler((object mouse_sender, MouseEventArgs mouse_e) => {
                System.Diagnostics.Debug.Print(mouse_e.Delta.ToString());
                startTime -= new TimeSpan(0, 0, mouse_e.Delta / 2);
            });
        }

        private void timer_Tick(object sender, EventArgs e) {
            var tripTime = DateTime.Now - startTime - totalPauseTime;
            var minuteTime = (Math.Ceiling(tripTime.TotalMinutes) * Consts.CostPerMinuteInEuro) + Consts.BasePriceInEuro;

            timerLabel.Text = tripTime.ToString("hh':'mm':'ss");
            timerLabel.Text += $"\n({minuteTime.ToString("0.00")}€)";
        }

        private void startCounterButton_Click(object sender, EventArgs e) {
            startTime = DateTime.Now;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            stopCounterButton.Enabled = true;
            logoutButton.Enabled = false;

            statusLabel.Text = $"Fahrt um {startTime.ToShortTimeString()} gestartet";

            startCounterButton.Text = "Pausieren";
            startCounterButton.ForeColor = Color.Orange;
            startCounterButton.Click -= startCounterButton_Click;
            startCounterButton.Click += pauseCounterButton_Click;

            parent.DisallowClosing = true;
        }

        private void pauseCounterButton_Click(object sender, EventArgs e) {
            pauseStartTime = DateTime.Now;
            timer.Stop();
            startCounterButton.Text = "Weiter";
            statusLabel.Text = "Fahrt pausiert, Scooter gesperrt.\nDrücke auf Weiter um die Fahrt fortzusetzen";

            startCounterButton.Click -= pauseCounterButton_Click;
            startCounterButton.Click += resumeCounterButton_Click;
        }

        private void resumeCounterButton_Click(object sender, EventArgs e) {
            totalPauseTime += DateTime.Now - pauseStartTime;
            timer.Start();
            startCounterButton.Text = "Pausieren";
            statusLabel.Text = "Fahrt fortgesetzt";

            startCounterButton.Click -= resumeCounterButton_Click;
            startCounterButton.Click += pauseCounterButton_Click;
        }

        private void stopCounterButton_Click(object sender, EventArgs e) {
            timer.Stop();
            stopCounterButton.Enabled = false;

            parent.ChangeView(
                new BookingOverview(
                    parent,
                    customer,
                    new TripInformation() {
                        TripStartTime = startTime,
                        TripEndTime = DateTime.Now,
                        BillTripBy = TripInformation.BookingType.ByTime,
                        TotalTime = DateTime.Now - startTime - totalPauseTime
                    }
                )
            );
        }

        private void logoutButton_Click(object sender, EventArgs e) {
            parent.ChangeView(new LoginOrRegister(parent));
        }

        private void timerLabel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Middle) {
                startTime -= new TimeSpan(0, 1, 0);
            }
        }
    }
}
