
namespace MooveTeqBooking {
    partial class UserManagement {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.customerListView = new System.Windows.Forms.ListView();
            this.usernameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountOfTripsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalCostHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.activeBonusTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isAdminHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.editUserButton = new System.Windows.Forms.ToolStripButton();
            this.closeButton = new System.Windows.Forms.ToolStripButton();
            this.deleteUserButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerListView
            // 
            this.customerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usernameHeader,
            this.firstnameHeader,
            this.lastnameHeader,
            this.amountOfTripsHeader,
            this.totalCostHeader,
            this.activeBonusTime,
            this.isAdminHeader});
            this.customerListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerListView.FullRowSelect = true;
            this.customerListView.GridLines = true;
            this.customerListView.HideSelection = false;
            this.customerListView.Location = new System.Drawing.Point(0, 25);
            this.customerListView.Name = "customerListView";
            this.customerListView.Size = new System.Drawing.Size(800, 425);
            this.customerListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.customerListView.TabIndex = 2;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            this.customerListView.View = System.Windows.Forms.View.Details;
            this.customerListView.DoubleClick += new System.EventHandler(this.EditSelectedUser);
            // 
            // usernameHeader
            // 
            this.usernameHeader.Text = "Username";
            this.usernameHeader.Width = 120;
            // 
            // firstnameHeader
            // 
            this.firstnameHeader.Text = "Vorname";
            this.firstnameHeader.Width = 125;
            // 
            // lastnameHeader
            // 
            this.lastnameHeader.Text = "Nachname";
            this.lastnameHeader.Width = 125;
            // 
            // amountOfTripsHeader
            // 
            this.amountOfTripsHeader.Text = "Fahrten gesamt";
            this.amountOfTripsHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountOfTripsHeader.Width = 110;
            // 
            // totalCostHeader
            // 
            this.totalCostHeader.Text = "Bezahlt gesamt";
            this.totalCostHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalCostHeader.Width = 110;
            // 
            // activeBonusTime
            // 
            this.activeBonusTime.Text = "Fahrtzeit gesamt";
            this.activeBonusTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.activeBonusTime.Width = 110;
            // 
            // isAdminHeader
            // 
            this.isAdminHeader.Text = "Admin";
            this.isAdminHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.isAdminHeader.Width = 50;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUserButton,
            this.closeButton,
            this.deleteUserButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // editUserButton
            // 
            this.editUserButton.Image = global::MooveTeqBooking.Properties.Resources.registration_16px1;
            this.editUserButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(132, 22);
            this.editUserButton.Text = "Benutzer bearbeiten";
            this.editUserButton.Click += new System.EventHandler(this.EditSelectedUser);
            // 
            // closeButton
            // 
            this.closeButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeButton.Image = global::MooveTeqBooking.Properties.Resources.delete_16px;
            this.closeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(78, 22);
            this.closeButton.Text = "Schließen";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Image = global::MooveTeqBooking.Properties.Resources.trash_16px;
            this.deleteUserButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(117, 22);
            this.deleteUserButton.Text = "Benutzer löschen";
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerListView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UserManagement";
            this.Text = "Benutzerverwaltung";
            this.Load += new System.EventHandler(this.Form_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView customerListView;
        private System.Windows.Forms.ColumnHeader usernameHeader;
        private System.Windows.Forms.ColumnHeader firstnameHeader;
        private System.Windows.Forms.ColumnHeader lastnameHeader;
        private System.Windows.Forms.ColumnHeader amountOfTripsHeader;
        private System.Windows.Forms.ColumnHeader totalCostHeader;
        private System.Windows.Forms.ColumnHeader activeBonusTime;
        private System.Windows.Forms.ColumnHeader isAdminHeader;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton editUserButton;
        private System.Windows.Forms.ToolStripButton closeButton;
        private System.Windows.Forms.ToolStripButton deleteUserButton;
    }
}