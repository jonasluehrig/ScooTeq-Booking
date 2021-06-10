using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MooveTeqBooking {
    public partial class UserManagement : Form {
        private EventHandler _onClosingCallback;

        public UserManagement(EventHandler onClosingCallback) {
            InitializeComponent();
            _onClosingCallback = onClosingCallback;
        }

        public async void Form_Load(object sender, EventArgs e) {
            await ReloadAllUsers();
        }

        private ListViewItem CustomerToListviewItem(Data.Customer customer) {
            var lvItem = new ListViewItem(customer.UserName);

            double totalCost = 0;
            var amountOfTrips = 0;
            TimeSpan totalDrivenTime = default(TimeSpan);

            foreach (Data.Booking booking in customer.Bookings) {
                totalCost += booking.TotalTripCost;
                amountOfTrips++;
                totalDrivenTime += booking.EndTime.Value - booking.StartTime.Value;
            }

            lvItem.Tag = customer.CustomerId;

            lvItem.SubItems.Add(customer.FirstName);
            lvItem.SubItems.Add(customer.LastName);
            lvItem.SubItems.Add(amountOfTrips.ToString());
            lvItem.SubItems.Add(totalCost.ToString("0.00€"));
            lvItem.SubItems.Add(totalDrivenTime.ToString("hh':'mm':'ss"));
            lvItem.SubItems.Add(customer.IsAdmin ? "Ja" : "Nein");

            return lvItem;
        }

        private async Task ReloadAllUsers() {
            var lvItems = new List<ListViewItem>();

            await Task.Run(() => {
                using (var db = new Data.DatabaseContext()) {
                    foreach (Data.Customer customer in db.Customers.Include(c => c.Bookings)) {
                        lvItems.Add(CustomerToListviewItem(customer));
                    }
                }
            });

            customerListView.BeginUpdate();
            customerListView.Items.AddRange(lvItems.ToArray());
            customerListView.EndUpdate();
        }

        private void closeButton_Click(object sender, EventArgs e) {
            if (!(_onClosingCallback is null)) {
                _onClosingCallback(this, new EventArgs());
            }

            Close();
        }

        private void EditSelectedUser(object sender, EventArgs e) {
            if (customerListView.SelectedItems.Count == 1) {
                using (var db = new Data.DatabaseContext()) {
                    var customer = db.Customers
                        .Include(c => c.Bookings)
                        .Where(c => c.CustomerId == (int)customerListView.SelectedItems[0].Tag).First();

                    var userEditor = new UserEditor(customer);

                    userEditor.ShowDialog();

                    if (userEditor.DialogResult == DialogResult.OK) {
                        customerListView.Items[customerListView.SelectedItems[0].Index] = CustomerToListviewItem(customer);
                        db.Update(customer);
                        _ = db.SaveChangesAsync();
                    }
                }
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e) {
            if (customerListView.SelectedItems.Count == 1) {
                using (var db = new Data.DatabaseContext()) {
                    var customer = db.Customers
                        .Include(c => c.Bookings)
                        .Where(c => c.CustomerId == (int)customerListView.SelectedItems[0].Tag).First();

                    if (MessageBox.Show(
                        this,
                        $"Den Benutzer {customer.UserName} wirklich löschen?",
                        "Bestätigung",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No
                    ) return;

                    db.Remove(customer);
                    _ = db.SaveChangesAsync();
                    customerListView.Items.RemoveAt(customerListView.SelectedItems[0].Index);
                }
            }
        }
    }
}
