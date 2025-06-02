using System;
using System.Security.Cryptography;

namespace Marshell_Web.Controllers
{
    public class EncriptionHelper
    {
        public static string EncText = "1234567890";
        #region Encryption
        public static string EncryptPassword(string password)
        {
            string SafePass = string.Empty;
            var Enc = new Encryption.Encrypt(EncText);
            SafePass = Enc.EncryptData(password);
            return SafePass;
        }
        public static string DecryptPassword(string Password)
        {
            string SafePass = string.Empty;
            var Dec = new Encryption.Decrypt(EncText);
            var ss = Dec.DecryptData(Password);
            try
            {
                SafePass = Dec.DecryptData(Password);
                if (ss == SafePass)
                {
                    return SafePass;
                }
            }
            catch (CryptographicException cp) { Console.WriteLine(cp.Message); return SafePass; }
            return SafePass;
        }

        #endregion
    }
}