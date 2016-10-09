using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Entities
{
    public class Fine : IEquatable<Fine>
    {
        private string _Title;
        private decimal _Fine_amt;
        private int _Loan_id;
        private bool _Paid;

        public Fine() { }

        public bool Equals(Fine other)
        {
            return this.Loan_id == other.Loan_id;
        }

        public override int GetHashCode()
        {
            return Loan_id;
        }

        public override string ToString()
        {
            return this.Properties();
        }

        //getters and setters
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
        public decimal Fine_amt
        {
            get { return _Fine_amt; }
            set { _Fine_amt = value; }
        }
        public int Loan_id
        {
            get { return _Loan_id; }
            set { _Loan_id = value; }
        }
        public bool Paid
        {
            get { return _Paid; }
            set { _Paid = value; }
        }
    }
}
