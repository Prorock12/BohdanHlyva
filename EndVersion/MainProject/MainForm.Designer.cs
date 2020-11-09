namespace MainProject
{
    partial class MainForm
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
            this.FieldForVerifycate = new System.Windows.Forms.TextBox();
            this.LabelForVerifycation = new System.Windows.Forms.Label();
            this.SaveDate = new System.Windows.Forms.Button();
            this.Verifycate = new System.Windows.Forms.Button();
            this.FieldForRequestLicense = new System.Windows.Forms.TextBox();
            this.RequestLicense = new System.Windows.Forms.Button();
            this.SaveKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FieldForVerifycate
            // 
            this.FieldForVerifycate.Location = new System.Drawing.Point(40, 201);
            this.FieldForVerifycate.Multiline = true;
            this.FieldForVerifycate.Name = "FieldForVerifycate";
            this.FieldForVerifycate.Size = new System.Drawing.Size(276, 103);
            this.FieldForVerifycate.TabIndex = 2;
            // 
            // LabelForVerifycation
            // 
            this.LabelForVerifycation.AutoSize = true;
            this.LabelForVerifycation.Location = new System.Drawing.Point(40, 183);
            this.LabelForVerifycation.Name = "LabelForVerifycation";
            this.LabelForVerifycation.Size = new System.Drawing.Size(130, 15);
            this.LabelForVerifycation.TabIndex = 3;
            this.LabelForVerifycation.Text = "Please enter license key";
            // 
            // SaveDate
            // 
            this.SaveDate.Location = new System.Drawing.Point(322, 58);
            this.SaveDate.Name = "SaveDate";
            this.SaveDate.Size = new System.Drawing.Size(129, 23);
            this.SaveDate.TabIndex = 5;
            this.SaveDate.Text = "Save Data";
            this.SaveDate.UseVisualStyleBackColor = true;
            this.SaveDate.Click += new System.EventHandler(this.SaveDate_Click);
            // 
            // Verifycate
            // 
            this.Verifycate.Location = new System.Drawing.Point(323, 262);
            this.Verifycate.Name = "Verifycate";
            this.Verifycate.Size = new System.Drawing.Size(129, 23);
            this.Verifycate.TabIndex = 6;
            this.Verifycate.Text = "Verificate";
            this.Verifycate.UseVisualStyleBackColor = true;
            this.Verifycate.Click += new System.EventHandler(this.Verifycate_Click);
            // 
            // FieldForRequestLicense
            // 
            this.FieldForRequestLicense.Location = new System.Drawing.Point(40, 12);
            this.FieldForRequestLicense.Multiline = true;
            this.FieldForRequestLicense.Name = "FieldForRequestLicense";
            this.FieldForRequestLicense.Size = new System.Drawing.Size(276, 94);
            this.FieldForRequestLicense.TabIndex = 7;
            this.FieldForRequestLicense.TextChanged += new System.EventHandler(this.FieldForRequestLicense_TextChanged);
            // 
            // RequestLicense
            // 
            this.RequestLicense.Location = new System.Drawing.Point(322, 29);
            this.RequestLicense.Name = "RequestLicense";
            this.RequestLicense.Size = new System.Drawing.Size(129, 23);
            this.RequestLicense.TabIndex = 8;
            this.RequestLicense.Text = "Request License";
            this.RequestLicense.UseVisualStyleBackColor = true;
            this.RequestLicense.Click += new System.EventHandler(this.RequestLicense_Click);
            // 
            // SaveKey
            // 
            this.SaveKey.Location = new System.Drawing.Point(322, 220);
            this.SaveKey.Name = "SaveKey";
            this.SaveKey.Size = new System.Drawing.Size(130, 23);
            this.SaveKey.TabIndex = 9;
            this.SaveKey.Text = "Save Key";
            this.SaveKey.UseVisualStyleBackColor = true;
            this.SaveKey.Click += new System.EventHandler(this.SaveKey_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(603, 399);
            this.Controls.Add(this.SaveKey);
            this.Controls.Add(this.RequestLicense);
            this.Controls.Add(this.FieldForRequestLicense);
            this.Controls.Add(this.Verifycate);
            this.Controls.Add(this.SaveDate);
            this.Controls.Add(this.LabelForVerifycation);
            this.Controls.Add(this.FieldForVerifycate);
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Close);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FieldForVerifycate;
        private System.Windows.Forms.Label LabelForVerifycation;
        private System.Windows.Forms.Button SaveDate;
        private System.Windows.Forms.Button Verifycate;
        private System.Windows.Forms.TextBox FieldForRequestLicense;
        private System.Windows.Forms.Button RequestLicense;
        private System.Windows.Forms.Button SaveKey;
    }
}

