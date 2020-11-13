using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;

namespace MainProject
{
    public partial class MainForm : Form
    {
        HashAction.Hash hash = new HashAction.Hash();
        StringOperation operation = new StringOperation();
        INIManager manager = new INIManager(Directory.GetCurrentDirectory()+ "\\License.ini");
        int count = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void Verifycate_Click(object sender, EventArgs e)
        {
            string result;
            string compareResult = hash.GenerateKey(string.Concat(Data.SerialNumberOut, Data.Availability, manager.GetPrivateString("main", "date")));
            if (Convert.ToDateTime(manager.GetPrivateString("main", "date")) >= DateTime.Now)
            {
                if (string.IsNullOrEmpty(txtVerifycate.Text))
                {
                    if (count == 3)
                        this.Close();
                    count++;
                    MessageBox.Show(
                    "Please enter key or upload file",
                    "Message",
                    MessageBoxButtons.OK);     
                }
                else
                {
                    if (hash.Verification(operation.RemoveSplit(txtVerifycate.Text), compareResult))
                    {
                        manager.WritePrivateString("main", "key",txtVerifycate.Text);
                        result = "This code is yours";
                        this.Hide();
                        MainProject main = new MainProject();
                        main.Show();
                    }
                    else
                    {
                        result = "Why you stole that code, you are so poor that you can't buy it?\n Please enter your key";
                        count++;
                    }
                    MessageBox.Show(
                    result,
                    "Message",
                    MessageBoxButtons.OK);
                    if (count == 3)
                        this.Close();
                }
            }
            else
            {
                MessageBox.Show(
                   "Your expiration date is over",
                   "Warning",
                   MessageBoxButtons.OK);
            }
        }

        private void RequestLicense_Click(object sender, EventArgs e)
        {
            txtRequestLicense.Text = string.Concat(Data.SerialNumberOut, Data.Availability,dateTimePicker1.Value.ToString("d"));
            manager.WritePrivateString("main", "date",dateTimePicker1.Value.ToString("d"));
            manager.WritePrivateString("main", "serialNumber", txtRequestLicense.Text);
        }

        private void FieldForRequestLicense_TextChanged(object sender, EventArgs e)
        {

        }
        private void MainForm_Close(object sender, FormClosedEventArgs e)
        {
            MainProject mainProject = new MainProject();
            mainProject.Close();
            this.Close();
        }

        private void txtVerifycate_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //string compareResult = operation.AddSplit(hash.GenerateKey(string.Concat(Data.SerialNumberOut, Data.Availability, manager.GetPrivateString("main", "date"))));
            //if (hash.Verification(compareResult, manager.GetPrivateString("main", "endKey")))
            //{
            //    this.Hide();
            //    MainProject x = new MainProject();
            //    x.Show();
            //}
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void UploadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            INIManager manager1 = new INIManager(filename);
            string fileText = manager1.GetPrivateString("main","key");
            txtVerifycate.Text = fileText;
        }
    }
}
