using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareLicenseKey
{
    public partial class Form1 : Form
    {
        static DateTime DateTime = DateTime.Now;
        Hash.My.Hash hash = new Hash.My.Hash(DateTime);
        bool IsSaved = false;
        public Form1()
        {          
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string key = hash.GenerateKey("Hello World");
            textBox2.Text = key;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            IsSaved=register.SaveToRegister();
            listBox2.Items.Add("Your license key is saved");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Register register = new Register();
 //           if (!IsSaved)
            if (register.RegisterVeryfication() == null)
            {
                MessageBox.Show(
                    "Please save data to register before verification that",
                    "Warning",
                    MessageBoxButtons.OK
                    );
            }
            else
            {
                hash.Veryfication(textBox1.Text);
                MessageBox.Show(
                hash.Veryfication(textBox1.Text),
                "Message",
                MessageBoxButtons.OK);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
