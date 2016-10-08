using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DAOs.SQL
{
    public static class Queries
    {
        public static string BookSearch(string term, BookSearchType searchType)
        {
            switch(searchType)
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
                default:
                    throw new ArgumentException("Invalid Book Search Type: " + searchType);
            }
        }

        public static string AuthorSearch(string isbn)
        {
            return
                "select au.Name " +
                "from authors au, book_authors ba " +
                "where ba.Isbn = \"" + isbn + "\" " +
                "and ba.Author_id = au.Author_id";
        }
    }
}
