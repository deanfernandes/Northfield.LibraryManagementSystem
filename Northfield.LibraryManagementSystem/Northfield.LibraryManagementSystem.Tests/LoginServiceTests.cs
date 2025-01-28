using Northfield.LibraryManagementSystem.Library.Services;
using Moq;
using Northfield.LibraryManagementSystem.Library.Models;

namespace Northfield.LibraryManagementSystem.Tests
{
    [TestClass]

    public class LoginServiceTests
    {
        private Mock<IDataService> _mockDataService = null!;
        private LoginService _loginService = null!;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockDataService = new Mock<IDataService>();
            _loginService = new LoginService(_mockDataService.Object);
        }

        [TestMethod]
        public void Login_ValidUsernamePassword_ReturnTrue()
        {
            // Arrange
            var username = "admin";
            var password = "admin";
            var (hash, salt) = PasswordService.SaltHashPassword(password);
            Admin admin = new Admin(1, username, hash, salt);
            _mockDataService.Setup(ds => ds.SelectAdmin(username)).Returns(admin);

            // Act
            var result = _loginService.Login(username, password);

            // Assert
            Assert.IsTrue(result);
            _mockDataService.Verify(ds => ds.SelectAdmin(username), Times.Once);
        }

        [TestMethod]
        public void Login_InvalidUsername_ReturnFalse()
        {
            // Arrange
            var username = "invalid_username";
            var password = "password123";

            _mockDataService.Setup(ds => ds.SelectAdmin(username)).Returns((Admin?)null);

            // Act
            var result = _loginService.Login(username, password);

            // Assert
            Assert.IsFalse(result);
            _mockDataService.Verify(ds => ds.SelectAdmin(username), Times.Once);
        }

        [TestMethod]
        public void Login_WrongPassword_ReturnsFalse()
        {
            // Arrange
            var username = "admin";
            var password = "wrong_password";

            var correctPassword = "correct_password";
            var (hash, salt) = PasswordService.SaltHashPassword(correctPassword);
            Admin admin = new Admin(1, username, hash, salt);

            _mockDataService.Setup(ds => ds.SelectAdmin(username)).Returns(admin);

            // Act
            var result = _loginService.Login(username, password);

            // Assert
            Assert.IsFalse(result);
            _mockDataService.Verify(ds => ds.SelectAdmin(username), Times.Once);
        }
    }
}
