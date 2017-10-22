namespace Library
{
    partial class frmFine
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
            this.btnPay = new IncLibrary.IncButton();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.incLabel2 = new IncLibrary.IncLabel();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblISBN = new IncLibrary.IncLabel();
            this.incLabel10 = new IncLibrary.IncLabel();
            this.lblSection = new IncLibrary.IncLabel();
            this.incLabel9 = new IncLibrary.IncLabel();
            this.lblAuthor = new IncLibrary.IncLabel();
            this.lblID = new IncLibrary.IncLabel();
            this.lblClass = new IncLibrary.IncLabel();
            this.lblBurrowedDate = new IncLibrary.IncLabel();
            this.lblBookTitle = new IncLibrary.IncLabel();
            this.incLabel4 = new IncLibrary.IncLabel();
            this.incLabel8 = new IncLibrary.IncLabel();
            this.incLabel7 = new IncLibrary.IncLabel();
            this.incLabel6 = new IncLibrary.IncLabel();
            this.lblSpecificInfoH = new IncLibrary.IncLabel();
            this.pnlISBN = new System.Windows.Forms.Panel();
            this.dgvFineDetail = new System.Windows.Forms.DataGridView();
            this.colSNF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBNF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFIneAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookTitleF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBurrowedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblName = new IncLibrary.IncLabel();
            this.pnlClose.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlISBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFineDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClose
            // 
            this.pnlClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlClose.Controls.Add(this._CloseButton);
            this.pnlClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClose.Location = new System.Drawing.Point(0, 0);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(870, 25);
            this.pnlClose.TabIndex = 61;
            // 
            // _CloseButton
            // 
            this._CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._CloseButton.DisplayText = "X";
            this._CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CloseButton.ForeColor = System.Drawing.Color.White;
            this._CloseButton.Location = new System.Drawing.Point(842, 0);
            this._CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this._CloseButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this._CloseButton.Name = "_CloseButton";
            this._CloseButton.Size = new System.Drawing.Size(28, 25);
            this._CloseButton.TabIndex = 2;
            this._CloseButton.Text = "X";
            this._CloseButton.TextLocation_X = 6;
            this._CloseButton.TextLocation_Y = 1;
            this._CloseButton.UseVisualStyleBackColor = true;
            this._CloseButton.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPay.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnPay.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPay.Location = new System.Drawing.Point(487, 485);
            this.btnPay.Name = "btnPay";
            this.btnPay.NextControl = null;
            this.btnPay.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnPay.PreviousControl = null;
            this.btnPay.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnPay.Size = new System.Drawing.Size(68, 32);
            this.btnPay.TabIndex = 80;
            this.btnPay.Text = "Pay";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStudentName.ForeColor = System.Drawing.Color.White;
            this.txtStudentName.Location = new System.Drawing.Point(248, 66);
            this.txtStudentName.MaxLength = 500;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(150, 23);
            this.txtStudentName.TabIndex = 77;
            // 
            // incLabel2
            // 
            this.incLabel2.AutoSize = true;
            this.incLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel2.Location = new System.Drawing.Point(146, 69);
            this.incLabel2.Name = "incLabel2";
            this.incLabel2.Readonly = false;
            this.incLabel2.Size = new System.Drawing.Size(98, 17);
            this.incLabel2.TabIndex = 78;
            this.incLabel2.Text = "Student Name";
            this.incLabel2.ValueByOrchestrator = "Student Name";
            // 
            // txtFine
            // 
            this.txtFine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFine.ForeColor = System.Drawing.Color.White;
            this.txtFine.Location = new System.Drawing.Point(561, 487);
            this.txtFine.MaxLength = 500;
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(105, 26);
            this.txtFine.TabIndex = 79;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.lblISBN);
            this.panel2.Controls.Add(this.incLabel10);
            this.panel2.Controls.Add(this.lblSection);
            this.panel2.Controls.Add(this.incLabel9);
            this.panel2.Controls.Add(this.lblAuthor);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.lblClass);
            this.panel2.Controls.Add(this.lblBurrowedDate);
            this.panel2.Controls.Add(this.lblBookTitle);
            this.panel2.Controls.Add(this.incLabel4);
            this.panel2.Controls.Add(this.incLabel8);
            this.panel2.Controls.Add(this.incLabel7);
            this.panel2.Controls.Add(this.incLabel6);
            this.panel2.Controls.Add(this.lblSpecificInfoH);
            this.panel2.Location = new System.Drawing.Point(477, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 386);
            this.panel2.TabIndex = 76;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblISBN.Location = new System.Drawing.Point(54, 323);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Readonly = false;
            this.lblISBN.Size = new System.Drawing.Size(8, 17);
            this.lblISBN.TabIndex = 78;
            this.lblISBN.Text = "\r\n";
            this.lblISBN.ValueByOrchestrator = "\r\n";
            // 
            // incLabel10
            // 
            this.incLabel10.AutoSize = true;
            this.incLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.incLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel10.Location = new System.Drawing.Point(7, 323);
            this.incLabel10.Name = "incLabel10";
            this.incLabel10.Readonly = false;
            this.incLabel10.Size = new System.Drawing.Size(51, 17);
            this.incLabel10.TabIndex = 77;
            this.incLabel10.Text = "ISBN : ";
            this.incLabel10.ValueByOrchestrator = "ISBN : ";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSection.Location = new System.Drawing.Point(66, 122);
            this.lblSection.Name = "lblSection";
            this.lblSection.Readonly = false;
            this.lblSection.Size = new System.Drawing.Size(8, 17);
            this.lblSection.TabIndex = 76;
            this.lblSection.Text = "\r\n";
            this.lblSection.ValueByOrchestrator = "\r\n";
            // 
            // incLabel9
            // 
            this.incLabel9.AutoSize = true;
            this.incLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.incLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel9.Location = new System.Drawing.Point(7, 122);
            this.incLabel9.Name = "incLabel9";
            this.incLabel9.Readonly = false;
            this.incLabel9.Size = new System.Drawing.Size(67, 17);
            this.incLabel9.TabIndex = 75;
            this.incLabel9.Text = "Section : ";
            this.incLabel9.ValueByOrchestrator = "Section : ";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAuthor.Location = new System.Drawing.Point(68, 222);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Readonly = false;
            this.lblAuthor.Size = new System.Drawing.Size(8, 17);
            this.lblAuthor.TabIndex = 74;
            this.lblAuthor.Text = "\r\n";
            this.lblAuthor.ValueByOrchestrator = "\r\n";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblID.Location = new System.Drawing.Point(38, 22);
            this.lblID.Name = "lblID";
            this.lblID.Readonly = false;
            this.lblID.Size = new System.Drawing.Size(8, 17);
            this.lblID.TabIndex = 73;
            this.lblID.Text = "\r\n";
            this.lblID.ValueByOrchestrator = "\r\n";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblClass.Location = new System.Drawing.Point(53, 72);
            this.lblClass.Name = "lblClass";
            this.lblClass.Readonly = false;
            this.lblClass.Size = new System.Drawing.Size(8, 17);
            this.lblClass.TabIndex = 71;
            this.lblClass.Text = "\r\n";
            this.lblClass.ValueByOrchestrator = "\r\n";
            // 
            // lblBurrowedDate
            // 
            this.lblBurrowedDate.AutoSize = true;
            this.lblBurrowedDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.lblBurrowedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBurrowedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBurrowedDate.Location = new System.Drawing.Point(112, 272);
            this.lblBurrowedDate.Name = "lblBurrowedDate";
            this.lblBurrowedDate.Readonly = false;
            this.lblBurrowedDate.Size = new System.Drawing.Size(8, 17);
            this.lblBurrowedDate.TabIndex = 70;
            this.lblBurrowedDate.Text = "\r\n";
            this.lblBurrowedDate.ValueByOrchestrator = "\r\n";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBookTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBookTitle.Location = new System.Drawing.Point(81, 172);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Readonly = false;
            this.lblBookTitle.Size = new System.Drawing.Size(8, 17);
            this.lblBookTitle.TabIndex = 69;
            this.lblBookTitle.Text = "\r\n";
            this.lblBookTitle.ValueByOrchestrator = "\r\n";
            // 
            // incLabel4
            // 
            this.incLabel4.AutoSize = true;
            this.incLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.incLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel4.Location = new System.Drawing.Point(5, 22);
            this.incLabel4.Name = "incLabel4";
            this.incLabel4.Readonly = false;
            this.incLabel4.Size = new System.Drawing.Size(33, 17);
            this.incLabel4.TabIndex = 68;
            this.incLabel4.Text = "ID : ";
            this.incLabel4.ValueByOrchestrator = "ID : ";
            // 
            // incLabel8
            // 
            this.incLabel8.AutoSize = true;
            this.incLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.incLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel8.Location = new System.Drawing.Point(7, 222);
            this.incLabel8.Name = "incLabel8";
            this.incLabel8.Readonly = false;
            this.incLabel8.Size = new System.Drawing.Size(62, 17);
            this.incLabel8.TabIndex = 67;
            this.incLabel8.Text = "Author : ";
            this.incLabel8.ValueByOrchestrator = "Author : ";
            // 
            // incLabel7
            // 
            this.incLabel7.AutoSize = true;
            this.incLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.incLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel7.Location = new System.Drawing.Point(5, 172);
            this.incLabel7.Name = "incLabel7";
            this.incLabel7.Readonly = false;
            this.incLabel7.Size = new System.Drawing.Size(83, 17);
            this.incLabel7.TabIndex = 67;
            this.incLabel7.Text = "Book Title : ";
            this.incLabel7.ValueByOrchestrator = "Book Title : ";
            // 
            // incLabel6
            // 
            this.incLabel6.AutoSize = true;
            this.incLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.incLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel6.Location = new System.Drawing.Point(3, 272);
            this.incLabel6.Name = "incLabel6";
            this.incLabel6.Readonly = false;
            this.incLabel6.Size = new System.Drawing.Size(114, 17);
            this.incLabel6.TabIndex = 66;
            this.incLabel6.Text = "Burrowed Date : ";
            this.incLabel6.ValueByOrchestrator = "Burrowed Date : ";
            // 
            // lblSpecificInfoH
            // 
            this.lblSpecificInfoH.AutoSize = true;
            this.lblSpecificInfoH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.lblSpecificInfoH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSpecificInfoH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSpecificInfoH.Location = new System.Drawing.Point(5, 72);
            this.lblSpecificInfoH.Name = "lblSpecificInfoH";
            this.lblSpecificInfoH.Readonly = false;
            this.lblSpecificInfoH.Size = new System.Drawing.Size(54, 17);
            this.lblSpecificInfoH.TabIndex = 65;
            this.lblSpecificInfoH.Text = "Class : ";
            this.lblSpecificInfoH.ValueByOrchestrator = "Class : ";
            // 
            // pnlISBN
            // 
            this.pnlISBN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlISBN.Controls.Add(this.dgvFineDetail);
            this.pnlISBN.Location = new System.Drawing.Point(142, 94);
            this.pnlISBN.Name = "pnlISBN";
            this.pnlISBN.Size = new System.Drawing.Size(336, 442);
            this.pnlISBN.TabIndex = 75;
            // 
            // dgvFineDetail
            // 
            this.dgvFineDetail.AllowUserToAddRows = false;
            this.dgvFineDetail.AllowUserToDeleteRows = false;
            this.dgvFineDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvFineDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFineDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFineDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFineDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFineDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSNF,
            this.colISBNF,
            this.colStudentName,
            this.colDays,
            this.colFIneAmount,
            this.colStudentID,
            this.colBookTitleF,
            this.colAuthorF,
            this.colClassF,
            this.colSection,
            this.colBurrowedDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFineDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFineDetail.EnableHeadersVisualStyles = false;
            this.dgvFineDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvFineDetail.Location = new System.Drawing.Point(-1, -1);
            this.dgvFineDetail.Name = "dgvFineDetail";
            this.dgvFineDetail.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFineDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFineDetail.RowHeadersVisible = false;
            this.dgvFineDetail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvFineDetail.Size = new System.Drawing.Size(331, 441);
            this.dgvFineDetail.TabIndex = 58;
            // 
            // colSNF
            // 
            this.colSNF.HeaderText = "SN";
            this.colSNF.Name = "colSNF";
            this.colSNF.ReadOnly = true;
            this.colSNF.Width = 50;
            // 
            // colISBNF
            // 
            this.colISBNF.HeaderText = "ISBN";
            this.colISBNF.Name = "colISBNF";
            this.colISBNF.ReadOnly = true;
            this.colISBNF.Visible = false;
            // 
            // colStudentName
            // 
            this.colStudentName.HeaderText = "Student Name";
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.ReadOnly = true;
            this.colStudentName.Width = 170;
            // 
            // colDays
            // 
            this.colDays.HeaderText = "Days";
            this.colDays.Name = "colDays";
            this.colDays.ReadOnly = true;
            this.colDays.Width = 50;
            // 
            // colFIneAmount
            // 
            this.colFIneAmount.HeaderText = "Fine";
            this.colFIneAmount.Name = "colFIneAmount";
            this.colFIneAmount.ReadOnly = true;
            this.colFIneAmount.Width = 60;
            // 
            // colStudentID
            // 
            this.colStudentID.HeaderText = "StudentID";
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.ReadOnly = true;
            this.colStudentID.Visible = false;
            // 
            // colBookTitleF
            // 
            this.colBookTitleF.HeaderText = "Book Title";
            this.colBookTitleF.Name = "colBookTitleF";
            this.colBookTitleF.ReadOnly = true;
            this.colBookTitleF.Visible = false;
            // 
            // colAuthorF
            // 
            this.colAuthorF.HeaderText = "Author";
            this.colAuthorF.Name = "colAuthorF";
            this.colAuthorF.ReadOnly = true;
            this.colAuthorF.Visible = false;
            // 
            // colClassF
            // 
            this.colClassF.HeaderText = "Class";
            this.colClassF.Name = "colClassF";
            this.colClassF.ReadOnly = true;
            this.colClassF.Visible = false;
            // 
            // colSection
            // 
            this.colSection.HeaderText = "Section";
            this.colSection.Name = "colSection";
            this.colSection.ReadOnly = true;
            this.colSection.Visible = false;
            // 
            // colBurrowedDate
            // 
            this.colBurrowedDate.HeaderText = "BurrowedDate";
            this.colBurrowedDate.Name = "colBurrowedDate";
            this.colBurrowedDate.ReadOnly = true;
            this.colBurrowedDate.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Red;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblName.Location = new System.Drawing.Point(577, 75);
            this.lblName.Name = "lblName";
            this.lblName.Readonly = false;
            this.lblName.Size = new System.Drawing.Size(57, 17);
            this.lblName.TabIndex = 74;
            this.lblName.Text = "Name : ";
            this.lblName.ValueByOrchestrator = "Name : ";
            // 
            // frmFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(870, 603);
            this.ControlBox = false;
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.incLabel2);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlISBN);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlClose.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlISBN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFineDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlClose;
        private ButtonZ _CloseButton;
        private IncLibrary.IncButton btnPay;
        private System.Windows.Forms.TextBox txtStudentName;
        private IncLibrary.IncLabel incLabel2;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Panel panel2;
        private IncLibrary.IncLabel lblISBN;
        private IncLibrary.IncLabel incLabel10;
        private IncLibrary.IncLabel lblSection;
        private IncLibrary.IncLabel incLabel9;
        private IncLibrary.IncLabel lblAuthor;
        private IncLibrary.IncLabel lblID;
        private IncLibrary.IncLabel lblClass;
        private IncLibrary.IncLabel lblBurrowedDate;
        private IncLibrary.IncLabel lblBookTitle;
        private IncLibrary.IncLabel incLabel4;
        private IncLibrary.IncLabel incLabel8;
        private IncLibrary.IncLabel incLabel7;
        private IncLibrary.IncLabel incLabel6;
        private IncLibrary.IncLabel lblSpecificInfoH;
        private System.Windows.Forms.Panel pnlISBN;
        private System.Windows.Forms.DataGridView dgvFineDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSNF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBNF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFIneAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookTitleF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBurrowedDate;
        private IncLibrary.IncLabel lblName;
    }
}

