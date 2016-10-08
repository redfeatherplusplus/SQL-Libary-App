using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Library_Entities;
using Library_DAOs.SQL;

namespace Library_DAOs
{
    public class BookCheckingDAO : LibraryDAO, IBookCheckingDAO 
    {
        public void checkOut(string isbn, string cardID)
        {
            throw new NotImplementedException();
        }

        public void checkIn(Book book, string cardID)
        {
            throw new NotImplementedException();
        }

        public List<Book> search(string term)
        {
            return search(term, BookSearchType.Both);
        }

        public List<Book> search(string term, BookSearchType searchType)
        {
            List<Book> books = new List<Book>();

            string bookSearchQuery = Queries.BookSearch(term, searchType);

            ReaderCallback bookReaderCallback = reader =>
            {
                while (reader.Read())
                {
                    Book book = new Book();

                    book.Isbn = (string)reader[Tables.Book.Isbn];
                    book.Title = (string)reader[Tables.Book.Title];
                    book.Cover = (string)reader[Tables.Book.Cover];
                    book.Publisher = (string)reader[Tables.Book.Publisher];
                    book.Pages = (int)reader[Tables.Book.Pages];

                    books.Add(book);
                }
            };

            ExecuteReader(bookSearchQuery, bookReaderCallback);
            return books;
        }
    }
}
