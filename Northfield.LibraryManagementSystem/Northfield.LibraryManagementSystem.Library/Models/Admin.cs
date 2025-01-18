namespace Northfield.LibraryManagementSystem.Library.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }

        public Admin(int adminId, string username, string passwordHash, string salt)
        {
            AdminId = adminId;
            Username = username;
            PasswordHash = passwordHash;
            Salt = salt;
        }
    }
}
