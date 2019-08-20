using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Continental.CUP.Web.Classes
{
    public class Tools
    {
        public static string GetHashedPassword(AppSettings appSettings, string password)
        {
            byte[] key = KeyDerivation.Pbkdf2(
               password: password,
               salt: Convert.FromBase64String(appSettings.Security_Password_Salt),
               prf: KeyDerivationPrf.HMACSHA1,
               iterationCount: 4096,
               numBytesRequested: 32);

            return Convert.ToBase64String(key);
        }
    }
}
