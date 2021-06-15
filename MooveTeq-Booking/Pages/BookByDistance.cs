using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScooTeqBooking.Data;

namespace ScooTeqBooking.Pages {
    public partial class BookByDistance : UserControl {
        private readonly MainForm _parent;
        private readonly Customer _customer;
        private DateTime _tripStartTime;
        private double _totalAvailableDistance;
        private double _drivenDistance = 0F;
        private Timer _timer = new Timer() {
            Interval = 1000
        };

        public BookByDistance(MainForm parent, Customer customer) {
            InitializeComponent();

            _parent = parent;
            _customer = customer;

            _timer.Tick += Timer_Tick;
        }

        private void Timer_Tick (object sender, EventArgs e) {
            _drivenDistance += Consts.AverageScooterSpeedInKm / 60 / 60;

            if (_drivenDistance >= _totalAvailableDistance) {
                _timer.Enabled = false;
                _drivenDistance = _totalAvailableDistance;
                statusLabel.Text = "Kilometeranzahl aufgebraucht,\nFahrt beendet.";
                bookAdditionalDistance.Enabled = true;
            }

            remainingDistanceLabel.Text  = $"{(_totalAvailableDistance - _drivenDistance).ToString("0.000")}km\n";
            remainingDistanceLabel.Text += $"{(_drivenDistance * Consts.CostPerKilometerInEuro).ToString("0.00")}€";
        }

        private void startCounterButton_Click(object sender, EventArgs e) {
            if (_totalAvailableDistance == 0) {
                var distanceChooser = new DistanceChooser();

                if (distanceChooser.ShowDialog() == DialogResult.OK) {
                    _totalAvailableDistance = distanceChooser.ChosenDistance;
                } else {
                    MessageBox.Show(this, "Fahrt abgebrochen.", "Aktuelle Fahrt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _parent.ChangeView(new TimeDistanceChoice(_parent, _customer));
                    return;
                }
            }

            _timer.Start();
            _tripStartTime = DateTime.Now;
            startCounterButton.Enabled = false;
            stopCounterButton.Enabled = true;
            logoutButton.Enabled = false;
        }

        private void stopCounterButton_Click(object sender, EventArgs e) {
            _timer.Stop();
            _parent.ChangeView(
                new BookingOverview(_parent, _customer, new TripInformation() {
                    BillTripBy = TripInformation.BookingType.ByDistance,
                    TotalDistance = _totalAvailableDistance,
                    DrivenDistance = _drivenDistance,
                    TripStartTime = _tripStartTime,
                    TripEndTime = DateTime.Now
                })
            );
        }

        private void logoutButton_Click(object sender, EventArgs e) {
            _parent.ChangeView(new LoginOrRegister(_parent));
        }

        private void bookAdditionalDistance_Click(object sender, EventArgs e) {
            var distanceChooser = new DistanceChooser();

            if (distanceChooser.ShowDialog() == DialogResult.OK) {
                _totalAvailableDistance += distanceChooser.ChosenDistance;
                startCounterButton.Enabled = true;
                bookAdditionalDistance.Enabled = false;
                startCounterButton.Text = "Fahrt fortsetzen";
            } else {
                return;
            }
        }

        private void BookByDistance_Load(object sender, EventArgs e) {
            welcomeMessageLabel.Text = $"Gute Fahrt, {_customer.FirstName} {_customer.LastName}!";
            usernameLabel.Text = _customer.UserName;
        }
    }
}
