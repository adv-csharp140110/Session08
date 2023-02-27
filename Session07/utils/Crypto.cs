using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Session07.utils
{
    public static class Crypto
    {
        public static string ToSHA512(this string painText)
        {
            var sha512Alg = SHA512.Create();
            var bytes = Encoding.UTF8.GetBytes(painText);
            var hash = sha512Alg.ComputeHash(bytes);
            return String.Concat(hash.Select( b => b.ToString("X2")).ToArray());
        }
    }
}
