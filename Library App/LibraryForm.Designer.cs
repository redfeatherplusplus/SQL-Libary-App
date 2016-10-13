namespace Library_App
{
    partial class LibraryForm
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
            this.tabController = new System.Windows.Forms.TabControl();
            this.booksTab = new System.Windows.Forms.TabPage();
            this.bookSearchTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.authorOrTitleRadioButton = new System.Windows.Forms.RadioButton();
            this.authorRadioButton = new System.Windows.Forms.RadioButton();
            this.titleRadioButton = new System.Windows.Forms.RadioButton();
            this.bookSearchTxt = new System.Windows.Forms.TextBox();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.bookSearchResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.bookSearchResultsList = new System.Windows.Forms.FlowLayoutPanel();
            this.bookLoanTab = new System.Windows.Forms.TabPage();
            this.bookLoanSearchText = new System.Windows.Forms.TextBox();
            this.btnBookLoanSearch = new System.Windows.Forms.Button();
            this.bookLoanSearchResultsBox = new System.Windows.Forms.GroupBox();
            this.bookLoanSearchResultsList = new System.Windows.Forms.FlowLayoutPanel();
            this.finesTab = new System.Windows.Forms.TabPage();
            this.fineSearchText = new System.Windows.Forms.TextBox();
            this.btnFineSearch = new System.Windows.Forms.Button();
            this.fineSearchResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.fineSearchResultList = new System.Windows.Forms.FlowLayoutPanel();
            this.isbnRadioButton = new System.Windows.Forms.RadioButton();
            this.tabController.SuspendLayout();
            this.booksTab.SuspendLayout();
            this.bookSearchTypeGroupBox.SuspendLayout();
            this.bookSearchResultsGroupBox.SuspendLayout();
            this.bookLoanTab.SuspendLayout();
            this.bookLoanSearchResultsBox.SuspendLayout();
            this.finesTab.SuspendLayout();
            this.fineSearchResultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabController
            // 
            this.tabController.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabController.Controls.Add(this.booksTab);
            this.tabController.Controls.Add(this.bookLoanTab);
            this.tabController.Controls.Add(this.finesTab);
            this.tabController.Location = new System.Drawing.Point(12, 12);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(726, 409);
            this.tabController.TabIndex = 0;
            // 
            // booksTab
            // 
            this.booksTab.Controls.Add(this.bookSearchTypeGroupBox);
            this.booksTab.Controls.Add(this.bookSearchTxt);
            this.booksTab.Controls.Add(this.btnBookSearch);
            this.booksTab.Controls.Add(this.bookSearchResultsGroupBox);
            this.booksTab.Location = new System.Drawing.Point(4, 22);
            this.booksTab.Name = "booksTab";
            this.booksTab.Padding = new System.Windows.Forms.Padding(3);
            this.booksTab.Size = new System.Drawing.Size(718, 383);
            this.booksTab.TabIndex = 0;
            this.booksTab.Text = "BOOKS";
            this.booksTab.UseVisualStyleBackColor = true;
            // 
            // bookSearchTypeGroupBox
            // 
            this.bookSearchTypeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bookSearchTypeGroupBox.Controls.Add(this.isbnRadioButton);
            this.bookSearchTypeGroupBox.Controls.Add(this.authorOrTitleRadioButton);
            this.bookSearchTypeGroupBox.Controls.Add(this.authorRadioButton);
            this.bookSearchTypeGroupBox.Controls.Add(this.titleRadioButton);
            this.bookSearchTypeGroupBox.Location = new System.Drawing.Point(575, 210);
            this.bookSearchTypeGroupBox.Name = "bookSearchTypeGroupBox";
            this.bookSearchTypeGroupBox.Size = new System.Drawing.Size(137, 112);
            this.bookSearchTypeGroupBox.TabIndex = 3;
            this.bookSearchTypeGroupBox.TabStop = false;
            this.bookSearchTypeGroupBox.Text = "Search Type";
            // 
            // authorOrTitleRadioButton
            // 
            this.authorOrTitleRadioButton.AutoSize = true;
            this.authorOrTitleRadioButton.Location = new System.Drawing.Point(35, 65);
            this.authorOrTitleRadioButton.Name = "authorOrTitleRadioButton";
            this.authorOrTitleRadioButton.Size = new System.Drawing.Size(47, 17);
            this.authorOrTitleRadioButton.TabIndex = 2;
            this.authorOrTitleRadioButton.Text = "Both";
            this.authorOrTitleRadioButton.UseVisualStyleBackColor = true;
            // 
            // authorRadioButton
            // 
            this.authorRadioButton.AutoSize = true;
            this.authorRadioButton.Location = new System.Drawing.Point(35, 42);
            this.authorRadioButton.Name = "authorRadioButton";
            this.authorRadioButton.Size = new System.Drawing.Size(56, 17);
            this.authorRadioButton.TabIndex = 1;
            this.authorRadioButton.Text = "Author";
            this.authorRadioButton.UseVisualStyleBackColor = true;
            // 
            // titleRadioButton
            // 
            this.titleRadioButton.AutoSize = true;
            this.titleRadioButton.Checked = true;
            this.titleRadioButton.Location = new System.Drawing.Point(35, 19);
            this.titleRadioButton.Name = "titleRadioButton";
            this.titleRadioButton.Size = new System.Drawing.Size(45, 17);
            this.titleRadioButton.TabIndex = 0;
            this.titleRadioButton.TabStop = true;
            this.titleRadioButton.Text = "Title";
            this.titleRadioButton.UseVisualStyleBackColor = true;
            // 
            // bookSearchTxt
            // 
            this.bookSearchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bookSearchTxt.Location = new System.Drawing.Point(575, 328);
            this.bookSearchTxt.Name = "bookSearchTxt";
            this.bookSearchTxt.Size = new System.Drawing.Size(137, 20);
            this.bookSearchTxt.TabIndex = 2;
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookSearch.Location = new System.Drawing.Point(575, 354);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(137, 23);
            this.btnBookSearch.TabIndex = 1;
            this.btnBookSearch.Text = "Search";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            // 
            // bookSearchResultsGroupBox
            // 
            this.bookSearchResultsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookSearchResultsGroupBox.Controls.Add(this.bookSearchResultsList);
            this.bookSearchResultsGroupBox.Location = new System.Drawing.Point(3, 6);
            this.bookSearchResultsGroupBox.Name = "bookSearchResultsGroupBox";
            this.bookSearchResultsGroupBox.Size = new System.Drawing.Size(566, 374);
            this.bookSearchResultsGroupBox.TabIndex = 0;
            this.bookSearchResultsGroupBox.TabStop = false;
            this.bookSearchResultsGroupBox.Text = "Search Results";
            // 
            // bookSearchResultsList
            // 
            this.bookSearchResultsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookSearchResultsList.AutoScroll = true;
            this.bookSearchResultsList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.bookSearchResultsList.Location = new System.Drawing.Point(6, 19);
            this.bookSearchResultsList.Name = "bookSearchResultsList";
            this.bookSearchResultsList.Size = new System.Drawing.Size(554, 349);
            this.bookSearchResultsList.TabIndex = 0;
            // 
            // bookLoanTab
            // 
            this.bookLoanTab.Controls.Add(this.bookLoanSearchText);
            this.bookLoanTab.Controls.Add(this.btnBookLoanSearch);
            this.bookLoanTab.Controls.Add(this.bookLoanSearchResultsBox);
            this.bookLoanTab.Location = new System.Drawing.Point(4, 22);
            this.bookLoanTab.Name = "bookLoanTab";
            this.bookLoanTab.Padding = new System.Windows.Forms.Padding(3);
            this.bookLoanTab.Size = new System.Drawing.Size(718, 383);
            this.bookLoanTab.TabIndex = 1;
            this.bookLoanTab.Text = "BOOK LOANS";
            this.bookLoanTab.UseVisualStyleBackColor = true;
            // 
            // bookLoanSearchText
            // 
            this.bookLoanSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bookLoanSearchText.Location = new System.Drawing.Point(575, 328);
            this.bookLoanSearchText.Name = "bookLoanSearchText";
            this.bookLoanSearchText.Size = new System.Drawing.Size(137, 20);
            this.bookLoanSearchText.TabIndex = 3;
            // 
            // btnBookLoanSearch
            // 
            this.btnBookLoanSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookLoanSearch.Location = new System.Drawing.Point(575, 354);
            this.btnBookLoanSearch.Name = "btnBookLoanSearch";
            this.btnBookLoanSearch.Size = new System.Drawing.Size(137, 23);
            this.btnBookLoanSearch.TabIndex = 2;
            this.btnBookLoanSearch.Text = "Search";
            this.btnBookLoanSearch.UseVisualStyleBackColor = true;
            // 
            // bookLoanSearchResultsBox
            // 
            this.bookLoanSearchResultsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookLoanSearchResultsBox.Controls.Add(this.bookLoanSearchResultsList);
            this.bookLoanSearchResultsBox.Location = new System.Drawing.Point(3, 6);
            this.bookLoanSearchResultsBox.Name = "bookLoanSearchResultsBox";
            this.bookLoanSearchResultsBox.Size = new System.Drawing.Size(566, 374);
            this.bookLoanSearchResultsBox.TabIndex = 1;
            this.bookLoanSearchResultsBox.TabStop = false;
            this.bookLoanSearchResultsBox.Text = "Search Results";
            // 
            // bookLoanSearchResultsList
            // 
            this.bookLoanSearchResultsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookLoanSearchResultsList.AutoScroll = true;
            this.bookLoanSearchResultsList.Location = new System.Drawing.Point(6, 19);
            this.bookLoanSearchResultsList.Name = "bookLoanSearchResultsList";
            this.bookLoanSearchResultsList.Size = new System.Drawing.Size(554, 349);
            this.bookLoanSearchResultsList.TabIndex = 1;
            // 
            // finesTab
            // 
            this.finesTab.Controls.Add(this.fineSearchText);
            this.finesTab.Controls.Add(this.btnFineSearch);
            this.finesTab.Controls.Add(this.fineSearchResultsGroupBox);
            this.finesTab.Location = new System.Drawing.Point(4, 22);
            this.finesTab.Name = "finesTab";
            this.finesTab.Padding = new System.Windows.Forms.Padding(3);
            this.finesTab.Size = new System.Drawing.Size(718, 383);
            this.finesTab.TabIndex = 2;
            this.finesTab.Text = "FINES";
            this.finesTab.UseVisualStyleBackColor = true;
            // 
            // fineSearchText
            // 
            this.fineSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fineSearchText.Location = new System.Drawing.Point(575, 328);
            this.fineSearchText.Name = "fineSearchText";
            this.fineSearchText.Size = new System.Drawing.Size(137, 20);
            this.fineSearchText.TabIndex = 4;
            // 
            // btnFineSearch
            // 
            this.btnFineSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFineSearch.Location = new System.Drawing.Point(575, 354);
            this.btnFineSearch.Name = "btnFineSearch";
            this.btnFineSearch.Size = new System.Drawing.Size(137, 23);
            this.btnFineSearch.TabIndex = 3;
            this.btnFineSearch.Text = "Search";
            this.btnFineSearch.UseVisualStyleBackColor = true;
            // 
            // fineSearchResultsGroupBox
            // 
            this.fineSearchResultsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fineSearchResultsGroupBox.Controls.Add(this.fineSearchResultList);
            this.fineSearchResultsGroupBox.Location = new System.Drawing.Point(3, 6);
            this.fineSearchResultsGroupBox.Name = "fineSearchResultsGroupBox";
            this.fineSearchResultsGroupBox.Size = new System.Drawing.Size(566, 374);
            this.fineSearchResultsGroupBox.TabIndex = 2;
            this.fineSearchResultsGroupBox.TabStop = false;
            this.fineSearchResultsGroupBox.Text = "Search Results";
            // 
            // fineSearchResultList
            // 
            this.fineSearchResultList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fineSearchResultList.AutoScroll = true;
            this.fineSearchResultList.Location = new System.Drawing.Point(6, 19);
            this.fineSearchResultList.Name = "fineSearchResultList";
            this.fineSearchResultList.Size = new System.Drawing.Size(554, 349);
            this.fineSearchResultList.TabIndex = 2;
            // 
            // isbnRadioButton
            // 
            this.isbnRadioButton.AutoSize = true;
            this.isbnRadioButton.Location = new System.Drawing.Point(35, 88);
            this.isbnRadioButton.Name = "isbnRadioButton";
            this.isbnRadioButton.Size = new System.Drawing.Size(45, 17);
            this.isbnRadioButton.TabIndex = 3;
            this.isbnRadioButton.Text = "Isbn";
            this.isbnRadioButton.UseVisualStyleBackColor = true;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 433);
            this.Controls.Add(this.tabController);
            this.Name = "LibraryForm";
            this.Text = "Library App";
            this.tabController.ResumeLayout(false);
            this.booksTab.ResumeLayout(false);
            this.booksTab.PerformLayout();
            this.bookSearchTypeGroupBox.ResumeLayout(false);
            this.bookSearchTypeGroupBox.PerformLayout();
            this.bookSearchResultsGroupBox.ResumeLayout(false);
            this.bookLoanTab.ResumeLayout(false);
            this.bookLoanTab.PerformLayout();
            this.bookLoanSearchResultsBox.ResumeLayout(false);
            this.finesTab.ResumeLayout(false);
            this.finesTab.PerformLayout();
            this.fineSearchResultsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage booksTab;
        private System.Windows.Forms.TabPage bookLoanTab;
        private System.Windows.Forms.TabPage finesTab;
        private System.Windows.Forms.GroupBox bookSearchResultsGroupBox;
        private System.Windows.Forms.GroupBox bookLoanSearchResultsBox;
        private System.Windows.Forms.FlowLayoutPanel bookSearchResultsList;
        private System.Windows.Forms.GroupBox fineSearchResultsGroupBox;
        private System.Windows.Forms.FlowLayoutPanel bookLoanSearchResultsList;
        private System.Windows.Forms.FlowLayoutPanel fineSearchResultList;
        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Button btnBookLoanSearch;
        private System.Windows.Forms.TextBox bookSearchTxt;
        private System.Windows.Forms.TextBox bookLoanSearchText;
        private System.Windows.Forms.TextBox fineSearchText;
        private System.Windows.Forms.Button btnFineSearch;
        private System.Windows.Forms.GroupBox bookSearchTypeGroupBox;
        private System.Windows.Forms.RadioButton titleRadioButton;
        private System.Windows.Forms.RadioButton authorOrTitleRadioButton;
        private System.Windows.Forms.RadioButton authorRadioButton;
        private System.Windows.Forms.RadioButton isbnRadioButton;
    }
}

