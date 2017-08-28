namespace Library
{
    partial class frmBookIssue
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlClose = new System.Windows.Forms.Panel();
            this._CloseButton = new Library.ButtonZ();
            this.lblBurrowerName = new IncLibrary.IncLabel();
            this.btnReturn = new IncLibrary.IncButton();
            this.txtBurrowerName = new System.Windows.Forms.TextBox();
            this.dgvBurrowerInfo = new System.Windows.Forms.DataGridView();
            this.colBurrowerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBurrowerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookIssued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblBurrowerID = new IncLibrary.IncLabel();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.txtBurrowerID = new System.Windows.Forms.TextBox();
            this.lblBurrowerCbo = new IncLibrary.IncLabel();
            this.incLabel3 = new IncLibrary.IncLabel();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.pnlStudentInfo = new System.Windows.Forms.Panel();
            this.chkBurrower = new System.Windows.Forms.CheckBox();
            this.pnlISBN = new System.Windows.Forms.Panel();
            this.dgvISBNList = new System.Windows.Forms.DataGridView();
            this.colSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picMember = new System.Windows.Forms.PictureBox();
            this.lblBurrowerNameImg = new IncLibrary.IncLabel();
            this.btnIssue = new IncLibrary.IncButton();
            this.dgvInfoGeneral = new System.Windows.Forms.DataGridView();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBurrowedBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBurrowedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWhichInfo = new IncLibrary.IncLabel();
            this.btnClear = new IncLibrary.IncButton();
            this.lblRemoveBook = new IncLibrary.IncLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.erpGeneral = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblIssueorReturn = new System.Windows.Forms.CheckBox();
            this.pnlClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBurrowerInfo)).BeginInit();
            this.pnlBook.SuspendLayout();
            this.pnlStudentInfo.SuspendLayout();
            this.pnlISBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvISBNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoGeneral)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClose
            // 
            this.pnlClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlClose.Controls.Add(this._CloseButton);
            this.pnlClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClose.Location = new System.Drawing.Point(0, 0);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(1361, 26);
            this.pnlClose.TabIndex = 2;
            // 
            // _CloseButton
            // 
            this._CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._CloseButton.DisplayText = "X";
            this._CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CloseButton.ForeColor = System.Drawing.Color.White;
            this._CloseButton.Location = new System.Drawing.Point(1331, 0);
            this._CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this._CloseButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this._CloseButton.Name = "_CloseButton";
            this._CloseButton.Size = new System.Drawing.Size(22, 21);
            this._CloseButton.TabIndex = 1;
            this._CloseButton.Text = "X";
            this._CloseButton.TextLocation_X = 6;
            this._CloseButton.TextLocation_Y = 1;
            this._CloseButton.UseVisualStyleBackColor = true;
            this._CloseButton.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // lblBurrowerName
            // 
            this.lblBurrowerName.AutoSize = true;
            this.lblBurrowerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblBurrowerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBurrowerName.Location = new System.Drawing.Point(44, 7);
            this.lblBurrowerName.Name = "lblBurrowerName";
            this.lblBurrowerName.Readonly = false;
            this.lblBurrowerName.Size = new System.Drawing.Size(98, 17);
            this.lblBurrowerName.TabIndex = 45;
            this.lblBurrowerName.Text = "Student Name";
            this.lblBurrowerName.ValueByOrchestrator = "Student Name";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReturn.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnReturn.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnReturn.Location = new System.Drawing.Point(1083, 513);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.NextControl = null;
            this.btnReturn.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnReturn.PreviousControl = null;
            this.btnReturn.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnReturn.Size = new System.Drawing.Size(92, 42);
            this.btnReturn.TabIndex = 46;
            this.btnReturn.Text = "Return";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtBurrowerName
            // 
            this.txtBurrowerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtBurrowerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBurrowerName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBurrowerName.Location = new System.Drawing.Point(28, 29);
            this.txtBurrowerName.MaxLength = 500;
            this.txtBurrowerName.Name = "txtBurrowerName";
            this.txtBurrowerName.Size = new System.Drawing.Size(131, 23);
            this.txtBurrowerName.TabIndex = 43;
            this.txtBurrowerName.TextChanged += new System.EventHandler(this.txtBookIDSearch_TextChanged);
            // 
            // dgvBurrowerInfo
            // 
            this.dgvBurrowerInfo.AllowUserToAddRows = false;
            this.dgvBurrowerInfo.AllowUserToDeleteRows = false;
            this.dgvBurrowerInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvBurrowerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBurrowerInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBurrowerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBurrowerInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBurrowerID,
            this.colBurrowerName,
            this.colClass,
            this.colDepartment,
            this.colDepartmentID,
            this.colBookIssued,
            this.colClassID,
            this.colFine});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBurrowerInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBurrowerInfo.EnableHeadersVisualStyles = false;
            this.dgvBurrowerInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvBurrowerInfo.Location = new System.Drawing.Point(2, -2);
            this.dgvBurrowerInfo.Name = "dgvBurrowerInfo";
            this.dgvBurrowerInfo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBurrowerInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBurrowerInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBurrowerInfo.Size = new System.Drawing.Size(557, 456);
            this.dgvBurrowerInfo.TabIndex = 49;
            this.dgvBurrowerInfo.Click += new System.EventHandler(this.dgvBurrowerInfo_Click);
            // 
            // colBurrowerID
            // 
            this.colBurrowerID.HeaderText = "Burrower ID";
            this.colBurrowerID.Name = "colBurrowerID";
            this.colBurrowerID.ReadOnly = true;
            this.colBurrowerID.Width = 110;
            // 
            // colBurrowerName
            // 
            this.colBurrowerName.HeaderText = "Name";
            this.colBurrowerName.Name = "colBurrowerName";
            this.colBurrowerName.ReadOnly = true;
            this.colBurrowerName.Width = 140;
            // 
            // colClass
            // 
            this.colClass.HeaderText = "Class";
            this.colClass.Name = "colClass";
            this.colClass.ReadOnly = true;
            this.colClass.Visible = false;
            // 
            // colDepartment
            // 
            this.colDepartment.HeaderText = "Deparment";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.ReadOnly = true;
            this.colDepartment.Visible = false;
            // 
            // colDepartmentID
            // 
            this.colDepartmentID.HeaderText = "Department ID";
            this.colDepartmentID.Name = "colDepartmentID";
            this.colDepartmentID.ReadOnly = true;
            this.colDepartmentID.Visible = false;
            // 
            // colBookIssued
            // 
            this.colBookIssued.HeaderText = "BookIssued";
            this.colBookIssued.Name = "colBookIssued";
            this.colBookIssued.ReadOnly = true;
            // 
            // colClassID
            // 
            this.colClassID.HeaderText = "Class ID";
            this.colClassID.Name = "colClassID";
            this.colClassID.ReadOnly = true;
            this.colClassID.Visible = false;
            // 
            // colFine
            // 
            this.colFine.HeaderText = "Fine";
            this.colFine.Name = "colFine";
            this.colFine.ReadOnly = true;
            this.colFine.Width = 80;
            // 
            // pnlBook
            // 
            this.pnlBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pnlBook.Controls.Add(this.cboDepartment);
            this.pnlBook.Controls.Add(this.lblBurrowerID);
            this.pnlBook.Controls.Add(this.cboClass);
            this.pnlBook.Controls.Add(this.txtBurrowerID);
            this.pnlBook.Controls.Add(this.lblBurrowerCbo);
            this.pnlBook.Controls.Add(this.lblBurrowerName);
            this.pnlBook.Controls.Add(this.txtBurrowerName);
            this.pnlBook.Location = new System.Drawing.Point(12, 75);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(566, 59);
            this.pnlBook.TabIndex = 50;
            // 
            // cboDepartment
            // 
            this.cboDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cboDepartment.ForeColor = System.Drawing.SystemColors.Window;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(211, 28);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(148, 24);
            this.cboDepartment.TabIndex = 59;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.txtBookIDSearch_TextChanged);
            // 
            // lblBurrowerID
            // 
            this.lblBurrowerID.AutoSize = true;
            this.lblBurrowerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblBurrowerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBurrowerID.Location = new System.Drawing.Point(411, 7);
            this.lblBurrowerID.Name = "lblBurrowerID";
            this.lblBurrowerID.Readonly = false;
            this.lblBurrowerID.Size = new System.Drawing.Size(74, 17);
            this.lblBurrowerID.TabIndex = 27;
            this.lblBurrowerID.Text = "Student ID";
            this.lblBurrowerID.ValueByOrchestrator = "Student ID";
            // 
            // cboClass
            // 
            this.cboClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cboClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cboClass.ForeColor = System.Drawing.SystemColors.Window;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(211, 28);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(148, 24);
            this.cboClass.TabIndex = 1;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.txtBookIDSearch_TextChanged);
            // 
            // txtBurrowerID
            // 
            this.txtBurrowerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtBurrowerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBurrowerID.ForeColor = System.Drawing.Color.White;
            this.txtBurrowerID.Location = new System.Drawing.Point(383, 29);
            this.txtBurrowerID.MaxLength = 500;
            this.txtBurrowerID.Name = "txtBurrowerID";
            this.txtBurrowerID.Size = new System.Drawing.Size(131, 23);
            this.txtBurrowerID.TabIndex = 26;
            this.txtBurrowerID.TextChanged += new System.EventHandler(this.txtBookIDSearch_TextChanged);
            // 
            // lblBurrowerCbo
            // 
            this.lblBurrowerCbo.AutoSize = true;
            this.lblBurrowerCbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblBurrowerCbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBurrowerCbo.Location = new System.Drawing.Point(258, 7);
            this.lblBurrowerCbo.Name = "lblBurrowerCbo";
            this.lblBurrowerCbo.Readonly = false;
            this.lblBurrowerCbo.Size = new System.Drawing.Size(42, 17);
            this.lblBurrowerCbo.TabIndex = 25;
            this.lblBurrowerCbo.Text = "Class";
            this.lblBurrowerCbo.ValueByOrchestrator = "Class";
            // 
            // incLabel3
            // 
            this.incLabel3.AutoSize = true;
            this.incLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.incLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel3.Location = new System.Drawing.Point(587, 254);
            this.incLabel3.Name = "incLabel3";
            this.incLabel3.Readonly = false;
            this.incLabel3.Size = new System.Drawing.Size(48, 16);
            this.incLabel3.TabIndex = 23;
            this.incLabel3.Text = "I.S.B.N";
            this.incLabel3.ValueByOrchestrator = "I.S.B.N";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtISBN.ForeColor = System.Drawing.SystemColors.Window;
            this.txtISBN.Location = new System.Drawing.Point(638, 249);
            this.txtISBN.MaxLength = 13;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(216, 24);
            this.txtISBN.TabIndex = 0;
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged);
            // 
            // pnlStudentInfo
            // 
            this.pnlStudentInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStudentInfo.Controls.Add(this.dgvBurrowerInfo);
            this.pnlStudentInfo.Location = new System.Drawing.Point(13, 135);
            this.pnlStudentInfo.Name = "pnlStudentInfo";
            this.pnlStudentInfo.Size = new System.Drawing.Size(566, 460);
            this.pnlStudentInfo.TabIndex = 51;
            // 
            // chkBurrower
            // 
            this.chkBurrower.AutoSize = true;
            this.chkBurrower.BackColor = System.Drawing.Color.Red;
            this.chkBurrower.Checked = true;
            this.chkBurrower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBurrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBurrower.ForeColor = System.Drawing.Color.White;
            this.chkBurrower.Location = new System.Drawing.Point(12, 47);
            this.chkBurrower.Name = "chkBurrower";
            this.chkBurrower.Size = new System.Drawing.Size(92, 22);
            this.chkBurrower.TabIndex = 52;
            this.chkBurrower.Text = "Is Student";
            this.chkBurrower.UseVisualStyleBackColor = true;
            this.chkBurrower.CheckedChanged += new System.EventHandler(this.chkBurrower_CheckedChanged);
            // 
            // pnlISBN
            // 
            this.pnlISBN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlISBN.Controls.Add(this.dgvISBNList);
            this.pnlISBN.Location = new System.Drawing.Point(638, 274);
            this.pnlISBN.Name = "pnlISBN";
            this.pnlISBN.Size = new System.Drawing.Size(216, 317);
            this.pnlISBN.TabIndex = 53;
            // 
            // dgvISBNList
            // 
            this.dgvISBNList.AllowUserToDeleteRows = false;
            this.dgvISBNList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvISBNList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvISBNList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvISBNList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvISBNList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSN,
            this.colISBN});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvISBNList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvISBNList.EnableHeadersVisualStyles = false;
            this.dgvISBNList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvISBNList.Location = new System.Drawing.Point(-1, -1);
            this.dgvISBNList.Name = "dgvISBNList";
            this.dgvISBNList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvISBNList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvISBNList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvISBNList.Size = new System.Drawing.Size(216, 312);
            this.dgvISBNList.TabIndex = 56;
            this.dgvISBNList.Click += new System.EventHandler(this.dgvISBNList_Click);
            // 
            // colSN
            // 
            this.colSN.HeaderText = "SN";
            this.colSN.Name = "colSN";
            this.colSN.ReadOnly = true;
            this.colSN.Width = 30;
            // 
            // colISBN
            // 
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            this.colISBN.Width = 172;
            // 
            // picMember
            // 
            this.picMember.Location = new System.Drawing.Point(669, 75);
            this.picMember.Name = "picMember";
            this.picMember.Size = new System.Drawing.Size(131, 126);
            this.picMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMember.TabIndex = 54;
            this.picMember.TabStop = false;
            // 
            // lblBurrowerNameImg
            // 
            this.lblBurrowerNameImg.AutoSize = true;
            this.lblBurrowerNameImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblBurrowerNameImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBurrowerNameImg.Location = new System.Drawing.Point(685, 204);
            this.lblBurrowerNameImg.Name = "lblBurrowerNameImg";
            this.lblBurrowerNameImg.Readonly = false;
            this.lblBurrowerNameImg.Size = new System.Drawing.Size(98, 17);
            this.lblBurrowerNameImg.TabIndex = 55;
            this.lblBurrowerNameImg.Text = "Student Name";
            this.lblBurrowerNameImg.ValueByOrchestrator = "Student Name";
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIssue.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnIssue.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnIssue.Location = new System.Drawing.Point(1237, 513);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.NextControl = null;
            this.btnIssue.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnIssue.PreviousControl = null;
            this.btnIssue.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnIssue.Size = new System.Drawing.Size(92, 42);
            this.btnIssue.TabIndex = 46;
            this.btnIssue.Text = "Issue";
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // dgvInfoGeneral
            // 
            this.dgvInfoGeneral.AllowUserToDeleteRows = false;
            this.dgvInfoGeneral.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvInfoGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfoGeneral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInfoGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubject,
            this.colInfo,
            this.dataGridViewTextBoxColumn1,
            this.colBurrowedBook,
            this.colBurrowedDate});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInfoGeneral.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInfoGeneral.EnableHeadersVisualStyles = false;
            this.dgvInfoGeneral.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvInfoGeneral.Location = new System.Drawing.Point(3, 3);
            this.dgvInfoGeneral.Name = "dgvInfoGeneral";
            this.dgvInfoGeneral.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfoGeneral.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInfoGeneral.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvInfoGeneral.Size = new System.Drawing.Size(395, 422);
            this.dgvInfoGeneral.TabIndex = 57;
            // 
            // colSubject
            // 
            this.colSubject.HeaderText = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.ReadOnly = true;
            // 
            // colInfo
            // 
            this.colInfo.HeaderText = "Info";
            this.colInfo.Name = "colInfo";
            this.colInfo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // colBurrowedBook
            // 
            this.colBurrowedBook.HeaderText = "Book Name";
            this.colBurrowedBook.Name = "colBurrowedBook";
            this.colBurrowedBook.ReadOnly = true;
            this.colBurrowedBook.Visible = false;
            // 
            // colBurrowedDate
            // 
            this.colBurrowedDate.HeaderText = "Burrowed Date";
            this.colBurrowedDate.Name = "colBurrowedDate";
            this.colBurrowedDate.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvInfoGeneral);
            this.panel1.Location = new System.Drawing.Point(927, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 432);
            this.panel1.TabIndex = 58;
            // 
            // lblWhichInfo
            // 
            this.lblWhichInfo.AutoSize = true;
            this.lblWhichInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblWhichInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblWhichInfo.Location = new System.Drawing.Point(966, 55);
            this.lblWhichInfo.Name = "lblWhichInfo";
            this.lblWhichInfo.Readonly = false;
            this.lblWhichInfo.Size = new System.Drawing.Size(31, 17);
            this.lblWhichInfo.TabIndex = 58;
            this.lblWhichInfo.Text = "Info";
            this.lblWhichInfo.ValueByOrchestrator = "Info";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnClear.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClear.Location = new System.Drawing.Point(929, 513);
            this.btnClear.Name = "btnClear";
            this.btnClear.NextControl = null;
            this.btnClear.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnClear.PreviousControl = null;
            this.btnClear.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnClear.Size = new System.Drawing.Size(92, 42);
            this.btnClear.TabIndex = 58;
            this.btnClear.Text = "Clear";
            // 
            // lblRemoveBook
            // 
            this.lblRemoveBook.BackColor = System.Drawing.Color.Red;
            this.lblRemoveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lblRemoveBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblRemoveBook.Location = new System.Drawing.Point(1, 1);
            this.lblRemoveBook.Name = "lblRemoveBook";
            this.lblRemoveBook.Readonly = false;
            this.lblRemoveBook.Size = new System.Drawing.Size(31, 42);
            this.lblRemoveBook.TabIndex = 59;
            this.lblRemoveBook.Text = "-";
            this.lblRemoveBook.ValueByOrchestrator = "-";
            this.lblRemoveBook.Click += new System.EventHandler(this.lblRemoveBook_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblRemoveBook);
            this.panel2.Location = new System.Drawing.Point(641, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(37, 45);
            this.panel2.TabIndex = 58;
            // 
            // erpGeneral
            // 
            this.erpGeneral.ContainerControl = this;
            // 
            // lblIssueorReturn
            // 
            this.lblIssueorReturn.AutoSize = true;
            this.lblIssueorReturn.BackColor = System.Drawing.Color.Red;
            this.lblIssueorReturn.Checked = true;
            this.lblIssueorReturn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lblIssueorReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueorReturn.ForeColor = System.Drawing.Color.White;
            this.lblIssueorReturn.Location = new System.Drawing.Point(669, 22);
            this.lblIssueorReturn.Name = "lblIssueorReturn";
            this.lblIssueorReturn.Size = new System.Drawing.Size(83, 30);
            this.lblIssueorReturn.TabIndex = 53;
            this.lblIssueorReturn.Text = "Issue";
            this.lblIssueorReturn.UseVisualStyleBackColor = true;
            // 
            // frmBookIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1361, 609);
            this.ControlBox = false;
            this.Controls.Add(this.lblIssueorReturn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblWhichInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBurrowerNameImg);
            this.Controls.Add(this.picMember);
            this.Controls.Add(this.pnlISBN);
            this.Controls.Add(this.chkBurrower);
            this.Controls.Add(this.pnlStudentInfo);
            this.Controls.Add(this.pnlBook);
            this.Controls.Add(this.incLabel3);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pnlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookIssue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmBookIssue_Load);
            this.pnlClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBurrowerInfo)).EndInit();
            this.pnlBook.ResumeLayout(false);
            this.pnlBook.PerformLayout();
            this.pnlStudentInfo.ResumeLayout(false);
            this.pnlISBN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvISBNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoGeneral)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonZ _CloseButton;
        private System.Windows.Forms.Panel pnlClose;
        private IncLibrary.IncLabel lblBurrowerName;
        private IncLibrary.IncButton btnReturn;
        private System.Windows.Forms.TextBox txtBurrowerName;
        private System.Windows.Forms.DataGridView dgvBurrowerInfo;
        private System.Windows.Forms.Panel pnlBook;
        private IncLibrary.IncLabel lblBurrowerID;
        private IncLibrary.IncLabel incLabel3;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.TextBox txtBurrowerID;
        private IncLibrary.IncLabel lblBurrowerCbo;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Panel pnlStudentInfo;
        private System.Windows.Forms.CheckBox chkBurrower;
        private System.Windows.Forms.Panel pnlISBN;
        private System.Windows.Forms.PictureBox picMember;
        private IncLibrary.IncLabel lblBurrowerNameImg;
        private IncLibrary.IncButton btnIssue;
        private System.Windows.Forms.DataGridView dgvISBNList;
        private System.Windows.Forms.DataGridView dgvInfoGeneral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private IncLibrary.IncLabel lblWhichInfo;
        private IncLibrary.IncButton btnClear;
        private IncLibrary.IncLabel lblRemoveBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBurrowerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBurrowerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookIssued;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBurrowedBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBurrowedDate;
        private System.Windows.Forms.ErrorProvider erpGeneral;
        private System.Windows.Forms.CheckBox lblIssueorReturn;
    }
}

