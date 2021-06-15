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
        Data.Customer _customer;
        double _price;
        
        public PaymentProcessing(Data.Customer customer, double totalPrice) {
            InitializeComponent();

            _customer = customer;
            _price = totalPrice;
        }

        public void Form_Load(object sender, EventArgs e) {
            costLabel.Text = $"von über {_price.ToString("C", CultureInfo.CurrentCulture)}";
            thanksMessageLabel.Text = $"Vielen Dank {_customer.FirstName} {_customer.LastName} für die Fahrt! Bis zum nächsten Mal :)";
        }

        private void processPaymentButton_Click(object sender, EventArgs e) {
            // Do actual payment stuff here...

            MessageBox.Show(this, "Zahlung erfolgreich!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
    }
}
