namespace Library_App
{
    partial class CheckoutForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblCardID = new System.Windows.Forms.Label();
            this.tbCardID = new System.Windows.Forms.TextBox();
            this.tbIsbn = new System.Windows.Forms.TextBox();
            this.btnCheckOutBook = new System.Windows.Forms.Button();
            this.btnCheckoutClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIsbn
            // 
            this.lblIsbn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(12, 9);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(33, 13);
            this.lblIsbn.TabIndex = 0;
            this.lblIsbn.Text = "Isbn: ";
            // 
            // lblCardID
            // 
            this.lblCardID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCardID.AutoSize = true;
            this.lblCardID.Location = new System.Drawing.Point(12, 35);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.Size = new System.Drawing.Size(49, 13);
            this.lblCardID.TabIndex = 1;
            this.lblCardID.Text = "Card ID: ";
            // 
            // tbCardID
            // 
            this.tbCardID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCardID.Location = new System.Drawing.Point(67, 32);
            this.tbCardID.Name = "tbCardID";
            this.tbCardID.Size = new System.Drawing.Size(139, 20);
            this.tbCardID.TabIndex = 2;
            // 
            // tbIsbn
            // 
            this.tbIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIsbn.Location = new System.Drawing.Point(67, 6);
            this.tbIsbn.Name = "tbIsbn";
            this.tbIsbn.Size = new System.Drawing.Size(139, 20);
            this.tbIsbn.TabIndex = 3;
            // 
            // btnCheckOutBook
            // 
            this.btnCheckOutBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckOutBook.Location = new System.Drawing.Point(15, 58);
            this.btnCheckOutBook.Name = "btnCheckOutBook";
            this.btnCheckOutBook.Size = new System.Drawing.Size(71, 24);
            this.btnCheckOutBook.TabIndex = 4;
            this.btnCheckOutBook.Text = "Check Out";
            this.btnCheckOutBook.UseVisualStyleBackColor = true;
            this.btnCheckOutBook.Click += new System.EventHandler(this.btnCheckOutBook_Click);
            // 
            // btnCheckoutClose
            // 
            this.btnCheckoutClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckoutClose.Location = new System.Drawing.Point(92, 57);
            this.btnCheckoutClose.Name = "btnCheckoutClose";
            this.btnCheckoutClose.Size = new System.Drawing.Size(114, 24);
            this.btnCheckoutClose.TabIndex = 5;
            this.btnCheckoutClose.Text = "Check Out && Close";
            this.btnCheckoutClose.UseVisualStyleBackColor = true;
            this.btnCheckoutClose.Click += new System.EventHandler(this.btnCheckoutClose_Click);
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 93);
            this.Controls.Add(this.btnCheckoutClose);
            this.Controls.Add(this.btnCheckOutBook);
            this.Controls.Add(this.tbIsbn);
            this.Controls.Add(this.tbCardID);
            this.Controls.Add(this.lblCardID);
            this.Controls.Add(this.lblIsbn);
            this.Name = "CheckoutForm";
            this.Text = "Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblCardID;
        private System.Windows.Forms.TextBox tbCardID;
        private System.Windows.Forms.TextBox tbIsbn;
        private System.Windows.Forms.Button btnCheckOutBook;
        private System.Windows.Forms.Button btnCheckoutClose;
    }
}