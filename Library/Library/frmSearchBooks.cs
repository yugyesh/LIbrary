using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
namespace Library
{
    public partial class frmSearchBooks : Form
    {
        public frmSearchBooks()
        {
            InitializeComponent();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        BALFine balFine = new BALFine();
        BALBook balBook = new BALBook();
        private void frmSearchBooks_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dtnew = new DataTable();
            dt = balBook.GetBookStatus();
            dtnew = balBook.GetBookStatus();
            DataRow dr = dt.NewRow();
            dr["BStatusName"] = "--Please Select--";
            dr["BStatusID"] = 0;
            dt.Rows.InsertAt(dr, 0);
            cboStatus.DisplayMember = "BstatusName";
            cboStatus.ValueMember = "BStatusID";
            cboStatus.DataSource = dt;
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStatus.Text.ToLower()=="burrowed")
            {
                pnlBurrowerInfo.Visible = true;
                pnlFindBookNumber.Visible = false;
            }
            else if (cboStatus.Text.ToLower()=="available")
            {
                pnlFindBookNumber.Visible = true;
                pnlBurrowerInfo.Visible = false;
            }
            else
            {
                pnlBurrowerInfo.Visible = false;
                pnlFindBookNumber.Visible = true;
            }
            DataTable dtAllBooks = new DataTable();
            string[] filterString = new string[]
                        {
                            txtTitle.Text.Trim(),
                            txtAuthor.Text.Trim(),
                            cboStatus.SelectedValue.ToString(),
                        };
            dtAllBooks = balBook.SearchBooks(filterString);
            dgvBookDetails.Rows.Clear();
            for (int i = 0; i < dtAllBooks.Rows.Count; i++)
            {
                dgvBookDetails.Rows.Add();
                dgvBookDetails.Rows[i].Cells["colSN"].Value = i;
                dgvBookDetails.Rows[i].Cells["colISBN"].Value = dtAllBooks.Rows[i]["ISBN"].ToString();
                dgvBookDetails.Rows[i].Cells["colBookDetailID"].Value = dtAllBooks.Rows[i]["BookDetailID"].ToString();
                dgvBookDetails.Rows[i].Cells["colBookTitle"].Value = dtAllBooks.Rows[i]["Title"].ToString();
                dgvBookDetails.Rows[i].Cells["colAuthor"].Value = dtAllBooks.Rows[i]["Author"].ToString();
                dgvBookDetails.Rows[i].Cells["colBookStatusID"].Value = dtAllBooks.Rows[i]["BStatusID"].ToString();
                dgvBookDetails.Rows[i].Cells["colStatusName"].Value = dtAllBooks.Rows[i]["BStatusName"].ToString();
                dgvBookDetails.Rows[i].Cells["colPlace"].Value = dtAllBooks.Rows[i]["Place"].ToString();
                dgvBookDetails.Rows[i].Cells["colPublisher"].Value = dtAllBooks.Rows[i]["Publisher"].ToString();
                dgvBookDetails.Rows[i].Cells["colSource"].Value = dtAllBooks.Rows[i]["Source"].ToString();
                dgvBookDetails.Rows[i].Cells["colPublishedYear"].Value = dtAllBooks.Rows[i]["PublishedYear"].ToString();
                dgvBookDetails.Rows[i].Cells["colSubCategory"].Value = dtAllBooks.Rows[i]["SubCategory"].ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void ClearControls()
        {
            dgvBookDetails.Rows.Clear();
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else if (control is ComboBox)
                    {
                        (control as ComboBox).SelectedIndex = 0;
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }

            };

            func(Controls);
        }
        BALBookIssueReturn balBookIssueReturn = new BALBookIssueReturn();
        private void dgvBookDetails_Click(object sender, EventArgs e)
        {
            //txtISBN.Text = dgvBookDetails.CurrentRow.Cells["colISBN"].Value.ToString();
            if (cboStatus.Text.ToLower() == "burrowed")
            {
                DataTable dt = new DataTable();
                DataTable dtName = new DataTable();
                dt = balBookIssueReturn.GetBurrowerDetails(dgvBookDetails.CurrentRow.Cells["colISBN"].Value.ToString());
                lblBurrowerID.Text = dt.Rows[0]["BurrowerID"].ToString();
                lblBurrowedDate.Text = dt.Rows[0]["BurrowedDate"].ToString();
                lblMemberType.Text = dt.Rows[0]["TypeName"].ToString();
                dtName = balBookIssueReturn.GetBurrowerName(lblBurrowerID.Text, Convert.ToInt32(dt.Rows[0]["BurrowerType"].ToString()));
                lblBName.Text = dtName.Rows[0]["BurrowerName"].ToString();
            }
            else if (cboStatus.Text.Trim().ToLower() == "available")
            {
                DataTable dt = new DataTable();
                string test;
                test = dgvBookDetails.CurrentRow.Cells["colBookDetailID"].Value.ToString();
                dt = balBook.GetBookCount(dgvBookDetails.CurrentRow.Cells["colBookDetailID"].Value.ToString());
                int availableBook = 0, burrowedBook = 0, lostBook = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["BStatusName"].ToString().ToLower() == "available")
                    {
                        availableBook += 1;
                    }
                    else if (dt.Rows[i]["BStatusName"].ToString().ToLower() == "burrowed")
                    {
                        burrowedBook += 1;
                    }
                    else
                    {
                        lostBook += 1;
                    }
                }
                lblAvailableNo.Text = availableBook.ToString();
                lblBurrowed.Text = burrowedBook.ToString();
                lblLost.Text = lostBook.ToString();
                lblTotalBooks.Text = dt.Rows.Count.ToString();
            }
            else
            {
                pnlBurrowerInfo.Visible = false;
                pnlFindBookNumber.Visible = false;
                return;
            }
        }

        //private void btnChangeStatus_Click(object sender, EventArgs e)
        //{
        //    DialogResult result;
        //    result = MessageBox.Show("Are you sure to change book status", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    if (result==DialogResult.OK)
        //    {
        //        bool check;
        //        check=balBook.ChangeBookStatus(txtISBN.Text, Convert.ToInt32(cboNewStatus.SelectedValue.ToString()));
        //        if (check==true)
        //        {
        //            MessageBox.Show("Status update successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //}
    }
}
