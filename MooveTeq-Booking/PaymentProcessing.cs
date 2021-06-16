using ScooTeqBooking.Data;
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

namespace ScooTeqBooking {
    public partial class PaymentProcessing : Form {
        private readonly Data.Customer customer;

        public PaymentProcessing(Customer customer) {
            this.customer = customer;
        }

        private readonly double price;

        public PaymentProcessing(Data.Customer customer, double totalPrice) {
            InitializeComponent();

            this.customer = customer;
            price = totalPrice;
        }

        public void Form_Load(object sender, EventArgs e) {
            costLabel.Text = $"von über {price.ToString("C", CultureInfo.CurrentCulture)}";
            thanksMessageLabel.Text = $"Vielen Dank {customer.FirstName} {customer.LastName} für die Fahrt! Bis zum nächsten Mal :)";
        }

        private void processPaymentButton_Click(object sender, EventArgs e) {
            /* Do actual payment stuff here... */

            MessageBox.Show(this, "Zahlung erfolgreich!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
    }
}
