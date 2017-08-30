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
    public partial class frmAddDepartment : Form
    {
        public frmAddDepartment ()
        {
            InitializeComponent();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BALHelper balHelper=new BALHelper();
        private void btnGet_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            //reinitalizing data grid to avoid adding blank line in grid view
            dgvList.Rows.Clear();
            dgvList.DataSource = null;
            DataTable dt = new DataTable();
            dt = balHelper.GetAllDepartment();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvList.Rows.Add();
                dgvList.Rows[i].Cells["colDepartmentID"].Value = dt.Rows[i]["DepartmentID"].ToString();
                dgvList.Rows[i].Cells["colDepartmentName"].Value = dt.Rows[i]["DepartmentName"].ToString();
            }
        }

        private void btnUpadate_Click(object sender, EventArgs e)
        {
            DialogResult checkSure = MessageBox.Show("Are you sure you want to update","Are you Sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (checkSure!=DialogResult.OK)
            {
                return;
            }
            else if(ValidateField()||txtID.Text == string.Empty)
            {
                MessageBox.Show("Error while updating Department", "Adding Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (balHelper.UpdateDepartment(txtDepartmentName.Text,Program.userName,Convert.ToInt32(txtID.Text)))
            {
                MessageBox.Show("Dapartment Name updated successfully", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                LoadGrid();
                return;
            }
            else
            {
                MessageBox.Show("Dapartment Name update failed", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearControls();
            }

        }
        private bool ValidateField()
        {
            if (txtDepartmentName.Text==string.Empty)
            {
                txtDepartmentName.Focus();
                erpGeneral.SetError(txtDepartmentName, "Please Provide Name");
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateField()||txtID.Text!=string.Empty)
            {
                MessageBox.Show("Error while adding Department", "Adding Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (balHelper.AddDepartment(txtDepartmentName.Text, Program.userName))
            {
                MessageBox.Show("Dapartment Name added successfully", "Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Dapartment Name adding failure", "Adding Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearControls();
            }
        }

        private void dgvList_Click(object sender, EventArgs e)
        {
            if (dgvList==null||dgvList.Rows.Count==0)
            {
                return;
            }
            txtDepartmentName.Text = dgvList.CurrentRow.Cells["colDepartmentName"].Value.ToString();
            txtID.Text = dgvList.CurrentRow.Cells["colDepartmentID"].Value.ToString();
        }
        private void ClearControls()
        {
            erpGeneral.Clear();
            txtDepartmentName.Text = string.Empty;
            txtID.Text = string.Empty;
            dgvList.Rows.Clear();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
