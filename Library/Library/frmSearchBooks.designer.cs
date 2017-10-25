namespace Library
{
    partial class frmSearchBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlClose = new System.Windows.Forms.Panel();
            this._CloseButton = new Library.ButtonZ();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblBurrowerName = new IncLibrary.IncLabel();
            this.dgvBookDetails = new System.Windows.Forms.DataGridView();
            this.colSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBurrowerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookStatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPublishedYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incLabel1 = new IncLibrary.IncLabel();
            this.incLabel3 = new IncLibrary.IncLabel();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.btnClear = new IncLibrary.IncButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.incLabel4 = new IncLibrary.IncLabel();
            this.incLabel2 = new IncLibrary.IncLabel();
            this.btnChangeStatus = new IncLibrary.IncButton();
            this.cboNewStatus = new System.Windows.Forms.ComboBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.pnlBurrowerInfo = new System.Windows.Forms.Panel();
            this.lblBName = new IncLibrary.IncLabel();
            this.incLabel7 = new IncLibrary.IncLabel();
            this.lblMemberType = new IncLibrary.IncLabel();
            this.lblBurrowedDate = new IncLibrary.IncLabel();
            this.incLabel11 = new IncLibrary.IncLabel();
            this.incLabel6 = new IncLibrary.IncLabel();
            this.lblBurrowerID = new IncLibrary.IncLabel();
            this.incLabel5 = new IncLibrary.IncLabel();
            this.pnlClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlBook.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlBurrowerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClose
            // 
            this.pnlClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlClose.Controls.Add(this._CloseButton);
            this.pnlClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClose.Location = new System.Drawing.Point(0, 0);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(1361, 25);
            this.pnlClose.TabIndex = 2;
            // 
            // _CloseButton
            // 
            this._CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._CloseButton.DisplayText = "X";
            this._CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CloseButton.ForeColor = System.Drawing.Color.White;
            this._CloseButton.Location = new System.Drawing.Point(1333, 0);
            this._CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this._CloseButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this._CloseButton.Name = "_CloseButton";
            this._CloseButton.Size = new System.Drawing.Size(28, 25);
            this._CloseButton.TabIndex = 0;
            this._CloseButton.Text = "X";
            this._CloseButton.TextLocation_X = 6;
            this._CloseButton.TextLocation_Y = 1;
            this._CloseButton.UseVisualStyleBackColor = true;
            this._CloseButton.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cboStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(70, 17);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(148, 24);
            this.cboStatus.TabIndex = 0;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(311, 18);
            this.txtTitle.MaxLength = 500;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(150, 23);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // lblBurrowerName
            // 
            this.lblBurrowerName.AutoSize = true;
            this.lblBurrowerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBurrowerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBurrowerName.Location = new System.Drawing.Point(237, 21);
            this.lblBurrowerName.Name = "lblBurrowerName";
            this.lblBurrowerName.Readonly = false;
            this.lblBurrowerName.Size = new System.Drawing.Size(71, 17);
            this.lblBurrowerName.TabIndex = 65;
            this.lblBurrowerName.Text = "Book Title";
            this.lblBurrowerName.ValueByOrchestrator = "Book Title";
            // 
            // dgvBookDetails
            // 
            this.dgvBookDetails.AllowUserToAddRows = false;
            this.dgvBookDetails.AllowUserToDeleteRows = false;
            this.dgvBookDetails.AllowUserToResizeColumns = false;
            this.dgvBookDetails.AllowUserToResizeRows = false;
            this.dgvBookDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvBookDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSN,
            this.colISBN,
            this.colBookDetailID,
            this.colBookTitle,
            this.colBurrowerName,
            this.colAuthor,
            this.colBookStatusID,
            this.colStatusName,
            this.colPlace,
            this.colPublisher,
            this.colSource,
            this.colPublishedYear,
            this.colSubCategory});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookDetails.EnableHeadersVisualStyles = false;
            this.dgvBookDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvBookDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvBookDetails.Name = "dgvBookDetails";
            this.dgvBookDetails.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookDetails.RowHeadersVisible = false;
            this.dgvBookDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBookDetails.Size = new System.Drawing.Size(1296, 438);
            this.dgvBookDetails.TabIndex = 0;
            this.dgvBookDetails.Click += new System.EventHandler(this.dgvBookDetails_Click);
            // 
            // colSN
            // 
            this.colSN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSN.HeaderText = "SN";
            this.colSN.MinimumWidth = 50;
            this.colSN.Name = "colSN";
            this.colSN.ReadOnly = true;
            this.colSN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSN.Width = 50;
            // 
            // colISBN
            // 
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            this.colISBN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colBookDetailID
            // 
            this.colBookDetailID.HeaderText = "Book ID";
            this.colBookDetailID.Name = "colBookDetailID";
            this.colBookDetailID.ReadOnly = true;
            this.colBookDetailID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBookDetailID.Width = 150;
            // 
            // colBookTitle
            // 
            this.colBookTitle.HeaderText = "Book Title";
            this.colBookTitle.Name = "colBookTitle";
            this.colBookTitle.ReadOnly = true;
            this.colBookTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBookTitle.Width = 250;
            // 
            // colBurrowerName
            // 
            this.colBurrowerName.HeaderText = "Burrower Name";
            this.colBurrowerName.Name = "colBurrowerName";
            this.colBurrowerName.ReadOnly = true;
            this.colBurrowerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBurrowerName.Visible = false;
            this.colBurrowerName.Width = 165;
            // 
            // colAuthor
            // 
            this.colAuthor.HeaderText = "Author";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            this.colAuthor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAuthor.Width = 150;
            // 
            // colBookStatusID
            // 
            this.colBookStatusID.HeaderText = "Status ID";
            this.colBookStatusID.Name = "colBookStatusID";
            this.colBookStatusID.ReadOnly = true;
            this.colBookStatusID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBookStatusID.Visible = false;
            // 
            // colStatusName
            // 
            this.colStatusName.HeaderText = "Status";
            this.colStatusName.Name = "colStatusName";
            this.colStatusName.ReadOnly = true;
            this.colStatusName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colPlace
            // 
            this.colPlace.HeaderText = "Place";
            this.colPlace.Name = "colPlace";
            this.colPlace.ReadOnly = true;
            this.colPlace.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colPublisher
            // 
            this.colPublisher.HeaderText = "Publisher";
            this.colPublisher.Name = "colPublisher";
            this.colPublisher.ReadOnly = true;
            this.colPublisher.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colSource
            // 
            this.colSource.HeaderText = "Source";
            this.colSource.Name = "colSource";
            this.colSource.ReadOnly = true;
            this.colSource.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colPublishedYear
            // 
            this.colPublishedYear.HeaderText = "Year";
            this.colPublishedYear.Name = "colPublishedYear";
            this.colPublishedYear.ReadOnly = true;
            this.colPublishedYear.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colSubCategory
            // 
            this.colSubCategory.HeaderText = "SubCategory";
            this.colSubCategory.Name = "colSubCategory";
            this.colSubCategory.ReadOnly = true;
            this.colSubCategory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // incLabel1
            // 
            this.incLabel1.AutoSize = true;
            this.incLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel1.Location = new System.Drawing.Point(468, 23);
            this.incLabel1.Name = "incLabel1";
            this.incLabel1.Readonly = false;
            this.incLabel1.Size = new System.Drawing.Size(50, 17);
            this.incLabel1.TabIndex = 65;
            this.incLabel1.Text = "Author";
            this.incLabel1.ValueByOrchestrator = "Author";
            // 
            // incLabel3
            // 
            this.incLabel3.AutoSize = true;
            this.incLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel3.Location = new System.Drawing.Point(18, 21);
            this.incLabel3.Name = "incLabel3";
            this.incLabel3.Readonly = false;
            this.incLabel3.Size = new System.Drawing.Size(48, 17);
            this.incLabel3.TabIndex = 65;
            this.incLabel3.Text = "Status";
            this.incLabel3.ValueByOrchestrator = "Status";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAuthor.ForeColor = System.Drawing.Color.White;
            this.txtAuthor.Location = new System.Drawing.Point(522, 19);
            this.txtAuthor.MaxLength = 500;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(150, 23);
            this.txtAuthor.TabIndex = 2;
            this.txtAuthor.TextChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvBookDetails);
            this.panel1.Location = new System.Drawing.Point(23, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 442);
            this.panel1.TabIndex = 1;
            // 
            // pnlBook
            // 
            this.pnlBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pnlBook.Controls.Add(this.cboStatus);
            this.pnlBook.Controls.Add(this.txtAuthor);
            this.pnlBook.Controls.Add(this.txtTitle);
            this.pnlBook.Controls.Add(this.incLabel3);
            this.pnlBook.Controls.Add(this.lblBurrowerName);
            this.pnlBook.Controls.Add(this.incLabel1);
            this.pnlBook.Location = new System.Drawing.Point(234, 71);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(686, 59);
            this.pnlBook.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnClear.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClear.Location = new System.Drawing.Point(926, 73);
            this.btnClear.Name = "btnClear";
            this.btnClear.NextControl = null;
            this.btnClear.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnClear.PreviousControl = null;
            this.btnClear.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnClear.Size = new System.Drawing.Size(59, 55);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.incLabel4);
            this.panel2.Controls.Add(this.incLabel2);
            this.panel2.Controls.Add(this.btnChangeStatus);
            this.panel2.Controls.Add(this.cboNewStatus);
            this.panel2.Controls.Add(this.txtISBN);
            this.panel2.Location = new System.Drawing.Point(12, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 59);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // incLabel4
            // 
            this.incLabel4.AutoSize = true;
            this.incLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel4.Location = new System.Drawing.Point(252, 6);
            this.incLabel4.Name = "incLabel4";
            this.incLabel4.Readonly = false;
            this.incLabel4.Size = new System.Drawing.Size(79, 17);
            this.incLabel4.TabIndex = 72;
            this.incLabel4.Text = "New Status";
            this.incLabel4.ValueByOrchestrator = "New Status";
            // 
            // incLabel2
            // 
            this.incLabel2.AutoSize = true;
            this.incLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel2.Location = new System.Drawing.Point(59, 5);
            this.incLabel2.Name = "incLabel2";
            this.incLabel2.Readonly = false;
            this.incLabel2.Size = new System.Drawing.Size(39, 17);
            this.incLabel2.TabIndex = 71;
            this.incLabel2.Text = "ISBN";
            this.incLabel2.ValueByOrchestrator = "ISBN";
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChangeStatus.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnChangeStatus.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnChangeStatus.Location = new System.Drawing.Point(170, 10);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.NextControl = null;
            this.btnChangeStatus.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnChangeStatus.PreviousControl = null;
            this.btnChangeStatus.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnChangeStatus.Size = new System.Drawing.Size(90, 49);
            this.btnChangeStatus.TabIndex = 68;
            this.btnChangeStatus.Text = "Change Status";
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // cboNewStatus
            // 
            this.cboNewStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cboNewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cboNewStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.cboNewStatus.FormattingEnabled = true;
            this.cboNewStatus.Location = new System.Drawing.Point(215, 26);
            this.cboNewStatus.Name = "cboNewStatus";
            this.cboNewStatus.Size = new System.Drawing.Size(148, 24);
            this.cboNewStatus.TabIndex = 69;
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtISBN.ForeColor = System.Drawing.Color.White;
            this.txtISBN.Location = new System.Drawing.Point(16, 26);
            this.txtISBN.MaxLength = 500;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(148, 23);
            this.txtISBN.TabIndex = 70;
            // 
            // pnlBurrowerInfo
            // 
            this.pnlBurrowerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pnlBurrowerInfo.Controls.Add(this.lblBName);
            this.pnlBurrowerInfo.Controls.Add(this.incLabel7);
            this.pnlBurrowerInfo.Controls.Add(this.lblMemberType);
            this.pnlBurrowerInfo.Controls.Add(this.lblBurrowedDate);
            this.pnlBurrowerInfo.Controls.Add(this.incLabel11);
            this.pnlBurrowerInfo.Controls.Add(this.incLabel6);
            this.pnlBurrowerInfo.Controls.Add(this.lblBurrowerID);
            this.pnlBurrowerInfo.Controls.Add(this.incLabel5);
            this.pnlBurrowerInfo.Location = new System.Drawing.Point(988, 31);
            this.pnlBurrowerInfo.Name = "pnlBurrowerInfo";
            this.pnlBurrowerInfo.Size = new System.Drawing.Size(335, 109);
            this.pnlBurrowerInfo.TabIndex = 5;
            // 
            // lblBName
            // 
            this.lblBName.AutoSize = true;
            this.lblBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBName.Location = new System.Drawing.Point(131, 31);
            this.lblBName.Name = "lblBName";
            this.lblBName.Readonly = false;
            this.lblBName.Size = new System.Drawing.Size(0, 17);
            this.lblBName.TabIndex = 67;
            this.lblBName.ValueByOrchestrator = "";
            // 
            // incLabel7
            // 
            this.incLabel7.AutoSize = true;
            this.incLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel7.Location = new System.Drawing.Point(4, 31);
            this.incLabel7.Name = "incLabel7";
            this.incLabel7.Readonly = false;
            this.incLabel7.Size = new System.Drawing.Size(114, 17);
            this.incLabel7.TabIndex = 67;
            this.incLabel7.Text = "Burrower Name :";
            this.incLabel7.ValueByOrchestrator = "Burrower Name :";
            // 
            // lblMemberType
            // 
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMemberType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblMemberType.Location = new System.Drawing.Point(131, 89);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Readonly = false;
            this.lblMemberType.Size = new System.Drawing.Size(0, 17);
            this.lblMemberType.TabIndex = 66;
            this.lblMemberType.ValueByOrchestrator = "";
            // 
            // lblBurrowedDate
            // 
            this.lblBurrowedDate.AutoSize = true;
            this.lblBurrowedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBurrowedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBurrowedDate.Location = new System.Drawing.Point(131, 60);
            this.lblBurrowedDate.Name = "lblBurrowedDate";
            this.lblBurrowedDate.Readonly = false;
            this.lblBurrowedDate.Size = new System.Drawing.Size(0, 17);
            this.lblBurrowedDate.TabIndex = 66;
            this.lblBurrowedDate.ValueByOrchestrator = "";
            // 
            // incLabel11
            // 
            this.incLabel11.AutoSize = true;
            this.incLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel11.Location = new System.Drawing.Point(15, 89);
            this.incLabel11.Name = "incLabel11";
            this.incLabel11.Readonly = false;
            this.incLabel11.Size = new System.Drawing.Size(103, 17);
            this.incLabel11.TabIndex = 66;
            this.incLabel11.Text = "Member Type :";
            this.incLabel11.ValueByOrchestrator = "Member Type :";
            // 
            // incLabel6
            // 
            this.incLabel6.AutoSize = true;
            this.incLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel6.Location = new System.Drawing.Point(8, 60);
            this.incLabel6.Name = "incLabel6";
            this.incLabel6.Readonly = false;
            this.incLabel6.Size = new System.Drawing.Size(110, 17);
            this.incLabel6.TabIndex = 66;
            this.incLabel6.Text = "Burrowed Date :";
            this.incLabel6.ValueByOrchestrator = "Burrowed Date :";
            // 
            // lblBurrowerID
            // 
            this.lblBurrowerID.AutoSize = true;
            this.lblBurrowerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBurrowerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBurrowerID.Location = new System.Drawing.Point(131, 2);
            this.lblBurrowerID.Name = "lblBurrowerID";
            this.lblBurrowerID.Readonly = false;
            this.lblBurrowerID.Size = new System.Drawing.Size(0, 17);
            this.lblBurrowerID.TabIndex = 65;
            this.lblBurrowerID.ValueByOrchestrator = "";
            // 
            // incLabel5
            // 
            this.incLabel5.AutoSize = true;
            this.incLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel5.Location = new System.Drawing.Point(28, 2);
            this.incLabel5.Name = "incLabel5";
            this.incLabel5.Readonly = false;
            this.incLabel5.Size = new System.Drawing.Size(90, 17);
            this.incLabel5.TabIndex = 65;
            this.incLabel5.Text = "Burrower ID :";
            this.incLabel5.ValueByOrchestrator = "Burrower ID :";
            // 
            // frmSearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1361, 609);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBurrowerInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBook);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmSearchBooks_Load);
            this.pnlClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlBook.ResumeLayout(false);
            this.pnlBook.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlBurrowerInfo.ResumeLayout(false);
            this.pnlBurrowerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClose;
        private ButtonZ _CloseButton;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtTitle;
        private IncLibrary.IncLabel lblBurrowerName;
        private System.Windows.Forms.DataGridView dgvBookDetails;
        private IncLibrary.IncLabel incLabel1;
        private IncLibrary.IncLabel incLabel3;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBook;
        private IncLibrary.IncButton btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBurrowerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookStatusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPublishedYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubCategory;
        private System.Windows.Forms.Panel panel2;
        private IncLibrary.IncButton btnChangeStatus;
        private System.Windows.Forms.ComboBox cboNewStatus;
        private System.Windows.Forms.TextBox txtISBN;
        private IncLibrary.IncLabel incLabel4;
        private IncLibrary.IncLabel incLabel2;
        private System.Windows.Forms.Panel pnlBurrowerInfo;
        private IncLibrary.IncLabel incLabel5;
        private IncLibrary.IncLabel lblBName;
        private IncLibrary.IncLabel incLabel7;
        private IncLibrary.IncLabel lblMemberType;
        private IncLibrary.IncLabel lblBurrowedDate;
        private IncLibrary.IncLabel incLabel11;
        private IncLibrary.IncLabel incLabel6;
        private IncLibrary.IncLabel lblBurrowerID;
    }
}

