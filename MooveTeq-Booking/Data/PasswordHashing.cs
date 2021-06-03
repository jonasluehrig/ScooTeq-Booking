using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace MooveTeqBooking.Data {
    class PasswordHashing {
        const int SALT_SIZE = 24; // size in bytes
        const int HASH_SIZE = 24; // size in bytes
        const int ITERATIONS = 100000; // number of pbkdf2 iterations

        public static string GetPasswordHash(string CleartextPassword, byte[] Salt = null) {
            // Generate a salt
            byte[] salt = new byte[SALT_SIZE];
            if (Salt is null) {
                RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
                salt = new byte[SALT_SIZE];
                provider.GetBytes(salt);
            } else {
                salt = Salt;
            }

            // Generate the hash
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(CleartextPassword, salt, ITERATIONS);

            return Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(pbkdf2.GetBytes(64));
        }

        public static bool TestPasswordAgainstHash(string CleartextPassword, string Hash) {
            var matches = Regex.Match(Hash, @"^([A-Za-z0-9+=/]+):([A-Za-z0-9+=/]+)$");
            byte[] salt = Convert.FromBase64String(matches.Groups[1].Value);

            var hashedPassword = GetPasswordHash(CleartextPassword, salt);

            return hashedPassword == Hash;
        }
    }
}
