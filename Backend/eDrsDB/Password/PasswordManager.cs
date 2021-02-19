using System.Collections.Generic;
using System.Linq;

namespace eDrsDB.Password
{
    public static class PasswordManager
    {
        public static List<byte[]> CreatePasswordHash(string password)
        {
            var hmac = new System.Security.Cryptography.HMACSHA512();
            var passwordSalt = hmac.Key;
            var passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return new List<byte[]> { passwordSalt, passwordHash };
        }

        public static bool VerifyPassword(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)); // Create hash using password salt.
                if (computedHash.Where((t, i) => t != passwordHash[i]).Any())
                {
                    return false; // if mismatch
                }
            }
            return true; //if no mismatches.
        }
    }
}
