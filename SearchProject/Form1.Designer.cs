namespace SearchProject
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
            this.ButtonFindFile = new System.Windows.Forms.Button();
            this.txtNeedsToFindFile = new System.Windows.Forms.TextBox();
            this.txtFormats = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBFoundFiles = new System.Windows.Forms.ListBox();
            this.LBWrong = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ButtonStopSearch = new System.Windows.Forms.Button();
            this.txtFindTextInFile = new System.Windows.Forms.TextBox();
            this.BottonFindTextInFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonFindFile
            // 
            this.ButtonFindFile.Location = new System.Drawing.Point(66, 213);
            this.ButtonFindFile.Name = "ButtonFindFile";
            this.ButtonFindFile.Size = new System.Drawing.Size(75, 23);
            this.ButtonFindFile.TabIndex = 1;
            this.ButtonFindFile.Text = "Find File";
            this.ButtonFindFile.UseVisualStyleBackColor = true;
            this.ButtonFindFile.Click += new System.EventHandler(this.ButtonFindFile_Click);
            // 
            // txtNeedsToFindFile
            // 
            this.txtNeedsToFindFile.Location = new System.Drawing.Point(3, 117);
            this.txtNeedsToFindFile.Multiline = true;
            this.txtNeedsToFindFile.Name = "txtNeedsToFindFile";
            this.txtNeedsToFindFile.Size = new System.Drawing.Size(182, 90);
            this.txtNeedsToFindFile.TabIndex = 2;
            // 
            // txtFormats
            // 
            this.txtFormats.AccessibleDescription = "";
            this.txtFormats.Location = new System.Drawing.Point(202, 117);
            this.txtFormats.Multiline = true;
            this.txtFormats.Name = "txtFormats";
            this.txtFormats.Size = new System.Drawing.Size(213, 90);
            this.txtFormats.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(422, 17);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(367, 433);
            this.treeView1.TabIndex = 4;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 76);
            this.checkedListBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please enter format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please enter files name";
            // 
            // LBFoundFiles
            // 
            this.LBFoundFiles.FormattingEnabled = true;
            this.LBFoundFiles.ItemHeight = 15;
            this.LBFoundFiles.Location = new System.Drawing.Point(12, 356);
            this.LBFoundFiles.Name = "LBFoundFiles";
            this.LBFoundFiles.Size = new System.Drawing.Size(173, 94);
            this.LBFoundFiles.TabIndex = 7;
            this.LBFoundFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LBFoundFiles_MouseDoubleClick);
            // 
            // LBWrong
            // 
            this.LBWrong.FormattingEnabled = true;
            this.LBWrong.ItemHeight = 15;
            this.LBWrong.Location = new System.Drawing.Point(201, 356);
            this.LBWrong.Name = "LBWrong";
            this.LBWrong.Size = new System.Drawing.Size(214, 94);
            this.LBWrong.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 242);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(403, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // ButtonStopSearch
            // 
            this.ButtonStopSearch.Location = new System.Drawing.Point(255, 213);
            this.ButtonStopSearch.Name = "ButtonStopSearch";
            this.ButtonStopSearch.Size = new System.Drawing.Size(107, 23);
            this.ButtonStopSearch.TabIndex = 10;
            this.ButtonStopSearch.Text = "Stop Searching";
            this.ButtonStopSearch.UseVisualStyleBackColor = true;
            this.ButtonStopSearch.Click += new System.EventHandler(this.StopSearch_Click);
            // 
            // txtFindTextInFile
            // 
            this.txtFindTextInFile.Location = new System.Drawing.Point(13, 287);
            this.txtFindTextInFile.Multiline = true;
            this.txtFindTextInFile.Name = "txtFindTextInFile";
            this.txtFindTextInFile.Size = new System.Drawing.Size(172, 63);
            this.txtFindTextInFile.TabIndex = 11;
            // 
            // BottonFindTextInFile
            // 
            this.BottonFindTextInFile.Location = new System.Drawing.Point(255, 292);
            this.BottonFindTextInFile.Name = "BottonFindTextInFile";
            this.BottonFindTextInFile.Size = new System.Drawing.Size(107, 23);
            this.BottonFindTextInFile.TabIndex = 12;
            this.BottonFindTextInFile.Text = "Find Text";
            this.BottonFindTextInFile.UseVisualStyleBackColor = true;
            this.BottonFindTextInFile.Click += new System.EventHandler(this.FindTextInFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Please enter some text";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(202, 17);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BottonFindTextInFile);
            this.Controls.Add(this.txtFindTextInFile);
            this.Controls.Add(this.ButtonStopSearch);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LBWrong);
            this.Controls.Add(this.LBFoundFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txtFormats);
            this.Controls.Add(this.txtNeedsToFindFile);
            this.Controls.Add(this.ButtonFindFile);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonFindFile;
        private System.Windows.Forms.TextBox txtNeedsToFindFile;
        private System.Windows.Forms.TextBox txtFormats;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LBFoundFiles;
        private System.Windows.Forms.ListBox LBWrong;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ButtonStopSearch;
        private System.Windows.Forms.TextBox txtFindTextInFile;
        private System.Windows.Forms.Button BottonFindTextInFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

