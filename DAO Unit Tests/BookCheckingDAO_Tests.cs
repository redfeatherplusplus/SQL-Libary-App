using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Library_DAOs;
using Library_Entities;
using DAO_Unit_Tests.Testing_Utilities;

namespace DAO_Unit_Tests
{
    [TestClass]
    public class BookCheckingDAO_Tests
    {
        private IBookCheckingDAO bookCheckingDAO;
        private TestingDAO testingDAO;

        [TestInitialize]
        public void Initialize()
        {
            bookCheckingDAO = new BookCheckingDAO();
            testingDAO = new TestingDAO();
        }

        [TestMethod, ExpectedException(typeof(NotImplementedException))]
        public void CheckOut_TermExists_NonEmptyListReturned()
        {
            List<Book> searchResults = bookCheckingDAO.search("Will");
            Assert.IsTrue(null != searchResults && 0 != searchResults.Count);
        }

        [TestMethod, ExpectedException(typeof(NotImplementedException))]
        public void Search_TermExists_NonEmptyListReturned()
        {
            List<Book> searchResults = bookCheckingDAO.search("Will");
            Assert.IsTrue(null != searchResults && 0 != searchResults.Count);
        }

        [TestMethod, ExpectedException(typeof(NotImplementedException))]
        public void Search_TermDoesNotExist_EmptyListReturned()
        {
            List<Book> searchResults = bookCheckingDAO.search("zz231 ");
            Assert.IsTrue(null != searchResults && 0 == searchResults.Count);
        }
    }
}
