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
            this.bookManagementGroupBox = new System.Windows.Forms.GroupBox();
            this.btnFindBookLoans = new System.Windows.Forms.Button();
            this.btnBookCheckout = new System.Windows.Forms.Button();
            this.bookSearchTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.rbSearchIsbn = new System.Windows.Forms.RadioButton();
            this.rbSearchTitleAndAuthor = new System.Windows.Forms.RadioButton();
            this.rbSearchAuthor = new System.Windows.Forms.RadioButton();
            this.rbSearchTitle = new System.Windows.Forms.RadioButton();
            this.bookSearchText = new System.Windows.Forms.TextBox();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.bookSearchResultGroupBox = new System.Windows.Forms.GroupBox();
            this.bookSearchResultList = new System.Windows.Forms.FlowLayoutPanel();
            this.bookLoanTab = new System.Windows.Forms.TabPage();
            this.gbBorrowerManagement = new System.Windows.Forms.GroupBox();
            this.btnAddNewBorrower = new System.Windows.Forms.Button();
            this.btnCheckInBook = new System.Windows.Forms.Button();
            this.gbSearchType = new System.Windows.Forms.GroupBox();
            this.rbSearchCheckedIn = new System.Windows.Forms.RadioButton();
            this.rbSearchOverdueOrNotOverdue = new System.Windows.Forms.RadioButton();
            this.rbSearchNotOverdue = new System.Windows.Forms.RadioButton();
            this.rbSearchOverdue = new System.Windows.Forms.RadioButton();
            this.bookLoanSearchText = new System.Windows.Forms.TextBox();
            this.btnBookLoanSearch = new System.Windows.Forms.Button();
            this.bookLoanSearchResultGroupBox = new System.Windows.Forms.GroupBox();
            this.bookLoanSearchResultList = new System.Windows.Forms.FlowLayoutPanel();
            this.finesTab = new System.Windows.Forms.TabPage();
            this.gbFineManagement = new System.Windows.Forms.GroupBox();
            this.btnSetFinePaid = new System.Windows.Forms.Button();
            this.gbFineSearchType = new System.Windows.Forms.GroupBox();
            this.rbSearchFinePaidOrUnpaid = new System.Windows.Forms.RadioButton();
            this.rbSearchFineUnpaid = new System.Windows.Forms.RadioButton();
            this.rbSearchFinePaid = new System.Windows.Forms.RadioButton();
            this.fineSearchText = new System.Windows.Forms.TextBox();
            this.btnFineSearch = new System.Windows.Forms.Button();
            this.fineSearchResultGroupBox = new System.Windows.Forms.GroupBox();
            this.fineSearchResultList = new System.Windows.Forms.FlowLayoutPanel();
            this.tabController.SuspendLayout();
            this.booksTab.SuspendLayout();
            this.bookManagementGroupBox.SuspendLayout();
            this.bookSearchTypeGroupBox.SuspendLayout();
            this.bookSearchResultGroupBox.SuspendLayout();
            this.bookLoanTab.SuspendLayout();
            this.gbBorrowerManagement.SuspendLayout();
            this.gbSearchType.SuspendLayout();
            this.bookLoanSearchResultGroupBox.SuspendLayout();
            this.finesTab.SuspendLayout();
            this.gbFineManagement.SuspendLayout();
            this.gbFineSearchType.SuspendLayout();
            this.fineSearchResultGroupBox.SuspendLayout();
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
            this.tabController.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabController.Location = new System.Drawing.Point(12, 12);
            this.tabController.Name = "tabController";
            this.tabController.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabController.RightToLeftLayout = true;
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(726, 409);
            this.tabController.TabIndex = 0;
            // 
            // booksTab
            // 
            this.booksTab.Controls.Add(this.bookManagementGroupBox);
            this.booksTab.Controls.Add(this.bookSearchTypeGroupBox);
            this.booksTab.Controls.Add(this.bookSearchText);
            this.booksTab.Controls.Add(this.btnBookSearch);
            this.booksTab.Controls.Add(this.bookSearchResultGroupBox);
            this.booksTab.Location = new System.Drawing.Point(4, 22);
            this.booksTab.Name = "booksTab";
            this.booksTab.Padding = new System.Windows.Forms.Padding(3);
            this.booksTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.booksTab.Size = new System.Drawing.Size(718, 383);
            this.booksTab.TabIndex = 0;
            this.booksTab.Text = "BOOKS";
            this.booksTab.UseVisualStyleBackColor = true;
            // 
            // bookManagementGroupBox
            // 
            this.bookManagementGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookManagementGroupBox.Controls.Add(this.btnFindBookLoans);
            this.bookManagementGroupBox.Controls.Add(this.btnBookCheckout);
            this.bookManagementGroupBox.Location = new System.Drawing.Point(575, 6);
            this.bookManagementGroupBox.Name = "bookManagementGroupBox";
            this.bookManagementGroupBox.Size = new System.Drawing.Size(137, 198);
            this.bookManagementGroupBox.TabIndex = 5;
            this.bookManagementGroupBox.TabStop = false;
            this.bookManagementGroupBox.Text = "Book Management";
            // 
            // btnFindBookLoans
            // 
            this.btnFindBookLoans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindBookLoans.Location = new System.Drawing.Point(6, 48);
            this.btnFindBookLoans.Name = "btnFindBookLoans";
            this.btnFindBookLoans.Size = new System.Drawing.Size(125, 23);
            this.btnFindBookLoans.TabIndex = 5;
            this.btnFindBookLoans.Text = "Find loans for book";
            this.btnFindBookLoans.UseVisualStyleBackColor = true;
            this.btnFindBookLoans.Click += new System.EventHandler(this.btnFindBookLoans_Click);
            // 
            // btnBookCheckout
            // 
            this.btnBookCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookCheckout.Location = new System.Drawing.Point(6, 19);
            this.btnBookCheckout.Name = "btnBookCheckout";
            this.btnBookCheckout.Size = new System.Drawing.Size(125, 23);
            this.btnBookCheckout.TabIndex = 4;
            this.btnBookCheckout.Text = "Check out";
            this.btnBookCheckout.UseVisualStyleBackColor = true;
            this.btnBookCheckout.Click += new System.EventHandler(this.btnBookCheckout_Click);
            // 
            // bookSearchTypeGroupBox
            // 
            this.bookSearchTypeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bookSearchTypeGroupBox.Controls.Add(this.rbSearchIsbn);
            this.bookSearchTypeGroupBox.Controls.Add(this.rbSearchTitleAndAuthor);
            this.bookSearchTypeGroupBox.Controls.Add(this.rbSearchAuthor);
            this.bookSearchTypeGroupBox.Controls.Add(this.rbSearchTitle);
            this.bookSearchTypeGroupBox.Location = new System.Drawing.Point(575, 210);
            this.bookSearchTypeGroupBox.Name = "bookSearchTypeGroupBox";
            this.bookSearchTypeGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bookSearchTypeGroupBox.Size = new System.Drawing.Size(137, 112);
            this.bookSearchTypeGroupBox.TabIndex = 3;
            this.bookSearchTypeGroupBox.TabStop = false;
            this.bookSearchTypeGroupBox.Text = "Search Type";
            // 
            // rbSearchIsbn
            // 
            this.rbSearchIsbn.AutoSize = true;
            this.rbSearchIsbn.Location = new System.Drawing.Point(35, 88);
            this.rbSearchIsbn.Name = "rbSearchIsbn";
            this.rbSearchIsbn.Size = new System.Drawing.Size(45, 17);
            this.rbSearchIsbn.TabIndex = 3;
            this.rbSearchIsbn.Text = "Isbn";
            this.rbSearchIsbn.UseVisualStyleBackColor = true;
            // 
            // rbSearchTitleAndAuthor
            // 
            this.rbSearchTitleAndAuthor.AutoSize = true;
            this.rbSearchTitleAndAuthor.Location = new System.Drawing.Point(35, 65);
            this.rbSearchTitleAndAuthor.Name = "rbSearchTitleAndAuthor";
            this.rbSearchTitleAndAuthor.Size = new System.Drawing.Size(47, 17);
            this.rbSearchTitleAndAuthor.TabIndex = 2;
            this.rbSearchTitleAndAuthor.Text = "Both";
            this.rbSearchTitleAndAuthor.UseVisualStyleBackColor = true;
            // 
            // rbSearchAuthor
            // 
            this.rbSearchAuthor.AutoSize = true;
            this.rbSearchAuthor.Location = new System.Drawing.Point(35, 42);
            this.rbSearchAuthor.Name = "rbSearchAuthor";
            this.rbSearchAuthor.Size = new System.Drawing.Size(56, 17);
            this.rbSearchAuthor.TabIndex = 1;
            this.rbSearchAuthor.Text = "Author";
            this.rbSearchAuthor.UseVisualStyleBackColor = true;
            // 
            // rbSearchTitle
            // 
            this.rbSearchTitle.AutoSize = true;
            this.rbSearchTitle.Checked = true;
            this.rbSearchTitle.Location = new System.Drawing.Point(35, 19);
            this.rbSearchTitle.Name = "rbSearchTitle";
            this.rbSearchTitle.Size = new System.Drawing.Size(45, 17);
            this.rbSearchTitle.TabIndex = 0;
            this.rbSearchTitle.TabStop = true;
            this.rbSearchTitle.Text = "Title";
            this.rbSearchTitle.UseVisualStyleBackColor = true;
            // 
            // bookSearchText
            // 
            this.bookSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bookSearchText.Location = new System.Drawing.Point(575, 328);
            this.bookSearchText.Name = "bookSearchText";
            this.bookSearchText.Size = new System.Drawing.Size(137, 20);
            this.bookSearchText.TabIndex = 2;
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
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // bookSearchResultGroupBox
            // 
            this.bookSearchResultGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookSearchResultGroupBox.Controls.Add(this.bookSearchResultList);
            this.bookSearchResultGroupBox.Location = new System.Drawing.Point(3, 6);
            this.bookSearchResultGroupBox.Name = "bookSearchResultGroupBox";
            this.bookSearchResultGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bookSearchResultGroupBox.Size = new System.Drawing.Size(566, 374);
            this.bookSearchResultGroupBox.TabIndex = 0;
            this.bookSearchResultGroupBox.TabStop = false;
            this.bookSearchResultGroupBox.Text = "Search Results";
            // 
            // bookSearchResultList
            // 
            this.bookSearchResultList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bookSearchResultList.AutoScroll = true;
            this.bookSearchResultList.BackColor = System.Drawing.SystemColors.Window;
            this.bookSearchResultList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookSearchResultList.Location = new System.Drawing.Point(6, 19);
            this.bookSearchResultList.Name = "bookSearchResultList";
            this.bookSearchResultList.Size = new System.Drawing.Size(554, 349);
            this.bookSearchResultList.TabIndex = 2;
            // 
            // bookLoanTab
            // 
            this.bookLoanTab.Controls.Add(this.gbBorrowerManagement);
            this.bookLoanTab.Controls.Add(this.gbSearchType);
            this.bookLoanTab.Controls.Add(this.bookLoanSearchText);
            this.bookLoanTab.Controls.Add(this.btnBookLoanSearch);
            this.bookLoanTab.Controls.Add(this.bookLoanSearchResultGroupBox);
            this.bookLoanTab.Location = new System.Drawing.Point(4, 22);
            this.bookLoanTab.Name = "bookLoanTab";
            this.bookLoanTab.Padding = new System.Windows.Forms.Padding(3);
            this.bookLoanTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bookLoanTab.Size = new System.Drawing.Size(718, 383);
            this.bookLoanTab.TabIndex = 1;
            this.bookLoanTab.Text = "BOOK LOANS";
            this.bookLoanTab.UseVisualStyleBackColor = true;
            // 
            // gbBorrowerManagement
            // 
            this.gbBorrowerManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBorrowerManagement.Controls.Add(this.btnAddNewBorrower);
            this.gbBorrowerManagement.Controls.Add(this.btnCheckInBook);
            this.gbBorrowerManagement.Location = new System.Drawing.Point(575, 6);
            this.gbBorrowerManagement.Name = "gbBorrowerManagement";
            this.gbBorrowerManagement.Size = new System.Drawing.Size(137, 198);
            this.gbBorrowerManagement.TabIndex = 6;
            this.gbBorrowerManagement.TabStop = false;
            this.gbBorrowerManagement.Text = "Borrower Management";
            // 
            // btnAddNewBorrower
            // 
            this.btnAddNewBorrower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewBorrower.Location = new System.Drawing.Point(6, 48);
            this.btnAddNewBorrower.Name = "btnAddNewBorrower";
            this.btnAddNewBorrower.Size = new System.Drawing.Size(125, 23);
            this.btnAddNewBorrower.TabIndex = 5;
            this.btnAddNewBorrower.Text = "Add New Borrower";
            this.btnAddNewBorrower.UseVisualStyleBackColor = true;
            this.btnAddNewBorrower.Click += new System.EventHandler(this.btnAddNewBorrower_Click);
            // 
            // btnCheckInBook
            // 
            this.btnCheckInBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckInBook.Location = new System.Drawing.Point(6, 19);
            this.btnCheckInBook.Name = "btnCheckInBook";
            this.btnCheckInBook.Size = new System.Drawing.Size(125, 23);
            this.btnCheckInBook.TabIndex = 4;
            this.btnCheckInBook.Text = "Check in book";
            this.btnCheckInBook.UseVisualStyleBackColor = true;
            this.btnCheckInBook.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // gbSearchType
            // 
            this.gbSearchType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearchType.Controls.Add(this.rbSearchCheckedIn);
            this.gbSearchType.Controls.Add(this.rbSearchOverdueOrNotOverdue);
            this.gbSearchType.Controls.Add(this.rbSearchNotOverdue);
            this.gbSearchType.Controls.Add(this.rbSearchOverdue);
            this.gbSearchType.Location = new System.Drawing.Point(575, 210);
            this.gbSearchType.Name = "gbSearchType";
            this.gbSearchType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbSearchType.Size = new System.Drawing.Size(137, 112);
            this.gbSearchType.TabIndex = 4;
            this.gbSearchType.TabStop = false;
            this.gbSearchType.Text = "Search Type";
            // 
            // rbSearchCheckedIn
            // 
            this.rbSearchCheckedIn.AutoSize = true;
            this.rbSearchCheckedIn.Location = new System.Drawing.Point(35, 88);
            this.rbSearchCheckedIn.Name = "rbSearchCheckedIn";
            this.rbSearchCheckedIn.Size = new System.Drawing.Size(79, 17);
            this.rbSearchCheckedIn.TabIndex = 3;
            this.rbSearchCheckedIn.Text = "Checked in";
            this.rbSearchCheckedIn.UseVisualStyleBackColor = true;
            // 
            // rbSearchOverdueOrNotOverdue
            // 
            this.rbSearchOverdueOrNotOverdue.AutoSize = true;
            this.rbSearchOverdueOrNotOverdue.Checked = true;
            this.rbSearchOverdueOrNotOverdue.Location = new System.Drawing.Point(35, 65);
            this.rbSearchOverdueOrNotOverdue.Name = "rbSearchOverdueOrNotOverdue";
            this.rbSearchOverdueOrNotOverdue.Size = new System.Drawing.Size(52, 17);
            this.rbSearchOverdueOrNotOverdue.TabIndex = 2;
            this.rbSearchOverdueOrNotOverdue.TabStop = true;
            this.rbSearchOverdueOrNotOverdue.Text = "Either";
            this.rbSearchOverdueOrNotOverdue.UseVisualStyleBackColor = true;
            // 
            // rbSearchNotOverdue
            // 
            this.rbSearchNotOverdue.AutoSize = true;
            this.rbSearchNotOverdue.Location = new System.Drawing.Point(35, 42);
            this.rbSearchNotOverdue.Name = "rbSearchNotOverdue";
            this.rbSearchNotOverdue.Size = new System.Drawing.Size(84, 17);
            this.rbSearchNotOverdue.TabIndex = 1;
            this.rbSearchNotOverdue.Text = "Not overdue";
            this.rbSearchNotOverdue.UseVisualStyleBackColor = true;
            // 
            // rbSearchOverdue
            // 
            this.rbSearchOverdue.AutoSize = true;
            this.rbSearchOverdue.Location = new System.Drawing.Point(35, 19);
            this.rbSearchOverdue.Name = "rbSearchOverdue";
            this.rbSearchOverdue.Size = new System.Drawing.Size(66, 17);
            this.rbSearchOverdue.TabIndex = 0;
            this.rbSearchOverdue.Text = "Overdue";
            this.rbSearchOverdue.UseVisualStyleBackColor = true;
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
            this.btnBookLoanSearch.Click += new System.EventHandler(this.btnBookLoanSearch_Click);
            // 
            // bookLoanSearchResultGroupBox
            // 
            this.bookLoanSearchResultGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookLoanSearchResultGroupBox.Controls.Add(this.bookLoanSearchResultList);
            this.bookLoanSearchResultGroupBox.Location = new System.Drawing.Point(3, 6);
            this.bookLoanSearchResultGroupBox.Name = "bookLoanSearchResultGroupBox";
            this.bookLoanSearchResultGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bookLoanSearchResultGroupBox.Size = new System.Drawing.Size(566, 374);
            this.bookLoanSearchResultGroupBox.TabIndex = 1;
            this.bookLoanSearchResultGroupBox.TabStop = false;
            this.bookLoanSearchResultGroupBox.Text = "Search Results";
            // 
            // bookLoanSearchResultList
            // 
            this.bookLoanSearchResultList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bookLoanSearchResultList.AutoScroll = true;
            this.bookLoanSearchResultList.BackColor = System.Drawing.SystemColors.Window;
            this.bookLoanSearchResultList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookLoanSearchResultList.Location = new System.Drawing.Point(6, 19);
            this.bookLoanSearchResultList.Name = "bookLoanSearchResultList";
            this.bookLoanSearchResultList.Size = new System.Drawing.Size(554, 349);
            this.bookLoanSearchResultList.TabIndex = 1;
            // 
            // finesTab
            // 
            this.finesTab.Controls.Add(this.gbFineManagement);
            this.finesTab.Controls.Add(this.gbFineSearchType);
            this.finesTab.Controls.Add(this.fineSearchText);
            this.finesTab.Controls.Add(this.btnFineSearch);
            this.finesTab.Controls.Add(this.fineSearchResultGroupBox);
            this.finesTab.Location = new System.Drawing.Point(4, 22);
            this.finesTab.Name = "finesTab";
            this.finesTab.Padding = new System.Windows.Forms.Padding(3);
            this.finesTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.finesTab.Size = new System.Drawing.Size(718, 383);
            this.finesTab.TabIndex = 2;
            this.finesTab.Text = "FINES";
            this.finesTab.UseVisualStyleBackColor = true;
            // 
            // gbFineManagement
            // 
            this.gbFineManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFineManagement.Controls.Add(this.btnSetFinePaid);
            this.gbFineManagement.Location = new System.Drawing.Point(575, 6);
            this.gbFineManagement.Name = "gbFineManagement";
            this.gbFineManagement.Size = new System.Drawing.Size(137, 198);
            this.gbFineManagement.TabIndex = 7;
            this.gbFineManagement.TabStop = false;
            this.gbFineManagement.Text = "Fine Management";
            // 
            // btnSetFinePaid
            // 
            this.btnSetFinePaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetFinePaid.Location = new System.Drawing.Point(6, 19);
            this.btnSetFinePaid.Name = "btnSetFinePaid";
            this.btnSetFinePaid.Size = new System.Drawing.Size(125, 23);
            this.btnSetFinePaid.TabIndex = 4;
            this.btnSetFinePaid.Text = "Set Fine Paid";
            this.btnSetFinePaid.UseVisualStyleBackColor = true;
            this.btnSetFinePaid.Click += new System.EventHandler(this.btnSetFinePaid_Click);
            // 
            // gbFineSearchType
            // 
            this.gbFineSearchType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFineSearchType.Controls.Add(this.rbSearchFinePaidOrUnpaid);
            this.gbFineSearchType.Controls.Add(this.rbSearchFineUnpaid);
            this.gbFineSearchType.Controls.Add(this.rbSearchFinePaid);
            this.gbFineSearchType.Location = new System.Drawing.Point(575, 210);
            this.gbFineSearchType.Name = "gbFineSearchType";
            this.gbFineSearchType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbFineSearchType.Size = new System.Drawing.Size(137, 112);
            this.gbFineSearchType.TabIndex = 5;
            this.gbFineSearchType.TabStop = false;
            this.gbFineSearchType.Text = "Search Type";
            // 
            // rbSearchFinePaidOrUnpaid
            // 
            this.rbSearchFinePaidOrUnpaid.AutoSize = true;
            this.rbSearchFinePaidOrUnpaid.Location = new System.Drawing.Point(35, 75);
            this.rbSearchFinePaidOrUnpaid.Name = "rbSearchFinePaidOrUnpaid";
            this.rbSearchFinePaidOrUnpaid.Size = new System.Drawing.Size(52, 17);
            this.rbSearchFinePaidOrUnpaid.TabIndex = 2;
            this.rbSearchFinePaidOrUnpaid.Text = "Either";
            this.rbSearchFinePaidOrUnpaid.UseVisualStyleBackColor = true;
            // 
            // rbSearchFineUnpaid
            // 
            this.rbSearchFineUnpaid.AutoSize = true;
            this.rbSearchFineUnpaid.Checked = true;
            this.rbSearchFineUnpaid.Location = new System.Drawing.Point(35, 52);
            this.rbSearchFineUnpaid.Name = "rbSearchFineUnpaid";
            this.rbSearchFineUnpaid.Size = new System.Drawing.Size(59, 17);
            this.rbSearchFineUnpaid.TabIndex = 1;
            this.rbSearchFineUnpaid.TabStop = true;
            this.rbSearchFineUnpaid.Text = "Unpaid";
            this.rbSearchFineUnpaid.UseVisualStyleBackColor = true;
            // 
            // rbSearchFinePaid
            // 
            this.rbSearchFinePaid.AutoSize = true;
            this.rbSearchFinePaid.Location = new System.Drawing.Point(35, 29);
            this.rbSearchFinePaid.Name = "rbSearchFinePaid";
            this.rbSearchFinePaid.Size = new System.Drawing.Size(46, 17);
            this.rbSearchFinePaid.TabIndex = 0;
            this.rbSearchFinePaid.Text = "Paid";
            this.rbSearchFinePaid.UseVisualStyleBackColor = true;
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
            this.btnFineSearch.Click += new System.EventHandler(this.btnFineSearch_Click);
            // 
            // fineSearchResultGroupBox
            // 
            this.fineSearchResultGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fineSearchResultGroupBox.Controls.Add(this.fineSearchResultList);
            this.fineSearchResultGroupBox.Location = new System.Drawing.Point(3, 6);
            this.fineSearchResultGroupBox.Name = "fineSearchResultGroupBox";
            this.fineSearchResultGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fineSearchResultGroupBox.Size = new System.Drawing.Size(566, 374);
            this.fineSearchResultGroupBox.TabIndex = 2;
            this.fineSearchResultGroupBox.TabStop = false;
            this.fineSearchResultGroupBox.Text = "Search Results";
            // 
            // fineSearchResultList
            // 
            this.fineSearchResultList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fineSearchResultList.AutoScroll = true;
            this.fineSearchResultList.BackColor = System.Drawing.SystemColors.Window;
            this.fineSearchResultList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fineSearchResultList.Location = new System.Drawing.Point(6, 19);
            this.fineSearchResultList.Name = "fineSearchResultList";
            this.fineSearchResultList.Size = new System.Drawing.Size(554, 349);
            this.fineSearchResultList.TabIndex = 2;
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
            this.bookManagementGroupBox.ResumeLayout(false);
            this.bookSearchTypeGroupBox.ResumeLayout(false);
            this.bookSearchTypeGroupBox.PerformLayout();
            this.bookSearchResultGroupBox.ResumeLayout(false);
            this.bookLoanTab.ResumeLayout(false);
            this.bookLoanTab.PerformLayout();
            this.gbBorrowerManagement.ResumeLayout(false);
            this.gbSearchType.ResumeLayout(false);
            this.gbSearchType.PerformLayout();
            this.bookLoanSearchResultGroupBox.ResumeLayout(false);
            this.finesTab.ResumeLayout(false);
            this.finesTab.PerformLayout();
            this.gbFineManagement.ResumeLayout(false);
            this.gbFineSearchType.ResumeLayout(false);
            this.gbFineSearchType.PerformLayout();
            this.fineSearchResultGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage booksTab;
        private System.Windows.Forms.TabPage bookLoanTab;
        private System.Windows.Forms.TabPage finesTab;
        private System.Windows.Forms.GroupBox bookSearchResultGroupBox;
        private System.Windows.Forms.GroupBox bookLoanSearchResultGroupBox;
        private System.Windows.Forms.GroupBox fineSearchResultGroupBox;
        private System.Windows.Forms.FlowLayoutPanel bookLoanSearchResultList;
        private System.Windows.Forms.FlowLayoutPanel fineSearchResultList;
        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Button btnBookLoanSearch;
        private System.Windows.Forms.TextBox bookSearchText;
        private System.Windows.Forms.TextBox bookLoanSearchText;
        private System.Windows.Forms.TextBox fineSearchText;
        private System.Windows.Forms.Button btnFineSearch;
        private System.Windows.Forms.GroupBox bookSearchTypeGroupBox;
        private System.Windows.Forms.RadioButton rbSearchTitle;
        private System.Windows.Forms.RadioButton rbSearchTitleAndAuthor;
        private System.Windows.Forms.RadioButton rbSearchAuthor;
        private System.Windows.Forms.RadioButton rbSearchIsbn;
        private System.Windows.Forms.FlowLayoutPanel bookSearchResultList;
        private System.Windows.Forms.Button btnBookCheckout;
        private System.Windows.Forms.GroupBox bookManagementGroupBox;
        private System.Windows.Forms.Button btnFindBookLoans;
        private System.Windows.Forms.GroupBox gbSearchType;
        private System.Windows.Forms.RadioButton rbSearchCheckedIn;
        private System.Windows.Forms.RadioButton rbSearchOverdueOrNotOverdue;
        private System.Windows.Forms.RadioButton rbSearchNotOverdue;
        private System.Windows.Forms.RadioButton rbSearchOverdue;
        private System.Windows.Forms.GroupBox gbBorrowerManagement;
        private System.Windows.Forms.Button btnAddNewBorrower;
        private System.Windows.Forms.Button btnCheckInBook;
        private System.Windows.Forms.GroupBox gbFineManagement;
        private System.Windows.Forms.Button btnSetFinePaid;
        private System.Windows.Forms.GroupBox gbFineSearchType;
        private System.Windows.Forms.RadioButton rbSearchFinePaidOrUnpaid;
        private System.Windows.Forms.RadioButton rbSearchFineUnpaid;
        private System.Windows.Forms.RadioButton rbSearchFinePaid;
    }
}

