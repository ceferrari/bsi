using System;
using System.Security.Cryptography;
using System.Text;

namespace TrabalhoPO.Shared
{
    public class Utils
    {
        public string _SHA256(string value)
        {
            return BitConverter.ToString(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(value))).Replace("-", "");
        }
    }
}