namespace Library_App_Controls
{
    partial class BookItem
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
            this.availableLabel = new System.Windows.Forms.Label();
            this.availableCheckBox = new System.Windows.Forms.CheckBox();
            this.publisher = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.Label();
            this.authors = new System.Windows.Forms.Label();
            this.AuthorsLabel = new System.Windows.Forms.Label();
            this.bookNameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookNameGroupBox
            // 
            this.bookNameGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookNameGroupBox.Controls.Add(this.availableLabel);
            this.bookNameGroupBox.Controls.Add(this.availableCheckBox);
            this.bookNameGroupBox.Controls.Add(this.publisher);
            this.bookNameGroupBox.Controls.Add(this.publisherLabel);
            this.bookNameGroupBox.Controls.Add(this.isbnLabel);
            this.bookNameGroupBox.Controls.Add(this.isbn);
            this.bookNameGroupBox.Controls.Add(this.authors);
            this.bookNameGroupBox.Controls.Add(this.AuthorsLabel);
            this.bookNameGroupBox.Location = new System.Drawing.Point(0, 0);
            this.bookNameGroupBox.Name = "bookNameGroupBox";
            this.bookNameGroupBox.Size = new System.Drawing.Size(523, 60);
            this.bookNameGroupBox.TabIndex = 0;
            this.bookNameGroupBox.TabStop = false;
            this.bookNameGroupBox.Text = "Book Name";
            // 
            // availableLabel
            // 
            this.availableLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.availableLabel.AutoSize = true;
            this.availableLabel.Location = new System.Drawing.Point(373, 40);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(56, 13);
            this.availableLabel.TabIndex = 7;
            this.availableLabel.Text = "Available: ";
            // 
            // availableCheckBox
            // 
            this.availableCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.availableCheckBox.AutoSize = true;
            this.availableCheckBox.Enabled = false;
            this.availableCheckBox.Location = new System.Drawing.Point(435, 40);
            this.availableCheckBox.Name = "availableCheckBox";
            this.availableCheckBox.Size = new System.Drawing.Size(15, 14);
            this.availableCheckBox.TabIndex = 6;
            this.availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // publisher
            // 
            this.publisher.AutoSize = true;
            this.publisher.Location = new System.Drawing.Point(69, 43);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(0, 13);
            this.publisher.TabIndex = 5;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(7, 43);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(56, 13);
            this.publisherLabel.TabIndex = 4;
            this.publisherLabel.Text = "Publisher: ";
            // 
            // isbnLabel
            // 
            this.isbnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(396, 20);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(33, 13);
            this.isbnLabel.TabIndex = 3;
            this.isbnLabel.Text = "Isbn: ";
            // 
            // isbn
            // 
            this.isbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isbn.AutoSize = true;
            this.isbn.Location = new System.Drawing.Point(435, 20);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(85, 13);
            this.isbn.TabIndex = 2;
            this.isbn.Text = "9999999999999";
            // 
            // authors
            // 
            this.authors.AutoSize = true;
            this.authors.Location = new System.Drawing.Point(62, 20);
            this.authors.Name = "authors";
            this.authors.Size = new System.Drawing.Size(0, 13);
            this.authors.TabIndex = 1;
            // 
            // AuthorsLabel
            // 
            this.AuthorsLabel.AutoSize = true;
            this.AuthorsLabel.Location = new System.Drawing.Point(7, 20);
            this.AuthorsLabel.Name = "AuthorsLabel";
            this.AuthorsLabel.Size = new System.Drawing.Size(49, 13);
            this.AuthorsLabel.TabIndex = 0;
            this.AuthorsLabel.Text = "Authors: ";
            // 
            // BookItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookNameGroupBox);
            this.Name = "BookItem";
            this.Size = new System.Drawing.Size(523, 60);
            this.bookNameGroupBox.ResumeLayout(false);
            this.bookNameGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bookNameGroupBox;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Label isbn;
        private System.Windows.Forms.Label authors;
        private System.Windows.Forms.Label AuthorsLabel;
        private System.Windows.Forms.Label availableLabel;
        private System.Windows.Forms.CheckBox availableCheckBox;
        private System.Windows.Forms.Label publisher;
        private System.Windows.Forms.Label publisherLabel;
    }
}
