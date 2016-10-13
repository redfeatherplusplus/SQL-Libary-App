using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library_Entities;

namespace Library_DAOs.SQL
{
    public static class Queries
    {
        public static string BookCheckOut(string isbn, string cardID)
        {
            return
                "insert into book_loans (Isbn, Card_id) "  +
                "values (" + isbn + ", " + cardID + ") ";
        }

        public static string BookCheckIn(string loanID)
        {
            return
                "update book_loans " +
                "set Date_In = current_date " +
                "where Loan_id = " + loanID + " ";
        }

        public static string BookSearch(string term, BookSearchType searchType)
        {
            switch (searchType)
            {
                case (BookSearchType.Both):
                    return
                        "select bk.*, au.Name " +
                        "from book bk, authors au, book_authors ba " +
                        "where bk.Isbn = ba.Isbn " +
                        "and ba.Author_id = au.Author_id " +
                        "and (bk.Title like \"%" + term + "%\" or au.Name like \"%" + term + "%\") ";
                case (BookSearchType.Title):
                    return
                        "select bk.*, au.Name " +
                        "from book bk, authors au, book_authors ba " +
                        "where bk.Isbn = ba.Isbn " +
                        "and ba.Author_id = au.Author_id " +
                        "and (bk.Title like \"%" + term + "%\") ";
                case (BookSearchType.Author):
                    return
                        "select bk.*, au.Name " +
                        "from book bk, authors au, book_authors ba " +
                        "where bk.Isbn = ba.Isbn " +
                        "and ba.Author_id = au.Author_id " +
                        "and (au.Name like \"%" + term + "%\") ";
                case (BookSearchType.Isbn):
                    return
                        "select bk.*, au.Name " +
                        "from book bk, authors au, book_authors ba " +
                        "where bk.Isbn = ba.Isbn " +
                        "and ba.Author_id = au.Author_id " +
                        "and bk.Isbn = " + term + ") ";
                default:
                    throw new ArgumentException("Invalid Book Search Type: " + searchType);
            }
        }

        public static string BookLoanSearch(string cardID, BookLoanSearchType searchType)
        {
            switch (searchType)
            {
                case (BookLoanSearchType.Overdue):
                    return
                        "select bl.*, bk.Title " +
                        "from book bk, book_loans bl " +
                        "where bl.Card_id = " + cardID + " " +
                        "and bk.Isbn = bl.Isbn " +
                        "and bl.Due_date < current_date " +
                        "and isnull(bl.Date_in) "+
                        "group by bl.Loan_id ";
                case (BookLoanSearchType.NotOverdue):
                    return
                        "select bl.*, bk.Title " +
                        "from book bk, book_loans bl " +
                        "where bl.Card_id = " + cardID + " " +
                        "and bk.Isbn = bl.Isbn " +
                        "and bl.Due_date >= current_date " +
                        "and isnull(bl.Date_in) " +
                        "group by bl.Loan_id ";
                case (BookLoanSearchType.Both):
                    return
                        "select bl.*, bk.Title " +
                        "from book bk, book_loans bl " +
                        "where bl.Card_id = " + cardID + " " +
                        "and bk.Isbn = bl.Isbn " +
                        "and isnull(bl.Date_in) " +
                        "group by bl.Loan_id ";
                case (BookLoanSearchType.CheckedIn):
                    return
                        "select bl.*, bk.Title " +
                        "from book bk, book_loans bl " +
                        "where bl.Card_id = " + cardID + " " +
                        "and bk.Isbn = bl.Isbn " +
                        "and not isnull(bl.Date_in) " +
                        "group by bl.Loan_id ";
                default:
                    throw new ArgumentException("Invalid Book Loan Search Type: " + searchType);
            }
        }

