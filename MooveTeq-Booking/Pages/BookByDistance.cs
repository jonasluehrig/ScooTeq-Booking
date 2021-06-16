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
        private readonly MainForm parent;
        private readonly Customer customer;
        private readonly Timer timer = new Timer() {
            Interval = 1000
        };

        private DateTime tripStartTime;
        private double totalAvailableDistance;
        private double drivenDistance = 0F;

        public BookByDistance(MainForm parent, Customer customer) {
            InitializeComponent();

            this.parent = parent;
            this.customer = customer;

            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e) {
            drivenDistance += Consts.AverageScooterSpeedInKm / 60 / 60;

            if (drivenDistance >= totalAvailableDistance) {
                timer.Enabled = false;
                drivenDistance = totalAvailableDistance;
                statusLabel.Text = "Kilometeranzahl aufgebraucht,\nFahrt beendet.";
                bookAdditionalDistance.Enabled = true;
            }

            remainingDistanceLabel.Text = $"{(totalAvailableDistance - drivenDistance).ToString("0.000")}km\n";
            remainingDistanceLabel.Text += $"{(drivenDistance * Consts.CostPerKilometerInEuro).ToString("0.00")}€";
        }

        private void startCounterButton_Click(object sender, EventArgs e) {
            if (totalAvailableDistance == 0) {
                var distanceChooser = new DistanceChooser();

                if (distanceChooser.ShowDialog() == DialogResult.OK) {
                    totalAvailableDistance = distanceChooser.ChosenDistance;
                } else {
                    MessageBox.Show(this, "Fahrt abgebrochen.", "Aktuelle Fahrt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    parent.ChangeView(new TimeDistanceChoice(parent, customer));
                    return;
                }
            }

            timer.Start();
            tripStartTime = DateTime.Now;
            startCounterButton.Enabled = false;
            stopCounterButton.Enabled = true;
            logoutButton.Enabled = false;

            parent.DisallowClosing = true;
        }

        private void stopCounterButton_Click(object sender, EventArgs e) {
            timer.Stop();
            parent.ChangeView(
                new BookingOverview(parent, customer, new TripInformation() {
                    BillTripBy = TripInformation.BookingType.ByDistance,
                    TotalDistance = totalAvailableDistance,
                    DrivenDistance = drivenDistance,
                    TripStartTime = tripStartTime,
                    TripEndTime = DateTime.Now
                })
            );
        }

        private void logoutButton_Click(object sender, EventArgs e) {
            parent.ChangeView(new LoginOrRegister(parent));
        }

        private void bookAdditionalDistance_Click(object sender, EventArgs e) {
            var distanceChooser = new DistanceChooser();

            if (distanceChooser.ShowDialog() == DialogResult.OK) {
                totalAvailableDistance += distanceChooser.ChosenDistance;
                startCounterButton.Enabled = true;
                bookAdditionalDistance.Enabled = false;
                startCounterButton.Text = "Fahrt fortsetzen";
            } else {
                return;
            }
        }

        private void BookByDistance_Load(object sender, EventArgs e) {
            welcomeMessageLabel.Text = $"Gute Fahrt, {customer.FirstName} {customer.LastName}!";
            usernameLabel.Text = customer.UserName;
        }
    }
}
