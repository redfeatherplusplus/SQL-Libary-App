﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library_Entities;

namespace Library_DAOs
{
    public enum BookSearchType { Author, Title, Both, Isbn };

    public interface IBookCheckingDAO
    {
        void checkOut(String isbn, String cardID);
        void checkIn(int loanID);
        List<Book> search(String term);
        List<Book> search(String term, BookSearchType searchType);
    }
}
