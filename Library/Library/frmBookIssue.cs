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
                dgvISBNList.Rows[length].Cells["colSN"].Value = length+1;
                //length = dgvISBNList.Rows.Count-1;
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
            ClearControls();
            if (chkBurrower.Checked==true)
            {
                lblBurrowerName.Text = "Student Name";
                lblBurrowerID.Text = "Student ID";
                lblBurrowerCbo.Text = "Class";
                lblBurrowerNameImg.Text = "Student Name";
                dgvBurrowerInfo.Columns["colDepartment"].Visible = false;
                dgvBurrowerInfo.Columns["colClass"].Visible = true;
                cboDepartment.Visible = false;
                cboClass.Visible = true;
            }
            else
            {
                lblBurrowerName.Text = "Teacher Name";
                lblBurrowerID.Text = "Teacher ID";
                lblBurrowerCbo.Text = "Department";
                lblBurrowerNameImg.Text = "Teacher Name";
                dgvBurrowerInfo.Columns["colClass"].Visible = false;
                dgvBurrowerInfo.Columns["colDepartment"].Visible = true;
                cboClass.Visible = false;
                cboDepartment.Visible = true;
            }
        }

        private void lblRemoveBook_Click(object sender, EventArgs e)
        {
            dgvISBNList.Rows.RemoveAt(dgvISBNList.CurrentRow.Index);
            txtISBN.Focus();
            length = length - 1;
            //dgvISBNList.CurrentRow.Cells["col"]
        }
        BALBookIssueReturn balIssueReturn = new BALBookIssueReturn();
        private void txtBookIDSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dtCount = new DataTable();
            dgvBurrowerInfo.Rows.Clear();
            if (chkBurrower.Checked==true)
            {
                string className = cboClass.Text == "-- Please Select --" ? string.Empty : cboClass.Text;
                dt=balIssueReturn.GetStudentInfo(txtBurrowerID.Text, txtBurrowerName.Text, className);
                dtCount = balIssueReturn.CountIssuedBook();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvBurrowerInfo.Rows.Add();
                    dgvBurrowerInfo.Rows[i].Cells["colBurrowerName"].Value = dt.Rows[i]["Name"].ToString();
                    dgvBurrowerInfo.Rows[i].Cells["colBurrowerID"].Value = dt.Rows[i]["StudentID"].ToString();
                    dgvBurrowerInfo.Rows[i].Cells["colClass"].Value = dt.Rows[i]["ClassName"].ToString();
                    dgvBurrowerInfo.Rows[i].Cells["colClassID"].Value = dt.Rows[i]["ClassID"].ToString();
                    dgvBurrowerInfo.Rows[i].Cells["colBookIssued"].Value = dtCount.Rows.Count;
                    dgvBurrowerInfo.Rows[i].Cells["colClassID"].Value = dt.Rows[i]["ClassID"].ToString();
                    dgvBurrowerInfo.Columns["colClass"].Visible = true;
                }
            }
            else
            {
                string departmentName = cboDepartment.Text == "-- Please Select --" ? string.Empty : cboDepartment.Text;
                dt =balIssueReturn.GetTeacherInfo(txtBurrowerID.Text, txtBurrowerName.Text, departmentName);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvBurrowerInfo.Rows.Add();
                    dgvBurrowerInfo.Rows[i].Cells["colBurrowerName"].Value = dt.Rows[i]["Name"].ToString();
                    dgvBurrowerInfo.Rows[i].Cells["colBurrowerID"].Value = dt.Rows[i]["TeacherID"].ToString();
                    dgvBurrowerInfo.Rows[i].Cells["colDepartmentID"].Value = dt.Rows[i]["DepartmentID"].ToString();
                    dgvBurrowerInfo.Rows[i].Cells["colDepartment"].Value = dt.Rows[i]["DepartmentName"].ToString();
                }
            }
        }
        BALHelper balHelper = new BALHelper();
        private void frmBookIssue_Load(object sender, EventArgs e)
        {
            LoadCombo();
            cboDepartment.Visible = false;
        }

        private void LoadCombo()
        {
            DataTable dt = new DataTable();
            dt = balHelper.GetAllClass();
            DataRow drClass = dt.NewRow();
            drClass["ClassName"] = "-- Please Select --";
            drClass["ClassID"] = 0;
            dt.Rows.InsertAt(drClass, 0);
            cboClass.DataSource = dt;
            cboClass.DisplayMember = "ClassName";
            cboClass.ValueMember = "ClassID";
            //Loading Department
            DataTable dtDept = new DataTable();
            dtDept = balHelper.GetAllDepartment();
            DataRow drDept = dtDept.NewRow();
            drDept["DepartmentName"] = "-- Please Select --";
            drDept["DepartmentID"] = 0;
            dtDept.Rows.InsertAt(drDept, 0);
            cboDepartment.DataSource = dtDept;
            cboDepartment.DisplayMember = "DepartmentName";
            cboDepartment.ValueMember = "DepartmentID";
        }

        private void dgvBurrowerInfo_Click(object sender, EventArgs e)
        {
            txtBurrowerName.Text = dgvBurrowerInfo.CurrentRow.Cells["colBurrowerName"].Value.ToString();
            txtBurrowerID.Text = dgvBurrowerInfo.CurrentRow.Cells["colBurrowerID"].Value.ToString();
            if (chkBurrower.Checked==true)
            {
                cboClass.SelectedValue = dgvBurrowerInfo.CurrentRow.Cells["colClassID"].Value;
            }
            else
            {
                cboDepartment.SelectedValue = dgvBurrowerInfo.CurrentRow.Cells["colDepartmentID"].Value;
            }
        }
        private void ClearControls()
        {
            //erpGeneral.Clear();
            //dgvProduct.DataSource = null;
            //dgvFeatures.DataSource = null;
            //dgvFeatures.Rows.Clear();
            //dgvProduct.Rows.Clear();
            // dgvFeatures.ClearSelection();
            dgvBurrowerInfo.Rows.Clear();
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
