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
            ReaderCallback bookReaderCallback = bookReader =>
            {
                while (bookReader.Read())
                {
                    Book book = new Book();

                    book.Isbn = bookReader.GetString(Tables.Book.Isbn).Trim();
                    
                    if (books.Contains(book)) 
                    {
                        book = books[books.IndexOf(book)];
                        book.Authors.Add(bookReader.GetString(Tables.Authors.Name).Trim());
                    }
                    else
                    {
                        book.Title = bookReader.GetString(Tables.Book.Title).Trim();
                        book.Cover = bookReader.GetString(Tables.Book.Cover).Trim();
                        book.Publisher = bookReader.GetString(Tables.Book.Publisher).Trim();
                        book.Pages = bookReader.GetInt32(Tables.Book.Pages);
                        book.Authors.Add(bookReader.GetString(Tables.Authors.Name).Trim());
                        books.Add(book);
                    }
                }
            };
            ExecuteReader(bookSearchQuery, bookReaderCallback);

            foreach (Book book in books) 
            { 
                Console.WriteLine(book.ToString()); 
            }
            Console.WriteLine(books.Count);
            return books;
        }
    }
}
