using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Outlook_Anonymizer
{
    public class Cipher
    {
        public static string Encrypt(string input, string key)
        {
            if (key.Length<16)
            {
                key += "this_is_the_default_key";
                key = key.Substring(0, 16);
            }

            try
            {
                byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
                TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
                tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
                tripleDES.Mode = CipherMode.ECB;
                tripleDES.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tripleDES.CreateEncryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
                tripleDES.Clear();
                return Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
            catch (Exception e)
            {
                //Inform the user that an exception was raised.  
                //Console.WriteLine("The encryption failed.");
                MessageBox.Show("Failed to encrypt: Invalid key or " + e.Message);
                return "";
                //throw;
            }
        }
        public static string Decrypt(string input, string key)
        {
            if (key.Length < 16)
            {
                key += "this_is_the_default_key";
                key = key.Substring(0, 16);
            }

            try
            {
                byte[] inputArray = Convert.FromBase64String(input);
                TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
                tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
                tripleDES.Mode = CipherMode.ECB;
                tripleDES.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tripleDES.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
                tripleDES.Clear();
                return UTF8Encoding.UTF8.GetString(resultArray);
            }
            catch(Exception e)
            {
                //Inform the user that an exception was raised.  
                //Console.WriteLine("The encryption failed.");
                MessageBox.Show("Failed to decrypt: Invalid key or " + e.Message);
                return "";
                //throw;
            }
        }
    }
}