        public static string BookLoanSearch(Book book, BookLoanSearchType searchType)
        {
            switch (searchType)
            {
                case (BookLoanSearchType.Overdue):
                    return
                        "select bl.*, bk.Title " +
                        "from book bk, book_loans bl " +
                        "where bl.Isbn = " + book.Isbn + " " +
                        "and bk.Isbn = bl.Isbn " +
                        "and bl.Due_date < current_date " +
                        "and isnull(bl.Date_in) " +
                        "group by bl.Loan_id ";
                case (BookLoanSearchType.NotOverdue):
                    return
                        "select bl.*, bk.Title " +
                        "from book bk, book_loans bl " +
                        "where bl.Isbn = " + book.Isbn + " " +
                        "and bk.Isbn = bl.Isbn " +
                        "and bl.Due_date >= current_date " +
                        "and isnull(bl.Date_in) " +
                        "group by bl.Loan_id ";
                case (BookLoanSearchType.Both):
                    return
                        "select bl.*, bk.Title " +
                        "from book bk, book_loans bl " +
                        "where bl.Isbn = " + book.Isbn + " " +
                        "and bk.Isbn = bl.Isbn " +
                        "and isnull(bl.Date_in) " +
                        "group by bl.Loan_id ";
                case (BookLoanSearchType.CheckedIn):
                    return
                        "select bl.*, bk.Title " +
                        "from book bk, book_loans bl " +
                        "where bl.Isbn = " + book.Isbn + " " +
                        "and bk.Isbn = bl.Isbn " +
                        "and not isnull(bl.Date_in) " +
                        "group by bl.Loan_id ";
                default:
                    throw new ArgumentException("Invalid Book Loan Search Type: " + searchType);
            }
        }

        public static string BorrowerInsert(Borrower borrower)
        {
            return
                "insert into borrower " +
                "(Ssn, Fname, Lname, Email, Address, City, State, Phone) " +
                "values ( " +
                (null != borrower.Ssn ? "\"" + borrower.Ssn + "\"" : "null") + ", " +
                (null != borrower.Fname ? "\"" + borrower.Fname + "\"" : "null") + ", " +
                (null != borrower.Lname ? "\"" + borrower.Lname + "\"" : "null") + ", " +
                (null != borrower.Email ? "\"" + borrower.Email + "\"" : "null") + ", " +
                (null != borrower.Address ? "\"" + borrower.Address + "\"" : "null") + ", " +
                (null != borrower.City ? "\"" + borrower.City + "\"" : "null") + ", " +
                (null != borrower.State ? "\"" + borrower.State + "\"" : "null") + ", " +
                (null != borrower.Phone ? "\"" + borrower.Phone + "\"" : "null") + ") ";
        }

        public static string FineSetPaid(string loanID)
        {
            return
                "update fines " +
                "set Paid = true " +
                "where Loan_id = " + loanID + " ";
        }

        public static string FineSearch(string cardID, FineSearchType searchType)
        {
            switch (searchType)
            {
                case (FineSearchType.Unpaid):
                    return
                        "select fn.*, bk.Title " +
                        "from fines fn, book bk, book_loans bl " +
                        "where bl.Card_id = " + cardID + " " +
                        "and fn.Loan_id = bl.Loan_id " +
                        "and bl.Isbn = bk.Isbn " +
                        "and fn.Paid = false " +
                        "group by fn.Loan_id ";
                case (FineSearchType.Paid):
                    return
                        "select fn.*, bk.Title " +
                        "from fines fn, book bk, book_loans bl " +
                        "where bl.Card_id = " + cardID + " " +
                        "and fn.Loan_id = bl.Loan_id " +
                        "and bl.Isbn = bk.Isbn " +
                        "and fn.Paid = true " +
                        "group by fn.Loan_id ";
                case (FineSearchType.PaidOrUnpaid):
                    return
                        "select fn.*, bk.Title " +
                        "from fines fn, book bk, book_loans bl " +
                        "where bl.Card_id = " + cardID + " " +
                        "and fn.Loan_id = bl.Loan_id " +
                        "and bl.Isbn = bk.Isbn " +
                        "group by fn.Loan_id ";
                default:
                    throw new ArgumentException("Invalid Fine Search Type: " + searchType);
            }
        }
    }
}
