
namespace ScooTeqBooking.Pages {
    partial class BookByDistance {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.startCounterButton = new System.Windows.Forms.Button();
            this.stopCounterButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bookAdditionalDistance = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.remainingDistanceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.logoutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.usernameLabel = new System.Windows.Forms.ToolStripLabel();
            this.welcomeMessageLabel = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusLabel, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(583, 321);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(159, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 211);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.startCounterButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.stopCounterButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 118);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(265, 57);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // startCounterButton
            // 
            this.startCounterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startCounterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCounterButton.ForeColor = System.Drawing.Color.Green;
            this.startCounterButton.Location = new System.Drawing.Point(3, 3);
            this.startCounterButton.Name = "startCounterButton";
            this.startCounterButton.Size = new System.Drawing.Size(126, 51);
            this.startCounterButton.TabIndex = 0;
            this.startCounterButton.Text = "Auswählen && Fahrt start";
            this.startCounterButton.UseVisualStyleBackColor = true;
            this.startCounterButton.Click += new System.EventHandler(this.startCounterButton_Click);
            // 
            // stopCounterButton
            // 
            this.stopCounterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopCounterButton.Enabled = false;
            this.stopCounterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopCounterButton.ForeColor = System.Drawing.Color.Red;
            this.stopCounterButton.Location = new System.Drawing.Point(135, 3);
            this.stopCounterButton.Name = "stopCounterButton";
            this.stopCounterButton.Size = new System.Drawing.Size(127, 51);
            this.stopCounterButton.TabIndex = 1;
            this.stopCounterButton.Text = "Fahrt beenden";
            this.stopCounterButton.UseVisualStyleBackColor = true;
            this.stopCounterButton.Click += new System.EventHandler(this.stopCounterButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bookAdditionalDistance);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 175);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(265, 36);
            this.panel3.TabIndex = 6;
            // 
            // bookAdditionalDistance
            // 
            this.bookAdditionalDistance.AutoSize = true;
            this.bookAdditionalDistance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookAdditionalDistance.Enabled = false;
            this.bookAdditionalDistance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAdditionalDistance.Location = new System.Drawing.Point(3, 3);
            this.bookAdditionalDistance.Name = "bookAdditionalDistance";
            this.bookAdditionalDistance.Size = new System.Drawing.Size(259, 30);
            this.bookAdditionalDistance.TabIndex = 5;
            this.bookAdditionalDistance.Text = "Mehr Fahrtstrecke buchen";
            this.bookAdditionalDistance.UseVisualStyleBackColor = true;
            this.bookAdditionalDistance.Click += new System.EventHandler(this.bookAdditionalDistance_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.remainingDistanceLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 84);
            this.panel2.TabIndex = 1;
            // 
            // remainingDistanceLabel
            // 
            this.remainingDistanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.remainingDistanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remainingDistanceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingDistanceLabel.Location = new System.Drawing.Point(0, 0);
            this.remainingDistanceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.remainingDistanceLabel.Name = "remainingDistanceLabel";
            this.remainingDistanceLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.remainingDistanceLabel.Size = new System.Drawing.Size(265, 84);
            this.remainingDistanceLabel.TabIndex = 1;
            this.remainingDistanceLabel.Text = "-,---km\r\n(0,00€)";
            this.remainingDistanceLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verbleibende Strecke";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(159, 269);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(265, 52);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutButton,
            this.toolStripSeparator1,
            this.usernameLabel,
            this.welcomeMessageLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(583, 25);
            this.toolStrip1.TabIndex = 3;
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
            this.welcomeMessageLabel.Size = new System.Drawing.Size(209, 22);
            this.welcomeMessageLabel.Text = "Gute Fahrt, <Firstname> <Lastname>!";
            // 
            // BookByDistance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ScooTeqBooking.Properties.Resources.skyline2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookByDistance";
            this.Size = new System.Drawing.Size(583, 346);
            this.Load += new System.EventHandler(this.BookByDistance_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label remainingDistanceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton logoutButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel usernameLabel;
        private System.Windows.Forms.ToolStripLabel welcomeMessageLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button startCounterButton;
        private System.Windows.Forms.Button stopCounterButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bookAdditionalDistance;
        private System.Windows.Forms.Label statusLabel;
    }
}
