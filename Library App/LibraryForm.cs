using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Library_DAO_Mediator;
using Library_DAOs;
using Library_Entities;

namespace Library_App
{
    public partial class LibraryForm : Form
    {
        private DAO_Mediator mediator;

        //items currently selected in their respective lists
        private BookItem bookItem;
        private BookLoanItem bookLoanItem;
        private FineItem fineItem;

        public LibraryForm()
        {
            InitializeComponent();

            mediator = DAO_Mediator.Instance;
        }

        //getters and setters
        public BookItem BookItem
        {
            get { return bookItem; }
            set { bookItem = value; }
        }
        public BookLoanItem BookLoanItem
        {
            get { return bookLoanItem; }
            set { bookLoanItem = value; }
        }
        public FineItem FineItem
        {
            get { return fineItem; }
            set { fineItem = value; }
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            bookSearchResultsList.Controls.Clear();
            bookItem = null;

            List<Book> books = null;
            if (rbSearchTitle.Checked)
            {
                books = mediator.searchBook(bookSearchTxt.Text, BookSearchType.Title);
            }
            else if (rbSearchAuthor.Checked)
            {
                books = mediator.searchBook(bookSearchTxt.Text, BookSearchType.Author);
            }
            else if (rbSearchBoth.Checked)
            {
                books = mediator.searchBook(bookSearchTxt.Text, BookSearchType.Both);
            }
            else if (rbSearchIsbn.Checked)
            {
                books = mediator.searchBook(bookSearchTxt.Text, BookSearchType.Isbn);
            }
            else
            {
                throw new InvalidOperationException("Searching using undefined search type");
            }

            if (null != books && 0 != books.Count) 
            {
                foreach (Book book in books)
                {
                    bookSearchResultsList.Controls.Add(new BookItem(book, this));
                }
            
                bookSearchResultsGroupBox.Text = "Search Results";
            }
            else 
            {
                bookSearchResultsGroupBox.Text = "No Results";
            }
        }

        private void btnBookCheckout_Click(object sender, EventArgs e)
        {
            CheckoutForm checkoutForm = new CheckoutForm(bookItem);
            checkoutForm.ShowDialog(this);
        }

        private void btnFindBookLoans_Click(object sender, EventArgs e)
        {
            if (null == BookItem)
            {
                MessageBox.Show("Please select a book first.");
            }
            else
            {
                tabController.SelectedTab = bookLoanTab;

                bookLoanSearchResultsList.Controls.Clear();
                bookLoanItem = null;

                List<BookLoan> bookLoans = mediator.searchBookLoan(BookItem.Book);
                if (null != bookLoans && 0 != bookLoans.Count)
                {
                    foreach (BookLoan bookLoan in bookLoans)
                    {
                        bookLoanSearchResultsList.Controls.Add(new BookLoanItem(bookLoan, this));
                    }

                    bookLoanSearchResultsGroupBox.Text = "Search Results";
                }
                else
                {
                    bookLoanSearchResultsGroupBox.Text = "No Results";
                }
            }
        }
    }
}
