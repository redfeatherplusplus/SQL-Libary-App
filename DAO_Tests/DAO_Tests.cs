using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Library_DAOs;
using Library_Entities;

namespace DAO_Tests
{
    [TestClass]
    public class DAO_Tests
    {
        [TestMethod]
        public void TestMethod()
        {
            IBookCheckingDAO bookCheckingDAO = new BookCheckingDAO();
            bookCheckingDAO.search("Will");
        }
    }
}
