using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DAOs.SQL
{
    public static class Tables
    {
        public class Book
        {
            public const string Isbn = "Isbn";
            public const string Title = "Title";
            public const string Cover = "Cover";
            public const string Publisher = "Publisher";
            public const string Pages = "Pages";
            public const string Available = "Available";
        }

        public class Authors
        {
            public const string Author_id = "Author_id";
            public const string Name = "Name";
        }

        public class Book_Authors
        {
            public const string Author_id = "Author_id";
            public const string Isbn = "Isbn";
        }

        public class Borrower
        {
            public const string Card_id = "Card_id";
            public const string Ssn = "Ssn";
            public const string Fname = "Fname";
            public const string Lname = "Lname";
            public const string Email = "Email";
            public const string Address = "Address";
            public const string City = "City";
            public const string State = "State";
            public const string Phone = "Phone";

        }

        public class Book_Loans
        {
            public const string Loan_id = "Loan_id";
            public const string Isbn = "Isbn";
            public const string Card_id = "Card_id";
            public const string Date_Out = "Date_out";
            public const string Due_date = "Due_date";
            public const string Date_in = "Date_in";
        }

        public class Fines
        {
            public const string Loan_id = "Loan_id";
            public const string Fine_amt = "Fine_amt";
            public const string Paid = "Paid";
        }
    }
}
