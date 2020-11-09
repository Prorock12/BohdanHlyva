using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainProject
{
    public partial class EnterForm : Form
    {
        StringOperation operation = new StringOperation();
        HashAction.Hash hash = new HashAction.Hash();
        Register register = new Register();
        public EnterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result;
            string compareResult = operation.AddSplit(hash.GenerateKey(string.Concat(Data.SerialNumberOut, Data.Availability, register.GetRegisterDate())));
            if (hash.Verification(compareResult, register.RegisterVerification()))
            {
                this.Hide();
                MainProject x = new MainProject();
                x.Show();
            }
            else
            {
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
        }

        private void EnterForm_Close(object sender, FormClosedEventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Close();
            MainProject mainProject = new MainProject();
            mainProject.Close();
        }
    }
}
