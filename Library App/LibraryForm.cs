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
using Library_App_Controls;

namespace Library_App
{
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();

            bookLoanSearchResultsList.Controls.Add(new BookItem());
            bookLoanSearchResultsList.Controls.Add(new BookItem());
            bookLoanSearchResultsList.Controls.Add(new BookItem());
            bookLoanSearchResultsList.Controls.Add(new BookItem());
            bookLoanSearchResultsList.Controls.Add(new BookItem());
            bookLoanSearchResultsList.Controls.Add(new BookItem());

            foreach (Control c in bookLoanSearchResultsList.Controls)
            {
                c.Anchor = AnchorStyles.None;
            }
        }
    }
}
