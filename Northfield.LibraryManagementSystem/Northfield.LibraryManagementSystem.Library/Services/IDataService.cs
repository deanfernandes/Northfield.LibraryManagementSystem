using Northfield.LibraryManagementSystem.Library.Models;

namespace Northfield.LibraryManagementSystem.Library.Services
{
    public interface IDataService
    {
        //Book
        public List<Book> SelectAllBooks();
        public bool InsertBook(Book book);
        public bool UpdateBook(Book book);
        public bool DeleteBook(string isbn);
        public Book? SelectBookByIsbn(string isbn);
        public bool IsBookOnLoan(string isbn);

        //Member
        public List<Member> SelectAllMembers();
        public bool InsertMember(Member member);
        public bool UpdateMember(Member member);
        public bool DeleteMember(string cardNumber);
        public Member? SelectMemberByCardNumber(string cardNumber);

        //Loan
        public List<Loan> SelectAllLoans();
        public bool InsertLoan(Loan loan);
        public bool UpdateLoanReturn(int loanId);

        //Admin
        public Admin? SelectAdmin(string username);
    }
}
