using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MainProject
{
    public partial class MainProject : Form
    {
        HashAction.Hash hash = new HashAction.Hash();
        StringOperation operation = new StringOperation();
        INIManager manager = new INIManager();
        public MainProject()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            projectDirectory = string.Concat(projectDirectory, "\\bin\\Debug\\netcoreapp3.1\\License.ini");
            manager.Path = projectDirectory;

            Timer MyTimer = new Timer();
            MyTimer.Interval = (60 * 60 * 1000); // 60 mins
            MyTimer.Tick += new EventHandler(timer1_Tick);
            MyTimer.Start();
        }

        private void MainProject_Close(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Close();
            this.Close();
        }

        private void MainProject_Shown(object sender, EventArgs e)
        {
            string compareResult = operation.AddSplit(hash.GenerateKey(string.Concat(Data.SerialNumberOut, Data.Availability, manager.GetPrivateString("main", "date"))));
            if (!hash.Verification(compareResult, manager.GetPrivateString("main", "key")))
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string compareResult = operation.AddSplit(hash.GenerateKey(string.Concat(Data.SerialNumberOut, Data.Availability, manager.GetPrivateString("main", "date"))));
            if (!hash.Verification(compareResult, manager.GetPrivateString("main", "key")))
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }
    }
}
