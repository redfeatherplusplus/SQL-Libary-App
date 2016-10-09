using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Library_DAOs;
using Library_Entities;

namespace DAO_Tests
{
    [TestClass]
    public class DAO_Tests
    {
        IBookCheckingDAO bookCheckingDAO;
        IBookLoanDAO bookLoanDAO;
        IBorrowerDAO borrowerDAO;
        IFineDAO fineDAO;

        [TestInitialize]
        public void Initialize()
        {
            bookCheckingDAO = new BookCheckingDAO();
            bookLoanDAO = new BookLoanDAO();
            borrowerDAO = new BorrowerDAO();
            fineDAO = new FineDAO();
        }

        [TestMethod]
        public void bookCheckingDAO_Tests()
        {
            bookCheckingDAO.search("Will");

            //bookCheckingDAO.checkOut("9780789709653", "1");
            //bookCheckingDAO.checkOut("9780840796561", "1");
            //bookCheckingDAO.checkOut("9781565122819", "1");
            //bookCheckingDAO.checkOut("9781853262418", "2");
            //bookCheckingDAO.checkOut("9780892838981", "2");
            //bookCheckingDAO.checkOut("9780812966626", "2");
            //bookCheckingDAO.checkOut("9780385261760", "3");
            //bookCheckingDAO.checkOut("9780590411820", "3");

            //bookCheckingDAO.checkIn("4");
        }

        [TestMethod]
        public void bookLoanDAO_Tests()
        {
            bookLoanDAO.search("1", BookLoanSearchType.Both);
            bookLoanDAO.search("2", BookLoanSearchType.Both);
            bookLoanDAO.search("3", BookLoanSearchType.Both);

            bookLoanDAO.search("1", BookLoanSearchType.CheckedIn);
            bookLoanDAO.search("2", BookLoanSearchType.CheckedIn);
            bookLoanDAO.search("3", BookLoanSearchType.CheckedIn);

            Book book = new Book();
            book.Isbn = "9780892838981";

            bookLoanDAO.search(book, BookLoanSearchType.Both);
        }

        [TestMethod]
        public void borrowerDAO_Tests()
        {
            //Borrower borrower = new Borrower();
            //borrower.Ssn = "341-23-1234";
            //borrower.Fname = "Bob";
            //borrower.Lname = "Yensin";
            //borrower.Address = "4333";

            //borrowerDAO.insert(borrower);
        }

        [TestMethod]
        public void fineDAO_Tests()
        {
        }
    }
}
