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
    public partial class frmFine : Form
    {
        public frmFine ()
        {
            InitializeComponent();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BALFine balFine = new BALFine();
        private void frmFine_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = balFine.GetFineDetails(txtStudentName.Text);
            if (dt != null && dt.Rows.Count > 0)
            {
                LoadGridFine(dt);
            }
        }
        private void LoadGridFine(DataTable dt)
        {
            dgvFineDetail.Columns["colDays"].DefaultCellStyle.BackColor = Color.Red;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["DaysExceed"].ToString() == null || dt.Rows[i]["DaysExceed"].ToString() == string.Empty || dt.Rows[i]["DaysExceed"].ToString() == "0")
                {
                    return;
                }
                dgvFineDetail.Rows.Add();
                dgvFineDetail.Rows[i].Cells["colSNF"].Value = i;
                dgvFineDetail.Rows[i].Cells["colDays"].Value = dt.Rows[i]["DaysExceed"].ToString();
                dgvFineDetail.Rows[i].Cells["colFineAmount"].Value = Convert.ToInt32(dt.Rows[i]["DaysExceed"].ToString()) * 5;
                dgvFineDetail.Rows[i].Cells["colStudentID"].Value = dt.Rows[i]["BurrowerID"].ToString();
                dgvFineDetail.Rows[i].Cells["colSection"].Value = dt.Rows[i]["SectionName"].ToString();
                dgvFineDetail.Rows[i].Cells["colClassF"].Value = dt.Rows[i]["ClassName"].ToString();
                dgvFineDetail.Rows[i].Cells["colStudentName"].Value = dt.Rows[i]["StudentName"].ToString();
                dgvFineDetail.Rows[i].Cells["colBookTitle"].Value = dt.Rows[i]["Title"].ToString();
                dgvFineDetail.Rows[i].Cells["colAuthorF"].Value = dt.Rows[i]["Author"].ToString();
                dgvFineDetail.Rows[i].Cells["colBurrowedDate"].Value = dt.Rows[i]["BurrowedDate"].ToString();
                dgvFineDetail.Rows[i].Cells["colISBNF"].Value = dt.Rows[i]["ISBN"].ToString();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtFine.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please provide fine Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Convert.ToInt32(dgvFineDetail.CurrentRow.Cells["colFineAmount"].Value.ToString()) == Convert.ToInt32(txtFine.Text.Trim()))
            {
                if (balFine.AddFineAmount(Convert.ToInt32(txtFine.Text), lblID.Text, lblISBN.Text))
                {
                    MessageBox.Show("Fine Paid", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please provide total fine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFineDetail_Click(object sender, EventArgs e)
        {
            if (dgvFineDetail != null && dgvFineDetail.Rows.Count > 0)
            {
                lblID.Text = dgvFineDetail.CurrentRow.Cells["colStudentID"].Value.ToString();
                lblName.Text = dgvFineDetail.CurrentRow.Cells["colStudentName"].Value.ToString();
                lblSection.Text = dgvFineDetail.CurrentRow.Cells["colSection"].Value.ToString();
                lblBookTitle.Text = dgvFineDetail.CurrentRow.Cells["colBookTitleF"].Value.ToString();
                lblAuthor.Text = dgvFineDetail.CurrentRow.Cells["colAuthorF"].Value.ToString();
                lblClass.Text = dgvFineDetail.CurrentRow.Cells["colClassF"].Value.ToString();
                lblISBN.Text = dgvFineDetail.CurrentRow.Cells["colISBNF"].Value.ToString();
                DateTime burrowedDate = Convert.ToDateTime(dgvFineDetail.CurrentRow.Cells["colBurrowedDate"].Value.ToString());
                lblBurrowedDate.Text = burrowedDate.ToString("yyyy-mm-dd");
            }
        }
    }
}
