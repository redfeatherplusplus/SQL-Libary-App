using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Library_Entities;

namespace Library_App
{
    public partial class BookItem: UserControl
    {
        private LibraryForm parent;
        private Book book;

        public BookItem(LibraryForm parent)
        {
            InitializeComponent();

            this.parent = parent;
        }

        public BookItem(Book book, LibraryForm parent)
        {
            InitializeComponent();

            //generate a list of all authors for the book
            StringBuilder bookAuthors = new StringBuilder();
            foreach (string author in book.Authors)
            {
                bookAuthors.Append(author + ", ");
            }
            bookAuthors.Remove(bookAuthors.Length - 2, 2);

            this.parent = parent;
            this.book = book;

            this.bookNameGroupBox.Text = book.Title;
            this.authors.Text = bookAuthors.ToString();
            this.isbn.Text = book.Isbn;
            this.publisher.Text = book.Publisher;
            this.availableCheckBox.Checked = book.Available;
        }

        private void selectedRadioButon_Click(object sender, EventArgs e)
        {
            //deselect all other items in the parent
            foreach (Control control in Parent.Controls)
            {
                BookItem item = control as BookItem;
                if (null != item)
                {
                    item.selectedRadioButon.Checked = false;
                }
                this.selectedRadioButon.Checked = true;
            }

            parent.BookItem = this;
        }

        //getters and setters
        public Book Book
        {
            get { return book; }
            set { book = value; }
        }
    }
}
