using System.Security.Cryptography;
using System.Text;

namespace Amf.PeladaFC.Infraestrutura.Security
{
    public static class CryptoHelper
    {
        public static string GenerateSHA256(string plainText)
        {
            StringBuilder builder = new StringBuilder();

            using (SHA256 hash = SHA256.Create())
            {
                Encoding encoding = Encoding.UTF8;
                byte[] result = hash.ComputeHash(encoding.GetBytes(plainText));

                foreach (byte b in result)
                    builder.Append(b.ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
