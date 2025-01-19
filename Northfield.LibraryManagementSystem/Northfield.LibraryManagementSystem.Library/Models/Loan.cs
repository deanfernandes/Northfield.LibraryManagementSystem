namespace Northfield.LibraryManagementSystem.Library.Models
{
    public class Loan
    {
        public int LoanId { get; set; }
        public string Isbn { get; set; }
        public string CardNumber { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }

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
    }
}
