using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmMain : BlackForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMember addMemberForm = new frmAddMember();
            addMemberForm.MdiParent = this;
            addMemberForm.Show();
        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddBooks addBooksForm = new frmAddBooks();
            addBooksForm.MdiParent = this;
            addBooksForm.Show();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookIssue bookIssueForm = new frmBookIssue();
            bookIssueForm.MdiParent = this;
            bookIssueForm.Show();
        }

        private void toolLogout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Logout", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (check==DialogResult.OK)
            {
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Close();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (statRoleID.Text!="1")
            {
                toolAddBooks.Enabled = false;
                toolAddMember.Enabled = false;
                masterToolStripMenuItem.Enabled = false;
            }
        }

        private void toolAddMember_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            frmAddMember addMemberForm = new frmAddMember();
            if (activeChild == null)
            {
                addMemberForm.Show();
                addMemberForm.MdiParent = this;
            }
            else
            {
                addMemberForm.Show();
                addMemberForm.MdiParent = this;
                activeChild.Close();
            }
        }

        private void toolAddBooks_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            frmAddBooks bookAddForm = new frmAddBooks();
            if (activeChild == null)
            {
                bookAddForm.Show();
                bookAddForm.MdiParent = this;
            }
            else
            {
                activeChild.Close();
                bookAddForm.Show();
                bookAddForm.MdiParent = this;
            }
        }

        private void toolBookIssue_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            frmBookIssue bookIssueForm = new frmBookIssue();
            if (activeChild == null)
            {
                bookIssueForm.Show();
                bookIssueForm.MdiParent = this;
            }
            else
            {
                activeChild.Close();
                bookIssueForm.Show();
                bookIssueForm.MdiParent = this;
            }
            bookIssueForm.lblIssueorReturn.Checked = true;
        }

        private void toolBookReturn_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            frmBookIssue bookIssueForm = new frmBookIssue();
            if (activeChild == null)
            {
                bookIssueForm.Show();
                bookIssueForm.MdiParent = this;
            }
            else
            {
                activeChild.Close();
                bookIssueForm.Show();
                bookIssueForm.MdiParent = this;
            }
            bookIssueForm.lblIssueorReturn.Checked = false;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword changePasswordForm = new frmChangePassword();
            changePasswordForm.ShowDialog();
            changePasswordForm.MdiParent = this;
        }

        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddClass addClassForm = new frmAddClass();
            addClassForm.ShowDialog();
            addClassForm.MdiParent = this;
        }

        private void addStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStatus addStatusForm = new frmAddStatus();
            addStatusForm.ShowDialog();
            addStatusForm.MdiParent = this;
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddDepartment addDepartmentForm = new frmAddDepartment();
            addDepartmentForm.ShowDialog();
            addDepartmentForm.MdiParent = this;
        }

        private void addTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddTag addTag = new frmAddTag();
            addTag.ShowDialog();
            addTag.MdiParent = this;
        }
    }
}
