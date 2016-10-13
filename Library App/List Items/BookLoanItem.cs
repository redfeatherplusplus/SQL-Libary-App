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
    public partial class BookLoanItem : UserControl
    {
        private LibraryForm parent;
        private BookLoan bookLoan;

        public BookLoanItem(LibraryForm parent)
        {
            InitializeComponent();

            this.parent = parent;
        }

        public BookLoanItem(BookLoan bookLoan, LibraryForm parent)
        {
            InitializeComponent();

            this.parent = parent;
            this.bookLoan = bookLoan;

            this.bookNameGroupBox.Text = bookLoan.Title;
            this.dateOut.Text = null != bookLoan.Date_out ?
                bookLoan.Date_out.ToString() : "";
            this.dueDate.Text = null != bookLoan.Due_date ?
                bookLoan.Due_date.ToString() : "";
            this.dateIn.Text = null != bookLoan.Date_in ?
                bookLoan.Date_in.ToString() : "";
            this.isbn.Text = bookLoan.Isbn;
            this.loanID.Text = bookLoan.Loan_id.ToString();
            this.cardID.Text = bookLoan.Card_id.ToString();
        }

        private void BookLoanItem_Click(object sender, EventArgs e)
        {
            //deselect all other items in the parent
            foreach (Control control in Parent.Controls)
            {
                BookLoanItem item = control as BookLoanItem;
                if (null != item)
                {
                    item.selectedRadioButon.Checked = false;
                }
                this.selectedRadioButon.Checked = true;
            }

            parent.BookLoanItem = this;
            Console.WriteLine("pressed RB: " + (null == this));
        }

        //getters and setters
        public BookLoan BookLoan
        {
            get { return bookLoan; }
            set { bookLoan = value; }
        }
    }
}
