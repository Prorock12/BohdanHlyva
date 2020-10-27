using Microsoft.Win32;
using System;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace Hash.My
{
    public class Hash
    {
        string SerialNumber = SerialNumberOut;
        string some=Product;
        int ExpirationDate= DateTime.Now.Month;
        int salt;
        string result;
        public string Result 
        {
            get
            {
                return result;
            }
        }
        public Hash(DateTime dateTime)
        {
            ExpirationDate = dateTime.Month;
             result = string.Concat(SerialNumber, some, ExpirationDate);
        }
        public Hash(int salt, DateTime dateTime)
        {
            ExpirationDate = dateTime.Month;
            this.salt = salt;
            result = string.Concat(SerialNumber, some, ExpirationDate,salt);
        }
        public string HashGet(string input)
        {
                var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
                string result = string.Concat(hash.Select(b => b.ToString("x2")));
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey helloKey = currentUserKey.CreateSubKey("UniqueKey");
                helloKey.SetValue("key", result);
                helloKey.Close();
                return result;
        }
        private static ManagementObjectSearcher baseboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
        private static ManagementObjectSearcher motherboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_MotherboardDevice");
        static public string Product
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in baseboardSearcher.Get())
                    {
                        return queryObj["Product"].ToString();
                    }
                    return "";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }
        static public string SerialNumberOut
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in baseboardSearcher.Get())
                    {
                        return queryObj["SerialNumber"].ToString();
                    }
                    return "";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }
    }
}
