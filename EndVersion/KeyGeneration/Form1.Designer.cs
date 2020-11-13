namespace KeyGeneration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.GenerateKey = new System.Windows.Forms.Button();
            this.txtLicenseKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(37, 144);
            this.txtSerialNumber.Multiline = true;
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(252, 104);
            this.txtSerialNumber.TabIndex = 0;
            // 
            // GenerateKey
            // 
            this.GenerateKey.Location = new System.Drawing.Point(295, 183);
            this.GenerateKey.Name = "GenerateKey";
            this.GenerateKey.Size = new System.Drawing.Size(105, 23);
            this.GenerateKey.TabIndex = 1;
            this.GenerateKey.Text = "GenerateKey";
            this.GenerateKey.UseVisualStyleBackColor = true;
            this.GenerateKey.Click += new System.EventHandler(this.GenerateKey_Click);
            // 
            // txtLicenseKey
            // 
            this.txtLicenseKey.Location = new System.Drawing.Point(406, 144);
            this.txtLicenseKey.Multiline = true;
            this.txtLicenseKey.Name = "txtLicenseKey";
            this.txtLicenseKey.Size = new System.Drawing.Size(252, 104);
            this.txtLicenseKey.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLicenseKey);
            this.Controls.Add(this.GenerateKey);
            this.Controls.Add(this.txtSerialNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Button GenerateKey;
        private System.Windows.Forms.TextBox txtLicenseKey;
    }
}

