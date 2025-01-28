namespace Northfield.LibraryManagementSystem.Library.Services
{
    public class LoginService
    {
        private IDataService _dataService { get; set; }

        public LoginService(IDataService dataService)
        {
            _dataService = dataService;
        }

        public bool Login(string username, string password)
        {
            var admin = _dataService.SelectAdmin(username);
            if (admin == null)
            {
                return false;
            }

            return PasswordService.VerifyPassword(password, admin.PasswordHash, admin.Salt);
        }
    }
}
