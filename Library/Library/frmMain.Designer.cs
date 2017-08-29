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
            this.menuStripZ1 = new Library.MenuStripZ();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripZ1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.menuStripZ1.Size = new System.Drawing.Size(1034, 24);
            this.menuStripZ1.TabIndex = 5;
            this.menuStripZ1.Text = "menuStripZ1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMemberToolStripMenuItem,
            this.addBooksToolStripMenuItem});
            this.masterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // addMemberToolStripMenuItem
            // 
            this.addMemberToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addMemberToolStripMenuItem.Name = "addMemberToolStripMenuItem";
            this.addMemberToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addMemberToolStripMenuItem.Text = "Add Member";
            this.addMemberToolStripMenuItem.Click += new System.EventHandler(this.addMemberToolStripMenuItem_Click);
            // 
            // addBooksToolStripMenuItem
            // 
            this.addBooksToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addBooksToolStripMenuItem.Name = "addBooksToolStripMenuItem";
            this.addBooksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addBooksToolStripMenuItem.Text = "Add Books";
            this.addBooksToolStripMenuItem.Click += new System.EventHandler(this.addBooksToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueToolStripMenuItem,
            this.returnToolStripMenuItem});
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
            this.toolStrip1.Size = new System.Drawing.Size(1034, 62);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1034, 22);
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
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.memberToolStripMenuItem.Text = "Member";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 548);
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
            this.menuStripZ1.ResumeLayout(false);
            this.menuStripZ1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
    }
}