using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Entities
{
    public class Borrower
    {
        private int _Card_id;
        private string _Ssn;
        private string _Fname;
        private string _Lname;
        private string _Email;
        private string _Address;
        private string _City;
        private string _State;
        private string _Phone;

        public Borrower() { }

        public override string ToString()
        {
            return this.Properties();
        }

        //getters and setters
        public int Card_id
        {
            get { return _Card_id; }
            set { _Card_id = value; }
        }
        public string Ssn
        {
            get { return _Ssn; }
            set { _Ssn = value; }
        }
        public string Fname
        {
            get { return _Fname; }
            set { _Fname = value; }
        }
        public string Lname
        {
            get { return _Lname; }
            set { _Lname = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        public string State
        {
            get { return _State; }
            set { _State = value; }
        }
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
    }
}
