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
    public partial class FineItem : UserControl
    {
        private LibraryForm parent;
        private Fine fine;

        public FineItem(LibraryForm parent)
        {
            InitializeComponent();

            this.parent = parent;
        }

        public FineItem(Fine fine, LibraryForm parent)
        {
            InitializeComponent();

            this.parent = parent;
            this.fine = fine;

            this.bookNameGroupBox.Text = fine.Title;
            this.fineAmount.Text = fine.Fine_amt.ToString();
            this.loanID.Text = fine.Loan_id.ToString();
            this.paidCheckBox.Checked = fine.Paid;
        }

        private void selectedRadioButon_Click(object sender, EventArgs e)
        {
            //deselect all other items in the parent
            foreach (Control control in Parent.Controls)
            {
                FineItem item = control as FineItem;
                if (null != item)
                {
                    item.selectedRadioButon.Checked = false;
                }
                this.selectedRadioButon.Checked = true;
            }

            parent.FineItem = this;
        }

        //getters and setters
        public Fine Fine
        {
            get { return fine; }
            set { fine = value; }
        }
    }
}
