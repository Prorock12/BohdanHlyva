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
            this.txtVerifycate = new System.Windows.Forms.TextBox();
            this.LabelForVerifycation = new System.Windows.Forms.Label();
            this.Verifycate = new System.Windows.Forms.Button();
            this.txtRequestLicense = new System.Windows.Forms.TextBox();
            this.RequestLicense = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.UploadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVerifycate
            // 
            this.txtVerifycate.Location = new System.Drawing.Point(40, 241);
            this.txtVerifycate.Multiline = true;
            this.txtVerifycate.Name = "txtVerifycate";
            this.txtVerifycate.Size = new System.Drawing.Size(276, 103);
            this.txtVerifycate.TabIndex = 2;
            this.txtVerifycate.TextChanged += new System.EventHandler(this.txtVerifycate_TextChanged);
            // 
            // LabelForVerifycation
            // 
            this.LabelForVerifycation.AutoSize = true;
            this.LabelForVerifycation.Location = new System.Drawing.Point(40, 223);
            this.LabelForVerifycation.Name = "LabelForVerifycation";
            this.LabelForVerifycation.Size = new System.Drawing.Size(130, 15);
            this.LabelForVerifycation.TabIndex = 3;
            this.LabelForVerifycation.Text = "Please enter license key";
            // 
            // Verifycate
            // 
            this.Verifycate.Location = new System.Drawing.Point(322, 288);
            this.Verifycate.Name = "Verifycate";
            this.Verifycate.Size = new System.Drawing.Size(129, 23);
            this.Verifycate.TabIndex = 6;
            this.Verifycate.Text = "Verificate";
            this.Verifycate.UseVisualStyleBackColor = true;
            this.Verifycate.Click += new System.EventHandler(this.Verifycate_Click);
            // 
            // txtRequestLicense
            // 
            this.txtRequestLicense.Location = new System.Drawing.Point(40, 126);
            this.txtRequestLicense.Multiline = true;
            this.txtRequestLicense.Name = "txtRequestLicense";
            this.txtRequestLicense.Size = new System.Drawing.Size(276, 94);
            this.txtRequestLicense.TabIndex = 7;
            this.txtRequestLicense.TextChanged += new System.EventHandler(this.FieldForRequestLicense_TextChanged);
            // 
            // RequestLicense
            // 
            this.RequestLicense.Location = new System.Drawing.Point(322, 164);
            this.RequestLicense.Name = "RequestLicense";
            this.RequestLicense.Size = new System.Drawing.Size(129, 23);
            this.RequestLicense.TabIndex = 8;
            this.RequestLicense.Text = "Request License";
            this.RequestLicense.UseVisualStyleBackColor = true;
            this.RequestLicense.Click += new System.EventHandler(this.RequestLicense_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select expiration time";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // UploadFile
            // 
            this.UploadFile.Location = new System.Drawing.Point(323, 259);
            this.UploadFile.Name = "UploadFile";
            this.UploadFile.Size = new System.Drawing.Size(128, 23);
            this.UploadFile.TabIndex = 11;
            this.UploadFile.Text = "Upload File";
            this.UploadFile.UseVisualStyleBackColor = true;
            this.UploadFile.Click += new System.EventHandler(this.UploadFile_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(603, 399);
            this.Controls.Add(this.UploadFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.RequestLicense);
            this.Controls.Add(this.txtRequestLicense);
            this.Controls.Add(this.Verifycate);
            this.Controls.Add(this.LabelForVerifycation);
            this.Controls.Add(this.txtVerifycate);
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Close);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtVerifycate;
        private System.Windows.Forms.Label LabelForVerifycation;
        private System.Windows.Forms.Button Verifycate;
        private System.Windows.Forms.TextBox txtRequestLicense;
        private System.Windows.Forms.Button RequestLicense;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button UploadFile;
    }
}

