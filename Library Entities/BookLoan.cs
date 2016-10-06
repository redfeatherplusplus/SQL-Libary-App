using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Entities
{
    public class BookLoan
    {
        private DateTime _Date_out;
        private DateTime _Due_date;
        private DateTime _Date_in;        
        private string _Isbn;
        private int _Loan_id;
        private int _Card_id;

        public BookLoan() { }

        public override string ToString()
        {
            return this.Properties();
        }

        //getters and setters
        public DateTime Date_out
        {
            get { return _Date_out; }
            set { _Date_out = value; }
        }
        public DateTime Due_date
        {
            get { return _Due_date; }
            set { _Due_date = value; }
        }
        public DateTime Date_in
        {
            get { return _Date_in; }
            set { _Date_in = value; }
        }
        public string Isbn
        {
            get { return _Isbn; }
            set { _Isbn = value; }
        }
        public int Loan_id
        {
            get { return _Loan_id; }
            set { _Loan_id = value; }
        }
        public int Card_id
        {
            get { return _Card_id; }
            set { _Card_id = value; }
        }
    }
}
