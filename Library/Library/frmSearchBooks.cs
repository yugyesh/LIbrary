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
            dt = balBook.GetBookStatus();
            DataRow dr = dt.NewRow();
            dr["BStatusName"] = "--Please Select--";
            dr["BStatusID"] = 0;
            dt.Rows.InsertAt(dr, 0);
            cboStatus.DisplayMember = "BstatusName";
            cboStatus.ValueMember = "BStatusID";
            cboStatus.DataSource = dt;
            //DataTable dt = new DataTable();
            //dt = balFine.GetFineDetails(txtStudentName.Text);
            //if (dt!=null && dt.Rows.Count>0)
            //{
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        dgvFineDetail.Rows.Add();
            //        dgvFineDetail.Rows[i].Cells["colSNF"].Value = i;
            //        dgvFineDetail.Rows[i].Cells["colDays"].Value = dt.Rows[i]["DaysExceed"].ToString();
            //        dgvFineDetail.Rows[i].Cells["colFineAmount"].Value = Convert.ToInt32(dt.Rows[i]["DaysExceed"].ToString()) * 5;
            //        dgvFineDetail.Rows[i].Cells["colStudentID"].Value = dt.Rows[i]["BurrowerID"].ToString();
            //        dgvFineDetail.Rows[i].Cells["colSection"].Value = dt.Rows[i]["SectionName"].ToString();
            //        dgvFineDetail.Rows[i].Cells["colClassF"].Value = dt.Rows[i]["ClassName"].ToString();
            //        dgvFineDetail.Rows[i].Cells["colStudentName"].Value = dt.Rows[i]["StudentName"].ToString();
            //        dgvFineDetail.Rows[i].Cells["colBookTitleF"].Value = dt.Rows[i]["BookTitle"].ToString();
            //        dgvFineDetail.Rows[i].Cells["colAuthorF"].Value = dt.Rows[i]["Author"].ToString();
            //        dgvFineDetail.Rows[i].Cells["colBurrowedDate"].Value = dt.Rows[i]["BurrowedDate"].ToString();
            //        dgvFineDetail.Rows[i].Cells["colISBN"].Value = dt.Rows[i]["ISBN"].ToString();
            //    }
            //}
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtAllBooks = new DataTable();
            string[] filterString = new string[]
                        {
                            txtTitle.Text.Trim(),
                            txtAuthor.Text.Trim(),
                            cboStatus.SelectedValue.ToString(),
                        };
            dtAllBooks = balBook.SearchBooks(filterString);
            //dgvBurrowerInfo.DataSource = dtAllBooks;
            dgvBurrowerInfo.Rows.Clear();
            for (int i = 0; i < dtAllBooks.Rows.Count; i++)
            {
                dgvBurrowerInfo.Rows.Add();
                dgvBurrowerInfo.Rows[i].Cells["colSN"].Value = i;
                dgvBurrowerInfo.Rows[i].Cells["colISBN"].Value = dtAllBooks.Rows[i]["ISBN"].ToString();
                dgvBurrowerInfo.Rows[i].Cells["colBookDetailID"].Value = dtAllBooks.Rows[i]["BookDetailID"].ToString();
                dgvBurrowerInfo.Rows[i].Cells["colBookTitle"].Value = dtAllBooks.Rows[i]["Title"].ToString();
                dgvBurrowerInfo.Rows[i].Cells["colAuthor"].Value = dtAllBooks.Rows[i]["Author"].ToString();
                dgvBurrowerInfo.Rows[i].Cells["colBookStatusID"].Value = dtAllBooks.Rows[i]["BStatusID"].ToString();
                dgvBurrowerInfo.Rows[i].Cells["colStatusName"].Value = dtAllBooks.Rows[i]["BStatusName"].ToString();
                dgvBurrowerInfo.Rows[i].Cells["colPlace"].Value = dtAllBooks.Rows[i]["Place"].ToString();
                dgvBurrowerInfo.Rows[i].Cells["colPublisher"].Value = dtAllBooks.Rows[i]["Publisher"].ToString();
                dgvBurrowerInfo.Rows[i].Cells["colSource"].Value = dtAllBooks.Rows[i]["Source"].ToString();
                dgvBurrowerInfo.Rows[i].Cells["colPublishedYear"].Value = dtAllBooks.Rows[i]["PublishedYear"].ToString();
                dgvBurrowerInfo.Rows[i].Cells["colSubCategory"].Value = dtAllBooks.Rows[i]["SubCategory"].ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboStatus.SelectedIndex = 0;
            txtAuthor.Text = string.Empty;
            txtTitle.Text = string.Empty;
            dgvBurrowerInfo.Rows.Clear();
            dgvBurrowerInfo.DataSource = null;
        }


        ////private void dgvFineDetail_Click(object sender, EventArgs e)
        ////{
        ////    if (dgvFineDetail!=null&& dgvFineDetail.Rows.Count>0)
        ////    {
        ////        lblID.Text = dgvFineDetail.CurrentRow.Cells["colStudentID"].Value.ToString();
        ////        lblName.Text = dgvFineDetail.CurrentRow.Cells["colStudentName"].Value.ToString();
        ////        lblSection.Text = dgvFineDetail.CurrentRow.Cells["colSection"].Value.ToString();
        ////        lblBookTitle.Text = dgvFineDetail.CurrentRow.Cells["colBookTitleF"].Value.ToString();
        ////        lblAuthor.Text = dgvFineDetail.CurrentRow.Cells["colAuthorF"].Value.ToString();
        ////        lblClass.Text = dgvFineDetail.CurrentRow.Cells["colClassF"].Value.ToString();
        ////        lblISBN.Text = dgvFineDetail.CurrentRow.Cells["colISBN"].Value.ToString();
        ////        DateTime burrowedDate = Convert.ToDateTime(dgvFineDetail.CurrentRow.Cells["colBurrowedDate"].Value.ToString());
        ////        lblBurrowedDate.Text = burrowedDate.ToString("yyyy-mm-dd");
        ////    }
        ////}

        ////private void btnPay_Click(object sender, EventArgs e)
        ////{
        ////    if (Convert.ToInt32(dgvFineDetail.CurrentRow.Cells["colFineAmount"].Value.ToString()) == Convert.ToInt32(txtFine.Text))
        ////    {
        ////        if (balFine.AddFineAmount(Convert.ToInt32(txtFine.Text), lblID.Text, lblISBN.Text))
        ////        {
        ////            MessageBox.Show("Fine Paid", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ////        }
        ////    }
        ////}
    }
}
