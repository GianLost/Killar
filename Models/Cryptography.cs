using System;
using System.Security.Cryptography;
using System.Text;

// usando MD5 Hash para "Criptografar" senha do usuário

namespace Killar.Models
{
    public class Cryptography
    {
        public static string EncryptedText(string password)
        {
            MD5 MD5Hasher = MD5.Create();

            byte[] descryptedByte = Encoding.Default.GetBytes(password);
            byte[] encryptedByte = MD5Hasher.ComputeHash(descryptedByte);

            StringBuilder SB = new StringBuilder();

            foreach (byte b in encryptedByte)
            {
                string DebugB = b.ToString("x2");
                SB.Append(DebugB);
            }

            return SB.ToString();
        }

    }
}