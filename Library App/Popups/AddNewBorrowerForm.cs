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
    public partial class AddNewBorrowerForm : Form
    {
        public AddNewBorrowerForm()
        {
            InitializeComponent();
        }

        private void btnAddBorrower_Click(object sender, EventArgs e)
        {
            try
            {
                Borrower borrower = new Borrower();
                borrower.Ssn = "" == tbSsn.Text ? null : tbSsn.Text;
                borrower.Fname = "" == tbFirst.Text ? null : tbFirst.Text;
                borrower.Lname = "" == tbLast.Text ? null : tbLast.Text;
                borrower.Email = "" == tbEmail.Text ? null : tbEmail.Text;
                borrower.Address = "" == tbAddress.Text ? null : tbAddress.Text;
                borrower.City = "" == tbCity.Text ? null : tbCity.Text;
                borrower.State = "" == tbState.Text ? null : tbState.Text;
                borrower.Phone = "" == tbPhone.Text ? null : tbPhone.Text;

                DAO_Mediator.Instance.insertBorrower(borrower);

                MessageBox.Show("Add Borrower success!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(DAO_Error_Handler.Instance.parse(exception));
            }
        }

        private void btnAddBorrowerClose_Click(object sender, EventArgs e)
        {
            try
            {
                Borrower borrower = new Borrower();
                borrower.Ssn = "" == tbSsn.Text ? null : tbSsn.Text;
                borrower.Fname = "" == tbFirst.Text ? null : tbFirst.Text;
                borrower.Lname = "" == tbLast.Text ? null : tbLast.Text;
                borrower.Email = "" == tbEmail.Text ? null : tbEmail.Text;
                borrower.Address = "" == tbAddress.Text ? null : tbAddress.Text;
                borrower.City = "" == tbCity.Text ? null : tbCity.Text;
                borrower.State = "" == tbState.Text ? null : tbState.Text;
                borrower.Phone = "" == tbPhone.Text ? null : tbPhone.Text;

                DAO_Mediator.Instance.insertBorrower(borrower);

                MessageBox.Show("Add Borrower success!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(DAO_Error_Handler.Instance.parse(exception));
            }

            this.Close();
        }
    }
}
