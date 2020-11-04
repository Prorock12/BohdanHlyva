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

namespace MainProject
{
    public partial class Form1 : Form
    {
        HashAction.Hash hash = new HashAction.Hash();
        StringOperation operation = new StringOperation();
        Register register = new Register();
        public Form1()
        {
            InitializeComponent();
        }

        private void FieldForGeneratedKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FieldForSavedKey_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GenerateKey_Click(object sender, EventArgs e)
        {
            if (FieldForEnterKey.Text != null && FieldForEnterKey.Text != string.Empty)
            {
                string expirationDate = DateTime.Now.ToString("d");
                string concatString = string.Concat(FieldForEnterKey.Text, Data.Product,Data.Availability, expirationDate);
                string key = hash.GenerateKey(concatString);
                key = operation.AddSplit(key);
                FieldForGeneratedKey.Text = key;

            }
            else
            {
                MessageBox.Show(
                    "Please enter serial number",
                    "Warning",
                    MessageBoxButtons.OK
                    );
            }
        }

        private void SaveKey_Click(object sender, EventArgs e)
        {
            register.SaveToRegister();
            MessageBox.Show(
                    "License key is saved",
                    "Message",
                    MessageBoxButtons.OK
                    );
        }

        private void Verifycate_Click(object sender, EventArgs e)
        {
            string result;
            if (register.RegisterVerification() == null)
            {
                MessageBox.Show(
                    "Please save data to register before verification that",
                    "Warning",
                    MessageBoxButtons.OK
                    );
            }
            else
            {
                if (Convert.ToDateTime(register.GetRegisterDate()).AddMonths(1) >= DateTime.Now)
                {
                    //Generation key on data which is taken from entered serial number + Data.Product + Data.Availability + Date which is saved in register
                    string compareResult = hash.GenerateKey(string.Concat(FieldForEnterKey.Text, Data.Product, Data.Availability, register.GetRegisterDate()));

                    if (hash.Verification(operation.RemoveSplit(FieldForVerifycate.Text), compareResult))
                    {
                        result = "This code is yours";
                    }
                    else
                    {
                        result = "Why you stole that code, you are so poor that you can't buy it?\n Please enter your key";
                    }
                    MessageBox.Show(
                    result,
                    "Message",
                    MessageBoxButtons.OK);
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

        private void SerialNumber_Click(object sender, EventArgs e)
        {
            FieldForSerialNumber.Text = Data.SerialNumberOut;
        }
    }
}
