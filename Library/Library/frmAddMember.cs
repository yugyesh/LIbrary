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
    public partial class frmAddMember : Form
    {
        public frmAddMember ()
        {
            InitializeComponent();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
        BALMember balMember = new BALMember();
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
            DataTable dtGender = new DataTable();
            dtGender = balMember.GetGenderType();
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
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            fileDialogPhoto.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;";
            string browseImage;
            if (fileDialogPhoto.ShowDialog()==DialogResult.OK)
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int lastMemberNo = balMember.CountMember();
            if (!ValidateField())
            {
                
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
                //if (Convert.ToInt32(cboMemberType.SelectedValue.ToString())==1)
                //{
                //    specificDetails.Add(txt)
                //}
            }
        }
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
                if (txtUserName.Text==string.Empty)
                {
                    txtUserName.Focus();
                    erpGeneral.SetError(txtUserName, "Please provide User Name");
                    return true;
                }
                else if (txtPassword.Text==string.Empty)
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
    }
}
