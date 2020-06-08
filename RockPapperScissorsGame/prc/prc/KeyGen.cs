using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace prc
{
    internal static class Generator
    {
        public static string GenerateKey()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[32];
            
            rng.GetBytes(buffer);
            string result = BitConverter.ToString(buffer, 0);
            result = result.Replace("-", "");

            return result;
        }

        public static string GenerateHashHMAC(string key, string message)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();

            Byte[] textBytes = encoding.GetBytes(message);
            Byte[] keyBytes = encoding.GetBytes(key);

            Byte[] hashBytes;

            using (HMACSHA256 hash = new HMACSHA256(keyBytes))
                hashBytes = hash.ComputeHash(textBytes);

            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }
    }
}
