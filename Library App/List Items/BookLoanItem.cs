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
    public partial class BookLoanItem : UserControl
    {
        private BookLoan bookLoan;

        public BookLoanItem()
        {
            InitializeComponent();
        }

        public BookLoanItem(BookLoan bookLoan)
        {
            InitializeComponent();

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
    }
}
