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
using ScooTeqBooking.Data;

namespace ScooTeqBooking.Pages {
    public partial class BookingOverview : UserControl {
        private readonly MainForm parent;
        private readonly Customer customer;
        private readonly TripInformation tripInformation;

        private double totalCost;

        public BookingOverview(MainForm parent, Customer customer, TripInformation tripInformation) {
            InitializeComponent();

            this.parent = parent;
            this.customer = customer;
            this.tripInformation = tripInformation;
        }

        public async void Form_Load(object sender, EventArgs e) {
            welcomeMessageLabel.Text = $"Auf Wiedersehen, {customer.FirstName} {customer.LastName}!";
            usernameLabel.Text = customer.UserName;

            switch (tripInformation.BillTripBy) {
                case TripInformation.BookingType.ByTime:
                    totalCost = (Math.Ceiling(tripInformation.TotalTime.Value.TotalMinutes) * Consts.CostPerMinuteInEuro) + Consts.BasePriceInEuro;

                    string timeText = string.Empty;
                    if (tripInformation.TotalTime.Value.Hours > 0) {
                        timeText += $"{tripInformation.TotalTime.Value.Hours} Stunden, ";
                    }

                    if (tripInformation.TotalTime.Value.Minutes > 0) {
                        timeText += $"{tripInformation.TotalTime.Value.Minutes} Minuten, ";
                    }

                    if (tripInformation.TotalTime.Value.Seconds > 0) {
                        timeText += $"{tripInformation.TotalTime.Value.Seconds} Sekunden, ";
                    }

                    timeText = timeText.TrimEnd(',', ' ');

                    tripLengthLabel.Text = $"Du bist {timeText} gefahren.";
                    tripTotalCostLabel.Text = $"{totalCost.ToString("C", CultureInfo.CurrentCulture)}";

                    customer.Bookings.Add(new Booking() {
                        StartTime = tripInformation.TripStartTime,
                        EndTime = tripInformation.TripEndTime,
                        TotalTripCost = totalCost
                    });

                    try {
                        using (var db = new DatabaseContext()) {
                            db.Update(customer);
                            await db.SaveChangesAsync();
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(this, $"Ein unbekannter Datenbankfehler ist aufgetreten:\n\n{ex.InnerException.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case TripInformation.BookingType.ByDistance:
                    totalCost = (tripInformation.DrivenDistance.Value * Consts.CostPerKilometerInEuro) + Consts.BasePriceInEuro;

                    tripLengthLabel.Text = $"Du bist {Math.Round(tripInformation.DrivenDistance.Value, 3)}km gefahren.";
                    tripTotalCostLabel.Text = $"{totalCost.ToString("C", CultureInfo.CurrentCulture)}";

                    customer.Bookings.Add(new Booking() {
                        StartTime = tripInformation.TripStartTime,
                        EndTime = tripInformation.TripEndTime,
                        TotalTripCost = totalCost,
                        TripDistance = tripInformation.DrivenDistance.Value
                    });

                    try {
                        using (var db = new DatabaseContext()) {
                            db.Update(customer);
                            await db.SaveChangesAsync();
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(this, $"Ein unbekannter Datenbankfehler ist aufgetreten:\n\n{ex.InnerException.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
            }
        }

        private void payAndCloseButton_Click(object sender, EventArgs e) {
            new PaymentProcessing(customer, totalCost).ShowDialog();
            parent.DisallowClosing = false;
            parent.ChangeView(new TimeDistanceChoice(parent, customer));
        }
    }
}
