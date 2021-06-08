
namespace MooveTeqBooking {
    partial class DistanceChooser {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.getMapsDistanceButton = new System.Windows.Forms.Button();
            this.stopAddressTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startAddressTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmChoiceButton = new System.Windows.Forms.Button();
            this.cancelChoiceButton = new System.Windows.Forms.Button();
            this.totalDistanceNumbox = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalDistanceNumbox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.getMapsDistanceButton);
            this.groupBox1.Controls.Add(this.stopAddressTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.startAddressTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gib entweder Start und Ziel ein...";
            // 
            // getMapsDistanceButton
            // 
            this.getMapsDistanceButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getMapsDistanceButton.Location = new System.Drawing.Point(9, 108);
            this.getMapsDistanceButton.Name = "getMapsDistanceButton";
            this.getMapsDistanceButton.Size = new System.Drawing.Size(185, 23);
            this.getMapsDistanceButton.TabIndex = 4;
            this.getMapsDistanceButton.Text = "Strecke prüfen";
            this.getMapsDistanceButton.UseVisualStyleBackColor = true;
            this.getMapsDistanceButton.Click += new System.EventHandler(this.getMapsDistanceButton_Click);
            // 
            // stopAddressTextbox
            // 
            this.stopAddressTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopAddressTextbox.Location = new System.Drawing.Point(9, 79);
            this.stopAddressTextbox.Name = "stopAddressTextbox";
            this.stopAddressTextbox.Size = new System.Drawing.Size(185, 23);
            this.stopAddressTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zieladresse";
            // 
            // startAddressTextbox
            // 
            this.startAddressTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startAddressTextbox.Location = new System.Drawing.Point(9, 35);
            this.startAddressTextbox.Name = "startAddressTextbox";
            this.startAddressTextbox.Size = new System.Drawing.Size(185, 23);
            this.startAddressTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Startadresse";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalDistanceNumbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "... oder direkt die Kilometeranzahl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "KM";
            // 
            // confirmChoiceButton
            // 
            this.confirmChoiceButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmChoiceButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmChoiceButton.ForeColor = System.Drawing.Color.Green;
            this.confirmChoiceButton.Location = new System.Drawing.Point(233, 144);
            this.confirmChoiceButton.Name = "confirmChoiceButton";
            this.confirmChoiceButton.Size = new System.Drawing.Size(102, 28);
            this.confirmChoiceButton.TabIndex = 2;
            this.confirmChoiceButton.Text = "Bestätigen";
            this.confirmChoiceButton.UseVisualStyleBackColor = true;
            this.confirmChoiceButton.Click += new System.EventHandler(this.confirmChoiceButton_Click);
            // 
            // cancelChoiceButton
            // 
            this.cancelChoiceButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelChoiceButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelChoiceButton.ForeColor = System.Drawing.Color.Red;
            this.cancelChoiceButton.Location = new System.Drawing.Point(233, 175);
            this.cancelChoiceButton.Name = "cancelChoiceButton";
            this.cancelChoiceButton.Size = new System.Drawing.Size(102, 28);
            this.cancelChoiceButton.TabIndex = 3;
            this.cancelChoiceButton.Text = "Abbrechen";
            this.cancelChoiceButton.UseVisualStyleBackColor = true;
            // 
            // totalDistanceNumbox
            // 
            this.totalDistanceNumbox.Location = new System.Drawing.Point(9, 22);
            this.totalDistanceNumbox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.totalDistanceNumbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.totalDistanceNumbox.Name = "totalDistanceNumbox";
            this.totalDistanceNumbox.Size = new System.Drawing.Size(154, 23);
            this.totalDistanceNumbox.TabIndex = 2;
            this.totalDistanceNumbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalDistanceNumbox.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.totalDistanceNumbox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DistanceChooser
            // 
            this.AcceptButton = this.confirmChoiceButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelChoiceButton;
            this.ClientSize = new System.Drawing.Size(347, 215);
            this.ControlBox = false;
            this.Controls.Add(this.cancelChoiceButton);
            this.Controls.Add(this.confirmChoiceButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DistanceChooser";
            this.ShowIcon = false;
            this.Text = "Strecke auswählen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalDistanceNumbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox stopAddressTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startAddressTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button getMapsDistanceButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirmChoiceButton;
        private System.Windows.Forms.Button cancelChoiceButton;
        private System.Windows.Forms.NumericUpDown totalDistanceNumbox;
    }
}