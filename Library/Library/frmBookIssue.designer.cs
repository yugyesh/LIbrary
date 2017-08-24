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
            this.lblBurrowerName = new IncLibrary.IncLabel();
            this.btnNew = new IncLibrary.IncButton();
            this.txtBookCopies = new System.Windows.Forms.TextBox();
            this.dgvStudentInfo = new System.Windows.Forms.DataGridView();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.lblBurrowerID = new IncLibrary.IncLabel();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.txtBookIDSearch = new System.Windows.Forms.TextBox();
            this.lblBurrowerCbo = new IncLibrary.IncLabel();
            this.incLabel3 = new IncLibrary.IncLabel();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.pnlStudentInfo = new System.Windows.Forms.Panel();
            this.chkBurrower = new System.Windows.Forms.CheckBox();
            this.pnlISBN = new System.Windows.Forms.Panel();
            this.picMember = new System.Windows.Forms.PictureBox();
            this.lblBurrowerNameImg = new IncLibrary.IncLabel();
            this.incButton1 = new IncLibrary.IncButton();
            this.dgvISBNList = new System.Windows.Forms.DataGridView();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this._CloseButton = new Library.ButtonZ();
            this.colBurrowerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBurrowerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeparmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookIssued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).BeginInit();
            this.pnlBook.SuspendLayout();
            this.pnlStudentInfo.SuspendLayout();
            this.pnlISBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvISBNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
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
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNew.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnNew.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnNew.Location = new System.Drawing.Point(1012, 522);
            this.btnNew.Name = "btnNew";
            this.btnNew.NextControl = null;
            this.btnNew.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnNew.PreviousControl = null;
            this.btnNew.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnNew.Size = new System.Drawing.Size(92, 42);
            this.btnNew.TabIndex = 46;
            this.btnNew.Text = "New";
            // 
            // txtBookCopies
            // 
            this.txtBookCopies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtBookCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookCopies.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBookCopies.Location = new System.Drawing.Point(28, 29);
            this.txtBookCopies.MaxLength = 500;
            this.txtBookCopies.Name = "txtBookCopies";
            this.txtBookCopies.Size = new System.Drawing.Size(131, 23);
            this.txtBookCopies.TabIndex = 43;
            // 
            // dgvStudentInfo
            // 
            this.dgvStudentInfo.AllowUserToAddRows = false;
            this.dgvStudentInfo.AllowUserToDeleteRows = false;
            this.dgvStudentInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvStudentInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBurrowerID,
            this.colBurrowerName,
            this.colClass,
            this.colDepartment,
            this.colDeparmentID,
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
            this.dgvStudentInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudentInfo.EnableHeadersVisualStyles = false;
            this.dgvStudentInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvStudentInfo.Location = new System.Drawing.Point(2, -2);
            this.dgvStudentInfo.Name = "dgvStudentInfo";
            this.dgvStudentInfo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudentInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvStudentInfo.Size = new System.Drawing.Size(557, 456);
            this.dgvStudentInfo.TabIndex = 49;
            // 
            // pnlBook
            // 
            this.pnlBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pnlBook.Controls.Add(this.cboDepartment);
            this.pnlBook.Controls.Add(this.lblBurrowerID);
            this.pnlBook.Controls.Add(this.cboClass);
            this.pnlBook.Controls.Add(this.txtBookIDSearch);
            this.pnlBook.Controls.Add(this.lblBurrowerCbo);
            this.pnlBook.Controls.Add(this.lblBurrowerName);
            this.pnlBook.Controls.Add(this.txtBookCopies);
            this.pnlBook.Location = new System.Drawing.Point(12, 75);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(566, 59);
            this.pnlBook.TabIndex = 50;
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
            // 
            // txtBookIDSearch
            // 
            this.txtBookIDSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtBookIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBookIDSearch.ForeColor = System.Drawing.Color.White;
            this.txtBookIDSearch.Location = new System.Drawing.Point(383, 29);
            this.txtBookIDSearch.MaxLength = 500;
            this.txtBookIDSearch.Name = "txtBookIDSearch";
            this.txtBookIDSearch.Size = new System.Drawing.Size(131, 23);
            this.txtBookIDSearch.TabIndex = 26;
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
            this.pnlStudentInfo.Controls.Add(this.dgvStudentInfo);
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
            // incButton1
            // 
            this.incButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.incButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incButton1.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.incButton1.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.incButton1.Location = new System.Drawing.Point(1192, 522);
            this.incButton1.Name = "incButton1";
            this.incButton1.NextControl = null;
            this.incButton1.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.incButton1.PreviousControl = null;
            this.incButton1.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.incButton1.Size = new System.Drawing.Size(92, 42);
            this.incButton1.TabIndex = 46;
            this.incButton1.Text = "New";
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
            // 
            // colISBN
            // 
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            this.colISBN.Width = 172;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(395, 422);
            this.dataGridView1.TabIndex = 57;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 172;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(927, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 432);
            this.panel1.TabIndex = 58;
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
            // colDeparmentID
            // 
            this.colDeparmentID.HeaderText = "Department ID";
            this.colDeparmentID.Name = "colDeparmentID";
            this.colDeparmentID.ReadOnly = true;
            this.colDeparmentID.Visible = false;
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
            // frmBookIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1361, 609);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBurrowerNameImg);
            this.Controls.Add(this.picMember);
            this.Controls.Add(this.pnlISBN);
            this.Controls.Add(this.chkBurrower);
            this.Controls.Add(this.pnlStudentInfo);
            this.Controls.Add(this.pnlBook);
            this.Controls.Add(this.incLabel3);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.incButton1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pnlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookIssue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).EndInit();
            this.pnlBook.ResumeLayout(false);
            this.pnlBook.PerformLayout();
            this.pnlStudentInfo.ResumeLayout(false);
            this.pnlISBN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvISBNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonZ _CloseButton;
        private System.Windows.Forms.Panel pnlClose;
        private IncLibrary.IncLabel lblBurrowerName;
        private IncLibrary.IncButton btnNew;
        private System.Windows.Forms.TextBox txtBookCopies;
        private System.Windows.Forms.DataGridView dgvStudentInfo;
        private System.Windows.Forms.Panel pnlBook;
        private IncLibrary.IncLabel lblBurrowerID;
        private IncLibrary.IncLabel incLabel3;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.TextBox txtBookIDSearch;
        private IncLibrary.IncLabel lblBurrowerCbo;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Panel pnlStudentInfo;
        private System.Windows.Forms.CheckBox chkBurrower;
        private System.Windows.Forms.Panel pnlISBN;
        private System.Windows.Forms.PictureBox picMember;
        private IncLibrary.IncLabel lblBurrowerNameImg;
        private IncLibrary.IncButton incButton1;
        private System.Windows.Forms.DataGridView dgvISBNList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBurrowerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBurrowerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeparmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookIssued;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFine;
    }
}

