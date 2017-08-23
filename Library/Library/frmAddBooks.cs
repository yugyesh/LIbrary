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
    public partial class frmAddBooks : Form
    {
        public frmAddBooks()
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
            LoadCboBox();
            string defaultImage;
            //application. startuppath gives the path of the bin
            defaultImage = Application.StartupPath + "\\DefaultBook.jpg";
            picMember.ImageLocation = defaultImage;
        }
        private void LoadCboBox()
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
            if (chkRegistered.Checked == true)
            {
                grpBookInfo.Enabled = true;
                pnlBook.Enabled = false;
                //as we are using isbn to validate the operation required
                //clearControls();
            }
            else
            {
                grpBookInfo.Enabled = false;
                pnlBook.Enabled = true;
                //clearControls();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateField())
            {
                if (chkRegistered.Checked==true)
                {
                    int lastBookNo = balBook.ContBookDetails();
                    string bookDetailID = Helper.GetBookID(txtBookTitle.Text, txtAuthor.Text, lastBookNo);
                    List<string> BookDetails = new List<string>();
                    BookDetails.Add(bookDetailID);
                    BookDetails.Add(txtBookTitle.Text);
                    BookDetails.Add(txtPublisherPlace.Text);
                    BookDetails.Add(txtPublisherName.Text);
                    BookDetails.Add(txtPublisherYear.Text);
                    BookDetails.Add(txtSource.Text);
                    BookDetails.Add(cboTag.SelectedValue.ToString());
                    BookDetails.Add(txtAuthor.Text);
                    BookDetails.Add("0");
                    BookDetails.Add(txtCost.Text);
                    BookDetails.Add(txtBookCopies.Text);
                    BookDetails.Add(cboClass.SelectedValue.ToString());
                    if (balBook.AddBookDetails(BookDetails))
                    {
                        MessageBox.Show("Book Details Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    List<string> BookInfo = new List<string>();
                    BookInfo.Add(txtISBN.Text);
                    BookInfo.Add(cboStatus.SelectedValue.ToString());
                    BookInfo.Add(txtBookIDSearch.Text);
                    BookInfo.Add(DateTime.Today.ToString());
                    BookInfo.Add("");
                    BookInfo.Add("");
                    if (balBook.AddBook(BookInfo))
                    {
                        MessageBox.Show("Book Details Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                
            }
        }
        private bool ValidateField()
        {
            if (chkRegistered.Checked == true)
            {
                if (txtBookTitle.Text.Trim() == string.Empty)
                {
                    txtBookTitle.Focus();
                    erpGeneral.SetError(txtBookTitle, "Please Provide Book Title");
                    return true;
                }
                else if (Convert.ToInt32(cboTag.SelectedValue.ToString())==0)
                {
                    cboTag.Focus();
                    erpGeneral.SetError(cboTag, "Please Select Tag");

                    return true;
                }
                else if (Convert.ToInt32(txtBookCopies.Text.Trim()) == 0)
                {
                    txtBookCopies.Focus();
                    erpGeneral.SetError(txtBookCopies, "Please Provide Number Of Copies");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (txtISBN.Text.Trim()==string.Empty)
                {
                    txtISBN.Focus();
                    erpGeneral.SetError(txtISBN, "Please Scan Book Properley");
                    return true;
                }
                else if (Convert.ToInt32(cboStatus.SelectedValue.ToString())==0)
                {
                    cboStatus.Focus();
                    erpGeneral.SetError(cboStatus, "Please Select Status");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
