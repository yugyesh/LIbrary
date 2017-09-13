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
    public partial class frmChangeRole : Form
    {
        public frmChangeRole()
        {
            InitializeComponent();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        BALUser balUser = new BALUser();
        private void frmChangeRole_Load(object sender, EventArgs e)
        {
            LoadCbo();
            LoadGrid();
        }

        private void LoadGrid()
        {
            dgvUser.Rows.Clear();
            dgvUser.DataSource = null;
            DataTable dt = new DataTable();
            dt = balUser.GetAllUser();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvUser.Rows.Add();
                dgvUser.Rows[i].Cells["colUserID"].Value = dt.Rows[i]["userid"].ToString();
                dgvUser.Rows[i].Cells["colUsername"].Value = dt.Rows[i]["UserName"].ToString();
                dgvUser.Rows[i].Cells["colRoleID"].Value = dt.Rows[i]["RoleID"].ToString();
            }
        }
        private void LoadGridFilter(object sender, EventArgs e)
        {
            dgvUser.Rows.Clear();
            dgvUser.DataSource = null;
            DataTable dt = new DataTable();
            dt = balUser.GetAllUserFilter(txtSearch.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvUser.Rows.Add();
                dgvUser.Rows[i].Cells["colUserID"].Value = dt.Rows[i]["userid"].ToString();
                dgvUser.Rows[i].Cells["colUsername"].Value = dt.Rows[i]["UserName"].ToString();
                dgvUser.Rows[i].Cells["colRoleID"].Value = dt.Rows[i]["RoleID"].ToString();
            }
        }

        private void LoadCbo()
        {
            DataTable dt = new DataTable();
            dt = balUser.GetUserType();
            DataRow dr = dt.NewRow();
            dr["RoleID"] = 0;
            dr["RoleName"] = "-- Please Select --";
            dt.Rows.InsertAt(dr,0);
            cboRole.DataSource = dt;
            cboRole.ValueMember = "RoleID";
            cboRole.DisplayMember = "RoleName";
        }

        private void dgvUser_Click(object sender, EventArgs e)
        {
            if (dgvUser==null||dgvUser.Rows.Count<=0)
            {
                return;
            }
            txtUserId.Text = dgvUser.CurrentRow.Cells["colUserID"].Value.ToString();
            txtUsername.Text = dgvUser.CurrentRow.Cells["colUserName"].Value.ToString();
            cboRole.SelectedValue = Convert.ToInt32(dgvUser.CurrentRow.Cells["colRoleID"].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to update", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res==DialogResult.OK && balUser.UpdateUser(txtUsername.Text,Convert.ToInt32(cboRole.SelectedValue),txtUserId.Text))
            {
                MessageBox.Show("Update Successful", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                LoadCbo();
            }
            else
            {
                MessageBox.Show("Update Operation Failure", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Delete User", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK && balUser.DeleteUser(txtUserId.Text))
            {
                MessageBox.Show("Deleted Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                LoadCbo();
            }
            else
            {
                MessageBox.Show("Deleted Operation Failure", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearControls()
        {
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

    }
}
