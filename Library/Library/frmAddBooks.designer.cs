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
            this._CloseButton = new Library.ButtonZ();
            this.pnlClose = new System.Windows.Forms.Panel();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.incLabel3 = new IncLibrary.IncLabel();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.incLabel5 = new IncLibrary.IncLabel();
            this.incLabel1 = new IncLibrary.IncLabel();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.incLabel2 = new IncLibrary.IncLabel();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.incLabel4 = new IncLibrary.IncLabel();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.incLabel6 = new IncLibrary.IncLabel();
            this.incLabel7 = new IncLibrary.IncLabel();
            this.incLabel8 = new IncLibrary.IncLabel();
            this.incLabel9 = new IncLibrary.IncLabel();
            this.incLabel10 = new IncLibrary.IncLabel();
            this.incLabel11 = new IncLibrary.IncLabel();
            this.incLabel12 = new IncLibrary.IncLabel();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.cboTag = new System.Windows.Forms.ComboBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtPublisherPlace = new System.Windows.Forms.TextBox();
            this.txtBookCopies = new System.Windows.Forms.TextBox();
            this.txtPublisherYear = new System.Windows.Forms.TextBox();
            this.dgvAuthor = new System.Windows.Forms.DataGridView();
            this.btnBrowse = new IncLibrary.IncButton();
            this.picMember = new System.Windows.Forms.PictureBox();
            this.dgvBookInfo = new System.Windows.Forms.DataGridView();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.pnlAdvanceFilter = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.incLabel13 = new IncLibrary.IncLabel();
            this.pnlClose.SuspendLayout();
            this.grpBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).BeginInit();
            this.pnlBook.SuspendLayout();
            this.pnlAdvanceFilter.SuspendLayout();
            this.SuspendLayout();
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
            this.grpBookInfo.Controls.Add(this.btnBrowse);
            this.grpBookInfo.Controls.Add(this.picMember);
            this.grpBookInfo.Controls.Add(this.dgvAuthor);
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
            this.grpBookInfo.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            this.grpBookInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpBookInfo.Location = new System.Drawing.Point(14, 117);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Size = new System.Drawing.Size(742, 501);
            this.grpBookInfo.TabIndex = 1;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Book Info";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtISBN.ForeColor = System.Drawing.SystemColors.Window;
            this.txtISBN.Location = new System.Drawing.Point(63, 9);
            this.txtISBN.MaxLength = 13;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(148, 24);
            this.txtISBN.TabIndex = 0;
            // 
            // incLabel3
            // 
            this.incLabel3.AutoSize = true;
            this.incLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel3.Location = new System.Drawing.Point(6, 13);
            this.incLabel3.Name = "incLabel3";
            this.incLabel3.Readonly = false;
            this.incLabel3.Size = new System.Drawing.Size(51, 17);
            this.incLabel3.TabIndex = 23;
            this.incLabel3.Text = "I.S.B.N";
            this.incLabel3.ValueByOrchestrator = "I.S.B.N";
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(297, 7);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(148, 26);
            this.cboStatus.TabIndex = 1;
            // 
            // incLabel5
            // 
            this.incLabel5.AutoSize = true;
            this.incLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel5.Location = new System.Drawing.Point(244, 12);
            this.incLabel5.Name = "incLabel5";
            this.incLabel5.Readonly = false;
            this.incLabel5.Size = new System.Drawing.Size(48, 17);
            this.incLabel5.TabIndex = 25;
            this.incLabel5.Text = "Status";
            this.incLabel5.ValueByOrchestrator = "Status";
            // 
            // incLabel1
            // 
            this.incLabel1.AutoSize = true;
            this.incLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel1.Location = new System.Drawing.Point(60, 50);
            this.incLabel1.Name = "incLabel1";
            this.incLabel1.Readonly = false;
            this.incLabel1.Size = new System.Drawing.Size(57, 17);
            this.incLabel1.TabIndex = 23;
            this.incLabel1.Text = "Book ID";
            this.incLabel1.ValueByOrchestrator = "Book ID";
            // 
            // txtBookID
            // 
            this.txtBookID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBookID.Location = new System.Drawing.Point(131, 43);
            this.txtBookID.MaxLength = 13;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(205, 26);
            this.txtBookID.TabIndex = 0;
            // 
            // incLabel2
            // 
            this.incLabel2.AutoSize = true;
            this.incLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel2.Location = new System.Drawing.Point(30, 166);
            this.incLabel2.Name = "incLabel2";
            this.incLabel2.Readonly = false;
            this.incLabel2.Size = new System.Drawing.Size(87, 17);
            this.incLabel2.TabIndex = 23;
            this.incLabel2.Text = "Book Copies";
            this.incLabel2.ValueByOrchestrator = "Book Copies";
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCost.Location = new System.Drawing.Point(131, 273);
            this.txtCost.MaxLength = 13;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(205, 26);
            this.txtCost.TabIndex = 4;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtBookTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBookTitle.Location = new System.Drawing.Point(555, 9);
            this.txtBookTitle.MaxLength = 13;
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(171, 24);
            this.txtBookTitle.TabIndex = 2;
            // 
            // incLabel4
            // 
            this.incLabel4.AutoSize = true;
            this.incLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel4.Location = new System.Drawing.Point(60, 224);
            this.incLabel4.Name = "incLabel4";
            this.incLabel4.Readonly = false;
            this.incLabel4.Size = new System.Drawing.Size(53, 17);
            this.incLabel4.TabIndex = 23;
            this.incLabel4.Text = "Source";
            this.incLabel4.ValueByOrchestrator = "Source";
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtPublisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisherName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPublisherName.Location = new System.Drawing.Point(131, 330);
            this.txtPublisherName.MaxLength = 13;
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(205, 26);
            this.txtPublisherName.TabIndex = 5;
            // 
            // incLabel6
            // 
            this.incLabel6.AutoSize = true;
            this.incLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel6.Location = new System.Drawing.Point(399, 291);
            this.incLabel6.Name = "incLabel6";
            this.incLabel6.Readonly = false;
            this.incLabel6.Size = new System.Drawing.Size(50, 17);
            this.incLabel6.TabIndex = 24;
            this.incLabel6.Text = "Author";
            this.incLabel6.ValueByOrchestrator = "Author";
            // 
            // incLabel7
            // 
            this.incLabel7.AutoSize = true;
            this.incLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel7.Location = new System.Drawing.Point(84, 108);
            this.incLabel7.Name = "incLabel7";
            this.incLabel7.Readonly = false;
            this.incLabel7.Size = new System.Drawing.Size(33, 17);
            this.incLabel7.TabIndex = 25;
            this.incLabel7.Text = "Tag";
            this.incLabel7.ValueByOrchestrator = "Tag";
            // 
            // incLabel8
            // 
            this.incLabel8.AutoSize = true;
            this.incLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel8.Location = new System.Drawing.Point(478, 13);
            this.incLabel8.Name = "incLabel8";
            this.incLabel8.Readonly = false;
            this.incLabel8.Size = new System.Drawing.Size(71, 17);
            this.incLabel8.TabIndex = 26;
            this.incLabel8.Text = "Book TItle";
            this.incLabel8.ValueByOrchestrator = "Book TItle";
            // 
            // incLabel9
            // 
            this.incLabel9.AutoSize = true;
            this.incLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel9.Location = new System.Drawing.Point(77, 282);
            this.incLabel9.Name = "incLabel9";
            this.incLabel9.Readonly = false;
            this.incLabel9.Size = new System.Drawing.Size(36, 17);
            this.incLabel9.TabIndex = 24;
            this.incLabel9.Text = "Cost";
            this.incLabel9.ValueByOrchestrator = "Cost";
            // 
            // incLabel10
            // 
            this.incLabel10.AutoSize = true;
            this.incLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel10.Location = new System.Drawing.Point(13, 398);
            this.incLabel10.Name = "incLabel10";
            this.incLabel10.Readonly = false;
            this.incLabel10.Size = new System.Drawing.Size(104, 17);
            this.incLabel10.TabIndex = 25;
            this.incLabel10.Text = "Published Year";
            this.incLabel10.ValueByOrchestrator = "Published Year";
            // 
            // incLabel11
            // 
            this.incLabel11.AutoSize = true;
            this.incLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel11.Location = new System.Drawing.Point(9, 340);
            this.incLabel11.Name = "incLabel11";
            this.incLabel11.Readonly = false;
            this.incLabel11.Size = new System.Drawing.Size(108, 17);
            this.incLabel11.TabIndex = 25;
            this.incLabel11.Text = "Publisher Name";
            this.incLabel11.ValueByOrchestrator = "Publisher Name";
            // 
            // incLabel12
            // 
            this.incLabel12.AutoSize = true;
            this.incLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel12.Location = new System.Drawing.Point(8, 456);
            this.incLabel12.Name = "incLabel12";
            this.incLabel12.Readonly = false;
            this.incLabel12.Size = new System.Drawing.Size(109, 17);
            this.incLabel12.TabIndex = 25;
            this.incLabel12.Text = "Published Place";
            this.incLabel12.ValueByOrchestrator = "Published Place";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAuthor.Location = new System.Drawing.Point(455, 282);
            this.txtAuthor.MaxLength = 13;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(226, 26);
            this.txtAuthor.TabIndex = 8;
            // 
            // cboTag
            // 
            this.cboTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cboTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTag.ForeColor = System.Drawing.SystemColors.Window;
            this.cboTag.FormattingEnabled = true;
            this.cboTag.Location = new System.Drawing.Point(131, 100);
            this.cboTag.Name = "cboTag";
            this.cboTag.Size = new System.Drawing.Size(205, 28);
            this.cboTag.TabIndex = 1;
            // 
            // txtSource
            // 
            this.txtSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSource.Location = new System.Drawing.Point(131, 216);
            this.txtSource.MaxLength = 13;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(205, 26);
            this.txtSource.TabIndex = 3;
            // 
            // txtPublisherPlace
            // 
            this.txtPublisherPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtPublisherPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisherPlace.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPublisherPlace.Location = new System.Drawing.Point(131, 453);
            this.txtPublisherPlace.MaxLength = 13;
            this.txtPublisherPlace.Name = "txtPublisherPlace";
            this.txtPublisherPlace.Size = new System.Drawing.Size(205, 26);
            this.txtPublisherPlace.TabIndex = 7;
            // 
            // txtBookCopies
            // 
            this.txtBookCopies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtBookCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookCopies.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBookCopies.Location = new System.Drawing.Point(131, 159);
            this.txtBookCopies.MaxLength = 13;
            this.txtBookCopies.Name = "txtBookCopies";
            this.txtBookCopies.Size = new System.Drawing.Size(205, 26);
            this.txtBookCopies.TabIndex = 2;
            // 
            // txtPublisherYear
            // 
            this.txtPublisherYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtPublisherYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisherYear.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPublisherYear.Location = new System.Drawing.Point(131, 387);
            this.txtPublisherYear.MaxLength = 13;
            this.txtPublisherYear.Name = "txtPublisherYear";
            this.txtPublisherYear.Size = new System.Drawing.Size(205, 26);
            this.txtPublisherYear.TabIndex = 6;
            // 
            // dgvAuthor
            // 
            this.dgvAuthor.AllowUserToAddRows = false;
            this.dgvAuthor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuthor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuthor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuthor.EnableHeadersVisualStyles = false;
            this.dgvAuthor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvAuthor.Location = new System.Drawing.Point(455, 310);
            this.dgvAuthor.Name = "dgvAuthor";
            this.dgvAuthor.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuthor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvAuthor.Size = new System.Drawing.Size(225, 160);
            this.dgvAuthor.TabIndex = 40;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBrowse.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnBrowse.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnBrowse.Location = new System.Drawing.Point(451, 218);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.NextControl = null;
            this.btnBrowse.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnBrowse.PreviousControl = null;
            this.btnBrowse.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnBrowse.Size = new System.Drawing.Size(229, 25);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse";
            // 
            // picMember
            // 
            this.picMember.Location = new System.Drawing.Point(454, 41);
            this.picMember.Name = "picMember";
            this.picMember.Size = new System.Drawing.Size(226, 171);
            this.picMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMember.TabIndex = 42;
            this.picMember.TabStop = false;
            // 
            // dgvBookInfo
            // 
            this.dgvBookInfo.AllowUserToAddRows = false;
            this.dgvBookInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvBookInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookInfo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBookInfo.EnableHeadersVisualStyles = false;
            this.dgvBookInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvBookInfo.Location = new System.Drawing.Point(843, 128);
            this.dgvBookInfo.Name = "dgvBookInfo";
            this.dgvBookInfo.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBookInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBookInfo.Size = new System.Drawing.Size(477, 415);
            this.dgvBookInfo.TabIndex = 3;
            // 
            // pnlBook
            // 
            this.pnlBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBook.Controls.Add(this.cboStatus);
            this.pnlBook.Controls.Add(this.txtBookTitle);
            this.pnlBook.Controls.Add(this.incLabel5);
            this.pnlBook.Controls.Add(this.incLabel3);
            this.pnlBook.Controls.Add(this.incLabel8);
            this.pnlBook.Controls.Add(this.txtISBN);
            this.pnlBook.Location = new System.Drawing.Point(14, 57);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(742, 52);
            this.pnlBook.TabIndex = 0;
            // 
            // pnlAdvanceFilter
            // 
            this.pnlAdvanceFilter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAdvanceFilter.Controls.Add(this.comboBox2);
            this.pnlAdvanceFilter.Controls.Add(this.incLabel13);
            this.pnlAdvanceFilter.Location = new System.Drawing.Point(843, 57);
            this.pnlAdvanceFilter.Name = "pnlAdvanceFilter";
            this.pnlAdvanceFilter.Size = new System.Drawing.Size(477, 46);
            this.pnlAdvanceFilter.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(49, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(94, 24);
            this.comboBox2.TabIndex = 0;
            // 
            // incLabel13
            // 
            this.incLabel13.AutoSize = true;
            this.incLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel13.Location = new System.Drawing.Point(10, 9);
            this.incLabel13.Name = "incLabel13";
            this.incLabel13.Readonly = false;
            this.incLabel13.Size = new System.Drawing.Size(33, 17);
            this.incLabel13.TabIndex = 28;
            this.incLabel13.Text = "Tag";
            this.incLabel13.ValueByOrchestrator = "Tag";
            // 
            // frmAddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1361, 630);
            this.ControlBox = false;
            this.Controls.Add(this.pnlAdvanceFilter);
            this.Controls.Add(this.pnlBook);
            this.Controls.Add(this.dgvBookInfo);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).EndInit();
            this.pnlBook.ResumeLayout(false);
            this.pnlBook.PerformLayout();
            this.pnlAdvanceFilter.ResumeLayout(false);
            this.pnlAdvanceFilter.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtBookTitle;
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
        private System.Windows.Forms.DataGridView dgvAuthor;
        private IncLibrary.IncButton btnBrowse;
        private System.Windows.Forms.PictureBox picMember;
        private System.Windows.Forms.DataGridView dgvBookInfo;
        private System.Windows.Forms.Panel pnlBook;
        private System.Windows.Forms.Panel pnlAdvanceFilter;
        private System.Windows.Forms.ComboBox comboBox2;
        private IncLibrary.IncLabel incLabel13;
        private System.Windows.Forms.TextBox txtBookCopies;
    }
}

