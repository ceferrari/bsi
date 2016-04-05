using System.Security.Cryptography;
using System.Text;

namespace Domain
{
    public static class Util
    {
        public static string sha256(string password)
        {
            SHA256Managed crypt = new SHA256Managed();
            StringBuilder hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
            foreach (byte b in crypto)
            {
                hash.Append(b.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
