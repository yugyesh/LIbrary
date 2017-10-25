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
    public partial class frmUserInfo : Form
    {
        public frmUserInfo ()
        {
            InitializeComponent();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BALMember balMember = new BALMember();
        BALUser balUser = new BALUser();
        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            DataTable dt = new DataTable();
            dt = balUser.GetAllUser();
            PopulateGrid(dt);
        }

        private void PopulateGrid(DataTable dt)
        {
            dgvUserInfo.Rows.Clear();
            DataTable dtStatus = new DataTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvUserInfo.Rows.Add();
                dgvUserInfo.Rows[i].Cells["colUserName"].Value = dt.Rows[i]["UserName"].ToString();
                dgvUserInfo.Rows[i].Cells["colPassword"].Value = dt.Rows[i]["Password"].ToString();
                dgvUserInfo.Rows[i].Cells["colUserID"].Value = dt.Rows[i]["UserID"].ToString();
                dgvUserInfo.Rows[i].Cells["colPersonalDetailID"].Value = dt.Rows[i]["PersonalDetailsID"].ToString();
                dgvUserInfo.Rows[i].Cells["colUsertype"].Value = dt.Rows[i]["RoleName"].ToString();
                dtStatus = balMember.GetMemberStatus(dt.Rows[i]["PersonalDetailsID"].ToString());
                dgvUserInfo.Rows[i].Cells["colStatus"].Value = dtStatus.Rows[0]["MStatusName"].ToString();
            }
        }

        private void LoadCombobox()
        {
            DataTable dt = new DataTable();
            DataTable dtnew = new DataTable();
            dt = balMember.GetMemberStatus();
            DataRow dr = dt.NewRow();
            dr["MStatusName"] = "--Please Select--";
            dr["MStatusID"] = 0;
            dt.Rows.InsertAt(dr, 0);
            cboStatus.DisplayMember = "MstatusName";
            cboStatus.ValueMember = "MStatusID";
            cboStatus.DataSource = dt;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = balUser.GetAllUserFilter(txtUserName.Text);
            PopulateGrid(dt);
        }

        private void dgvUserInfo_Click(object sender, EventArgs e)
        {
            txtUserName.Text = dgvUserInfo.CurrentRow.Cells["colUserName"].Value.ToString();
            txtUserId.Text = dgvUserInfo.CurrentRow.Cells["colPersonalDetailID"].Value.ToString();
        }

        private void btnUpdateStaus_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure to update status", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (result == DialogResult.OK && ValidateControls())
            {
                if (balUser.UpdateUserStatus(txtUserId.Text,Convert.ToInt32(cboStatus.SelectedValue.ToString())))
                {
                    MessageBox.Show("Updated successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ClearControls();
                }
            }
        }
        private bool ValidateControls()
        {
            if (txtUserName.Text.Trim() == string.Empty)
            {
                txtUserName.Focus();
                erpGeneral.SetError(txtUserName, "Please select UserName");
                return false;
            }
            else if (txtUserId.Text.Trim()==string.Empty)
            {
                MessageBox.Show("User Not selected");
                return false;
            }
            else if (cboStatus.SelectedIndex.ToString()=="0")
            {
                cboStatus.Focus();
                erpGeneral.SetError(cboStatus, "Please provide new status");
                return false;
            }
            else
            {
                return true;       
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
