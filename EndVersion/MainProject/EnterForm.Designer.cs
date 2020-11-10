namespace MainProject
{
    partial class EnterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnterProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterProgram
            // 
            this.EnterProgram.Location = new System.Drawing.Point(305, 146);
            this.EnterProgram.Name = "EnterProgram";
            this.EnterProgram.Size = new System.Drawing.Size(135, 109);
            this.EnterProgram.TabIndex = 0;
            this.EnterProgram.Text = "Enter in program";
            this.EnterProgram.UseVisualStyleBackColor = true;
            this.EnterProgram.Click += new System.EventHandler(this.EnterProgram_Click);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnterProgram);
            this.Name = "EnterForm";
            this.Text = "EnterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterForm_Close);
            this.Load += new System.EventHandler(this.EnterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnterProgram;
    }
}