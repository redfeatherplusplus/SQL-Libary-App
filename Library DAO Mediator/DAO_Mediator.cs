using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library_DAOs;
using Library_Entities;

namespace Library_DAO_Mediator
{
    public class DAO_Mediator
    {
        private static readonly DAO_Mediator instance = new DAO_Mediator();
        private IBookCheckingDAO bookCheckingDAO;
        private IBookLoanDAO bookloanDAO;
        private IBorrowerDAO borrowerDAO;
        private IFineDAO fineDAO;

        private DAO_Mediator() 
        {
            //initialize attributes
            bookCheckingDAO = new BookCheckingDAO();
            bookloanDAO = new BookLoanDAO();
            borrowerDAO = new BorrowerDAO();
            fineDAO = new FineDAO();
        }

        //getters and setters
        public static DAO_Mediator Instance
        {
            get { return DAO_Mediator.instance; }
        }

        //book checking methods
        public void checkOutBook(string isbn, string cardID)
        {
            bookCheckingDAO.checkOut(isbn, cardID);
        }
        public void checkInBook(string loanID)
        {
            bookCheckingDAO.checkIn(loanID);
        }
        public List<Book> searchBook(string term)
        {
            return bookCheckingDAO.search(term);
        }
        public List<Book> searchBook(string term, BookSearchType searchType)
        {
            return bookCheckingDAO.search(term, searchType);
        }

        //book loan methods
        public List<BookLoan> searchBookLoan(String cardID)
        {
            return bookloanDAO.search(cardID);
        }
        public List<BookLoan> searchBookLoan(String cardID, BookLoanSearchType searchType)
        {
            return bookloanDAO.search(cardID, searchType);
        }
        public List<BookLoan> searchBookLoan(Book book)
        {
            return bookloanDAO.search(book);
        }
        public List<BookLoan> searchBookLoan(Book book, BookLoanSearchType searchType)
        {
            return bookloanDAO.search(book, searchType);
        }

        //borrower methods
        public void insertBorrower(Borrower borrower)
        {
            borrowerDAO.insert(borrower);
        }

        //fine methods
        public void setPaidFine(string loanID)
        {
            fineDAO.setPaid(loanID);
        }
        public List<Fine> searchFine(string cardID)
        {
            return fineDAO.search(cardID);
        }
        public List<Fine> searchFine(string cardID, FineSearchType searchType)
        {
            return fineDAO.search(cardID, searchType);
        }
    }
}
