using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library_Entities;

namespace Library_DAOs
{
    public enum BookLoanSearchType { Overdue, NotOverdue, Both, CheckedIn };

    public interface IBookLoanDAO
    {
        List<BookLoan> search(String cardID);
        List<BookLoan> search(String cardID, BookLoanSearchType searchType);
        List<BookLoan> search(Book book);
        List<BookLoan> search(Book book, BookLoanSearchType searchType);
    }
}
