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
            //txtClassification.GotFocus += txtClassification_Focused;
            //txtCategory.GotFocus += txtCategory_Focused;
            //txtSubCategory.GotFocus += txtSubCategory_Focused;
        }
        private void LoadCboBox()
        {
            DataTable dt = new DataTable();
            dt = balHelper.GetAllClass();
            DataRow drClass = dt.NewRow();
            drClass["ClassName"] = "-- Please Select --";
            drClass["ClassID"] = 0;
            dt.Rows.InsertAt(drClass, 0);
            cboClassSearch.DataSource = dt;
            cboClassSearch.DisplayMember = "ClassName";
            cboClassSearch.ValueMember = "ClassID";
            //Loading Currency Combo box
            dt = balHelper.GetCurrencyType();
            DataRow drCurrency = dt.NewRow();
            drCurrency["CurrencyID"] = 0;
            drCurrency["CurrencyCode"] = "CURR";
            dt.Rows.InsertAt(drCurrency, 0);
            cboCurrency.DataSource = dt;
            cboCurrency.DisplayMember = "CurrencyCode";
            cboCurrency.ValueMember = "CurrencyID";
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

        //Button CLick Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateField() && chkRegistered.Checked == true)
            {
                if (txtBookID.Text.Trim() != string.Empty)
                {
                    MessageBox.Show("This Book is already Added", "Book Already Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls();
                    return;
                }
                else
                {
                    int lastBookNo = balBook.CountBookDetails();
                    string bookDetailID = Helper.GetBookID(txtBookTitle.Text, txtAuthor.Text, lastBookNo);
                    List<string> BookDetails = new List<string>();
                    BookDetails.Add(bookDetailID);
                    BookDetails.Add(txtBookTitle.Text);
                    BookDetails.Add(txtPublisherPlace.Text);
                    BookDetails.Add(txtPublisherName.Text);
                    BookDetails.Add(txtPublisherYear.Text);
                    BookDetails.Add(txtSource.Text);
                    BookDetails.Add(txtAuthor.Text);
                    BookDetails.Add("0");
                    BookDetails.Add(txtCost.Text == string.Empty ? "0" : txtCost.Text);
                    if (balBook.AddBookDetails(BookDetails))
                    {
                        MessageBox.Show("Book Details Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControls();
                        return;
                    }
                }

            }
            else
            {
                if (balBook.CheckISBN(txtISBN.Text))
                {
                    MessageBox.Show("This Book is already Added", "Book Already Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls();
                    return;
                }
                else
                {
                    List<string> BookInfo = new List<string>();
                    BookInfo.Add(txtISBN.Text);
                    BookInfo.Add(txtBookIDSearch.Text);
                    BookInfo.Add(DateTime.Today.ToString());
                    BookInfo.Add("");
                    BookInfo.Add("");
                    if (balBook.AddBook(BookInfo))
                    {
                        MessageBox.Show("Book Details Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControls();
                        return;
                    }

                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateField() && chkRegistered.Checked == true)
            {
                if (txtBookID.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("This Book is already Added", "Book Already Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    List<string> BookDetails = new List<string>();
                    BookDetails.Add(txtBookID.Text);
                    BookDetails.Add(txtBookTitle.Text);
                    BookDetails.Add(txtPublisherPlace.Text);
                    BookDetails.Add(txtPublisherName.Text);
                    BookDetails.Add(txtPublisherYear.Text);
                    BookDetails.Add(txtSource.Text);
                    BookDetails.Add(txtAuthor.Text);
                    BookDetails.Add("0");
                    BookDetails.Add(txtCost.Text);
                    if (balBook.UpdateBookDetails(BookDetails))
                    {
                        MessageBox.Show("Book Details Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            else
            {
                if (!balBook.CheckISBN(txtISBN.Text))
                {
                    MessageBox.Show("Update operation Falure book not added Yet!", "Book Not Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                List<string> BookInfo = new List<string>();
                BookInfo.Add(txtISBN.Text);
                BookInfo.Add(txtBookIDSearch.Text);
                BookInfo.Add(DateTime.Today.ToString());
                BookInfo.Add("");
                BookInfo.Add("");
                if (balBook.UpdateBook(BookInfo))
                {
                    MessageBox.Show("Book Details Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGridView();
            ClearControls();
        }


        private void btnGet_Click(object sender, EventArgs e)
        {
            DataTable dtAllBooks = new DataTable();
            string[] filterString = new string[]
            {
                txtBookTitleSearch.Text.Trim(),
                txtBookIDSearch.Text.Trim(),
                cboClassSearch.SelectedText.Trim(),
            };
            if (chkRegistered.Checked==true)
            {
                dgvBooksInfo.Columns["colStatus"].Visible = true;
                dgvBooksInfo.Columns["colISBN"].Visible = false;
                dtAllBooks = balBook.GetBookInfo(filterString);
                ClearGridView();
                LoadGrid(dtAllBooks);
            }
            else
            {
                dgvBooksInfo.Columns["colStatus"].Visible = false;
                dgvBooksInfo.Columns["colISBN"].Visible = true;
                dtAllBooks = balBook.GetAllBookInfo(filterString);
                ClearGridView();
                LoadGrid(dtAllBooks);
                for (int i = 0; i < dtAllBooks.Rows.Count; i++)
                {
                    //dgvBooksInfo.Rows.Add(dgvBooksInfo.Rows[i].Cells["colISBN"].Value, dtAllBooks.Rows[i]["BookDetailID"].ToString());
                    dgvBooksInfo.Rows[i].Cells["colISBN"].Value = dtAllBooks.Rows[i]["ISBN"].ToString();
                    dgvBooksInfo.Rows[i].Cells["colBookStatusID"].Value = dtAllBooks.Rows[i]["BStatusID"].ToString();
                    dgvBooksInfo.Rows[i].Cells["colStatus"].Value = dtAllBooks.Rows[i]["BStatusName"].ToString();
                }
            }
            //assigning values to grid view
        }

        private void dgvBooksInfo_Click(object sender, EventArgs e)
        {
            if (chkRegistered.Checked == false)
            {
                if (txtISBN.Text==string.Empty)
                {
                    txtISBN.Text = dgvBooksInfo.CurrentRow.Cells["colISBN"].Value == null ? string.Empty : dgvBooksInfo.CurrentRow.Cells["colISBN"].Value.ToString();
                }
                txtBookIDSearch.Text = dgvBooksInfo.CurrentRow.Cells["colBookDetailID"].Value.ToString();
            }
            else
            {
                txtBookID.Text = dgvBooksInfo.CurrentRow.Cells["colBookDetailID"].Value.ToString();
                txtBookTitle.Text = dgvBooksInfo.CurrentRow.Cells["colTitle"].Value.ToString();
                txtAuthor.Text = dgvBooksInfo.CurrentRow.Cells["colAuthor"].Value.ToString();
                txtSource.Text = dgvBooksInfo.CurrentRow.Cells["colSource"].Value == null ? string.Empty : dgvBooksInfo.CurrentRow.Cells["colSource"].Value.ToString();
                txtCost.Text = dgvBooksInfo.CurrentRow.Cells["colCost"].Value == null ? string.Empty : dgvBooksInfo.CurrentRow.Cells["colCost"].Value.ToString();
                txtPublisherName.Text = dgvBooksInfo.CurrentRow.Cells["colPublisherName"].Value == null ? string.Empty : dgvBooksInfo.CurrentRow.Cells["colPublisherName"].Value.ToString();
                txtPublisherYear.Text = dgvBooksInfo.CurrentRow.Cells["colPublishedYear"].Value == null ? string.Empty : dgvBooksInfo.CurrentRow.Cells["colPublishedYear"].Value.ToString();

            }
        }

        //Text Changed Events
        private void txtBookIDSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dtAllBooks = new DataTable();
            string[] filterString = new string[]
            {
                txtBookTitleSearch.Text.Trim(),
                txtBookIDSearch.Text.Trim(),
                cboClassSearch.Text.Trim()=="-- Please Select --"?string.Empty:cboClassSearch.Text.Trim(),
            };
            dtAllBooks = balBook.GetBookInfo(filterString);
            ClearGridView();
            LoadGrid(dtAllBooks);
        }

        private void LoadGrid(DataTable dtAllBooks)
        {
            for (int i = 0; i < dtAllBooks.Rows.Count; i++)
            {
                dgvBooksInfo.Rows.Add();
                dgvBooksInfo.Rows[i].Cells["colBookDetailID"].Value = dtAllBooks.Rows[i]["BookDetailID"].ToString();
                dgvBooksInfo.Rows[i].Cells["colTitle"].Value = dtAllBooks.Rows[i]["BookTitle"].ToString();
                dgvBooksInfo.Rows[i].Cells["colAuthor"].Value = dtAllBooks.Rows[i]["Author"].ToString();
                dgvBooksInfo.Rows[i].Cells["colBookCopies"].Value = dtAllBooks.Rows[i]["BookCopies"].ToString();
                dgvBooksInfo.Rows[i].Cells["colTagID"].Value = dtAllBooks.Rows[i]["TagID"].ToString();
                dgvBooksInfo.Rows[i].Cells["colTag"].Value = dtAllBooks.Rows[i]["TagName"].ToString();
                dgvBooksInfo.Rows[i].Cells["colClassID"].Value = dtAllBooks.Rows[i]["ClassID"].ToString();
                dgvBooksInfo.Rows[i].Cells["colClassName"].Value = dtAllBooks.Rows[i]["ClassName"].ToString();
                dgvBooksInfo.Rows[i].Cells["colCost"].Value = dtAllBooks.Rows[i]["Cost"].ToString();
                dgvBooksInfo.Rows[i].Cells["colPages"].Value = dtAllBooks.Rows[i]["Pages"].ToString();
                dgvBooksInfo.Rows[i].Cells["colPlace"].Value = dtAllBooks.Rows[i]["Place"].ToString();
                dgvBooksInfo.Rows[i].Cells["colPublisherName"].Value = dtAllBooks.Rows[i]["PublisherName"].ToString();
                dgvBooksInfo.Rows[i].Cells["colSource"].Value = dtAllBooks.Rows[i]["Source"].ToString();
                dgvBooksInfo.Rows[i].Cells["colPublishedYear"].Value = dtAllBooks.Rows[i]["PublishedYear"].ToString();
            }
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            if (txtISBN.Text.Length == 13)
            {
                //cboStatus.Focus();
            }
        }

        private void ClearGridView()
        {
            dgvBooksInfo.DataSource = null;
            dgvBooksInfo.Rows.Clear();
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
        private void txtPublisherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
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
                else
                {
                    return false;
                }
            }
            else
            {
                if (txtISBN.Text.Trim() == string.Empty)
                {
                    txtISBN.Focus();
                    erpGeneral.SetError(txtISBN, "Please Scan Book Properley");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //Maintaining integrity of a textbox
        private void txtBookCopies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtCost.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void _CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //Grid that hold classification
        private void LoadGridClassification(DataTable dt)
        {
            //Adding data row with null value to select empty row
            DataRow dr = dt.NewRow();
            dr["ID"] = string.Empty;
            dr["Name"] = "Clear";
            dt.Rows.InsertAt(dr, dt.Rows.Count + 1);
            dgvClassificationList.Rows.Clear();
            dgvClassificationList.DataSource = null;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvClassificationList.Rows.Add();
                dgvClassificationList.Rows[i].Cells["colID"].Value = dt.Rows[i]["ID"].ToString();
                dgvClassificationList.Rows[i].Cells["colName"].Value = dt.Rows[i]["Name"].ToString();
            }
            dgvClassificationList.Focus();
        }
        //this global variable is used to identify which value is getting populated in classification grid
        string identifySelect;
        //Loading classification in grid classification
        private void txtClassification_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = balBook.GetClassification();
            LoadGridClassification(dt);
            identifySelect = "Classification";
            dgvClassificationList.Columns[1].HeaderText = "Classification Name";
        }
        //Loading category in grid category based on classification selected
        private void txtCategory_Click(object sender, EventArgs e)
        {
            if (txtClassification.Text.Trim() == string.Empty)
            {
                return;
            }
            DataTable dt = new DataTable();
            dt = balBook.GetCategory(txtClassification.Text);
            LoadGridClassification(dt);
            identifySelect = "Category";
            dgvClassificationList.Columns[1].HeaderText = "Category Name";
        }
        //Loading sub category in grid based on category selected
        private void txtSubCategory_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text == string.Empty)
            {
                return;
            }
            DataTable dt = new DataTable();
            dt = balBook.GetSubCategory(txtCategory.Text);

            LoadGridClassification(dt);
            identifySelect = "SubCategory";
            dgvClassificationList.Columns[1].HeaderText = "Sub-Category Name";
        }

        private void dgvClassificationList_Click(object sender, EventArgs e)
        {
            if (identifySelect=="Classification")
            {
                txtClassification.Text=dgvClassificationList.CurrentRow.Cells["colID"].Value.ToString();
                
                return;
            }
            else if (identifySelect == "Category")
            {
                txtCategory.Text = dgvClassificationList.CurrentRow.Cells["colID"].Value.ToString();
                return;
            }
            else
            {
                txtSubCategory.Text = dgvClassificationList.CurrentRow.Cells["colID"].Value.ToString();
                return;
            }
        }
    }
}
