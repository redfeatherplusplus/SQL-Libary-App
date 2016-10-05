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

        public List<BookLoan> search(string cardID, BookSearchType searchType)
        {
            throw new NotImplementedException();
        }
    }
}
