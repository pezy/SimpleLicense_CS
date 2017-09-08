using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace SimpleLicense
{
    public class AesTools
    {
        private static string key = "n#If^*:Y4;-xH&<Ozj/Zybq]~@%,JC'o";

        public static string Encrypt(string plainText)
        {
            byte[] key = Encoding.ASCII.GetBytes(AesTools.key);
            byte[] encrypted = EncryptStringToBytes_Aes(plainText, key);
            return Convert.ToBase64String(encrypted);
        }

        public static string Decrypt(string cipherText)
        {
            byte[] key = Encoding.ASCII.GetBytes(AesTools.key);
            byte[] encrypted = Convert.FromBase64String(cipherText);
            return DecryptStringFromBytes_Aes(encrypted, key);
        }

        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] key)
        {
            byte[] encrypted;
            byte[] IV;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.GenerateIV();
                IV = aesAlg.IV;
                aesAlg.Mode = CipherMode.CBC;
                
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            byte[] combined = new byte[IV.Length + encrypted.Length];
            Array.Copy(IV, 0, combined, 0, IV.Length);
            Array.Copy(encrypted, 0, combined, IV.Length, encrypted.Length);

            return combined;
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherTextCombined, byte[] key)
        {
            // Declare the string used to hold the decrypted text.
            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;

                byte[] IV = new byte[aesAlg.BlockSize / 8];
                byte[] cipherText = new byte[cipherTextCombined.Length - IV.Length];

                Array.Copy(cipherTextCombined, IV, IV.Length);
                Array.Copy(cipherTextCombined, IV.Length, cipherText, 0, cipherText.Length);

                aesAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
    }
}
