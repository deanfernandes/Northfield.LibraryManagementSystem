namespace Northfield.LibraryManagementSystem.Library.Models
{
    public class Loan
    {
        public int LoanId { get; set; }
        public string Isbn { get; set; }
        public string CardNumber { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string BookTitle { get; set; }
        public string MemberFullName { get; set; }
        public string DisplayMember
        {
            get
            {
                return BookTitle + "(" + MemberFullName + ")";
            }
        }

        public Loan(int loanId, string isbn, string cardNumber, DateTime loanDate, DateTime? returnDate)
        {
            LoanId = loanId;
            Isbn = isbn;
            CardNumber = cardNumber;
            LoanDate = loanDate;
            ReturnDate = returnDate;
        }

        public Loan(string isbn, string cardNumber)
        {
            Isbn = isbn;
            CardNumber = cardNumber;
        }
        public Loan(int loanId, string isbn, string cardNumber, DateTime loanDate, DateTime? returnDate, string bookTitle, string memberFullName)
        {
            LoanId = loanId;
            Isbn = isbn;
            CardNumber = cardNumber;
            LoanDate = loanDate;
            ReturnDate = returnDate;
            BookTitle = bookTitle;
            MemberFullName = memberFullName;
        }
    }
}
