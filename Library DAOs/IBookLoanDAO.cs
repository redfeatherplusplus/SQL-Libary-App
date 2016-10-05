using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library_Entities;

namespace Library_DAOs
{
    public enum BookLoanSearchType { Overdue, NotOverDue, Both };

    public interface IBookLoanDAO
    {
        List<BookLoan> search(String cardID);
        List<BookLoan> search(String cardID, BookSearchType searchType);
    }
}
