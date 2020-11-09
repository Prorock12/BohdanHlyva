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
    public partial class MainForm : Form
    {
        HashAction.Hash hash = new HashAction.Hash();
        StringOperation operation = new StringOperation();
        Register register = new Register();
        int count = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void FieldForGeneratedKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //string result;
            //string compareResult = operation.AddSplit(hash.GenerateKey(string.Concat(Data.SerialNumberOut, Data.Availability, register.GetRegisterDate())));
            //if (hash.Verification(compareResult, register.RegisterVerification()))
            //{
            //    result = "This code is yours";
            //    MainProject frm2 = new MainProject();
            //    frm2.Show();
            //}
            //else
            //{
            //    result = "Why you stole that code, you are so poor that you can't buy it?\n Please enter your key"; 
            //}
            ////MessageBox.Show(
            ////result,
            ////"Message",
            ////MessageBoxButtons.OK);
        }

        private void FieldForSavedKey_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void GenerateKey_Click(object sender, EventArgs e)
        //{
        //    if (FieldForEnterKey.Text != null && FieldForEnterKey.Text != string.Empty)
        //    {
        //        string concatString = string.Concat(FieldForEnterKey.Text);
        //        string key = hash.GenerateKey(concatString);
        //        key = operation.AddSplit(key);
        //        FieldForGeneratedKey.Text = key;

        //    }
        //    else
        //    {
        //        MessageBox.Show(
        //            "Please enter serial number",
        //            "Warning",
        //            MessageBoxButtons.OK
        //            );
        //    }
        //}

        private void SaveDate_Click(object sender, EventArgs e)
        {
            register.SaveDataToRegister();
            MessageBox.Show(
                    "Data is saved",
                    "Message",
                    MessageBoxButtons.OK
                    );
        }

        private void Verifycate_Click(object sender, EventArgs e)
        {
            string result;
            if (register.GetRegisterDate() == null)
            {
                MessageBox.Show(
                    "Please save data to register before verification that",
                    "Warning",
                    MessageBoxButtons.OK
                    );
            }
            else
            {
                if (FieldForVerifycate.Text != null && FieldForVerifycate.Text != string.Empty)
                {
                    if (Convert.ToDateTime(register.GetRegisterDate()).AddMonths(1) >= DateTime.Now)
                    {
                        // Substring it is text from FieldForRequestLicense from which was removed date it means 10 last signs
                        //string Substring = FieldForRequestLicense.Text.Remove(FieldForRequestLicense.Text.Length - 10, 10);
                        //string Substring = string.Concat(Data.SerialNumberOut, Data.Availability);
                        //Generation key on data which is taken from entered serial number + Data.Product + Data.Availability + Date which is saved in register
                        string compareResult = hash.GenerateKey(string.Concat(Data.SerialNumberOut, Data.Availability, register.GetRegisterDate()));

                        if (hash.Verification(operation.RemoveSplit(FieldForVerifycate.Text), compareResult))
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
                    else
                    {
                        MessageBox.Show(
                        "Your expiration date is over",
                        "Warning",
                        MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Please enter license key",
                        "Warning",
                        MessageBoxButtons.OK);
                }
            }
        }

        private void RequestLicense_Click(object sender, EventArgs e)
        {
            FieldForRequestLicense.Text = string.Concat(Data.SerialNumberOut, Data.Availability,DateTime.Now.ToString("d"));
        }

        private void FieldForRequestLicense_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveKey_Click(object sender, EventArgs e)
        {
            if (FieldForVerifycate.Text != null && FieldForVerifycate.Text != string.Empty)
            {
                register.SaveKeyToRegister(FieldForVerifycate.Text);
                MessageBox.Show(
                        "License key is saved",
                        "Message",
                        MessageBoxButtons.OK
                        );
            }
            else
            {
                MessageBox.Show(
                        "Please enter license key before save",
                        "Message",
                        MessageBoxButtons.OK
                        );
            }
        }
        private void MainForm_Close(object sender, FormClosedEventArgs e)
        {
            EnterForm enterForm = new EnterForm();
            enterForm.Close();
            this.Close();
            MainProject mainProject = new MainProject();
            mainProject.Close();
        }
    }
}
