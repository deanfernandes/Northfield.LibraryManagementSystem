namespace Northfield.LibraryManagementSystem.Library.Models
{
    public class Member
    {
        public string CardNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public Member(string cardNumber, string firstName, string lastName, string emailAddress)
        {
            CardNumber = cardNumber;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }
    }
}
