using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace MooveTeqBooking.Data {
    internal class PasswordHashing {
        private const int SaltSize = 24; // size in bytes
        private const int Iterations = 100000; // number of pbkdf2 iterations

        public static string GetPasswordHash(string cleartextPassword, byte[] existingSalt = null) {
            // Generate a salt
            var salt = new byte[SaltSize];
            if (existingSalt is null) {
                var provider = new RNGCryptoServiceProvider();
                salt = new byte[SaltSize];
                provider.GetBytes(salt);
            } else {
                salt = existingSalt;
            }

            // Generate the hash
            var pbkdf2 = new Rfc2898DeriveBytes(cleartextPassword, salt, Iterations);

            return Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(pbkdf2.GetBytes(64));
        }

        public static bool TestPasswordAgainstHash(string cleartextPassword, string hash) {
            var matches = Regex.Match(hash, @"^([A-Za-z0-9+=/]+):([A-Za-z0-9+=/]+)$");
            byte[] salt = Convert.FromBase64String(matches.Groups[1].Value);

            var hashedPassword = GetPasswordHash(cleartextPassword, salt);

            return hashedPassword == hash;
        }
    }
}
