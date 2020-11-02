using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLicenseKey
{
    public class Register
    {
        Hash.My.Hash My = new Hash.My.Hash();
        public bool SaveToRegister()
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey helloKey = currentUserKey.CreateSubKey("UniqueKey");
            helloKey.SetValue("key", My.GenerateKey("Hello World"));
            helloKey.Close();
            return true;
        }
        public string RegisterVeryfication()
        {
            try
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey helloKey = currentUserKey.CreateSubKey("UniqueKey");
                string result = helloKey.GetValue("key").ToString();
                helloKey.Close();
                return result;
            }
            catch(NullReferenceException ex)
            {
                return null;
            }
        }
    }
}
