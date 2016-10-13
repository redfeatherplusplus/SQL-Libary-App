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

namespace Library_App_Controls
{
    public partial class BookItem: UserControl
    {
        private Book book;

        public BookItem()
        {
            InitializeComponent();
        }

        public BookItem(Book book)
        {
            InitializeComponent();

            //generate a list of all authors for the book
            StringBuilder bookAuthors = new StringBuilder();
            foreach (string author in book.Authors)
            {
                bookAuthors.Append(author + ", ");
            }
            bookAuthors.Remove(bookAuthors.Length - 2, 2);

            this.book = book;
            this.bookNameGroupBox.Text = book.Title;
            this.authors.Text = bookAuthors.ToString();
            this.isbn.Text = book.Isbn;
            this.publisher.Text = book.Publisher;
            this.availableCheckBox.Checked = book.Available;
        }

        private void selectedRadioButon_CheckedChanged(object sender, EventArgs e)
        {
            //deselect all other items in the parent
            foreach (Control control in Parent.Controls)
            {
                BookItem item = control as BookItem;
                if (null != item)
                {
                    item.selectedRadioButon.Checked = false;
                }
            }
            this.selectedRadioButon.Checked = true;
        }
    }
}
