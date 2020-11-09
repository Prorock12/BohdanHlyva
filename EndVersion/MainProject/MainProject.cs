using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainProject
{
    public partial class MainProject : Form
    {
        public MainProject()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void MainProject_Close(object sender, FormClosedEventArgs e)
        {
            EnterForm enterForm = new EnterForm();
            enterForm.Close();
            MainForm mainForm = new MainForm();
            mainForm.Close();
            this.Close();
        }
    }
}
