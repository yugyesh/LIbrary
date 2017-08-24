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
    public partial class frmBookIssue : Form
    {
        public frmBookIssue ()
        {
            InitializeComponent();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int length = 0;
        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            if (txtISBN.Text.Length==13)
            {
                dgvISBNList.Rows.Add();
                dgvISBNList.Rows[length].Cells["colISBN"].Value = txtISBN.Text;
                length = length + 1;
                txtISBN.Text = string.Empty;
                return;
                //length = dgvISBNList.Rows.Count;
            }
            else
            {
                return;
            }
        }

        private void chkBurrower_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBurrower.Checked==true)
            {
                lblBurrowerName.Text = "Student Name";
                lblBurrowerID.Text = "Student ID";
                lblBurrowerCbo.Text = "Class";
                lblBurrowerNameImg.Text = "Student Name";
                dgvStudentInfo.Columns["colDepartment"].Visible = false;
                dgvStudentInfo.Columns["colClass"].Visible = true;
            }
            else
            {
                lblBurrowerName.Text = "Teacher Name";
                lblBurrowerID.Text = "Teacher ID";
                lblBurrowerCbo.Text = "Department";
                lblBurrowerNameImg.Text = "Teacher Name";
                dgvStudentInfo.Columns["colClass"].Visible = false;
                dgvStudentInfo.Columns["colDepartment"].Visible = true;

            }
        }
    }
}
