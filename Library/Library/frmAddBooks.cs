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
    public partial class frmAddBooks : Form
    {
        public frmAddBooks ()
        {
            InitializeComponent();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BALHelper balHelper = new BALHelper();
        BALBook balBook = new BALBook();
        private void frmAddBooks_Load(object sender, EventArgs e)
        {
            DataTable dtStatus = new DataTable();
            dtStatus = balBook.GetBookType();
            if (dtStatus != null)
            {
                DataRow dr = dtStatus.NewRow();
                dr["BStatusName"] = "-- Please Select --";
                dr["BStatusID"] = 0;
                dtStatus.Rows.InsertAt(dr, 0);
                cboStatus.DataSource = dtStatus;
                cboStatus.ValueMember = "BStatusID";
                cboStatus.DisplayMember = "BStatusName";
            }
            DataTable dtTag = new DataTable();
            dtTag = balBook.GetBookTag();
            if (dtStatus != null)
            {
                DataRow dr = dtTag.NewRow();
                dr["TagName"] = "-- Please Select --";
                dr["TagID"] = 0;
                dtTag.Rows.InsertAt(dr, 0);
                cboTag.DataSource = dtTag;
                cboTag.ValueMember = "TagID";
                cboTag.DisplayMember = "TagName";
            }
            string defaultImage;
            //application. startuppath gives the path of the bin
            defaultImage = Application.StartupPath + "\\DefaultBook.jpg";
            picMember.ImageLocation = defaultImage;
        }

        private void txtPublisherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkRegistered_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegistered.Checked==true)
            {
                grpBookInfo.Enabled = true;
                pnlBook.Enabled = false;
            }
            else
            {
                grpBookInfo.Enabled = false;
                pnlBook.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chkRegistered.Checked==true)
            {

            }
        }
        private bool ValidateField()
        {
            if (chkRegistered.Checked==true)
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
            }
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
        }
        }
}
