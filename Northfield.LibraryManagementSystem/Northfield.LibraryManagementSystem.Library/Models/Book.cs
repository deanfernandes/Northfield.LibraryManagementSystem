namespace Northfield.LibraryManagementSystem.Library.Models
{
    public class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string isbn, string title, string author)
        {
            Isbn = isbn;
            Title = title;
            Author = author;
        }
    }
}
