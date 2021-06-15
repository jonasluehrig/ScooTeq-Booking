using Microsoft.Data.Sqlite;
using ScooTeqBooking.Data;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScooTeqBooking.Pages
{
    public partial class LoginOrRegister : UserControl {
        private readonly MainForm parent;

        public LoginOrRegister(MainForm Parent) {
            InitializeComponent();

            parent = Parent;
        }

        private async void LoginButton_Click(object sender, System.EventArgs e) {
            Customer customer;

            this.Cursor = Cursors.WaitCursor;
            this.Enabled = false;

            using (var db = new DatabaseContext()) {
                var customers = from c in db.Customers where c.UserName == loginUsername.Text select c;

                customer = customers.Count() == 1 ? customers.First() : null;
            }

            if(customer is null) {
                MessageBox.Show(this, "Benutzer nicht gefunden.", "Anmeldefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Cursor = Cursors.Default;
                this.Enabled = true;

                return;
            }

            var passwordCorrect = await Task.Run(() => PasswordHashing.TestPasswordAgainstHash(loginPassword.Text, customer.PasswordHash));
            
            this.Cursor = Cursors.Default;
            this.Enabled = true;

            if (!passwordCorrect) {
                MessageBox.Show(this, "Das angegebene Password ist falsch.", "Anmeldefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            parent.ChangeView(new TimeDistanceChoice(parent, customer));
        }

        private async void registerButton_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            this.Enabled = false;

            if (registerPassword.Text != registerPasswortRepeat.Text) {
                MessageBox.Show(this, "Die Passwörter stimmen nicht überein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Cursor = Cursors.Default;
                this.Enabled = true;

                return;
            }

            var customer = new Customer() {
                UserName = registerUsername.Text,
                FirstName = registerFirstName.Text,
                LastName = registerLastName.Text,
                PasswordHash = PasswordHashing.GetPasswordHash(registerPassword.Text)
            };

            using (var db = new DatabaseContext()) {
                db.Add(customer);

                try {
                    _ = await db.SaveChangesAsync();
                } catch (Exception ex) {
                    if (((SqliteException) ex.InnerException).SqliteErrorCode == 19) {
                        MessageBox.Show(this, "Der Benutzername ist bereits vergeben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Cursor = Cursors.Default;
                        this.Enabled = true;
                    } else {
                        MessageBox.Show(
                            this,
                            $"Ein unbekannter Datenbankfehler ist aufgetreten:\n\n{ ex.Message }",
                            "Fehler",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }

                    return;
                }

                parent.ChangeView(new TimeDistanceChoice(parent, customer));
            }

            this.Cursor = Cursors.Default;
            this.Enabled = true;
        }

        private void registerBoxes_TextChanged(object sender, EventArgs e) {
            registerButton.Enabled = !(
                string.IsNullOrEmpty(registerFirstName.Text) ||
                string.IsNullOrEmpty(registerLastName.Text) ||
                string.IsNullOrEmpty(registerUsername.Text) ||
                string.IsNullOrEmpty(registerPassword.Text) ||
                string.IsNullOrEmpty(registerPasswortRepeat.Text)
            );
        }

        private void loginBoxes_TextChanged(object sender, EventArgs e) {
            loginButton.Enabled = !(string.IsNullOrEmpty(loginUsername.Text) || string.IsNullOrEmpty(loginPassword.Text));
        }

        private void loginPassword_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                e.Handled = true;
                e.SuppressKeyPress = true;
                LoginButton_Click(null, null);
            }
        }
    }
}
