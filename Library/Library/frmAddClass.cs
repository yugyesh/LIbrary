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
    public partial class frmAddClass : Form
    {
        public frmAddClass()
        {
            InitializeComponent();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        BALHelper balHelper = new BALHelper();
        private void btnGet_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            dgvList.Rows.Clear();
            dgvList.DataSource = null;
            DataTable dt = new DataTable();
            dt = balHelper.GetAllClass();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvList.Rows.Add();
                dgvList.Rows[i].Cells["colClassID"].Value = dt.Rows[i]["ClassID"].ToString();
                dgvList.Rows[i].Cells["colClassName"].Value = dt.Rows[i]["ClassName"].ToString();
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
                MessageBox.Show("Error while updating Class", "Adding Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (balHelper.UpdateClass(txtClassName.Text, Program.userName, Convert.ToInt32(txtID.Text)))
            {
                MessageBox.Show("Class Name updated successfully", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtClassName.Text == string.Empty)
            {
                txtClassName.Focus();
                erpGeneral.SetError(txtClassName, "Please Provide Name");
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
                MessageBox.Show("Error while adding Class", "Adding Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (balHelper.AddClass(txtClassName.Text, Program.userName))
            {
                MessageBox.Show("Class Name added successfully", "Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtClassName.Text = dgvList.CurrentRow.Cells["colClassName"].Value.ToString();
            txtID.Text = dgvList.CurrentRow.Cells["colClassID"].Value.ToString();
        }
        private void ClearControls()
        {
            erpGeneral.Clear();
            txtClassName.Text = string.Empty;
            txtID.Text = string.Empty;
            dgvList.Rows.Clear();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

    }
}
