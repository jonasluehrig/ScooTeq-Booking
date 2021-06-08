using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MooveTeqBooking.Data;

namespace MooveTeqBooking.Pages {
    public partial class BookingOverview : UserControl {
        MainForm _parent;
        Customer _customer;
        TripInformation _tripInformation;

        double _totalCost;

        public BookingOverview(MainForm parent, Customer customer, TripInformation tripInformation) {
            InitializeComponent();

            _parent = parent;
            _customer = customer;
            _tripInformation = tripInformation;
        }

        public async void Form_Load(object sender, EventArgs e) {
            welcomeMessageLabel.Text = $"Auf Wiedersehen, {_customer.FirstName} {_customer.LastName}!";
            usernameLabel.Text = _customer.UserName;

            switch (_tripInformation.BillTripBy) {
                case TripInformation.BookingType.ByTime:
                    _totalCost = (Math.Ceiling(_tripInformation.TotalTime.Value.TotalMinutes) * Consts.CostPerMinuteInEuro) + Consts.BasePriceInEuro;

                    string timeText = string.Empty;
                    if (_tripInformation.TotalTime.Value.Hours > 0) {
                        timeText += $"{_tripInformation.TotalTime.Value.Hours} Stunden, ";
                    }

                    if (_tripInformation.TotalTime.Value.Minutes > 0) {
                        timeText += $"{_tripInformation.TotalTime.Value.Minutes} Minuten, ";
                    }

                    if (_tripInformation.TotalTime.Value.Seconds > 0) {
                        timeText += $"{_tripInformation.TotalTime.Value.Seconds} Sekunden, ";
                    }

                    timeText = timeText.TrimEnd(',', ' ');

                    tripLengthLabel.Text = $"Du bist {timeText} gefahren.";
                    tripTotalCostLabel.Text = $"{_totalCost.ToString("C", CultureInfo.CurrentCulture)}";

                    _customer.Bookings.Add(new Booking() {
                        StartTime = _tripInformation.TripStartTime,
                        EndTime = _tripInformation.TripEndTime,
                        TotalTripCost = _totalCost
                    });

                    try {
                        using (var db = new DatabaseContext()) {
                            db.Update(_customer);
                            await db.SaveChangesAsync();
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(this, $"Ein unbekannter Datenbankfehler ist aufgetreten:\n\n{ex.InnerException.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case TripInformation.BookingType.ByDistance:
                    _totalCost = (_tripInformation.TotalDistance.Value * Consts.CostPerKilometerInEuro) + Consts.BasePriceInEuro;

                    tripLengthLabel.Text = $"Du bist {_tripInformation.TotalDistance.Value}km gefahren.";
                    tripTotalCostLabel.Text = $"{_totalCost.ToString("C", CultureInfo.CurrentCulture)}";

                    _customer.Bookings.Add(new Booking() {
                        StartTime = _tripInformation.TripStartTime,
                        EndTime = _tripInformation.TripEndTime,
                        TotalTripCost = _totalCost,
                        TripDistance = _tripInformation.TotalDistance.Value
                    });

                    try {
                        using (var db = new DatabaseContext()) {
                            db.Update(_customer);
                            await db.SaveChangesAsync();
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(this, $"Ein unbekannter Datenbankfehler ist aufgetreten:\n\n{ex.InnerException.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
            }
        }

        private void payAndCloseButton_Click(object sender, EventArgs e) {
            new PaymentProcessing(_customer, _totalCost).ShowDialog();
            _parent.ChangeView(new TimeDistanceChoice(_parent, _customer));
        }
    }
}
