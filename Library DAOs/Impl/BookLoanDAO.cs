using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library_Entities;

namespace Library_DAOs
{
    public class BookLoanDAO : LibraryDAO, IBookLoanDAO 
    {
        public List<BookLoan> search(string cardID)
        {
            throw new NotImplementedException();
        }

        public List<BookLoan> search(string cardID, BookLoanSearchType searchType)
        {
            throw new NotImplementedException();
        }

        public List<BookLoan> search(Book book)
        {
            throw new NotImplementedException();
        }

        public List<BookLoan> search(Book book, BookLoanSearchType searchType)
        {
            throw new NotImplementedException();
        }
    }
}
