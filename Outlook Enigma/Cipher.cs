using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

//Author: Pierre Amparado (Appsenal) 02/01/2021

namespace Outlook_Anonymizer
{
    public class Cipher
    {
        public static string Encrypt(string input, string key)
        {
            //the key that will go to the encryption algorithm should be 128 bit. 
            //the logic below will ensure that the key have 128 bit.
            if (key.Length<16)
            {
                //increase the string if less than 128 bit
                key += "this_is_the_default_key";
            }

            //trim to 128 bit
            key = key.Substring(0, 16);

            try
            {
                //this piece of codes to encrypt the message was taken from https://www.c-sharpcorner.com/UploadFile/f8fa6c/data-encryption-and-decryption-in-C-Sharp/
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
                //Do not stop the process
                MessageBox.Show("Failed to encrypt: Invalid key or " + e.Message);
                return "";
                //throw;
            }
        }
        public static string Decrypt(string input, string key)
        {
            //the key that will go to the encryption algorithm should be 128 bit. 
            //the logic below will ensure that the key have 128 bit.
            if (key.Length < 16)
            {
                //increase the string if less than 128 bit
                key += "this_is_the_default_key";
            }

            //trim to 128 bit
            key = key.Substring(0, 16);

            try
            {
                //this piece of codes to decrypt the message was taken from https://www.c-sharpcorner.com/UploadFile/f8fa6c/data-encryption-and-decryption-in-C-Sharp/
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
                //Do not stop the process
                MessageBox.Show("Failed to decrypt: Invalid key or " + e.Message);
                return "";
                //throw;
            }
        }
    }
}
