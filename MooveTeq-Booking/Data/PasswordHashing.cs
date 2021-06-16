using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ScooTeqBooking.Data {
    internal static class PasswordHashing {
        private const int SaltSize = 24; // size in bytes
        private const int Iterations = 5000; // number of pbkdf2 iterations

        public static string GetPasswordHash(string cleartextPassword, byte[] existingSalt = null) {
            // Generate a salt
            byte[] salt;
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

        public static bool TestPasswordAgainstHash(string cleartextPassword, string hash)
        {
            if (string.IsNullOrEmpty(hash))
            {
                return false;
            }

            var matches = Regex.Match(hash, @"^([A-Za-z0-9+=/]+):([A-Za-z0-9+=/]+)$");
            var salt = Convert.FromBase64String(matches.Groups[1].Value);

            var hashedPassword = GetPasswordHash(cleartextPassword, salt);

            return hashedPassword == hash;
        }
    }
}
