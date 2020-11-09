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
            string path = Directory.GetCurrentDirectory() + "\\License.ini";
            INIManager manager = new INIManager(path);
            StringOperation stringOperation = new StringOperation();
            string result = hash.GenerateKey(FieldForEnterData.Text);
            FieldForLicenseKey.Text = stringOperation.AddSplit(result);

            manager.WritePrivateString("main", "key", FieldForLicenseKey.Text);
            MessageBox.Show(
                path,
                "warning",
                MessageBoxButtons.OK);
        }
    }
}
