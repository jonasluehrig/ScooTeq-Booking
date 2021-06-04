using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Bogus;

namespace MooveTeqBooking {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            //InitDatabase();

            ChangeView(new Pages.LoginOrRegister(this));
        }

        public void ChangeView(Control nextControl) {
            Controls.Clear();
            Controls.Add(nextControl);
            ClientSize = nextControl.Size;
            Text = nextControl.Text;
        }
    }
}
