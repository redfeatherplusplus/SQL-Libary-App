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

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            bookSearchResultList.Controls.Clear();
            bookItem = null;

            List<Book> books = null;
            if (rbSearchTitle.Checked)
            {
                books = mediator.searchBook(bookSearchText.Text, BookSearchType.Title);
            }
            else if (rbSearchAuthor.Checked)
            {
                books = mediator.searchBook(bookSearchText.Text, BookSearchType.Author);
            }
            else if (rbSearchTitleAndAuthor.Checked)
            {
                books = mediator.searchBook(bookSearchText.Text, BookSearchType.Both);
            }
            else if (rbSearchIsbn.Checked)
            {
                books = mediator.searchBook(bookSearchText.Text, BookSearchType.Isbn);
            }
            else
            {
                throw new InvalidOperationException("Searching using undefined search type");
            }

            if (null != books && 0 != books.Count) 
            {
                foreach (Book book in books)
                {
                    bookSearchResultList.Controls.Add(new BookItem(book, this));
                }
            
                bookSearchResultGroupBox.Text = "Search Results";
            }
            else 
            {
                bookSearchResultGroupBox.Text = "No Results";
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

                bookLoanSearchResultList.Controls.Clear();
                rbSearchOverdueOrNotOverdue.Checked = true;
                bookLoanItem = null;

                List<BookLoan> bookLoans = mediator.searchBookLoan(BookItem.Book);
                if (null != bookLoans && 0 != bookLoans.Count)
                {
                    foreach (BookLoan bookLoan in bookLoans)
                    {
                        bookLoanSearchResultList.Controls.Add(new BookLoanItem(bookLoan, this));
                    }

                    bookLoanSearchResultGroupBox.Text = "Search Results";
                }
                else
                {
                    bookLoanSearchResultGroupBox.Text = "No Results";
                }
            }
        }

        private void btnBookLoanSearch_Click(object sender, EventArgs e)
        {
            bookLoanSearchResultList.Controls.Clear();
            bookLoanItem = null;

            List<BookLoan> bookLoans = null;
            if (rbSearchOverdue.Checked)
            {
                bookLoans = mediator.searchBookLoan(bookLoanSearchText.Text, BookLoanSearchType.Overdue);
            }
            else if (rbSearchNotOverdue.Checked)
            {
                bookLoans = mediator.searchBookLoan(bookLoanSearchText.Text, BookLoanSearchType.NotOverdue);
            }
            else if (rbSearchOverdueOrNotOverdue.Checked)
            {
                bookLoans = mediator.searchBookLoan(bookLoanSearchText.Text, BookLoanSearchType.Both);
            }
            else if (rbSearchCheckedIn.Checked)
            {
                bookLoans = mediator.searchBookLoan(bookLoanSearchText.Text, BookLoanSearchType.CheckedIn);
            }
            else
            {
                throw new InvalidOperationException("Searching using undefined search type");
            }

            if (null != bookLoans && 0 != bookLoans.Count)
            {
                foreach (BookLoan bookLoan in bookLoans)
                {
                    bookLoanSearchResultList.Controls.Add(new BookLoanItem(bookLoan, this));
                }

                bookLoanSearchResultGroupBox.Text = "Search Results";
            }
            else
            {
                bookLoanSearchResultGroupBox.Text = "No Results";
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (null == bookLoanItem) 
            {
                MessageBox.Show("Please select a book loan first");
            }
            else
            {
                try
                {
                    mediator.checkInBook(bookLoanItem.BookLoan.Loan_id);
                    MessageBox.Show("Check-in success!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(DAO_Error_Handler.Instance.getMessage(exception));
                }
            }
        }

        private void btnAddNewBorrower_Click(object sender, EventArgs e)
        {
            AddNewBorrowerForm addBorrowerForm = new AddNewBorrowerForm();
            addBorrowerForm.ShowDialog(this);
        }

        private void btnFineSearch_Click(object sender, EventArgs e)
        {
            fineSearchResultList.Controls.Clear();
            fineItem = null;

            List<Fine> fines = null;
            if (rbSearchFinePaid.Checked)
            {
                fines = mediator.searchFine(fineSearchText.Text, FineSearchType.Paid);
            }
            else if (rbSearchFineUnpaid.Checked)
            {
                fines = mediator.searchFine(fineSearchText.Text, FineSearchType.Unpaid);
            }
            else if (rbSearchFinePaidOrUnpaid.Checked)
            {
                fines = mediator.searchFine(fineSearchText.Text, FineSearchType.PaidOrUnpaid);
            }
            else
            {
                throw new InvalidOperationException("Searching using undefined search type");
            }

            if (null != fines && 0 != fines.Count)
            {
                foreach (Fine fine in fines)
                {
                    fineSearchResultList.Controls.Add(new FineItem(fine, this));
                }

                fineSearchResultGroupBox.Text = "Search Results";
            }
            else
            {
                fineSearchResultGroupBox.Text = "No Results";
            }
        }

        private void btnSetFinePaid_Click(object sender, EventArgs e)
        {
            if (null == fineItem || fineItem.Fine.Paid)
            {
                MessageBox.Show("Please select an unpaid fine first");
            }
            else
            {
                try
                {
                    mediator.setPaidFine(fineItem.Fine.Loan_id);
                    MessageBox.Show("Set fine paid success!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(DAO_Error_Handler.Instance.getMessage(exception));
                }
            }
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
    }
}
