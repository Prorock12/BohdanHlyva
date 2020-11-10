using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using KeyGeneration;

namespace MainProject
{
    public partial class EnterForm : Form
    {
        StringOperation operation = new StringOperation();
        HashAction.Hash hash = new HashAction.Hash();
        INIManager manager = new INIManager();
        string path = null;
        public EnterForm()
        {
            InitializeComponent();
        }

        private void EnterProgram_Click(object sender, EventArgs e)
        {
            string compareResult = operation.AddSplit(hash.GenerateKey(string.Concat(Data.SerialNumberOut, Data.Availability, manager.GetPrivateString("main","date"))));
            if (hash.Verification(compareResult,manager.GetPrivateString("main","key")))
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
            //this.Close();
            //MainForm mainForm = new MainForm();
            //mainForm.Close();
            //MainProject mainProject = new MainProject();
            //mainProject.Close();
        }

        private void EnterForm_Load(object sender, EventArgs e)
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
    }
}
