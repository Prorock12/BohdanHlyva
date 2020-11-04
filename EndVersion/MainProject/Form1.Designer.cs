namespace MainProject
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
            this.FieldForEnterKey = new System.Windows.Forms.TextBox();
            this.FieldForVerifycate = new System.Windows.Forms.TextBox();
            this.LabelForVerifycation = new System.Windows.Forms.Label();
            this.GenerateKey = new System.Windows.Forms.Button();
            this.SaveKey = new System.Windows.Forms.Button();
            this.Verifycate = new System.Windows.Forms.Button();
            this.FieldForSerialNumber = new System.Windows.Forms.TextBox();
            this.SerialNumber = new System.Windows.Forms.Button();
            this.FieldForGeneratedKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FieldForEnterKey
            // 
            this.FieldForEnterKey.Location = new System.Drawing.Point(40, 114);
            this.FieldForEnterKey.Multiline = true;
            this.FieldForEnterKey.Name = "FieldForEnterKey";
            this.FieldForEnterKey.Size = new System.Drawing.Size(276, 58);
            this.FieldForEnterKey.TabIndex = 0;
            this.FieldForEnterKey.TextChanged += new System.EventHandler(this.FieldForGeneratedKey_TextChanged);
            // 
            // FieldForVerifycate
            // 
            this.FieldForVerifycate.Location = new System.Drawing.Point(40, 298);
            this.FieldForVerifycate.Multiline = true;
            this.FieldForVerifycate.Name = "FieldForVerifycate";
            this.FieldForVerifycate.Size = new System.Drawing.Size(276, 57);
            this.FieldForVerifycate.TabIndex = 2;
            // 
            // LabelForVerifycation
            // 
            this.LabelForVerifycation.AutoSize = true;
            this.LabelForVerifycation.Location = new System.Drawing.Point(40, 280);
            this.LabelForVerifycation.Name = "LabelForVerifycation";
            this.LabelForVerifycation.Size = new System.Drawing.Size(130, 15);
            this.LabelForVerifycation.TabIndex = 3;
            this.LabelForVerifycation.Text = "Please enter license key";
            // 
            // GenerateKey
            // 
            this.GenerateKey.Location = new System.Drawing.Point(322, 131);
            this.GenerateKey.Name = "GenerateKey";
            this.GenerateKey.Size = new System.Drawing.Size(129, 23);
            this.GenerateKey.TabIndex = 4;
            this.GenerateKey.Text = "Generate Key";
            this.GenerateKey.UseVisualStyleBackColor = true;
            this.GenerateKey.Click += new System.EventHandler(this.GenerateKey_Click);
            // 
            // SaveKey
            // 
            this.SaveKey.Location = new System.Drawing.Point(322, 210);
            this.SaveKey.Name = "SaveKey";
            this.SaveKey.Size = new System.Drawing.Size(129, 23);
            this.SaveKey.TabIndex = 5;
            this.SaveKey.Text = "Save Key";
            this.SaveKey.UseVisualStyleBackColor = true;
            this.SaveKey.Click += new System.EventHandler(this.SaveKey_Click);
            // 
            // Verifycate
            // 
            this.Verifycate.Location = new System.Drawing.Point(322, 307);
            this.Verifycate.Name = "Verifycate";
            this.Verifycate.Size = new System.Drawing.Size(129, 23);
            this.Verifycate.TabIndex = 6;
            this.Verifycate.Text = "Verificate";
            this.Verifycate.UseVisualStyleBackColor = true;
            this.Verifycate.Click += new System.EventHandler(this.Verifycate_Click);
            // 
            // FieldForSerialNumber
            // 
            this.FieldForSerialNumber.Location = new System.Drawing.Point(40, 12);
            this.FieldForSerialNumber.Multiline = true;
            this.FieldForSerialNumber.Name = "FieldForSerialNumber";
            this.FieldForSerialNumber.Size = new System.Drawing.Size(276, 60);
            this.FieldForSerialNumber.TabIndex = 7;
            // 
            // SerialNumber
            // 
            this.SerialNumber.Location = new System.Drawing.Point(322, 29);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(129, 23);
            this.SerialNumber.TabIndex = 8;
            this.SerialNumber.Text = "Get Serial Number";
            this.SerialNumber.UseVisualStyleBackColor = true;
            this.SerialNumber.Click += new System.EventHandler(this.SerialNumber_Click);
            // 
            // FieldForGeneratedKey
            // 
            this.FieldForGeneratedKey.Location = new System.Drawing.Point(40, 192);
            this.FieldForGeneratedKey.Multiline = true;
            this.FieldForGeneratedKey.Name = "FieldForGeneratedKey";
            this.FieldForGeneratedKey.Size = new System.Drawing.Size(276, 58);
            this.FieldForGeneratedKey.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Please enter serial number of your PC";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(603, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FieldForGeneratedKey);
            this.Controls.Add(this.SerialNumber);
            this.Controls.Add(this.FieldForSerialNumber);
            this.Controls.Add(this.Verifycate);
            this.Controls.Add(this.SaveKey);
            this.Controls.Add(this.GenerateKey);
            this.Controls.Add(this.LabelForVerifycation);
            this.Controls.Add(this.FieldForVerifycate);
            this.Controls.Add(this.FieldForEnterKey);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FieldForEnterKey;
        private System.Windows.Forms.TextBox FieldForVerifycate;
        private System.Windows.Forms.Label LabelForVerifycation;
        private System.Windows.Forms.Button GenerateKey;
        private System.Windows.Forms.Button SaveKey;
        private System.Windows.Forms.Button Verifycate;
        private System.Windows.Forms.TextBox FieldForSerialNumber;
        private System.Windows.Forms.Button SerialNumber;
        private System.Windows.Forms.TextBox FieldForGeneratedKey;
        private System.Windows.Forms.Label label1;
    }
}

