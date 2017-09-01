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
    public partial class frmAddTag : Form
    {
        public frmAddTag()
        {
            InitializeComponent();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        BALBook balBook = new BALBook();
        private void btnGet_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            DataTable dt = new DataTable();
            dt = balBook.GetBookTag();
            dgvList.Rows.Clear();
            dgvList.DataSource = null;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvList.Rows.Add();
                dgvList.Rows[i].Cells["colTagID"].Value = dt.Rows[i]["TagID"].ToString();
                dgvList.Rows[i].Cells["colTagName"].Value = dt.Rows[i]["TagName"].ToString();
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
                MessageBox.Show("Error while updating Tag", "Adding Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (balBook.UpdateTag(txtTagName.Text, Program.userName, Convert.ToInt32(txtID.Text)))
            {
                MessageBox.Show("Tag Name updated successfully", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtTagName.Text == string.Empty)
            {
                txtTagName.Focus();
                erpGeneral.SetError(txtTagName, "Please Provide Name");
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateField()||txtID.Text != string.Empty)
            {
                MessageBox.Show("Error while Adding Tag", "Adding Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (balBook.AddTag(txtTagName.Text, Program.userName))
            {
                MessageBox.Show("Tag Name added successfully", "Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Tag name adding failed", "Adding Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearControls();
            }
        }

        private void dgvList_Click(object sender, EventArgs e)
        {
            if (dgvList == null || dgvList.Rows.Count == 0)
            {
                return;
            }
            txtTagName.Text = dgvList.CurrentRow.Cells["colTagName"].Value.ToString();
            txtID.Text = dgvList.CurrentRow.Cells["colTagID"].Value.ToString();
        }
        private void ClearControls()
        {
            erpGeneral.Clear();
            txtTagName.Text = string.Empty;
            txtID.Text = string.Empty;
            dgvList.Rows.Clear();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

    }
}
