using Northfield.LibraryManagementSystem.Library.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Northfield.LibraryManagementSystem.Library.Services
{
    public class SqlDatabaseService : IDataService
    {
        private readonly string _connectionString;

        public SqlDatabaseService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool DeleteBook(string isbn)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("DeleteBook", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Isbn", isbn);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool DeleteMember(string cardNumber)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = "DELETE FROM Member WHERE CardNumber = @CardNumber";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CardNumber", cardNumber);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool InsertBook(Book book)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("InsertBook", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Isbn", book.Isbn);
                    command.Parameters.AddWithValue("@Title", book.Title);
                    command.Parameters.AddWithValue("@Author", book.Author);

                    connection.Open();
                    command.ExecuteNonQuery();

                    return true;
                }
            }

            return false;
        }

        public bool InsertLoan(Loan loan)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = "INSERT INTO Loan (Isbn, CardNumber) VALUES (@Isbn, @CardNumber)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Isbn", loan.Isbn);
                    command.Parameters.AddWithValue("@CardNumber", loan.CardNumber);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool InsertMember(Member member)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = "INSERT INTO Member (CardNumber, FirstName, LastName, EmailAddress) VALUES (@CardNumber, @FirstName, @LastName, @EmailAddress)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CardNumber", member.CardNumber);
                    command.Parameters.AddWithValue("@FirstName", member.FirstName);
                    command.Parameters.AddWithValue("@LastName", member.LastName);
                    command.Parameters.AddWithValue("@EmailAddress", member.EmailAddress);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool IsBookOnLoan(string isbn)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Loan WHERE Isbn = @Isbn AND ReturnDate IS NULL;";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Isbn", isbn);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        public Admin? SelectAdmin(string username)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = "SELECT AdminId, Username, PasswordHash, Salt FROM Admin WHERE Username = @Username";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new Admin(reader.GetInt32(reader.GetOrdinal("AdminId")), reader["Username"].ToString(), reader["PasswordHash"].ToString(), reader["Salt"].ToString());
                        }
                    }
                }
            }

            return null;
        }

        public List<Book> SelectAllBooks()
        {
            var books = new List<Book>();

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("SelectAllBooks", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book(reader["Isbn"].ToString(), reader["Title"].ToString(), reader["Author"].ToString()));
                        }
                    }
                }
            }

            return books;
        }

        public List<Loan> SelectAllLoans()
        {
            var loans = new List<Loan>();

            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = @"SELECT Loan.LoanId, Loan.Isbn, Loan.CardNumber, Loan.LoanDate, Loan.ReturnDate, Book.Title AS BookTitle, Member.FirstName, Member.LastName
                                    FROM Loan
                                    INNER JOIN 
                                        Book ON Loan.Isbn = Book.Isbn
                                    INNER JOIN 
                                        Member ON Loan.CardNumber = Member.CardNumber;";

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime? returnDate = reader.IsDBNull(reader.GetOrdinal("ReturnDate"))
                                                    ? (DateTime?)null
                                                    : reader.GetDateTime(reader.GetOrdinal("ReturnDate"));
                            loans.Add(new Loan(reader.GetInt32(reader.GetOrdinal("LoanId")), reader["Isbn"].ToString(), reader["CardNumber"].ToString(), reader.GetDateTime(reader.GetOrdinal("LoanDate")), returnDate, reader["BookTitle"].ToString(), reader["FirstName"].ToString() + " " + reader["LastName"].ToString()));
                        }
                    }
                }
            }

            return loans;
        }

        public List<Member> SelectAllMembers()
        {
            var members = new List<Member>();

            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = "SELECT CardNumber, FirstName, LastName, EmailAddress FROM Member";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            members.Add(new Member(reader["CardNumber"].ToString(), reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["EmailAddress"].ToString()));
                        }
                    }
                }
            }

            return members;
        }

        public Book? SelectBookByIsbn(string isbn)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = "SELECT Isbn, Title, Author FROM Book WHERE Isbn = @Isbn";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Isbn", isbn);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new Book(reader["Isbn"].ToString(), reader["Title"].ToString(), reader["Author"].ToString());
                        }
                    }
                }
            }

            return null;
        }

        public Member? SelectMemberByCardNumber(string cardNumber)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = "SELECT CardNumber, FirstName, LastName, EmailAddress FROM Member WHERE CardNumber = @CardNumber";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CardNumber", cardNumber);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new Member(reader["CardNumber"].ToString(), reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["EmailAddress"].ToString());
                        }
                    }
                }
            }

            return null;
        }

        public bool UpdateBook(Book book)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("UpdateBook", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Isbn", book.Isbn);
                    command.Parameters.AddWithValue("@Title", book.Title);
                    command.Parameters.AddWithValue("@Author", book.Author);

                    connection.Open();
                    command.ExecuteNonQuery();
                    
                    return true;
                }
            }

            return false;
        }

        public bool UpdateLoanReturn(int loanId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = "UPDATE Loan SET ReturnDate = @ReturnDate WHERE LoanId = @LoanId";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LoanId", loanId);
                    command.Parameters.AddWithValue("@ReturnDate", DateTime.Now);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool UpdateMember(Member member)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = "UPDATE Member SET FirstName = @FirstName, LastName = @LastName, EmailAddress = @EmailAddress WHERE CardNumber = @CardNumber";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CardNumber", member.CardNumber);
                    command.Parameters.AddWithValue("@FirstName", member.FirstName);
                    command.Parameters.AddWithValue("@LastName", member.LastName);
                    command.Parameters.AddWithValue("@EmailAddress", member.EmailAddress);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
