namespace Library_App_Controls
{
    partial class FineItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookNameGroupBox = new System.Windows.Forms.GroupBox();
            this.fineAmountLabel = new System.Windows.Forms.Label();
            this.loanIDLabel = new System.Windows.Forms.Label();
            this.paidLabel = new System.Windows.Forms.Label();
            this.fineAmount = new System.Windows.Forms.Label();
            this.loanID = new System.Windows.Forms.Label();
            this.paidCheckBox = new System.Windows.Forms.CheckBox();
            this.bookNameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookNameGroupBox
            // 
            this.bookNameGroupBox.Controls.Add(this.paidCheckBox);
            this.bookNameGroupBox.Controls.Add(this.loanID);
            this.bookNameGroupBox.Controls.Add(this.fineAmount);
            this.bookNameGroupBox.Controls.Add(this.paidLabel);
            this.bookNameGroupBox.Controls.Add(this.loanIDLabel);
            this.bookNameGroupBox.Controls.Add(this.fineAmountLabel);
            this.bookNameGroupBox.Location = new System.Drawing.Point(0, 0);
            this.bookNameGroupBox.Name = "bookNameGroupBox";
            this.bookNameGroupBox.Size = new System.Drawing.Size(523, 59);
            this.bookNameGroupBox.TabIndex = 0;
            this.bookNameGroupBox.TabStop = false;
            this.bookNameGroupBox.Text = "Book Name";
            // 
            // fineAmountLabel
            // 
            this.fineAmountLabel.AutoSize = true;
            this.fineAmountLabel.Location = new System.Drawing.Point(6, 16);
            this.fineAmountLabel.Name = "fineAmountLabel";
            this.fineAmountLabel.Size = new System.Drawing.Size(72, 13);
            this.fineAmountLabel.TabIndex = 0;
            this.fineAmountLabel.Text = "Fine Amount: ";
            // 
            // loanIDLabel
            // 
            this.loanIDLabel.AutoSize = true;
            this.loanIDLabel.Location = new System.Drawing.Point(6, 29);
            this.loanIDLabel.Name = "loanIDLabel";
            this.loanIDLabel.Size = new System.Drawing.Size(51, 13);
            this.loanIDLabel.TabIndex = 1;
            this.loanIDLabel.Text = "Loan ID: ";
            // 
            // paidLabel
            // 
            this.paidLabel.AutoSize = true;
            this.paidLabel.Location = new System.Drawing.Point(6, 43);
            this.paidLabel.Name = "paidLabel";
            this.paidLabel.Size = new System.Drawing.Size(34, 13);
            this.paidLabel.TabIndex = 2;
            this.paidLabel.Text = "Paid: ";
            // 
            // fineAmount
            // 
            this.fineAmount.AutoSize = true;
            this.fineAmount.Location = new System.Drawing.Point(84, 16);
            this.fineAmount.Name = "fineAmount";
            this.fineAmount.Size = new System.Drawing.Size(0, 13);
            this.fineAmount.TabIndex = 3;
            // 
            // loanID
            // 
            this.loanID.AutoSize = true;
            this.loanID.Location = new System.Drawing.Point(84, 29);
            this.loanID.Name = "loanID";
            this.loanID.Size = new System.Drawing.Size(0, 13);
            this.loanID.TabIndex = 4;
            // 
            // paidCheckBox
            // 
            this.paidCheckBox.AutoSize = true;
            this.paidCheckBox.Enabled = false;
            this.paidCheckBox.Location = new System.Drawing.Point(87, 43);
            this.paidCheckBox.Name = "paidCheckBox";
            this.paidCheckBox.Size = new System.Drawing.Size(15, 14);
            this.paidCheckBox.TabIndex = 5;
            this.paidCheckBox.UseVisualStyleBackColor = true;
            // 
            // FineItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookNameGroupBox);
            this.Name = "FineItem";
            this.Size = new System.Drawing.Size(523, 59);
            this.bookNameGroupBox.ResumeLayout(false);
            this.bookNameGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bookNameGroupBox;
        private System.Windows.Forms.CheckBox paidCheckBox;
        private System.Windows.Forms.Label loanID;
        private System.Windows.Forms.Label fineAmount;
        private System.Windows.Forms.Label paidLabel;
        private System.Windows.Forms.Label loanIDLabel;
        private System.Windows.Forms.Label fineAmountLabel;
    }
}
