using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace MainProject
{
    public class Register
    {
        HashAction.Hash My = new HashAction.Hash();
        public bool SaveToRegister()
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey helloKey = currentUserKey.CreateSubKey("UniqueKey");
            //string expirationDate = string.Concat(DateTime.Now.ToString("d"), Data.Availability);
            string expirationDate = DateTime.Now.ToString("d");
            string concatString = string.Concat(Data.SerialNumberOut, Data.Product,Data.Availability,expirationDate);
            helloKey.SetValue("key", My.GenerateKey(concatString));
            helloKey.SetValue("date", expirationDate);
            helloKey.Close();
            return true;
        }
        public string RegisterVerification()
        {
            try
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey helloKey = currentUserKey.CreateSubKey("UniqueKey");
                string result = helloKey.GetValue("key").ToString();
                helloKey.Close();
                return result;
            }
            catch (NullReferenceException ex)
            {
                return null;
            }
        }
        public string GetRegisterDate()
        {
            try
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey helloKey = currentUserKey.CreateSubKey("UniqueKey");
                string result = helloKey.GetValue("date").ToString();
                helloKey.Close();
                return result;
            }
            catch (NullReferenceException ex)
            {
                return null;
            }
        }
    }
}
