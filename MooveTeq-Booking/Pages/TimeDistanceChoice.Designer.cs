
namespace MooveTeqBooking.Pages {
    partial class TimeDistanceChoice {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.logoutButton = new System.Windows.Forms.ToolStripButton();
            this.adminMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.openUserManagementButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.usernameLabel = new System.Windows.Forms.ToolStripLabel();
            this.welcomeMessageLabel = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bookByTimeButton = new System.Windows.Forms.Button();
            this.bookByDistanceButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutButton,
            this.adminMenu,
            this.toolStripSeparator1,
            this.usernameLabel,
            this.welcomeMessageLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(583, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // logoutButton
            // 
            this.logoutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutButton.Image = global::MooveTeqBooking.Properties.Resources.exit_16px;
            this.logoutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(65, 22);
            this.logoutButton.Text = "Logout";
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // adminMenu
            // 
            this.adminMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.adminMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openUserManagementButton});
            this.adminMenu.Image = global::MooveTeqBooking.Properties.Resources.user_shield_16px;
            this.adminMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adminMenu.Name = "adminMenu";
            this.adminMenu.Size = new System.Drawing.Size(95, 22);
            this.adminMenu.Text = "Verwaltung";
            // 
            // openUserManagementButton
            // 
            this.openUserManagementButton.Image = global::MooveTeqBooking.Properties.Resources.registration_16px;
            this.openUserManagementButton.Name = "openUserManagementButton";
            this.openUserManagementButton.Size = new System.Drawing.Size(179, 22);
            this.openUserManagementButton.Text = "Benutzerverwaltung";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.usernameLabel.Image = global::MooveTeqBooking.Properties.Resources.user_16px;
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(92, 22);
            this.usernameLabel.Text = "<Username>";
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(222, 22);
            this.welcomeMessageLabel.Text = "Willkommen, <Firstname> <Lastname>!";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(583, 321);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.bookByTimeButton);
            this.flowLayoutPanel1.Controls.Add(this.bookByDistanceButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(145, 130);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(292, 61);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // bookByTimeButton
            // 
            this.bookByTimeButton.Location = new System.Drawing.Point(3, 3);
            this.bookByTimeButton.Name = "bookByTimeButton";
            this.bookByTimeButton.Size = new System.Drawing.Size(140, 55);
            this.bookByTimeButton.TabIndex = 0;
            this.bookByTimeButton.Text = "Scooter nach verstrichener Zeit buchen";
            this.bookByTimeButton.UseVisualStyleBackColor = true;
            this.bookByTimeButton.Click += new System.EventHandler(this.bookByTimeButton_Click);
            // 
            // bookByDistanceButton
            // 
            this.bookByDistanceButton.Location = new System.Drawing.Point(149, 3);
            this.bookByDistanceButton.Name = "bookByDistanceButton";
            this.bookByDistanceButton.Size = new System.Drawing.Size(140, 55);
            this.bookByDistanceButton.TabIndex = 1;
            this.bookByDistanceButton.Text = "Scooter nach fester Strecke buchen";
            this.bookByDistanceButton.UseVisualStyleBackColor = true;
            this.bookByDistanceButton.Click += new System.EventHandler(this.bookByDistanceButton_Click);
            // 
            // TimeDistanceChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TimeDistanceChoice";
            this.Size = new System.Drawing.Size(583, 346);
            this.Load += new System.EventHandler(this.TimeDistanceChoice_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton logoutButton;
        private System.Windows.Forms.ToolStripLabel usernameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bookByTimeButton;
        private System.Windows.Forms.Button bookByDistanceButton;
        private System.Windows.Forms.ToolStripLabel welcomeMessageLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton adminMenu;
        private System.Windows.Forms.ToolStripMenuItem openUserManagementButton;
    }
}
