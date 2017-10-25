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
using System.Speech.Synthesis;

namespace Library
{
    public partial class frmLogin : Form
    {
        public frmLogin ()
        {
            InitializeComponent();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        BALUser balUser = new BALUser();
        BALMember balMember = new BALMember();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            erpGeneral.Clear();
            if (!ValidateFields())
            {
                DataTable dt = new DataTable();
                DataTable dtStatusCheck = new DataTable();
                dt = balUser.CheckUser(txtUserName.Text, txtPassword.Text, Convert.ToInt32(cboUserType.SelectedValue.ToString()));
                dtStatusCheck = balMember.CheckStatusState(dt.Rows[0]["PersonalDetailsID"].ToString());
                if (dt == null)
                {
                    MessageBox.Show("Username and Password Mismatch", "Login Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                }
                else if (dtStatusCheck.Rows[0]["MStatusName"].ToString().ToLower()!="active")
                {
                    MessageBox.Show("This User is blocked contat your admin", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Program.userName = txtUserName.Text;
                    //SpeechSynthesizer speak = new SpeechSynthesizer();
                    //speak.Speak("Hello! Welcome to Library Management System");
                    //speak.Speak("Have a good day");
                    MessageBox.Show("Login Successful", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain mainForm = new frmMain();
                    mainForm.statUserName.Text = txtUserName.Text;
                    //mainForm.statRoleID.Text = cboUserType.SelectedValue.ToString();
                    mainForm.Show();
                    this.Hide();
                }
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool ValidateFields()
        {
            if (this.txtUserName.Text.Trim()==string.Empty)
            {
                txtUserName.Focus();
                erpGeneral.SetError(txtUserName, "Please Provide UserName");
                return true;
            }
            else if (this.txtPassword.Text.Trim()==string.Empty)
            {
                txtPassword.Focus();
                erpGeneral.SetError(txtPassword, "Please Enter Password");
                return true;
            }
            else if (cboUserType.SelectedIndex==0)
            {
                cboUserType.Focus();
                erpGeneral.SetError(cboUserType, "Please Select User Type");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = balUser.GetUserType();
            if (dt != null)
            {
                DataRow dr = dt.NewRow();
                dr["RoleName"] = "-- Please Select --";
                dt.Rows.InsertAt(dr, 0);
                cboUserType.DataSource = dt;
                cboUserType.ValueMember = "RoleID";
                cboUserType.DisplayMember = "RoleName";
            }
        }
    }
}
