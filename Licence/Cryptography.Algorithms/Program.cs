using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace RijndaelManaged_Example
{
    public class RijndaelExample
    {
        private static ManagementObjectSearcher baseboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
        private static ManagementObjectSearcher motherboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_MotherboardDevice");
        static DateTime DateTime = DateTime.Now;
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
        public static void Main()
        {
            GetHash();
            if(RegisterVeryfication()==Veryfication())
            {
                Console.WriteLine("This code is yours:{0}",GetHash());
            }
            else
            {
                Console.WriteLine("Why you stole that code, you are so poor that you can't buy it?");
            }
            
        }
        public static string GetHash()
        {
            try
            {
                Hash.My.Hash hash = new Hash.My.Hash(DateTime);
                string key = hash.HashGet(hash.Result);
                return key;
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public static string RegisterVeryfication()
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey helloKey = currentUserKey.CreateSubKey("UniqueKey");
            string result = helloKey.GetValue("key").ToString();
            helloKey.Close();
            return result;
        }
        public static string Veryfication()
        {
            try
            {
                string SerialNumber = SerialNumberOut;
                string some = Product;
                int ExpirationDate = DateTime.Now.Month;
                string result = string.Concat(SerialNumber, some, ExpirationDate);
                var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(result));
                return string.Concat(hash.Select(b => b.ToString("x2")));
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}