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
using Common;
namespace Library
{
    public partial class frmAddMember : Form
    {
        public frmAddMember()
        {
            InitializeComponent();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BALMember balMember = new BALMember();
        BALHelper balHelper = new BALHelper();
        private void cboMemberType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboMemberType.SelectedValue.ToString()) == 1)
            {
                grpStudent.Visible = true;
                grpTeacher.Visible = false;
                grpUser.Visible = false;
                return;
            }
            else if (Convert.ToInt32(cboMemberType.SelectedValue.ToString()) == 2)
            {
                grpTeacher.Visible = true;
                grpStudent.Visible = false;
                grpUser.Visible = false;
                return;
            }
            else if (Convert.ToInt32(cboMemberType.SelectedValue.ToString()) == 3)
            {
                grpUser.Visible = true;
                grpTeacher.Visible = false;
                grpStudent.Visible = false;
                return;
            }
            else
            {
                return;
            }
        }

        private void frmAddMember_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            string defaultImage;
            //application. startuppath gives the path of the bin
            defaultImage = Application.StartupPath + "\\default.jpg";
            picMember.ImageLocation = defaultImage;
        }

        private void LoadComboBoxes()
        {
            DataTable dtClass = new DataTable();
            dtClass = balHelper.GetAllClass();
            DataRow drClass = dtClass.NewRow();
            drClass["ClassName"] = "-- Please Select --";
            drClass["ClassID"] = 0;
            dtClass.Rows.InsertAt(drClass, 0);
            cboClass.DataSource = dtClass;
            cboClass.DisplayMember = "ClassName";
            cboClass.ValueMember = "ClassID";

            DataTable dtDept = new DataTable();
            dtDept = balHelper.GetAllDepartment();
            DataRow drDept = dtDept.NewRow();
            drDept["DepartmentName"] = "-- Please Select --";
            drDept["DepartmentID"] = 0;
            dtDept.Rows.InsertAt(drDept, 0);
            cboDepartment.DataSource = dtDept;
            cboDepartment.DisplayMember = "DepartmentName";
            cboDepartment.ValueMember = "DepartmentID";

            DataTable dtRole = new DataTable();
            dtRole = balHelper.GetUserRole();
            DataRow drRole = dtRole.NewRow();
            drRole["RoleName"] = "-- Please Select --";
            drRole["RoleID"] = 0;
            dtRole.Rows.InsertAt(drRole, 0);
            cboRole.DataSource = dtRole;
            cboRole.DisplayMember = "RoleName";
            cboRole.ValueMember = "RoleID";

            DataTable dtGender = new DataTable();
            dtGender = balHelper.GetGenderType();
            if (dtGender != null)
            {
                DataRow dr = dtGender.NewRow();
                dr["GenderName"] = "-- Please Select --";
                dr["GenderID"] = 0;
                dtGender.Rows.InsertAt(dr, 0);
                cboGender.DataSource = dtGender;
                cboGender.ValueMember = "GenderID";
                cboGender.DisplayMember = "GenderName";
            }
            DataTable dtStatus = new DataTable();
            dtStatus = balMember.GetMemberStatus();
            if (dtStatus != null)
            {
                DataRow dr = dtStatus.NewRow();
                dr["MStatusName"] = "-- Please Select --";
                dr["MStatusID"] = 0;
                dtStatus.Rows.InsertAt(dr, 0);
                cboStatus.DataSource = dtStatus;
                cboStatus.ValueMember = "MStatusID";
                cboStatus.DisplayMember = "MStatusName";
            }
            this.cboMemberType.SelectedIndexChanged -= new EventHandler(cboMemberType_SelectedIndexChanged);
            DataTable dt = new DataTable();
            dt = balMember.GetMemberType();
            if (dt != null)
            {
                DataRow dr = dt.NewRow();
                dr["TypeName"] = "-- Please Select --";
                dr["TypeID"] = 0;
                dt.Rows.InsertAt(dr, 0);
                //removing handler so that event wont get triggered when binding datasource to combo box
                cboMemberType.DataSource = dt;
                cboMemberType.ValueMember = "TypeID";
                cboMemberType.DisplayMember = "TypeName";
                this.cboMemberType.SelectedIndexChanged += new EventHandler(cboMemberType_SelectedIndexChanged);
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            fileDialogPhoto.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;";
            string browseImage;
            if (fileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                browseImage = fileDialogPhoto.FileName;
                picMember.ImageLocation = browseImage;
            }

        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void btnGetAllMember_Click(object sender, EventArgs e)
        {
            int memberTypeID = Convert.ToInt32(cboMemberType.SelectedValue.ToString());
            if (memberTypeID <= 0)
            {
                return;
            }
            LoadGridGeneral(memberTypeID);
        }
        private void LoadGridGeneral(int memberTypeID)
        {
            DataTable dt = balMember.GetAllMember(memberTypeID);
            dgvAllMember.DataSource = null;
            dgvAllMember.Rows.Clear();
            LoadGridPersonalDetails(dt);
            if (Convert.ToInt32(cboMemberType.SelectedValue.ToString()) == 1)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    dgvAllMember.Rows[i].Cells["colStudentID"].Value = dt.Rows[i]["StudentID"].ToString();
                    dgvAllMember.Rows[i].Cells["colClassName"].Value = dt.Rows[i]["ClassName"].ToString();
                    dgvAllMember.Rows[i].Cells["colClassID"].Value = dt.Rows[i]["ClassID"].ToString();
                    dgvAllMember.Rows[i].Cells["colSectionName"].Value = dt.Rows[i]["SectionName"].ToString();

                }

            }
            else if (Convert.ToInt32(cboMemberType.SelectedValue.ToString()) == 2)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    dgvAllMember.Rows[i].Cells["colTeacherID"].Value = dt.Rows[i]["TeacherID"].ToString();
                    dgvAllMember.Rows[i].Cells["colMajorSubject"].Value = dt.Rows[i]["MajorSubject"].ToString();
                    dgvAllMember.Rows[i].Cells["colDepartmentName"].Value = dt.Rows[i]["DepartmentName"].ToString();
                    dgvAllMember.Rows[i].Cells["colDepartmentID"].Value = dt.Rows[i]["DepartmentID"].ToString();

                }

            }
            else if (Convert.ToInt32(cboMemberType.SelectedValue.ToString()) == 3)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    dgvAllMember.Rows[i].Cells["colUserID"].Value = dt.Rows[i]["UserID"].ToString();
                    dgvAllMember.Rows[i].Cells["colUserName"].Value = dt.Rows[i]["UserName"].ToString();
                    dgvAllMember.Rows[i].Cells["colRoleID"].Value = dt.Rows[i]["RoleID"].ToString();
                    dgvAllMember.Rows[i].Cells["colMemberType"].Value = dt.Rows[i]["MemberType"].ToString();

                }

            }
            else
            {
                return;
            }
        }

        private void LoadGridPersonalDetails(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvAllMember.Rows.Add();
                dgvAllMember.Rows[i].Cells["colFirstName"].Value = dt.Rows[i]["FirstName"].ToString();
                dgvAllMember.Rows[i].Cells["colMiddleName"].Value = dt.Rows[i]["MiddleName"].ToString();
                dgvAllMember.Rows[i].Cells["colLastName"].Value = dt.Rows[i]["LastName"].ToString();
                dgvAllMember.Rows[i].Cells["colGenderID"].Value = dt.Rows[i]["GenderID"].ToString();
                dgvAllMember.Rows[i].Cells["colGender"].Value = dt.Rows[i]["GenderName"].ToString();
                dgvAllMember.Rows[i].Cells["colStatusID"].Value = dt.Rows[i]["StatusId"].ToString();
                dgvAllMember.Rows[i].Cells["colAddress"].Value = dt.Rows[i]["Address"].ToString();
                dgvAllMember.Rows[i].Cells["colPhone"].Value = dt.Rows[i]["Phone"].ToString();
                dgvAllMember.Rows[i].Cells["colEmail"].Value = dt.Rows[i]["Email"].ToString();
                dgvAllMember.Rows[i].Cells["colPersonalDetailID"].Value = dt.Rows[i]["PersonalDetailID"].ToString();
                dgvAllMember.Rows[i].Cells["colContactID"].Value = dt.Rows[i]["ContactID"].ToString();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "--Not Available--";
            txtPasswordConform.Text = "--Not Available--";
            if (!ValidateField() && txtPersonalDetailID.Text.Trim() != string.Empty && txtContactDetailID.Text.Trim() != string.Empty)
            {
                //creating a list that consist of personal details except photo as it is in byte formate   
                List<string> personalDetails = new List<string>();
                personalDetails.Add(txtFirstName.Text);
                personalDetails.Add(txtMiddleName.Text);
                personalDetails.Add(txtLastName.Text);
                personalDetails.Add(cboGender.SelectedValue.ToString());
                personalDetails.Add(cboStatus.SelectedValue.ToString());
                personalDetails.Add(txtAddress.Text);
                personalDetails.Add(txtPhone.Text);
                personalDetails.Add(txtEmail.Text);
                personalDetails.Add(txtPersonalDetailID.Text);
                personalDetails.Add(txtContactDetailID.Text);
                List<string> specificDetails = new List<string>();
                int memberType = Convert.ToInt32(cboMemberType.SelectedValue.ToString());
                //sending parameter to the bussiness layer based on the member type
                if (Convert.ToInt32(cboMemberType.SelectedValue.ToString()) == 1)
                {
                    specificDetails.Add(txtStudentID.Text);
                    specificDetails.Add(txtSection.Text);
                    specificDetails.Add(cboClass.SelectedValue.ToString());
                    if (balMember.UpdateMember(memberType, personalDetails, specificDetails))
                    {
                        MessageBox.Show("Student updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Convert.ToInt32(cboMemberType.SelectedValue.ToString()) == 2)
                {
                    specificDetails.Add(txtTeacherID.Text);
                    specificDetails.Add(txtMajorSubject.Text);
                    specificDetails.Add(cboDepartment.SelectedValue.ToString());
                    if (balMember.UpdateMember(memberType, personalDetails, specificDetails))
                    {
                        MessageBox.Show("Teacher Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Convert.ToInt32(cboMemberType.SelectedValue.ToString()) == 3)
                {
                    specificDetails.Add(txtUserID.Text);
                    specificDetails.Add(txtUserName.Text);
                    specificDetails.Add(txtPassword.Text);
                    specificDetails.Add(cboRole.SelectedValue.ToString());
                    if (balMember.UpdateMember(memberType, personalDetails, specificDetails))
                    {
                        MessageBox.Show("User Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Save Detail First", "Falure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadGridGeneral(Convert.ToInt32(cboMemberType.SelectedValue.ToString()));
            ClearControls();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!ValidateField())
            {
                //creating a list that consist of personal details except photo as it is in byte formate   
                List<string> personalDetails = new List<string>();
                personalDetails.Add(txtFirstName.Text);
                personalDetails.Add(txtMiddleName.Text);
                personalDetails.Add(txtLastName.Text);
                personalDetails.Add(cboGender.SelectedValue.ToString());
                personalDetails.Add(cboStatus.SelectedValue.ToString());
                personalDetails.Add(txtAddress.Text);
                personalDetails.Add(txtPhone.Text);
                personalDetails.Add(txtEmail.Text);
                List<string> specificDetails = new List<string>();
                int lastMemberNo = balMember.CountMember();
                int memberType = Convert.ToInt32(cboMemberType.SelectedValue.ToString());
                //sending parameter to the bussiness layer based on the member type
                if (Convert.ToInt32(cboMemberType.SelectedValue.ToString()) == 1)
                {
                    string studentID = Helper.GetMemberID(personalDetails[0], personalDetails[2], lastMemberNo);
                    specificDetails.Add(studentID);
                    specificDetails.Add(txtSection.Text);
                    specificDetails.Add(cboClass.SelectedValue.ToString());
                    if (balMember.AddMember(memberType, personalDetails, specificDetails))
                    {
                        MessageBox.Show("Student Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Convert.ToInt32(cboMemberType.SelectedValue.ToString()) == 2)
                {
                    string teacherID = Helper.GetMemberID(personalDetails[0], personalDetails[2], lastMemberNo);
                    specificDetails.Add(teacherID);
                    specificDetails.Add(txtMajorSubject.Text);
                    specificDetails.Add(cboDepartment.SelectedValue.ToString());
                    if (balMember.AddMember(memberType, personalDetails, specificDetails))
                    {
                        MessageBox.Show("Teacher Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Convert.ToInt32(cboMemberType.SelectedValue.ToString()) == 3)
                {
                    string userID = Helper.GetMemberID(personalDetails[0], personalDetails[2], lastMemberNo);
                    specificDetails.Add(userID);
                    specificDetails.Add(txtUserName.Text);
                    specificDetails.Add(txtPassword.Text);
                    specificDetails.Add(cboRole.SelectedValue.ToString());
                    if (balMember.AddMember(memberType, personalDetails, specificDetails))
                    {
                        MessageBox.Show("User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    return;
                }
            }
        }
        //clearing Controls
        private void ClearControls()
        {
            erpGeneral.Clear();
            //dgvProduct.DataSource = null;
            //dgvFeatures.DataSource = null;
            //dgvFeatures.Rows.Clear();
            //dgvProduct.Rows.Clear();
            // dgvFeatures.ClearSelection();
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
        //validating controls in this form
        private bool ValidateField()
        {
            if (cboMemberType.SelectedIndex == 0)
            {
                cboMemberType.Focus();
                erpGeneral.SetError(cboMemberType, "Please Select any Member");
                return true;
            }
            else if (txtFirstName.Text.Trim() == string.Empty)
            {
                txtFirstName.Focus();
                erpGeneral.SetError(txtFirstName, "Please provide First Name");
                return true;
            }
            else if (txtLastName.Text.Trim() == string.Empty)
            {
                txtLastName.Focus();
                erpGeneral.SetError(txtLastName, "Please provide Last Name");
                return true;
            }
            else if (cboGender.SelectedIndex == 0)
            {
                cboGender.Focus();
                erpGeneral.SetError(cboGender, "Please Select Gender");
                return true;
            }
            else if (cboStatus.SelectedIndex == 0)
            {
                cboStatus.Focus();
                erpGeneral.SetError(cboStatus, "Please Select Status");
                return true;
            }
            else if (txtAddress.Text.Trim() == string.Empty)
            {
                txtAddress.Focus();
                erpGeneral.SetError(txtAddress, "Please provide Address");
                return true;
            }
            else if (Convert.ToInt32(cboMemberType.SelectedValue.ToString()) == 1 && Convert.ToInt32(cboClass.SelectedValue.ToString()) == 0)
            {
                cboClass.Focus();
                erpGeneral.SetError(cboClass, "Please Select Class");
                return true;
            }
            else if (Convert.ToInt32(cboMemberType.SelectedValue.ToString()) == 3)
            {
                if (txtUserName.Text == string.Empty)
                {
                    txtUserName.Focus();
                    erpGeneral.SetError(txtUserName, "Please provide User Name");
                    return true;
                }
                else if (txtPassword.Text == string.Empty)
                {
                    txtPassword.Focus();
                    erpGeneral.SetError(txtPassword, "Please provide Password");
                    return true;
                }
                else if (Convert.ToInt32(cboRole.SelectedValue.ToString()) == 0)
                {
                    cboRole.Focus();
                    erpGeneral.SetError(cboRole, "Please Select Role");
                    return true;
                }
                else if (txtPassword.Text != txtPasswordConform.Text)
                {
                    txtPassword.Focus();
                    erpGeneral.SetError(txtPassword, "Password Miss Match");
                }
                else
                {

                }
            }
            else if (Convert.ToInt32(cboMemberType.SelectedValue.ToString()) == 2 && Convert.ToInt32(cboDepartment.SelectedValue.ToString()) == 0)
            {
                cboDepartment.Focus();
                erpGeneral.SetError(cboDepartment, "Please Select Department");
                return true;
            }

            else
            {
                return false;
            }
            return false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void dgvAllMember_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = dgvAllMember.CurrentRow.Cells["colFirstName"].Value.ToString();
            txtMiddleName.Text = dgvAllMember.CurrentRow.Cells["colMiddleName"].Value.ToString() == null ? string.Empty : dgvAllMember.CurrentRow.Cells["colMiddleName"].Value.ToString();
            txtLastName.Text = dgvAllMember.CurrentRow.Cells["colLastName"].Value.ToString();
            cboGender.SelectedValue = dgvAllMember.CurrentRow.Cells["colGenderID"].Value;
            cboStatus.SelectedValue = dgvAllMember.CurrentRow.Cells["colStatusID"].Value;
            txtAddress.Text = dgvAllMember.CurrentRow.Cells["colAddress"].Value.ToString();
            txtPhone.Text = dgvAllMember.CurrentRow.Cells["colPhone"].Value.ToString() == null ? string.Empty : dgvAllMember.CurrentRow.Cells["colPhone"].Value.ToString();
            txtEmail.Text = dgvAllMember.CurrentRow.Cells["colEmail"].Value.ToString() == null ? string.Empty : txtEmail.Text = dgvAllMember.CurrentRow.Cells["colEmail"].Value.ToString();
            txtPersonalDetailID.Text = dgvAllMember.CurrentRow.Cells["colPersonalDetailID"].Value.ToString();
            txtContactDetailID.Text = dgvAllMember.CurrentRow.Cells["colContactID"].Value.ToString();
            int memberType = Convert.ToInt32(cboMemberType.SelectedValue.ToString());
            if (memberType == 1)
            {
                txtSection.Text = dgvAllMember.CurrentRow.Cells["colSection"].Value.ToString();
                txtStudentID.Text = dgvAllMember.CurrentRow.Cells["colStudentID"].Value.ToString();
                cboClass.SelectedValue = dgvAllMember.CurrentRow.Cells["colClassID"].Value.ToString();
            }
            else if (memberType == 2)
            {
                txtTeacherID.Text = dgvAllMember.CurrentRow.Cells["colTeacherID"].Value.ToString();
                txtMajorSubject.Text = dgvAllMember.CurrentRow.Cells["colMajorSubject"].Value.ToString() == null ? string.Empty : dgvAllMember.CurrentRow.Cells["colMajorSubject"].Value.ToString();
                cboDepartment.SelectedValue = dgvAllMember.CurrentRow.Cells["colMajorSubject"].Value;

            }
            else if (memberType == 3)
            {
                txtUserID.Text = dgvAllMember.CurrentRow.Cells["colUserID"].Value.ToString();
                txtUserName.Text = dgvAllMember.CurrentRow.Cells["colUserName"].Value.ToString();
                cboRole.SelectedValue = dgvAllMember.CurrentRow.Cells["colRoleID"].Value;
                txtPassword.Enabled = false;
                txtPasswordConform.Enabled = false;
            }
            else
            {
                return;
            }

        }
    }
}
