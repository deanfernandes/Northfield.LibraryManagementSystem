using Northfield.LibraryManagementSystem.Library.Models;

namespace Northfield.LibraryManagementSystem.Library.Services
{
    public interface IDatabaseService
    {
        public List<Book> SelectAllBooks();
        public Book? SelectBookByIsbn(string isbn);
        public bool InsertBook(Book book);
        public bool UpdateBook(Book book);
        public bool DeleteBook(string isbn);
    }
}
