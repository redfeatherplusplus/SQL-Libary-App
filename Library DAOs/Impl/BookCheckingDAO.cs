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
            string query = Queries.BookCheckOut(isbn, cardID);
            ExecuteNonQuery(query);
        }

        public void checkIn(string loanID)
        {
            string query = Queries.BookCheckIn(loanID);
            ExecuteNonQuery(query);
        }

        public List<Book> search(string term)
        {
            return search(term, BookSearchType.Both);
        }

        public List<Book> search(string term, BookSearchType searchType)
        {
            List<Book> books = new List<Book>();

            string query = Queries.BookSearch(term, searchType);
            ReaderCallback readerCallback = reader =>
            {
                while (reader.Read())
                {
                    Book book = new Book();

                    book.Isbn = reader.GetString(Tables.Book.Isbn).Trim();
                    
                    if (books.Contains(book)) 
                    {
                        book = books[books.IndexOf(book)];
                        book.Authors.Add(reader.GetString(Tables.Authors.Name).Trim());
                    }
                    else
                    {
                        book.Title = reader.GetString(Tables.Book.Title).Trim();
                        book.Cover = reader.GetString(Tables.Book.Cover).Trim();
                        book.Publisher = reader.GetString(Tables.Book.Publisher).Trim();
                        book.Pages = reader.GetInt32(Tables.Book.Pages);
                        book.Available = reader.GetBoolean(Tables.Book.Available);
                        book.Authors.Add(reader.GetString(Tables.Authors.Name).Trim());
                        
                        books.Add(book);
                    }
                }
            };
            ExecuteReader(query, readerCallback);

            Console.WriteLine("Book Count: " + books.Count + "\n");
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }

            return books;
        }
    }
}
