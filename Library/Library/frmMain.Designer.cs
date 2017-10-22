namespace Library
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripZ1 = new Library.MenuStripZ();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAddMember = new System.Windows.Forms.ToolStripButton();
            this.toolAddBooks = new System.Windows.Forms.ToolStripButton();
            this.toolBookIssue = new System.Windows.Forms.ToolStripButton();
            this.toolBookReturn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolLogout = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statRoleID = new System.Windows.Forms.ToolStripStatusLabel();
            this.statDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlFine = new System.Windows.Forms.Panel();
            this.incLabel1 = new IncLibrary.IncLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPay = new IncLibrary.IncButton();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.lblBurrowedDate = new IncLibrary.IncLabel();
            this.lblISBN = new IncLibrary.IncLabel();
            this.incLabel10 = new IncLibrary.IncLabel();
            this.lblSection = new IncLibrary.IncLabel();
            this.incLabel9 = new IncLibrary.IncLabel();
            this.lblAuthor = new IncLibrary.IncLabel();
            this.lblID = new IncLibrary.IncLabel();
            this.lblClass = new IncLibrary.IncLabel();
            this.lblBookTitle = new IncLibrary.IncLabel();
            this.incLabel4 = new IncLibrary.IncLabel();
            this.incLabel8 = new IncLibrary.IncLabel();
            this.incLabel7 = new IncLibrary.IncLabel();
            this.incLabel6 = new IncLibrary.IncLabel();
            this.lblSpecificInfoH = new IncLibrary.IncLabel();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblName = new IncLibrary.IncLabel();
            this.incLabel2 = new IncLibrary.IncLabel();
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
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripZ1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlFine.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlISBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFineDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripZ1
            // 
            this.menuStripZ1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStripZ1.Location = new System.Drawing.Point(0, 36);
            this.menuStripZ1.Name = "menuStripZ1";
            this.menuStripZ1.Size = new System.Drawing.Size(1361, 24);
            this.menuStripZ1.TabIndex = 5;
            this.menuStripZ1.Text = "menuStripZ1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMemberToolStripMenuItem,
            this.addBooksToolStripMenuItem,
            this.addDepartmentToolStripMenuItem,
            this.addClassToolStripMenuItem,
            this.addStatusToolStripMenuItem});
            this.masterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // addMemberToolStripMenuItem
            // 
            this.addMemberToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addMemberToolStripMenuItem.Name = "addMemberToolStripMenuItem";
            this.addMemberToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addMemberToolStripMenuItem.Text = "Add Member";
            this.addMemberToolStripMenuItem.Click += new System.EventHandler(this.addMemberToolStripMenuItem_Click);
            // 
            // addBooksToolStripMenuItem
            // 
            this.addBooksToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addBooksToolStripMenuItem.Name = "addBooksToolStripMenuItem";
            this.addBooksToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addBooksToolStripMenuItem.Text = "Add Books";
            this.addBooksToolStripMenuItem.Click += new System.EventHandler(this.addBooksToolStripMenuItem_Click);
            // 
            // addDepartmentToolStripMenuItem
            // 
            this.addDepartmentToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            this.addDepartmentToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addDepartmentToolStripMenuItem.Text = "Add Department";
            this.addDepartmentToolStripMenuItem.Click += new System.EventHandler(this.addDepartmentToolStripMenuItem_Click);
            // 
            // addClassToolStripMenuItem
            // 
            this.addClassToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addClassToolStripMenuItem.Name = "addClassToolStripMenuItem";
            this.addClassToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addClassToolStripMenuItem.Text = "Add Class";
            this.addClassToolStripMenuItem.Click += new System.EventHandler(this.addClassToolStripMenuItem_Click);
            // 
            // addStatusToolStripMenuItem
            // 
            this.addStatusToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addStatusToolStripMenuItem.Name = "addStatusToolStripMenuItem";
            this.addStatusToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addStatusToolStripMenuItem.Text = "Add Status";
            this.addStatusToolStripMenuItem.Click += new System.EventHandler(this.addStatusToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.importToolStripMenuItem});
            this.bookToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.issueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.issueToolStripMenuItem.Text = "Issue";
            this.issueToolStripMenuItem.Click += new System.EventHandler(this.toolBookIssue_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.toolBookReturn_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.memberToolStripMenuItem});
            this.searchToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.memberToolStripMenuItem.Text = "Member";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.userToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.toolLogout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddMember,
            this.toolAddBooks,
            this.toolBookIssue,
            this.toolBookReturn,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolLogout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1361, 62);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolAddMember
            // 
            this.toolAddMember.Image = ((System.Drawing.Image)(resources.GetObject("toolAddMember.Image")));
            this.toolAddMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddMember.Name = "toolAddMember";
            this.toolAddMember.Size = new System.Drawing.Size(81, 59);
            this.toolAddMember.Text = "Add Member";
            this.toolAddMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolAddMember.Click += new System.EventHandler(this.toolAddMember_Click);
            // 
            // toolAddBooks
            // 
            this.toolAddBooks.Image = ((System.Drawing.Image)(resources.GetObject("toolAddBooks.Image")));
            this.toolAddBooks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddBooks.Name = "toolAddBooks";
            this.toolAddBooks.Size = new System.Drawing.Size(68, 59);
            this.toolAddBooks.Text = "Add Books";
            this.toolAddBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolAddBooks.Click += new System.EventHandler(this.toolAddBooks_Click);
            // 
            // toolBookIssue
            // 
            this.toolBookIssue.Image = ((System.Drawing.Image)(resources.GetObject("toolBookIssue.Image")));
            this.toolBookIssue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBookIssue.Name = "toolBookIssue";
            this.toolBookIssue.Size = new System.Drawing.Size(67, 59);
            this.toolBookIssue.Text = "Book Issue";
            this.toolBookIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBookIssue.Click += new System.EventHandler(this.toolBookIssue_Click);
            // 
            // toolBookReturn
            // 
            this.toolBookReturn.Image = ((System.Drawing.Image)(resources.GetObject("toolBookReturn.Image")));
            this.toolBookReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBookReturn.Name = "toolBookReturn";
            this.toolBookReturn.Size = new System.Drawing.Size(76, 59);
            this.toolBookReturn.Text = "Book Return";
            this.toolBookReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBookReturn.Click += new System.EventHandler(this.toolBookReturn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(81, 59);
            this.toolStripButton1.Text = "Search Books";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(94, 59);
            this.toolStripButton2.Text = "Search Member";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolLogout
            // 
            this.toolLogout.Image = ((System.Drawing.Image)(resources.GetObject("toolLogout.Image")));
            this.toolLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLogout.Name = "toolLogout";
            this.toolLogout.Size = new System.Drawing.Size(46, 59);
            this.toolLogout.Text = "logout";
            this.toolLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolLogout.Click += new System.EventHandler(this.toolLogout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statUserName,
            this.statRoleID,
            this.statDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 705);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1361, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statUserName
            // 
            this.statUserName.ForeColor = System.Drawing.Color.White;
            this.statUserName.Name = "statUserName";
            this.statUserName.Size = new System.Drawing.Size(62, 17);
            this.statUserName.Text = "UserName";
            // 
            // statRoleID
            // 
            this.statRoleID.Name = "statRoleID";
            this.statRoleID.Size = new System.Drawing.Size(41, 17);
            this.statRoleID.Text = "RoleID";
            this.statRoleID.Visible = false;
            // 
            // statDate
            // 
            this.statDate.ForeColor = System.Drawing.Color.White;
            this.statDate.Name = "statDate";
            this.statDate.Size = new System.Drawing.Size(31, 17);
            this.statDate.Text = "Date";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlFine);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 122);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1361, 583);
            this.pnlMain.TabIndex = 87;
            // 
            // pnlFine
            // 
            this.pnlFine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFine.Controls.Add(this.incLabel1);
            this.pnlFine.Controls.Add(this.panel2);
            this.pnlFine.Controls.Add(this.txtStudentName);
            this.pnlFine.Controls.Add(this.lblName);
            this.pnlFine.Controls.Add(this.incLabel2);
            this.pnlFine.Controls.Add(this.pnlISBN);
            this.pnlFine.Location = new System.Drawing.Point(942, 4);
            this.pnlFine.Name = "pnlFine";
            this.pnlFine.Size = new System.Drawing.Size(418, 435);
            this.pnlFine.TabIndex = 86;
            // 
            // incLabel1
            // 
            this.incLabel1.AutoSize = true;
            this.incLabel1.BackColor = System.Drawing.Color.Red;
            this.incLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic);
            this.incLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel1.Location = new System.Drawing.Point(192, 4);
            this.incLabel1.Name = "incLabel1";
            this.incLabel1.Readonly = false;
            this.incLabel1.Size = new System.Drawing.Size(59, 33);
            this.incLabel1.TabIndex = 77;
            this.incLabel1.Text = "Fine";
            this.incLabel1.ValueByOrchestrator = "Fine";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Controls.Add(this.txtFine);
            this.panel2.Controls.Add(this.lblBurrowedDate);
            this.panel2.Controls.Add(this.lblISBN);
            this.panel2.Controls.Add(this.incLabel10);
            this.panel2.Controls.Add(this.lblSection);
            this.panel2.Controls.Add(this.incLabel9);
            this.panel2.Controls.Add(this.lblAuthor);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.lblClass);
            this.panel2.Controls.Add(this.lblBookTitle);
            this.panel2.Controls.Add(this.incLabel4);
            this.panel2.Controls.Add(this.incLabel8);
            this.panel2.Controls.Add(this.incLabel7);
            this.panel2.Controls.Add(this.incLabel6);
            this.panel2.Controls.Add(this.lblSpecificInfoH);
            this.panel2.Location = new System.Drawing.Point(165, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 345);
            this.panel2.TabIndex = 74;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPay.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnPay.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPay.Location = new System.Drawing.Point(8, 311);
            this.btnPay.Name = "btnPay";
            this.btnPay.NextControl = null;
            this.btnPay.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnPay.PreviousControl = null;
            this.btnPay.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnPay.Size = new System.Drawing.Size(63, 30);
            this.btnPay.TabIndex = 83;
            this.btnPay.Text = "Pay";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtFine
            // 
            this.txtFine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFine.ForeColor = System.Drawing.Color.White;
            this.txtFine.Location = new System.Drawing.Point(79, 314);
            this.txtFine.MaxLength = 500;
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(91, 23);
            this.txtFine.TabIndex = 82;
            // 
            // lblBurrowedDate
            // 
            this.lblBurrowedDate.AutoSize = true;
            this.lblBurrowedDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblBurrowedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBurrowedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBurrowedDate.Location = new System.Drawing.Point(108, 227);
            this.lblBurrowedDate.Name = "lblBurrowedDate";
            this.lblBurrowedDate.Readonly = false;
            this.lblBurrowedDate.Size = new System.Drawing.Size(8, 17);
            this.lblBurrowedDate.TabIndex = 81;
            this.lblBurrowedDate.Text = "\r\n";
            this.lblBurrowedDate.ValueByOrchestrator = "\r\n";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblISBN.Location = new System.Drawing.Point(48, 271);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Readonly = false;
            this.lblISBN.Size = new System.Drawing.Size(8, 17);
            this.lblISBN.TabIndex = 80;
            this.lblISBN.Text = "\r\n";
            this.lblISBN.ValueByOrchestrator = "\r\n";
            // 
            // incLabel10
            // 
            this.incLabel10.AutoSize = true;
            this.incLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.incLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel10.Location = new System.Drawing.Point(2, 271);
            this.incLabel10.Name = "incLabel10";
            this.incLabel10.Readonly = false;
            this.incLabel10.Size = new System.Drawing.Size(51, 17);
            this.incLabel10.TabIndex = 79;
            this.incLabel10.Text = "ISBN : ";
            this.incLabel10.ValueByOrchestrator = "ISBN : ";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSection.Location = new System.Drawing.Point(61, 95);
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
            this.incLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.incLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel9.Location = new System.Drawing.Point(2, 95);
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
            this.lblAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAuthor.Location = new System.Drawing.Point(61, 183);
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
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblID.Location = new System.Drawing.Point(30, 7);
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
            this.lblClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblClass.Location = new System.Drawing.Point(56, 51);
            this.lblClass.Name = "lblClass";
            this.lblClass.Readonly = false;
            this.lblClass.Size = new System.Drawing.Size(8, 17);
            this.lblClass.TabIndex = 71;
            this.lblClass.Text = "\r\n";
            this.lblClass.ValueByOrchestrator = "\r\n";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBookTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBookTitle.Location = new System.Drawing.Point(81, 139);
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
            this.incLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.incLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel4.Location = new System.Drawing.Point(2, 7);
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
            this.incLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.incLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel8.Location = new System.Drawing.Point(2, 183);
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
            this.incLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.incLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel7.Location = new System.Drawing.Point(2, 139);
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
            this.incLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.incLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel6.Location = new System.Drawing.Point(2, 227);
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
            this.lblSpecificInfoH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblSpecificInfoH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSpecificInfoH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSpecificInfoH.Location = new System.Drawing.Point(2, 51);
            this.lblSpecificInfoH.Name = "lblSpecificInfoH";
            this.lblSpecificInfoH.Readonly = false;
            this.lblSpecificInfoH.Size = new System.Drawing.Size(54, 17);
            this.lblSpecificInfoH.TabIndex = 65;
            this.lblSpecificInfoH.Text = "Class : ";
            this.lblSpecificInfoH.ValueByOrchestrator = "Class : ";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtStudentName.ForeColor = System.Drawing.Color.White;
            this.txtStudentName.Location = new System.Drawing.Point(1, 61);
            this.txtStudentName.MaxLength = 500;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(163, 21);
            this.txtStudentName.TabIndex = 75;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblName.Location = new System.Drawing.Point(246, 64);
            this.lblName.Name = "lblName";
            this.lblName.Readonly = false;
            this.lblName.Size = new System.Drawing.Size(57, 17);
            this.lblName.TabIndex = 72;
            this.lblName.Text = "Name : ";
            this.lblName.ValueByOrchestrator = "Name : ";
            // 
            // incLabel2
            // 
            this.incLabel2.AutoSize = true;
            this.incLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel2.Location = new System.Drawing.Point(35, 43);
            this.incLabel2.Name = "incLabel2";
            this.incLabel2.Readonly = false;
            this.incLabel2.Size = new System.Drawing.Size(98, 17);
            this.incLabel2.TabIndex = 76;
            this.incLabel2.Text = "Student Name";
            this.incLabel2.ValueByOrchestrator = "Student Name";
            // 
            // pnlISBN
            // 
            this.pnlISBN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlISBN.Controls.Add(this.dgvFineDetail);
            this.pnlISBN.Location = new System.Drawing.Point(1, 85);
            this.pnlISBN.Name = "pnlISBN";
            this.pnlISBN.Size = new System.Drawing.Size(163, 347);
            this.pnlISBN.TabIndex = 73;
            // 
            // dgvFineDetail
            // 
            this.dgvFineDetail.AllowUserToAddRows = false;
            this.dgvFineDetail.AllowUserToDeleteRows = false;
            this.dgvFineDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvFineDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFineDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFineDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFineDetail.EnableHeadersVisualStyles = false;
            this.dgvFineDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvFineDetail.Location = new System.Drawing.Point(0, -3);
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
            this.dgvFineDetail.Size = new System.Drawing.Size(158, 346);
            this.dgvFineDetail.TabIndex = 58;
            this.dgvFineDetail.Click += new System.EventHandler(this.dgvFineDetail_Click);
            // 
            // colSNF
            // 
            this.colSNF.HeaderText = "SN";
            this.colSNF.Name = "colSNF";
            this.colSNF.ReadOnly = true;
            this.colSNF.Width = 30;
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
            this.colStudentName.Visible = false;
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
            this.colFIneAmount.Width = 80;
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
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 727);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStripZ1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripZ1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Controls.SetChildIndex(this.menuStripZ1, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.menuStripZ1.ResumeLayout(false);
            this.menuStripZ1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlFine.ResumeLayout(false);
            this.pnlFine.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlISBN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFineDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStripZ menuStripZ1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem addMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBooksToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton toolBookIssue;
        private System.Windows.Forms.ToolStripButton toolBookReturn;
        private System.Windows.Forms.ToolStripButton toolLogout;
        public System.Windows.Forms.ToolStripStatusLabel statUserName;
        public System.Windows.Forms.ToolStripStatusLabel statRoleID;
        public System.Windows.Forms.ToolStripStatusLabel statDate;
        private System.Windows.Forms.ToolStripButton toolAddMember;
        private System.Windows.Forms.ToolStripButton toolAddBooks;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStatusToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFine;
        private IncLibrary.IncLabel incLabel1;
        private System.Windows.Forms.Panel panel2;
        private IncLibrary.IncLabel lblSection;
        private IncLibrary.IncLabel incLabel9;
        private IncLibrary.IncLabel lblAuthor;
        private IncLibrary.IncLabel lblID;
        private IncLibrary.IncLabel lblClass;
        private IncLibrary.IncLabel lblBookTitle;
        private IncLibrary.IncLabel incLabel4;
        private IncLibrary.IncLabel incLabel8;
        private IncLibrary.IncLabel incLabel7;
        private IncLibrary.IncLabel incLabel6;
        private IncLibrary.IncLabel lblSpecificInfoH;
        private System.Windows.Forms.TextBox txtStudentName;
        private IncLibrary.IncLabel lblName;
        private IncLibrary.IncLabel incLabel2;
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
        private IncLibrary.IncLabel lblISBN;
        private IncLibrary.IncLabel incLabel10;
        private IncLibrary.IncLabel lblBurrowedDate;
        private IncLibrary.IncButton btnPay;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
    }
}