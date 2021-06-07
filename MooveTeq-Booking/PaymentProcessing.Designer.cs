
namespace MooveTeqBooking {
    partial class PaymentProcessing {
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
            this.label1 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.processPaymentButton = new System.Windows.Forms.Button();
            this.thanksMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zahlung an ScooTeq";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costLabel
            // 
            this.costLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(17, 54);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(298, 24);
            this.costLabel.TabIndex = 1;
            this.costLabel.Text = "von über 0,00€";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::MooveTeqBooking.Properties.Resources.ScooTec3;
            this.pictureBox1.Location = new System.Drawing.Point(72, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // processPaymentButton
            // 
            this.processPaymentButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processPaymentButton.Image = global::MooveTeqBooking.Properties.Resources.paper_money_16px;
            this.processPaymentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.processPaymentButton.Location = new System.Drawing.Point(12, 377);
            this.processPaymentButton.Name = "processPaymentButton";
            this.processPaymentButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.processPaymentButton.Size = new System.Drawing.Size(298, 31);
            this.processPaymentButton.TabIndex = 2;
            this.processPaymentButton.Text = "Zahlung bestätigen";
            this.processPaymentButton.UseVisualStyleBackColor = true;
            this.processPaymentButton.Click += new System.EventHandler(this.processPaymentButton_Click);
            // 
            // thanksMessageLabel
            // 
            this.thanksMessageLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanksMessageLabel.Location = new System.Drawing.Point(18, 240);
            this.thanksMessageLabel.Name = "thanksMessageLabel";
            this.thanksMessageLabel.Size = new System.Drawing.Size(292, 70);
            this.thanksMessageLabel.TabIndex = 4;
            this.thanksMessageLabel.Text = "Vielen Dank <Firstname> <Lastname> für die Fahrt! Bis zum nächsten Mal :)";
            this.thanksMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 420);
            this.Controls.Add(this.thanksMessageLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.processPaymentButton);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentProcessing";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paybuddy";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Button processPaymentButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label thanksMessageLabel;
    }
}