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
    public partial class FineItem : UserControl
    {
        public FineItem()
        {
            InitializeComponent();
        }

        public FineItem(Fine fine)
        {
            InitializeComponent();

            this.bookNameGroupBox.Text = fine.Title;
            this.fineAmount.Text = fine.Fine_amt.ToString();
            this.loanID.Text = fine.Loan_id.ToString();
            this.paidCheckBox.Checked = fine.Paid;
        }
    }
}
