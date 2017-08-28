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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword ()
        {
            InitializeComponent();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BALUser balUser = new BALUser();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateControls())
            {
                string userName = Program.userName;
                if (balUser.CheckPassword(userName)&&balUser.ChangePassword(userName,txtPasswordNew.Text))
                {
                    MessageBox.Show("Password Changed Successfully", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Check Current Password And Try Again", "Password Change Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPasswordNew.Focus();
                }
            }
        }
        private bool ValidateControls()
        {
            if (txtPasswordConform.Text.Trim()!=txtPasswordNew.Text.Trim())
            {
                txtPasswordNew.Focus();
                erpGeneral.SetError(txtPasswordNew, "Password Mismatch");
                return true;
            }
            else if (txtPasswordCurrent.Text.Trim()==string.Empty)
            {
                txtPasswordCurrent.Focus();
                erpGeneral.SetError(txtPasswordCurrent, "Please Current Password");
                return true;
            }
            else if (txtPasswordNew.Text.Trim() == string.Empty)
            {
                txtPasswordNew.Focus();
                erpGeneral.SetError(txtPasswordNew, "Please Provide New Password");
                return true;
            }
            else
            {
                return false;
            }
        }
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

        private void _CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
