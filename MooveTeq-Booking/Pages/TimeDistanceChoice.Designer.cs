
namespace ScooTeqBooking.Pages {
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
            this.mainGridLayoutTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.bookByTimeButton = new System.Windows.Forms.Button();
            this.bookByDistanceButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.mainGridLayoutTablePanel.SuspendLayout();
            this.buttonTablePanel.SuspendLayout();
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
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Image = global::ScooTeqBooking.Properties.Resources.exit_16px;
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
            this.adminMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminMenu.Image = global::ScooTeqBooking.Properties.Resources.user_shield_16px;
            this.adminMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adminMenu.Name = "adminMenu";
            this.adminMenu.Size = new System.Drawing.Size(95, 22);
            this.adminMenu.Text = "Verwaltung";
            // 
            // openUserManagementButton
            // 
            this.openUserManagementButton.Image = global::ScooTeqBooking.Properties.Resources.registration_16px;
            this.openUserManagementButton.Name = "openUserManagementButton";
            this.openUserManagementButton.Size = new System.Drawing.Size(179, 22);
            this.openUserManagementButton.Text = "Benutzerverwaltung";
            this.openUserManagementButton.Click += new System.EventHandler(this.openUserManagementButton_Click);
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
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Image = global::ScooTeqBooking.Properties.Resources.user_16px;
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(92, 22);
            this.usernameLabel.Text = "<Username>";
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(222, 22);
            this.welcomeMessageLabel.Text = "Willkommen, <Firstname> <Lastname>!";
            // 
            // mainGridLayoutTablePanel
            // 
            this.mainGridLayoutTablePanel.BackColor = System.Drawing.Color.Transparent;
            this.mainGridLayoutTablePanel.ColumnCount = 3;
            this.mainGridLayoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainGridLayoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.mainGridLayoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainGridLayoutTablePanel.Controls.Add(this.label1, 1, 0);
            this.mainGridLayoutTablePanel.Controls.Add(this.buttonTablePanel, 1, 1);
            this.mainGridLayoutTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGridLayoutTablePanel.Location = new System.Drawing.Point(0, 25);
            this.mainGridLayoutTablePanel.Name = "mainGridLayoutTablePanel";
            this.mainGridLayoutTablePanel.RowCount = 3;
            this.mainGridLayoutTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainGridLayoutTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainGridLayoutTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainGridLayoutTablePanel.Size = new System.Drawing.Size(583, 321);
            this.mainGridLayoutTablePanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.label1.Size = new System.Drawing.Size(344, 130);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wähle eine Buchungsart für deine Fahrt aus:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTablePanel
            // 
            this.buttonTablePanel.ColumnCount = 2;
            this.buttonTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonTablePanel.Controls.Add(this.bookByTimeButton, 0, 0);
            this.buttonTablePanel.Controls.Add(this.bookByDistanceButton, 1, 0);
            this.buttonTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTablePanel.Location = new System.Drawing.Point(116, 130);
            this.buttonTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTablePanel.Name = "buttonTablePanel";
            this.buttonTablePanel.RowCount = 1;
            this.buttonTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonTablePanel.Size = new System.Drawing.Size(350, 60);
            this.buttonTablePanel.TabIndex = 3;
            // 
            // bookByTimeButton
            // 
            this.bookByTimeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookByTimeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookByTimeButton.Location = new System.Drawing.Point(3, 3);
            this.bookByTimeButton.Name = "bookByTimeButton";
            this.bookByTimeButton.Size = new System.Drawing.Size(169, 54);
            this.bookByTimeButton.TabIndex = 0;
            this.bookByTimeButton.Text = "Scooter nach verstrichener Zeit buchen";
            this.bookByTimeButton.UseVisualStyleBackColor = true;
            this.bookByTimeButton.Click += new System.EventHandler(this.bookByTimeButton_Click);
            // 
            // bookByDistanceButton
            // 
            this.bookByDistanceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookByDistanceButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookByDistanceButton.Location = new System.Drawing.Point(178, 3);
            this.bookByDistanceButton.Name = "bookByDistanceButton";
            this.bookByDistanceButton.Size = new System.Drawing.Size(169, 54);
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
            this.BackgroundImage = global::ScooTeqBooking.Properties.Resources.skyline2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.mainGridLayoutTablePanel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TimeDistanceChoice";
            this.Size = new System.Drawing.Size(583, 346);
            this.Load += new System.EventHandler(this.TimeDistanceChoice_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainGridLayoutTablePanel.ResumeLayout(false);
            this.buttonTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton logoutButton;
        private System.Windows.Forms.ToolStripLabel usernameLabel;
        private System.Windows.Forms.TableLayoutPanel mainGridLayoutTablePanel;
        private System.Windows.Forms.ToolStripLabel welcomeMessageLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton adminMenu;
        private System.Windows.Forms.ToolStripMenuItem openUserManagementButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel buttonTablePanel;
        private System.Windows.Forms.Button bookByTimeButton;
        private System.Windows.Forms.Button bookByDistanceButton;
    }
}
