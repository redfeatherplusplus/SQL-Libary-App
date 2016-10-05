using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library_Entities;

namespace Library_DAOs
{
    public class BookCheckingDAO : LibraryDAO, IBookCheckingDAO 
    {
        public void checkOut(Book book, string cardID)
        {
            throw new NotImplementedException();
        }

        public void checkIn(Book book, string cardID)
        {
            throw new NotImplementedException();
        }

        public List<Book> search(string term)
        {
            throw new NotImplementedException();
        }

        public List<Book> search(string term, BookSearchType searchType)
        {
            throw new NotImplementedException();
        }
    }
}
