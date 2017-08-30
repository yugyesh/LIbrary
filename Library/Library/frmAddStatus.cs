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
    public partial class frmAddStatus : Form
    {
        public frmAddStatus()
        {
            InitializeComponent();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        BALBook balBook = new BALBook();
        BALMember balMember = new BALMember();
        private void LoadGrid()
        {
            dgvList.Rows.Clear();
            dgvList.DataSource = null;
            DataTable dt = new DataTable();
            if (radBookStatus.Checked==true)
            {
                dt = balBook.GetBookStatus();
                dgvList.Columns["colMemberStatus"].Visible = false;
                dgvList.Columns["colBookStatus"].Visible = true;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvList.Rows.Add();
                    dgvList.Rows[i].Cells["colBookStatusID"].Value = dt.Rows[i]["BStatusID"].ToString();
                    dgvList.Rows[i].Cells["colBookStatus"].Value = dt.Rows[i]["BStatusName"].ToString();
                }
            }
            else
            {
                dt = balMember.GetMemberStatus();
                dgvList.Columns["colBookStatus"].Visible = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvList.Rows.Add();
                    dgvList.Rows[i].Cells["colMemberStatusID"].Value = dt.Rows[i]["MStatusID"].ToString();
                    dgvList.Rows[i].Cells["colMemberStatus"].Value = dt.Rows[i]["MStatusName"].ToString();
                    dgvList.Columns["colMemberStatus"].Visible = true;
                }

            }
        }

        private void btnUpadate_Click(object sender, EventArgs e)
        {
            DialogResult checkSure = MessageBox.Show("Are you sure you want to update ?", "Are you Sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (checkSure != DialogResult.OK)
            {
                return;
            }
            else if (ValidateField() || txtID.Text == string.Empty)
            {
                MessageBox.Show("Error while updating Status", "Adding Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (radBookStatus.Checked == true && balBook.UpdateBStatus(txtStatusName.Text, Program.userName, Convert.ToInt32(txtID.Text)))
            {
                MessageBox.Show("Status Name updated successfully", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                LoadGrid();
                return;
            }
            else if (radMemberStatus.Checked == true && balMember.UpdateMStatus(txtStatusName.Text, Program.userName, Convert.ToInt32(txtID.Text)))
            {
                MessageBox.Show("Status Name updated successfully", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                LoadGrid();
                return;
            }
            else
            {
                MessageBox.Show("Class Name update failed", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearControls();
            }

        }
        private bool ValidateField()
        {
            if (txtStatusName.Text == string.Empty)
            {
                txtStatusName.Focus();
                erpGeneral.SetError(txtStatusName, "Please Provide Name");
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateField() || txtID.Text != string.Empty)
            {
                MessageBox.Show("Error while adding Status", "Adding Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radBookStatus.Checked==true && balBook.AddBStatus(txtStatusName.Text, Program.userName))
            {
                MessageBox.Show("Status added successfully", "Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radMemberStatus.Checked == true && balMember.AddMStatus(txtStatusName.Text, Program.userName))
            {
                MessageBox.Show("Status added successfully", "Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Class name adding failed", "Adding Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearControls();
            LoadGrid();
        }

        private void dgvList_Click(object sender, EventArgs e)
        {
            if (dgvList == null || dgvList.Rows.Count == 0)
            {
                return;
            }
            else if (radBookStatus.Checked==true)
            {
                txtStatusName.Text = dgvList.CurrentRow.Cells["colBookStatus"].Value.ToString();
                txtID.Text = dgvList.CurrentRow.Cells["colBookStatusID"].Value.ToString();
            }
            else
            {
                txtStatusName.Text = dgvList.CurrentRow.Cells["colMemberStatus"].Value.ToString();
                txtID.Text = dgvList.CurrentRow.Cells["colMemberStatusID"].Value.ToString();
            }

        }
        private void ClearControls()
        {
            erpGeneral.Clear();
            txtStatusName.Text = string.Empty;
            txtID.Text = string.Empty;
            dgvList.Rows.Clear();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void frmAddStatus_Load(object sender, EventArgs e)
        {
            radBookStatus.Checked = true;
            LoadGrid();
        }

        private void radBookStatus_CheckedChanged(object sender, EventArgs e)
        {
            dgvList.Rows.Clear();
        }
    }
}
