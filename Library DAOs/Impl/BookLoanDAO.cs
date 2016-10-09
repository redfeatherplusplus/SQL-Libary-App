using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library_Entities;
using Library_DAOs.SQL;

using MySql.Data.MySqlClient;

namespace Library_DAOs
{
    public class BookLoanDAO : LibraryDAO, IBookLoanDAO 
    {
        private ReaderCallback bookLoanCallback(List<BookLoan> bookLoans) 
        {
            ReaderCallback readerCallback = reader =>
            {
                while (reader.Read())
                {
                    BookLoan bookLoan = new BookLoan();

                    bookLoan.Date_out = reader[Tables.BookLoans.Date_out] != DBNull.Value ?
                        (DateTime?)reader[Tables.BookLoans.Date_out] : null;
                    bookLoan.Due_date = reader[Tables.BookLoans.Due_date] != DBNull.Value ?
                        (DateTime?)reader[Tables.BookLoans.Due_date] : null;
                    bookLoan.Date_in = reader[Tables.BookLoans.Date_in] != DBNull.Value ?
                        (DateTime?)reader[Tables.BookLoans.Date_in] : null;

                    bookLoan.Isbn = reader.GetString(Tables.BookLoans.Isbn).Trim();
                    bookLoan.Title = reader.GetString(Tables.Book.Title).Trim();
                    bookLoan.Loan_id = reader.GetInt32(Tables.BookLoans.Loan_id);
                    bookLoan.Card_id = reader.GetInt32(Tables.BookLoans.Card_id);

                    bookLoans.Add(bookLoan);
                }
            };

            return readerCallback;
        }

        public List<BookLoan> search(string cardID)
        {
            return search(cardID, BookLoanSearchType.Overdue);
        }

        public List<BookLoan> search(string cardID, BookLoanSearchType searchType)
        {
            List<BookLoan> bookLoans = new List<BookLoan>();

            string query = Queries.BookLoanSearch(cardID, searchType);
            ReaderCallback readerCallback = bookLoanCallback(bookLoans);
            ExecuteReader(query, readerCallback);

            Console.WriteLine("BookLoan Count: " + bookLoans.Count + "\n");
            foreach (BookLoan bookLoan in bookLoans)
            {
                Console.WriteLine(bookLoan.ToString());
            }

            return bookLoans;
        }

        public List<BookLoan> search(Book book)
        {
            return search(book, BookLoanSearchType.Overdue);
        }

        public List<BookLoan> search(Book book, BookLoanSearchType searchType)
        {
            List<BookLoan> bookLoans = new List<BookLoan>();

            string query = Queries.BookLoanSearch(book, searchType);
            ReaderCallback readerCallback = bookLoanCallback(bookLoans);
            ExecuteReader(query, readerCallback);

            Console.WriteLine("BookLoan Count: " + bookLoans.Count + "\n");
            foreach (BookLoan bookLoan in bookLoans)
            {
                Console.WriteLine(bookLoan.ToString());
            }

            return bookLoans;
        }
    }
}
