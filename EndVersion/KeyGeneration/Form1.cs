using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyGeneration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void GenerateKey_Click(object sender, EventArgs e)
        {
            
            HashAction.Hash hash = new HashAction.Hash();
            INIManager manager = new INIManager(Directory.GetCurrentDirectory() + "\\License.ini");
            StringOperation stringOperation = new StringOperation();
            if (string.IsNullOrEmpty(txtSerialNumber.Text))
            {
                MessageBox.Show(
                         "Please enter some data or generate them in the main form");
            }
            else
            {
                string result = hash.GenerateKey(txtSerialNumber.Text);
                txtLicenseKey.Text = stringOperation.AddSplit(result);
                manager.WritePrivateString("main", "key", txtLicenseKey.Text);
            }
        }
    }
}
