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
    public partial class CheckoutForm : Form
    {
        public CheckoutForm()
        {
            InitializeComponent();
        }

        public CheckoutForm(BookItem bookItem)
        {
            InitializeComponent();

            if (null != bookItem)
            {
                tbIsbn.Text = bookItem.Book.Isbn;
            }
        }

        private void btnCheckOutBook_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Mediator.Instance.checkOutBook(tbIsbn.Text, tbCardID.Text);
                MessageBox.Show("Check-out success!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(DAO_Error_Handler.Instance.getMessage(exception));
            }
        }

        private void btnCheckoutClose_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Mediator.Instance.checkOutBook(tbIsbn.Text, tbCardID.Text);
                MessageBox.Show("Check-out success!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(DAO_Error_Handler.Instance.getMessage(exception));
            }

            this.Close();
        }
    }
}
