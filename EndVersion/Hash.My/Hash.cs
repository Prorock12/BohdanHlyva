using Microsoft.Win32;
using System;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace HashAction
{
    public class Hash
    {
        
        public Hash()
        {

        }
        public string GenerateKey(string input)
        {               
            try
            {
                if (input == null || input == string.Empty)
                {
                    throw new ArgumentException("Value cannot be null.");
                }
                else
                {
                    var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
                    string result = string.Concat(hash.Select(b => b.ToString("X2")));
                    return result;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool Verification(string input,string registerData)
        {
            try
            {
                if (registerData == input)
                {
                    //return "This code is yours";
                    return true;
                }
                else
                {
                    //return "Why you stole that code, you are so poor that you can't buy it?";
                    return false;
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }
}
