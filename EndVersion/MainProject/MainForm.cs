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
using KeyGeneration;
using System.IO;

namespace MainProject
{
    public partial class MainForm : Form
    {
        HashAction.Hash hash = new HashAction.Hash();
        StringOperation operation = new StringOperation();
        INIManager manager = new INIManager();
        int count = 0;
        string path = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int index = 0; index < 4; index++)
            {
                if (index > 0)
                {
                    path = Path.GetDirectoryName(path);
                }
                else
                {
                    path = Path.GetDirectoryName(Directory.GetCurrentDirectory());
                }
            }
            path = path + "\\KeyGeneration\\bin\\Debug\\netcoreapp3.1\\License.ini";
            manager.Path = path;
        }
        private void Verifycate_Click(object sender, EventArgs e)
        {
            string result;
            if (string.IsNullOrEmpty(manager.GetPrivateString("main", "key")))
            {
                MessageBox.Show(
                    "Please generate license key before verification it",
                    "Warning",
                    MessageBoxButtons.OK
                    );
            }
            else
            {
                string compareResult = hash.GenerateKey(string.Concat(Data.SerialNumberOut, Data.Availability, manager.GetPrivateString("main","date")));
                if (Convert.ToDateTime(manager.GetPrivateString("main","date")).AddMonths(1) >= DateTime.Now)
                {
                    if (string.IsNullOrEmpty(txtVerifycate.Text))
                    {
                        if (hash.Verification(operation.RemoveSplit(manager.GetPrivateString("main", "key")), compareResult))
                        {
                            result = "This code is yours";
                            manager.WritePrivateString("main", "endKey", manager.GetPrivateString("main", "key"));
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
                    else
                    {
                        if (hash.Verification(operation.RemoveSplit(txtVerifycate.Text), compareResult))
                        {
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
        }

        private void RequestLicense_Click(object sender, EventArgs e)
        {
            txtRequestLicense.Text = string.Concat(Data.SerialNumberOut, Data.Availability,DateTime.Now.ToString("d"));
            manager.WritePrivateString("main", "date", DateTime.Now.ToString("d"));
            manager.WritePrivateString("main", "serialNumber", txtRequestLicense.Text);
        }

        private void FieldForRequestLicense_TextChanged(object sender, EventArgs e)
        {

        }
        private void MainForm_Close(object sender, FormClosedEventArgs e)
        {
            EnterForm enterForm = new EnterForm();
            enterForm.Close();
            this.Close();
        }

        private void txtVerifycate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
