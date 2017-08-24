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
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBookIssue = new System.Windows.Forms.ToolStripButton();
            this.toolBookReturn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statUserID = new System.Windows.Forms.ToolStripStatusLabel();
            this.statDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStripZ1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripZ1
            // 
            this.menuStripZ1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.issueBookToolStripMenuItem});
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
            this.addMemberToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addMemberToolStripMenuItem.Text = "Add Member";
            this.addMemberToolStripMenuItem.Click += new System.EventHandler(this.addMemberToolStripMenuItem_Click);
            // 
            // addBooksToolStripMenuItem
            // 
            this.addBooksToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addBooksToolStripMenuItem.Name = "addBooksToolStripMenuItem";
            this.addBooksToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addBooksToolStripMenuItem.Text = "Add Books";
            this.addBooksToolStripMenuItem.Click += new System.EventHandler(this.addBooksToolStripMenuItem_Click);
            // 
            // issueBookToolStripMenuItem
            // 
            this.issueBookToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            this.issueBookToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.issueBookToolStripMenuItem.Text = "Issue Book";
            this.issueBookToolStripMenuItem.Click += new System.EventHandler(this.issueBookToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBookIssue,
            this.toolBookReturn,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1034, 72);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBookIssue
            // 
            this.toolBookIssue.Image = ((System.Drawing.Image)(resources.GetObject("toolBookIssue.Image")));
            this.toolBookIssue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBookIssue.Name = "toolBookIssue";
            this.toolBookIssue.Size = new System.Drawing.Size(67, 69);
            this.toolBookIssue.Text = "Book Issue";
            this.toolBookIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolBookReturn
            // 
            this.toolBookReturn.Image = ((System.Drawing.Image)(resources.GetObject("toolBookReturn.Image")));
            this.toolBookReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBookReturn.Name = "toolBookReturn";
            this.toolBookReturn.Size = new System.Drawing.Size(76, 69);
            this.toolBookReturn.Text = "Book Return";
            this.toolBookReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statUserName,
            this.statUserID,
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
            // statUserID
            // 
            this.statUserID.Name = "statUserID";
            this.statUserID.Size = new System.Drawing.Size(41, 17);
            this.statUserID.Text = "UserID";
            // 
            // statDate
            // 
            this.statDate.ForeColor = System.Drawing.Color.White;
            this.statDate.Name = "statDate";
            this.statDate.Size = new System.Drawing.Size(31, 17);
            this.statDate.Text = "Date";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(44, 69);
            this.toolStripButton1.Text = "toolStripButton1";
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
        private System.Windows.Forms.ToolStripStatusLabel statUserName;
        private System.Windows.Forms.ToolStripStatusLabel statUserID;
        private System.Windows.Forms.ToolStripStatusLabel statDate;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolBookIssue;
        private System.Windows.Forms.ToolStripButton toolBookReturn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}