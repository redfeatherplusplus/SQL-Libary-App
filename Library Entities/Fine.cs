using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Entities
{
    public class Fine
    {
        private string _Title;
        private double _Fine_amt;
        private int _Loan_id;
        private bool _Paid;

        public Fine() { }

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
        public double Fine_amt
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
