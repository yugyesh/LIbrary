using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        private void ValidateControls()
        {
            if (txtPasswordConform.Text.Trim()!=txtPasswordNew.Text.Trim())
            {
                txtPasswordNew.Focus();
                erpGeneral.SetError(txtPasswordNew, "Password Mismatch");
            }
            else if (txtPasswordCurrent.Text.Trim()!=string.Empty)
            {
                txtPasswordCurrent.Focus();
                erpGeneral.SetError(txtPasswordCurrent, "Please Current Password");
            }
            else if (txtPasswordNew.Text.Trim() != string.Empty)
            {
                txtPasswordNew.Focus();
                erpGeneral.SetError(txtPasswordNew, "Please Provide New Password");
            }
            else
            {
                return;
            }
        }
    }
}
