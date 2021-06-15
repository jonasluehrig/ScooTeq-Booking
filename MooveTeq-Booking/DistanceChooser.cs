using System;
using System.Windows.Forms;
using ScooTeqBooking.Data;
using System.Threading.Tasks;

namespace ScooTeqBooking {
    public partial class DistanceChooser : Form {
        public double ChosenDistance { get; internal set; }

        public DistanceChooser() {
            InitializeComponent();
        }

        private async void getMapsDistanceButton_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;

            if (string.IsNullOrEmpty(startAddressTextbox.Text) || string.IsNullOrEmpty(stopAddressTextbox.Text)) {
                MessageBox.Show(
                    this,
                    "Beide Adressfelder müssen ausgefüllt sein.",
                    "Fehler",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Cursor = Cursors.Default;
                return;
            }

            try {
                var distance = await Data.MapsApi.GetDistanceBetweenTwoAddresses(startAddressTextbox.Text, stopAddressTextbox.Text);

                totalDistanceNumbox.Value = (decimal) Math.Round((double)distance / 1000);
            } catch (Exception ex) {
                if (ex.Message == "NOT_FOUND" || ex.Message == "ZERO_RESULTS") {
                    MessageBox.Show(
                        this,
                        "Mindestens eine der angegebenen Adressen wurde nicht gefunden.",
                        "Fehler",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                   );
                } else {
                    MessageBox.Show(
                        this,
                        $"Beim Laden der Route hat der Google Maps Server folgenen Fehler zurück gemeldet:\n\n{ex.Message}",
                        "Fehler",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }

            this.Cursor = Cursors.Default;
        }

        private void confirmChoiceButton_Click(object sender, EventArgs e) {
            ChosenDistance = (double) totalDistanceNumbox.Value;
        }
    }
}
