using System;
using System.IO;

namespace SimpleLicense
{
    public class License
    {
        public static Tuple<bool, string> CheckLicense()
        {
            string errInfo = "Cannot find the license file.";

            DirectoryInfo hdDir = new DirectoryInfo(".");
            foreach (FileInfo found in hdDir.GetFiles("*.lic"))
            {
                string encrypted = File.ReadAllText(found.FullName);
                if (encrypted == string.Empty) continue;

                string plainText = AesTools.Decrypt(encrypted);
                string[] info = plainText.Split(' ');
                if (!SystemTools.CheckMAC(info[0]))
                {
                    errInfo = "The physical address does not match.";
                    continue;
                }

                DateTime dt = Convert.ToDateTime(info[1]);
                if (DateTime.Compare(dt, DateTime.Now) < 0)
                {
                    errInfo = "Your license is expired.";
                    continue;
                }

                return Tuple.Create(true, Path.GetFileNameWithoutExtension(found.Name));
            }

            return Tuple.Create(false, errInfo);
        }
    }
}
