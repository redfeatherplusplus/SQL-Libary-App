using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library_Entities;

namespace Library_DAOs
{
    public enum BookSearchType { Author, Title, Both };

    public interface IBookCheckingDAO
    {
        void checkOut(Book book, String cardID);
        void checkIn(Book book, String cardID);
        List<Book> search(String term);
        List<Book> search(String term, BookSearchType searchType);
    }
}
