namespace Library
{
    partial class frmAddBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlClose = new System.Windows.Forms.Panel();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.incLabel13 = new IncLibrary.IncLabel();
            this.pnlGridAuthor = new System.Windows.Forms.Panel();
            this.dgvAuthor = new System.Windows.Forms.DataGridView();
            this.colAuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBrowse = new IncLibrary.IncButton();
            this.picMember = new System.Windows.Forms.PictureBox();
            this.txtPublisherYear = new System.Windows.Forms.TextBox();
            this.txtBookCopies = new System.Windows.Forms.TextBox();
            this.cboTag = new System.Windows.Forms.ComboBox();
            this.incLabel12 = new IncLibrary.IncLabel();
            this.incLabel11 = new IncLibrary.IncLabel();
            this.incLabel10 = new IncLibrary.IncLabel();
            this.incLabel7 = new IncLibrary.IncLabel();
            this.incLabel9 = new IncLibrary.IncLabel();
            this.incLabel6 = new IncLibrary.IncLabel();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.txtPublisherPlace = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.incLabel4 = new IncLibrary.IncLabel();
            this.incLabel2 = new IncLibrary.IncLabel();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.incLabel1 = new IncLibrary.IncLabel();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.incLabel3 = new IncLibrary.IncLabel();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.incLabel5 = new IncLibrary.IncLabel();
            this.txtBookTitleSearch = new System.Windows.Forms.TextBox();
            this.incLabel8 = new IncLibrary.IncLabel();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.dgvBooksInfo = new System.Windows.Forms.DataGridView();
            this.pnlBooksInfo = new System.Windows.Forms.Panel();
            this.btnSave = new IncLibrary.IncButton();
            this.btnUpdate = new IncLibrary.IncButton();
            this.btnGet = new IncLibrary.IncButton();
            this.btnClear = new IncLibrary.IncButton();
            this.chkRegistered = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.incLabel14 = new IncLibrary.IncLabel();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPublishedYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._CloseButton = new Library.ButtonZ();
            this.pnlClose.SuspendLayout();
            this.grpBookInfo.SuspendLayout();
            this.pnlGridAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).BeginInit();
            this.pnlBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksInfo)).BeginInit();
            this.pnlBooksInfo.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClose
            // 
            this.pnlClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlClose.Controls.Add(this._CloseButton);
            this.pnlClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClose.Location = new System.Drawing.Point(0, 0);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(1361, 36);
            this.pnlClose.TabIndex = 2;
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.Controls.Add(this.txtBookTitle);
            this.grpBookInfo.Controls.Add(this.incLabel13);
            this.grpBookInfo.Controls.Add(this.pnlGridAuthor);
            this.grpBookInfo.Controls.Add(this.btnBrowse);
            this.grpBookInfo.Controls.Add(this.picMember);
            this.grpBookInfo.Controls.Add(this.txtPublisherYear);
            this.grpBookInfo.Controls.Add(this.txtBookCopies);
            this.grpBookInfo.Controls.Add(this.cboTag);
            this.grpBookInfo.Controls.Add(this.incLabel12);
            this.grpBookInfo.Controls.Add(this.incLabel11);
            this.grpBookInfo.Controls.Add(this.incLabel10);
            this.grpBookInfo.Controls.Add(this.incLabel7);
            this.grpBookInfo.Controls.Add(this.incLabel9);
            this.grpBookInfo.Controls.Add(this.incLabel6);
            this.grpBookInfo.Controls.Add(this.txtPublisherName);
            this.grpBookInfo.Controls.Add(this.txtPublisherPlace);
            this.grpBookInfo.Controls.Add(this.txtSource);
            this.grpBookInfo.Controls.Add(this.txtCost);
            this.grpBookInfo.Controls.Add(this.incLabel4);
            this.grpBookInfo.Controls.Add(this.incLabel2);
            this.grpBookInfo.Controls.Add(this.txtAuthor);
            this.grpBookInfo.Controls.Add(this.txtBookID);
            this.grpBookInfo.Controls.Add(this.incLabel1);
            this.grpBookInfo.Enabled = false;
            this.grpBookInfo.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            this.grpBookInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpBookInfo.Location = new System.Drawing.Point(14, 117);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Size = new System.Drawing.Size(742, 501);
            this.grpBookInfo.TabIndex = 1;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Book Info";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBookTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBookTitle.Location = new System.Drawing.Point(118, 104);
            this.txtBookTitle.MaxLength = 13;
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(205, 26);
            this.txtBookTitle.TabIndex = 45;
            // 
            // incLabel13
            // 
            this.incLabel13.AutoSize = true;
            this.incLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel13.Location = new System.Drawing.Point(42, 111);
            this.incLabel13.Name = "incLabel13";
            this.incLabel13.Readonly = false;
            this.incLabel13.Size = new System.Drawing.Size(71, 17);
            this.incLabel13.TabIndex = 46;
            this.incLabel13.Text = "Book TItle";
            this.incLabel13.ValueByOrchestrator = "Book TItle";
            // 
            // pnlGridAuthor
            // 
            this.pnlGridAuthor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGridAuthor.Controls.Add(this.dgvAuthor);
            this.pnlGridAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlGridAuthor.Location = new System.Drawing.Point(468, 271);
            this.pnlGridAuthor.Name = "pnlGridAuthor";
            this.pnlGridAuthor.Size = new System.Drawing.Size(230, 165);
            this.pnlGridAuthor.TabIndex = 44;
            // 
            // dgvAuthor
            // 
            this.dgvAuthor.AllowUserToAddRows = false;
            this.dgvAuthor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuthor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAuthorName,
            this.colAuthorID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuthor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuthor.EnableHeadersVisualStyles = false;
            this.dgvAuthor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvAuthor.Location = new System.Drawing.Point(0, 1);
            this.dgvAuthor.Name = "dgvAuthor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuthor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvAuthor.Size = new System.Drawing.Size(227, 162);
            this.dgvAuthor.TabIndex = 43;
            // 
            // colAuthorName
            // 
            this.colAuthorName.FillWeight = 140F;
            this.colAuthorName.HeaderText = "Author Name";
            this.colAuthorName.Name = "colAuthorName";
            this.colAuthorName.Width = 185;
            // 
            // colAuthorID
            // 
            this.colAuthorID.FillWeight = 200F;
            this.colAuthorID.HeaderText = "Author ID";
            this.colAuthorID.Name = "colAuthorID";
            this.colAuthorID.Visible = false;
            this.colAuthorID.Width = 200;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBrowse.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnBrowse.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnBrowse.Location = new System.Drawing.Point(488, 201);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.NextControl = null;
            this.btnBrowse.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnBrowse.PreviousControl = null;
            this.btnBrowse.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnBrowse.Size = new System.Drawing.Size(181, 25);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse";
            // 
            // picMember
            // 
            this.picMember.Location = new System.Drawing.Point(488, 38);
            this.picMember.Name = "picMember";
            this.picMember.Size = new System.Drawing.Size(181, 157);
            this.picMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMember.TabIndex = 42;
            this.picMember.TabStop = false;
            // 
            // txtPublisherYear
            // 
            this.txtPublisherYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtPublisherYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisherYear.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPublisherYear.Location = new System.Drawing.Point(118, 448);
            this.txtPublisherYear.MaxLength = 13;
            this.txtPublisherYear.Name = "txtPublisherYear";
            this.txtPublisherYear.Size = new System.Drawing.Size(205, 26);
            this.txtPublisherYear.TabIndex = 6;
            // 
            // txtBookCopies
            // 
            this.txtBookCopies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtBookCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookCopies.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBookCopies.Location = new System.Drawing.Point(118, 220);
            this.txtBookCopies.MaxLength = 13;
            this.txtBookCopies.Name = "txtBookCopies";
            this.txtBookCopies.Size = new System.Drawing.Size(205, 26);
            this.txtBookCopies.TabIndex = 2;
            // 
            // cboTag
            // 
            this.cboTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cboTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTag.ForeColor = System.Drawing.SystemColors.Window;
            this.cboTag.FormattingEnabled = true;
            this.cboTag.Location = new System.Drawing.Point(118, 161);
            this.cboTag.Name = "cboTag";
            this.cboTag.Size = new System.Drawing.Size(205, 28);
            this.cboTag.TabIndex = 1;
            // 
            // incLabel12
            // 
            this.incLabel12.AutoSize = true;
            this.incLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel12.Location = new System.Drawing.Point(356, 456);
            this.incLabel12.Name = "incLabel12";
            this.incLabel12.Readonly = false;
            this.incLabel12.Size = new System.Drawing.Size(109, 17);
            this.incLabel12.TabIndex = 25;
            this.incLabel12.Text = "Published Place";
            this.incLabel12.ValueByOrchestrator = "Published Place";
            // 
            // incLabel11
            // 
            this.incLabel11.AutoSize = true;
            this.incLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel11.Location = new System.Drawing.Point(5, 396);
            this.incLabel11.Name = "incLabel11";
            this.incLabel11.Readonly = false;
            this.incLabel11.Size = new System.Drawing.Size(108, 17);
            this.incLabel11.TabIndex = 25;
            this.incLabel11.Text = "Publisher Name";
            this.incLabel11.ValueByOrchestrator = "Publisher Name";
            // 
            // incLabel10
            // 
            this.incLabel10.AutoSize = true;
            this.incLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel10.Location = new System.Drawing.Point(9, 456);
            this.incLabel10.Name = "incLabel10";
            this.incLabel10.Readonly = false;
            this.incLabel10.Size = new System.Drawing.Size(104, 17);
            this.incLabel10.TabIndex = 25;
            this.incLabel10.Text = "Published Year";
            this.incLabel10.ValueByOrchestrator = "Published Year";
            // 
            // incLabel7
            // 
            this.incLabel7.AutoSize = true;
            this.incLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel7.Location = new System.Drawing.Point(80, 166);
            this.incLabel7.Name = "incLabel7";
            this.incLabel7.Readonly = false;
            this.incLabel7.Size = new System.Drawing.Size(33, 17);
            this.incLabel7.TabIndex = 25;
            this.incLabel7.Text = "Tag";
            this.incLabel7.ValueByOrchestrator = "Tag";
            // 
            // incLabel9
            // 
            this.incLabel9.AutoSize = true;
            this.incLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel9.Location = new System.Drawing.Point(77, 340);
            this.incLabel9.Name = "incLabel9";
            this.incLabel9.Readonly = false;
            this.incLabel9.Size = new System.Drawing.Size(36, 17);
            this.incLabel9.TabIndex = 24;
            this.incLabel9.Text = "Cost";
            this.incLabel9.ValueByOrchestrator = "Cost";
            // 
            // incLabel6
            // 
            this.incLabel6.AutoSize = true;
            this.incLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel6.Location = new System.Drawing.Point(415, 251);
            this.incLabel6.Name = "incLabel6";
            this.incLabel6.Readonly = false;
            this.incLabel6.Size = new System.Drawing.Size(50, 17);
            this.incLabel6.TabIndex = 24;
            this.incLabel6.Text = "Author";
            this.incLabel6.ValueByOrchestrator = "Author";
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtPublisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisherName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPublisherName.Location = new System.Drawing.Point(118, 391);
            this.txtPublisherName.MaxLength = 13;
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(205, 26);
            this.txtPublisherName.TabIndex = 5;
            this.txtPublisherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPublisherName_KeyPress);
            // 
            // txtPublisherPlace
            // 
            this.txtPublisherPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtPublisherPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisherPlace.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPublisherPlace.Location = new System.Drawing.Point(471, 450);
            this.txtPublisherPlace.MaxLength = 13;
            this.txtPublisherPlace.Name = "txtPublisherPlace";
            this.txtPublisherPlace.Size = new System.Drawing.Size(227, 26);
            this.txtPublisherPlace.TabIndex = 7;
            // 
            // txtSource
            // 
            this.txtSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSource.Location = new System.Drawing.Point(118, 277);
            this.txtSource.MaxLength = 13;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(205, 26);
            this.txtSource.TabIndex = 3;
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCost.Location = new System.Drawing.Point(118, 334);
            this.txtCost.MaxLength = 13;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(205, 26);
            this.txtCost.TabIndex = 4;
            // 
            // incLabel4
            // 
            this.incLabel4.AutoSize = true;
            this.incLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel4.Location = new System.Drawing.Point(60, 282);
            this.incLabel4.Name = "incLabel4";
            this.incLabel4.Readonly = false;
            this.incLabel4.Size = new System.Drawing.Size(53, 17);
            this.incLabel4.TabIndex = 23;
            this.incLabel4.Text = "Source";
            this.incLabel4.ValueByOrchestrator = "Source";
            // 
            // incLabel2
            // 
            this.incLabel2.AutoSize = true;
            this.incLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel2.Location = new System.Drawing.Point(26, 224);
            this.incLabel2.Name = "incLabel2";
            this.incLabel2.Readonly = false;
            this.incLabel2.Size = new System.Drawing.Size(87, 17);
            this.incLabel2.TabIndex = 23;
            this.incLabel2.Text = "Book Copies";
            this.incLabel2.ValueByOrchestrator = "Book Copies";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAuthor.Location = new System.Drawing.Point(470, 245);
            this.txtAuthor.MaxLength = 13;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(226, 26);
            this.txtAuthor.TabIndex = 8;
            this.txtAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPublisherName_KeyPress);
            // 
            // txtBookID
            // 
            this.txtBookID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBookID.Location = new System.Drawing.Point(118, 47);
            this.txtBookID.MaxLength = 13;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(205, 26);
            this.txtBookID.TabIndex = 0;
            // 
            // incLabel1
            // 
            this.incLabel1.AutoSize = true;
            this.incLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel1.Location = new System.Drawing.Point(56, 50);
            this.incLabel1.Name = "incLabel1";
            this.incLabel1.Readonly = false;
            this.incLabel1.Size = new System.Drawing.Size(57, 17);
            this.incLabel1.TabIndex = 23;
            this.incLabel1.Text = "Book ID";
            this.incLabel1.ValueByOrchestrator = "Book ID";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtISBN.ForeColor = System.Drawing.SystemColors.Window;
            this.txtISBN.Location = new System.Drawing.Point(85, 10);
            this.txtISBN.MaxLength = 13;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(148, 24);
            this.txtISBN.TabIndex = 0;
            // 
            // incLabel3
            // 
            this.incLabel3.AutoSize = true;
            this.incLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.incLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel3.Location = new System.Drawing.Point(28, 14);
            this.incLabel3.Name = "incLabel3";
            this.incLabel3.Readonly = false;
            this.incLabel3.Size = new System.Drawing.Size(48, 16);
            this.incLabel3.TabIndex = 23;
            this.incLabel3.Text = "I.S.B.N";
            this.incLabel3.ValueByOrchestrator = "I.S.B.N";
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cboStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(319, 8);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(148, 25);
            this.cboStatus.TabIndex = 1;
            // 
            // incLabel5
            // 
            this.incLabel5.AutoSize = true;
            this.incLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.incLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel5.Location = new System.Drawing.Point(266, 13);
            this.incLabel5.Name = "incLabel5";
            this.incLabel5.Readonly = false;
            this.incLabel5.Size = new System.Drawing.Size(45, 16);
            this.incLabel5.TabIndex = 25;
            this.incLabel5.Text = "Status";
            this.incLabel5.ValueByOrchestrator = "Status";
            // 
            // txtBookTitleSearch
            // 
            this.txtBookTitleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtBookTitleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBookTitleSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBookTitleSearch.Location = new System.Drawing.Point(396, 14);
            this.txtBookTitleSearch.MaxLength = 13;
            this.txtBookTitleSearch.Name = "txtBookTitleSearch";
            this.txtBookTitleSearch.Size = new System.Drawing.Size(168, 23);
            this.txtBookTitleSearch.TabIndex = 2;
            // 
            // incLabel8
            // 
            this.incLabel8.AutoSize = true;
            this.incLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.incLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel8.Location = new System.Drawing.Point(259, 18);
            this.incLabel8.Name = "incLabel8";
            this.incLabel8.Readonly = false;
            this.incLabel8.Size = new System.Drawing.Size(134, 16);
            this.incLabel8.TabIndex = 26;
            this.incLabel8.Text = "Search Book By Title";
            this.incLabel8.ValueByOrchestrator = "Search Book By Title";
            // 
            // pnlBook
            // 
            this.pnlBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pnlBook.Controls.Add(this.cboStatus);
            this.pnlBook.Controls.Add(this.incLabel5);
            this.pnlBook.Controls.Add(this.incLabel3);
            this.pnlBook.Controls.Add(this.txtISBN);
            this.pnlBook.Location = new System.Drawing.Point(192, 62);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(564, 44);
            this.pnlBook.TabIndex = 0;
            // 
            // dgvBooksInfo
            // 
            this.dgvBooksInfo.AllowUserToAddRows = false;
            this.dgvBooksInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvBooksInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooksInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBooksInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooksInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colStatus,
            this.colAuthor,
            this.colTag,
            this.colCost,
            this.colISBN,
            this.colSource,
            this.colPlace,
            this.colPublisherName,
            this.colPublishedYear,
            this.colPages,
            this.colBookCopies,
            this.colBookDetailID});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBooksInfo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBooksInfo.EnableHeadersVisualStyles = false;
            this.dgvBooksInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvBooksInfo.Location = new System.Drawing.Point(1, 1);
            this.dgvBooksInfo.Name = "dgvBooksInfo";
            this.dgvBooksInfo.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooksInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBooksInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBooksInfo.Size = new System.Drawing.Size(572, 386);
            this.dgvBooksInfo.TabIndex = 40;
            // 
            // pnlBooksInfo
            // 
            this.pnlBooksInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBooksInfo.Controls.Add(this.dgvBooksInfo);
            this.pnlBooksInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBooksInfo.ForeColor = System.Drawing.Color.White;
            this.pnlBooksInfo.Location = new System.Drawing.Point(755, 129);
            this.pnlBooksInfo.Name = "pnlBooksInfo";
            this.pnlBooksInfo.Size = new System.Drawing.Size(575, 392);
            this.pnlBooksInfo.TabIndex = 41;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnSave.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSave.Location = new System.Drawing.Point(1216, 549);
            this.btnSave.Name = "btnSave";
            this.btnSave.NextControl = null;
            this.btnSave.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnSave.PreviousControl = null;
            this.btnSave.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnSave.Size = new System.Drawing.Size(85, 47);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnUpdate.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnUpdate.Location = new System.Drawing.Point(1109, 549);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NextControl = null;
            this.btnUpdate.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnUpdate.PreviousControl = null;
            this.btnUpdate.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnUpdate.Size = new System.Drawing.Size(85, 47);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Update";
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGet.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnGet.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGet.Location = new System.Drawing.Point(1003, 549);
            this.btnGet.Name = "btnGet";
            this.btnGet.NextControl = null;
            this.btnGet.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnGet.PreviousControl = null;
            this.btnGet.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnGet.Size = new System.Drawing.Size(85, 47);
            this.btnGet.TabIndex = 42;
            this.btnGet.Text = "Get";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnClear.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClear.Location = new System.Drawing.Point(894, 549);
            this.btnClear.Name = "btnClear";
            this.btnClear.NextControl = null;
            this.btnClear.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnClear.PreviousControl = null;
            this.btnClear.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnClear.Size = new System.Drawing.Size(85, 47);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Clear";
            // 
            // chkRegistered
            // 
            this.chkRegistered.AutoSize = true;
            this.chkRegistered.BackColor = System.Drawing.Color.Red;
            this.chkRegistered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRegistered.ForeColor = System.Drawing.Color.White;
            this.chkRegistered.Location = new System.Drawing.Point(43, 73);
            this.chkRegistered.Name = "chkRegistered";
            this.chkRegistered.Size = new System.Drawing.Size(122, 21);
            this.chkRegistered.TabIndex = 43;
            this.chkRegistered.Text = "Not Registered";
            this.chkRegistered.UseVisualStyleBackColor = false;
            this.chkRegistered.CheckedChanged += new System.EventHandler(this.chkRegistered_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(94, 15);
            this.textBox1.MaxLength = 13;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(148, 23);
            this.textBox1.TabIndex = 26;
            // 
            // incLabel14
            // 
            this.incLabel14.AutoSize = true;
            this.incLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.incLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel14.Location = new System.Drawing.Point(38, 19);
            this.incLabel14.Name = "incLabel14";
            this.incLabel14.Readonly = false;
            this.incLabel14.Size = new System.Drawing.Size(56, 16);
            this.incLabel14.TabIndex = 27;
            this.incLabel14.Text = "Book ID";
            this.incLabel14.ValueByOrchestrator = "Book ID";
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.grpSearch.Controls.Add(this.incLabel14);
            this.grpSearch.Controls.Add(this.textBox1);
            this.grpSearch.Controls.Add(this.txtBookTitleSearch);
            this.grpSearch.Controls.Add(this.incLabel8);
            this.grpSearch.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.ForeColor = System.Drawing.Color.SeaShell;
            this.grpSearch.Location = new System.Drawing.Point(756, 62);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(572, 44);
            this.grpSearch.TabIndex = 44;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Box";
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 200;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colAuthor
            // 
            this.colAuthor.HeaderText = "Author";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            // 
            // colTag
            // 
            this.colTag.HeaderText = "Tag";
            this.colTag.Name = "colTag";
            this.colTag.ReadOnly = true;
            this.colTag.Width = 94;
            // 
            // colCost
            // 
            this.colCost.HeaderText = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.ReadOnly = true;
            this.colCost.Visible = false;
            // 
            // colISBN
            // 
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            this.colISBN.Visible = false;
            // 
            // colSource
            // 
            this.colSource.HeaderText = "Source";
            this.colSource.Name = "colSource";
            this.colSource.ReadOnly = true;
            this.colSource.Visible = false;
            // 
            // colPlace
            // 
            this.colPlace.HeaderText = "Place";
            this.colPlace.Name = "colPlace";
            this.colPlace.ReadOnly = true;
            this.colPlace.Visible = false;
            // 
            // colPublisherName
            // 
            this.colPublisherName.HeaderText = "Publisher Name";
            this.colPublisherName.Name = "colPublisherName";
            this.colPublisherName.ReadOnly = true;
            this.colPublisherName.Visible = false;
            // 
            // colPublishedYear
            // 
            this.colPublishedYear.HeaderText = "Published Year";
            this.colPublishedYear.Name = "colPublishedYear";
            this.colPublishedYear.ReadOnly = true;
            this.colPublishedYear.Visible = false;
            // 
            // colPages
            // 
            this.colPages.HeaderText = "Pages";
            this.colPages.Name = "colPages";
            this.colPages.ReadOnly = true;
            this.colPages.Visible = false;
            // 
            // colBookCopies
            // 
            this.colBookCopies.HeaderText = "No.";
            this.colBookCopies.Name = "colBookCopies";
            this.colBookCopies.ReadOnly = true;
            this.colBookCopies.Width = 40;
            // 
            // colBookDetailID
            // 
            this.colBookDetailID.HeaderText = "Book Detail ID";
            this.colBookDetailID.Name = "colBookDetailID";
            this.colBookDetailID.ReadOnly = true;
            this.colBookDetailID.Visible = false;
            // 
            // _CloseButton
            // 
            this._CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._CloseButton.DisplayText = "X";
            this._CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CloseButton.ForeColor = System.Drawing.Color.White;
            this._CloseButton.Location = new System.Drawing.Point(1327, 2);
            this._CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this._CloseButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this._CloseButton.Name = "_CloseButton";
            this._CloseButton.Size = new System.Drawing.Size(31, 27);
            this._CloseButton.TabIndex = 1;
            this._CloseButton.Text = "X";
            this._CloseButton.TextLocation_X = 6;
            this._CloseButton.TextLocation_Y = 1;
            this._CloseButton.UseVisualStyleBackColor = true;
            this._CloseButton.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // frmAddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1361, 630);
            this.ControlBox = false;
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.chkRegistered);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlBooksInfo);
            this.Controls.Add(this.pnlBook);
            this.Controls.Add(this.grpBookInfo);
            this.Controls.Add(this.pnlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmAddBooks_Load);
            this.pnlClose.ResumeLayout(false);
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            this.pnlGridAuthor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).EndInit();
            this.pnlBook.ResumeLayout(false);
            this.pnlBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksInfo)).EndInit();
            this.pnlBooksInfo.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonZ _CloseButton;
        private System.Windows.Forms.Panel pnlClose;
        private System.Windows.Forms.GroupBox grpBookInfo;
        private IncLibrary.IncLabel incLabel5;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.ComboBox cboStatus;
        private IncLibrary.IncLabel incLabel3;
        private IncLibrary.IncLabel incLabel8;
        private IncLibrary.IncLabel incLabel7;
        private IncLibrary.IncLabel incLabel6;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.TextBox txtCost;
        private IncLibrary.IncLabel incLabel4;
        private IncLibrary.IncLabel incLabel2;
        private System.Windows.Forms.TextBox txtBookTitleSearch;
        private System.Windows.Forms.TextBox txtBookID;
        private IncLibrary.IncLabel incLabel1;
        private IncLibrary.IncLabel incLabel12;
        private IncLibrary.IncLabel incLabel11;
        private IncLibrary.IncLabel incLabel10;
        private IncLibrary.IncLabel incLabel9;
        private System.Windows.Forms.TextBox txtPublisherYear;
        private System.Windows.Forms.ComboBox cboTag;
        private System.Windows.Forms.TextBox txtPublisherPlace;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtAuthor;
        private IncLibrary.IncButton btnBrowse;
        private System.Windows.Forms.PictureBox picMember;
        private System.Windows.Forms.Panel pnlBook;
        private System.Windows.Forms.TextBox txtBookCopies;
        private System.Windows.Forms.DataGridView dgvAuthor;
        private System.Windows.Forms.DataGridView dgvBooksInfo;
        private System.Windows.Forms.Panel pnlGridAuthor;
        private System.Windows.Forms.Panel pnlBooksInfo;
        private IncLibrary.IncButton btnSave;
        private IncLibrary.IncButton btnUpdate;
        private IncLibrary.IncButton btnGet;
        private IncLibrary.IncButton btnClear;
        private System.Windows.Forms.CheckBox chkRegistered;
        private System.Windows.Forms.TextBox txtBookTitle;
        private IncLibrary.IncLabel incLabel13;
        private System.Windows.Forms.TextBox textBox1;
        private IncLibrary.IncLabel incLabel14;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPublisherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPublishedYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPages;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookCopies;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookDetailID;
    }
}

