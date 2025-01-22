using Northfield.LibraryManagementSystem.Library.Services;

namespace Northfield.LibraryManagementSystem.Tests
{
    [TestClass]

    public class PasswordServiceTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SaltHashPassword_EmptyPassword_ThrowsException()
        {
            // Arrange
            string emptyPassword = string.Empty;

            // Act
            var res = PasswordService.SaltHashPassword(emptyPassword);

            // Assert
        }

        [TestMethod]
        public void SaltHashPassword_ValidPassword_ReturnsNonEmptyHashAndSalt()
        {
            // Arrange
            string validPassword = "StrongPassword123!";

            // Act
            var (hash, salt) = PasswordService.SaltHashPassword(validPassword);

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(hash), "Hash should not be empty.");
            Assert.IsFalse(string.IsNullOrEmpty(salt), "Salt should not be empty.");
        }

        [TestMethod]
        public void SaltHashPassword_MultipleCalls_ReturnsUniqueSalts()
        {
            // Arrange
            string validPassword = "StrongPassword123!";

            // Act
            var (_, salt1) = PasswordService.SaltHashPassword(validPassword);
            var (_, salt2) = PasswordService.SaltHashPassword(validPassword);

            // Assert
            Assert.AreNotEqual(salt1, salt2, "Each call should generate a unique salt.");
        }

        [TestMethod]
        public void SaltHashPassword_DifferentPasswords_ReturnsDifferentHash()
        {
            // Arrange
            string password1 = "Password1";
            string password2 = "Password2";

            // Act
            var (hash1, _) = PasswordService.SaltHashPassword(password1);
            var (hash2, _) = PasswordService.SaltHashPassword(password2);

            // Assert
            Assert.AreNotEqual(hash1, hash2, "Different passwords should produce different hashes.");
        }

        [TestMethod]
        public void VerifyPassword_SamePassword_ReturnTrue()
        {
            // Arrange
            string password = "admin";
            (string hash, string salt) = PasswordService.SaltHashPassword(password);

            // Act
            bool result = PasswordService.VerifyPassword(password, hash, salt);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void VerifyPassword_DifferentPassword_ReturnFalse()
        {
            // Arrange
            string password = "admin";
            string wrongPassword = "bob";
            (string hash, string salt) = PasswordService.SaltHashPassword(password);

            // Act
            bool result = PasswordService.VerifyPassword(wrongPassword, hash, salt);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void VerifyPassword_EmptyPassword_ThrowsException()
        {
            // Arrange
            string password = "";
            string hash = "dummyHash";
            string salt = "dummySalt";

            // Act
            PasswordService.VerifyPassword(password, hash, salt);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void VerifyPassword_EmptyHash_ThrowsException()
        {
            // Arrange
            string password = "dummyPassword";
            string hash = "";
            string salt = "dummySalt";

            // Act
            PasswordService.VerifyPassword(password, hash, salt);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void VerifyPassword_EmptySalt_ThrowsException()
        {
            // Arrange
            string password = "dummyPassword";
            string hash = "dummyHash";
            string salt = "";

            // Act
            PasswordService.VerifyPassword(password, hash, salt);
        }
    }
}
