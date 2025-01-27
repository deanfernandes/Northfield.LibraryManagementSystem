using System.Security.Cryptography;
using System.Text;

namespace Northfield.LibraryManagementSystem.Library.Services
{
    public static class PasswordService
    {
        public const int SALT_LENGTH_BYTES = 16;

        public static (string hash, string salt) SaltHashPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException();
            }

            //salt pw (random salt)
            byte[] saltBytes = GenerateRandomSaltNew();

            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] passwordSaltBytes = new byte[passwordBytes.Length + saltBytes.Length];
            Buffer.BlockCopy(passwordBytes, 0, passwordSaltBytes, 0, passwordBytes.Length);
            Buffer.BlockCopy(saltBytes, 0, passwordSaltBytes, passwordBytes.Length, saltBytes.Length);

            //hash pw (SHA256)
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(passwordSaltBytes);

                string hashString = Convert.ToBase64String(hashBytes);
                string saltString = Convert.ToBase64String(saltBytes);

                return (hashString, saltString);
            }
        }
        public static bool VerifyPassword(string password, string hash, string salt)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(hash) || string.IsNullOrEmpty(salt))
            {
                throw new ArgumentException();
            }

            byte[] saltBytes = Convert.FromBase64String(salt);

            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] passwordSaltBytes = new byte[passwordBytes.Length + saltBytes.Length];
            Buffer.BlockCopy(passwordBytes, 0, passwordSaltBytes, 0, passwordBytes.Length);
            Buffer.BlockCopy(saltBytes, 0, passwordSaltBytes, passwordBytes.Length, saltBytes.Length);

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(passwordSaltBytes);
                string hashString = Convert.ToBase64String(hashBytes);

                return hashString == hash;
            }
        }

        [Obsolete("GenerateRandomSalt is obsolete. To generate a random salt, use GenerateRandomSaltNew instead.")]
        private static byte[] GenerateRandomSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] saltBytes = new byte[SALT_LENGTH_BYTES];
                rng.GetBytes(saltBytes);

                return saltBytes;
            }
        }
        private static byte[] GenerateRandomSaltNew()
        {
            byte[] saltBytes = new byte[SALT_LENGTH_BYTES];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return saltBytes;
        }

    }
}
