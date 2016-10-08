using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Entities
{
    public class Book : IEquatable<Book>
    {
        private List<string> _Authors;
        private string _Isbn;
        private string _Title;
        private string _Cover;
        private string _Publisher;
        private int _Pages;
        private bool _Available;

        public Book()
        {
            _Authors = new List<string>();
        }

        public bool Equals(Book other)
        {
            return this.Isbn == other.Isbn;
        }

        public override int GetHashCode()
        {
            return int.Parse(Isbn);
        }

        public override string ToString()
        {
            return this.Properties();
        }

        //getters and setters
        public List<string> Authors
        {
            get { return _Authors; }
            set { _Authors = value; }
        }
        public string Isbn
        {
            get { return _Isbn; }
            set { _Isbn = value; }
        }
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
        public string Cover
        {
            get { return _Cover; }
            set { _Cover = value; }
        }
        public string Publisher
        {
            get { return _Publisher; }
            set { _Publisher = value; }
        }
        public int Pages
        {
            get { return _Pages; }
            set { _Pages = value; }
        }
        public bool Available
        {
            get { return _Available; }
            set { _Available = value; }
        }

    }
}
