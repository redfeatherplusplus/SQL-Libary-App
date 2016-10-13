using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Library_Entities;

namespace Library_App
{
    public partial class LibraryForm : Form
    {
        //items currently selected in their respective lists
        private BookItem bookItem;
        private BookLoanItem bookLoanItem;
        private FineItem fineItem;

        public LibraryForm()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                BookItem bk = new BookItem(this);
                bk.Parent = bookSearchResultsList;
                bookLoanSearchResultsList.Controls.Add(bk);
            }

            foreach (Control c in bookLoanSearchResultsList.Controls)
            {
                c.Anchor = AnchorStyles.None;
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
