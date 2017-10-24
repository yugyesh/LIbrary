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
                    dgvBurrowerInfo.Rows[i].Cells["colBookIssued"].Value = string.Empty;
                    dgvBurrowerInfo.Rows[i].Cells["colClassID"].Value = dt.Rows[i]["ClassID"].ToString();
                    //dgvBurrowerInfo.Rows[i].Cells["colBookIssued"].Value = dtCount.Rows.Count;
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
            if (lblIssueorReturn.Checked==true)
            {
                btnIssue.Enabled = true;
                btnReturn.Enabled = false;    
            }
            else
            {
                btnReturn.Enabled = true;
                btnIssue.Enabled = false;
            }
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
            if (dgvBurrowerInfo==null||dgvBurrowerInfo.Rows.Count<=0)
            {
                return;
            }
            string[] values = new string[]
            {
                dgvBurrowerInfo.CurrentRow.Cells["colBurrowerName"].Value.ToString(),
                dgvBurrowerInfo.CurrentRow.Cells["colBurrowerID"].Value.ToString(),
                dgvBurrowerInfo.CurrentRow.Cells["colClassID"].Value==null?"0":dgvBurrowerInfo.CurrentRow.Cells["colClassID"].Value.ToString(),
                dgvBurrowerInfo.CurrentRow.Cells["colDepartmentID"].Value==null?"0":dgvBurrowerInfo.CurrentRow.Cells["colDepartmentID"].Value.ToString(),
            };
            txtBurrowerName.Text = values[0];
            txtBurrowerID.Text = values[1];
            if (chkBurrower.Checked==true)
            {
                cboClass.SelectedValue = values[2];
            }
            else
            {
                cboDepartment.SelectedValue = values[3];
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

        private void dgvISBNList_Click(object sender, EventArgs e)
        {
            dgvInfoGeneral.Rows.Clear();
            if (dgvISBNList.CurrentRow.Cells["colISBN"].Value==null)
            {
                return;
            }
            DataTable dtBookInfo = new DataTable();
            dtBookInfo=balIssueReturn.GetBookInfo(dgvISBNList.CurrentRow.Cells["colISBN"].Value.ToString());
            //populating the Book detail in data grid general
            string[] subject = new string[] { "Book Title", "Author", "ClassName" };
            for (int i = 0; i < dtBookInfo.Columns.Count; i++)
            {
                dgvInfoGeneral.Rows.Add();
                dgvInfoGeneral.Rows[i].Cells["colSubject"].Value = subject[i];
                dgvInfoGeneral.Rows[i].Cells["colInfo"].Value = dtBookInfo.Rows[0][i].ToString();
            }
            lblWhichInfo.Text = "Book Details" + "      "+"ISBN"+" : "+dgvISBNList.CurrentRow.Cells["colISBN"].Value.ToString();
            //dgvInfoGeneral.Rows[0].Cells[]
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            DateTime burrowedDate = DateTime.Today;
            DateTime dueDate = burrowedDate.AddDays(10);
            string[] burrowrInfo = new string[]
            {
                txtBurrowerID.Text,
                //provider id
                //"unknown",
                burrowedDate.ToString(),
                dueDate.ToString(),
                chkBurrower.Checked==true?"1":"0",
                "1",
                chkBurrower.Checked==true?"1":"2",
            };
            for (int i = 0; i < dgvISBNList.Rows.Count-1; i++)
            {
                balIssueReturn.IssueBook(dgvISBNList.Rows[i].Cells["colISBN"].Value.ToString(), burrowrInfo);
            }
            MessageBox.Show("Book issued successfully", "Issue SuccessFul", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearControls();
            ClearGrid();
            dgvISBNList.Rows.Clear();
            dgvISBNList.DataSource = null;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvISBNList.Rows.Count; i++)
            {
                balIssueReturn.ReturnBook(dgvISBNList.Rows[0].Cells["colISBN"].Value.ToString(),txtBurrowerID.Text);
            }
            MessageBox.Show("Books returned successfully", "Issue SuccessFul", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearControls();
            ClearGrid();
            dgvISBNList.Rows.Clear();
            dgvISBNList.DataSource = null;
        }

        private void _CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblIssueorReturn_CheckedChanged(object sender, EventArgs e)
        {
            if (lblIssueorReturn.Checked == true)
            {
                btnIssue.Enabled = true;
                btnReturn.Enabled = false;
            }
            else
            {
                btnReturn.Enabled = true;
                btnIssue.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
            ClearGrid();
            length = 0;
        }
        private void ClearGrid()
        {
            dgvInfoGeneral.Rows.Clear();
            dgvISBNList.Rows.Clear();
        }
        int length = 0;
        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

            //if (txtISBN.Text.Length == 13)
            //{
            //    if (txtISBN.Text.Length == 13)
            //    {
            //        if (!balIssueReturn.CheckBookAvailibity(txtISBN.Text))
            //        {
            //            MessageBox.Show("Book Not Registered", "Book Not Added Yet!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        //if book is already issued it cannot be issued agian until its returned
            //        else if (balIssueReturn.CheckBookIssued(txtISBN.Text))
            //        {
            //            MessageBox.Show("Book already issued", "Adding Terminated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        else if (CheckISBNDuplicate())
            //        {
            //            MessageBox.Show("Book Already Added To List");
            //        }
            //        else
            //        {
            //            dgvISBNList.Rows.Add();
            //            dgvISBNList.Rows[length].Cells["colISBN"].Value = txtISBN.Text;
            //            dgvISBNList.Rows[length].Cells["colSN"].Value = length + 1;
            //            //length = dgvISBNList.Rows.Count-1;
            //            length = length + 1;
            //        }
            //        txtISBN.Text = string.Empty;
            //        txtISBN.Focus();
            //    }
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
            {
                if (txtISBN.Text.Trim()==string.Empty)
                {
                    return;
                }
                else if (!balIssueReturn.CheckBookAvailibity(txtISBN.Text))
                {
                    MessageBox.Show("Book Not Registered", "Book Not Added Yet!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //if book is already issued it cannot be issued agian until its returned
                else if (lblIssueorReturn.Checked==true && balIssueReturn.CheckBookIssued(txtISBN.Text))
                {
                    MessageBox.Show("Book already issued", "Adding Terminated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (lblIssueorReturn.Checked == false && !balIssueReturn.CheckBookIssued(txtISBN.Text))
                {
                    MessageBox.Show("This book is not issued", "Adding Terminated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CheckISBNDuplicate())
                {
                    MessageBox.Show("Book Already Added To List");
                }
                //Test whether that user take that book or not
                else if (lblIssueorReturn.Checked==false && balIssueReturn.CheckUserIssued(txtISBN.Text,txtBurrowerID.Text))
                {
                    MessageBox.Show("Book not issued by this user", "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgvISBNList.Rows.Add();
                    dgvISBNList.Rows[length].Cells["colISBN"].Value = txtISBN.Text;
                    dgvISBNList.Rows[length].Cells["colSN"].Value = length + 1;
                    //length = dgvISBNList.Rows.Count-1;
                    length = length + 1;
                }
                txtISBN.Text = string.Empty;
                txtISBN.Focus();
        }
        private bool CheckISBNDuplicate()
        {
            if (dgvISBNList == null || dgvISBNList.Rows.Count == 1)
            {
                return false;
            }
            for (int i = 0; i < dgvISBNList.Rows.Count-1; i++)
            {
                if (txtISBN.Text == dgvISBNList.Rows[i].Cells["colISBN"].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private void lblRemoveBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvISBNList.CurrentRow.Cells["colISBN"].Value == null)
                {
                    return;
                }
                dgvISBNList.Rows.RemoveAt(dgvISBNList.CurrentRow.Index);
                txtISBN.Focus();
                length = length - 1;
            }
            catch (Exception)
            {

                return;
            }

            //dgvISBNList.CurrentRow.Cells["col"]
        }
    }
}
