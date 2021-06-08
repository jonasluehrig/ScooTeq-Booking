using System;
using System.Windows.Forms;
using MooveTeqBooking.Data;
using System.Threading.Tasks;

namespace MooveTeqBooking {
    public partial class DistanceChooser : Form {
        private EventHandler<DistanceChosenEventArgs> _callbackEvent;

        public DistanceChooser(EventHandler<DistanceChosenEventArgs> callbackEvent) {
            InitializeComponent();
            _callbackEvent = callbackEvent;
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
            }

            try {
                var distance = await Data.MapsApi.GetDistanceBetweenTwoAddresses(startAddressTextbox.Text, stopAddressTextbox.Text);

                totalDistanceTextbox.Text = Math.Round((double)distance / 1000).ToString();
            } catch (Exception ex) {
                if (ex.Message == "NOT_FOUND" || ex.Message == "ZERO_REULTS") {
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

        private void cancelChoiceButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void confirmChoiceButton_Click(object sender, EventArgs e) {
            if (!(_callbackEvent is null)) {
                _ = Task.Run(() => {
                    _callbackEvent(
                        this,
                        new DistanceChosenEventArgs(
                            false,
                            float.Parse(totalDistanceTextbox.Text)
                        )
                    );
                });
            }

            Close();
        }
    }
}
