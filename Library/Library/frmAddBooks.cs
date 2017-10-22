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
            chkRegistered.Checked = true;
            //txtClassification.GotFocus += txtClassification_Focused;
            //txtCategory.GotFocus += txtCategory_Focused;
            //txtSubCategory.GotFocus += txtSubCategory_Focused;
        }
        private void LoadCboBox()
        {
            //Loading Currency Combo box
            DataTable dtCurr = new DataTable();
            dtCurr = balHelper.GetCurrencyType();
            DataRow drCurrency = dtCurr.NewRow();
            drCurrency["CurrencyID"] = 0;
            drCurrency["CurrencyCode"] = "CURR";
            dtCurr.Rows.InsertAt(drCurrency, 0);
            cboCurrency.DataSource = dtCurr;
            cboCurrency.DisplayMember = "CurrencyCode";
            cboCurrency.ValueMember = "CurrencyID";
        }


        private void chkRegistered_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegistered.Checked == true)
            {
                //grpBookInfo.Enabled = true;
                pnlBook.Enabled = false;
                pnlAddBookForm.Visible = true;
                pnlBooksDetail.Visible = false;
                //as we are using isbn to validate the operation required
                erpGeneral.Clear();
                lblBook.Visible = false;
                lblBookDetails.Visible = false;
            }
            else
            {
                //grpBookInfo.Enabled = false;
                pnlBook.Enabled = true;
                pnlBooksDetail.Visible = true;
                pnlAddBookForm.Visible = false;
                lblBook.Visible = true;
                lblBookDetails.Visible = true;
                //grpBookInfo.Visible = false;
            }
            ClearControls();
            RefreshGrid();
        }

        //Button CLick Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateField() == true)
            {
                return;
            }
            else if (chkRegistered.Checked == true)
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
                    BookDetails.Add(txtAuthor.Text);
                    BookDetails.Add(txtBookTitle.Text);
                    BookDetails.Add(txtEdition.Text);
                    BookDetails.Add(txtPlace.Text);
                    BookDetails.Add(txtPublisher.Text);
                    BookDetails.Add(txtYear.Text);
                    BookDetails.Add(txtPages.Text);
                    BookDetails.Add(txtVol.Text);
                    BookDetails.Add(txtSource.Text);
                    BookDetails.Add(txtCost.Text == string.Empty ? "0" : txtCost.Text);
                    BookDetails.Add(cboCurrency.SelectedValue.ToString());
                    BookDetails.Add(txtSubCategory.Text);
                    BookDetails.Add(txtCategory.Text);
                    BookDetails.Add(txtClassification.Text);
                    if (balBook.AddBookDetails(BookDetails))
                    {
                        MessageBox.Show("Book Details Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControls();
                        RefreshGrid();
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
                    if (balBook.AddBook(BookInfo))
                    {
                        MessageBox.Show("Book Details Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControls();
                        RefreshGrid();
                        return;
                    }

                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateField())
            {
                return;
            }
            else if (chkRegistered.Checked == true)
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
                    BookDetails.Add(txtAuthor.Text);
                    BookDetails.Add(txtBookTitle.Text);
                    BookDetails.Add(txtEdition.Text);
                    BookDetails.Add(txtPlace.Text);
                    BookDetails.Add(txtPublisher.Text);
                    BookDetails.Add(txtYear.Text);
                    BookDetails.Add(txtPages.Text);
                    BookDetails.Add(txtVol.Text);
                    BookDetails.Add(txtSource.Text);
                    BookDetails.Add(txtCost.Text == string.Empty ? "0" : txtCost.Text);
                    BookDetails.Add(cboCurrency.SelectedValue.ToString());
                    BookDetails.Add(txtClassification.Text);
                    BookDetails.Add(txtCategory.Text);
                    BookDetails.Add(txtSubCategory.Text);
                    if (balBook.UpdateBookDetails(BookDetails))
                    {
                        MessageBox.Show("Book Details Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControls();
                        RefreshGrid();
                        return;
                    }
                }
            }
            else
            {
                if (!balBook.CheckISBN(txtISBN.Text))
                {
                    MessageBox.Show("Update operation Failure book not added Yet!", "Book Not Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                List<string> BookInfo = new List<string>();
                BookInfo.Add(txtISBN.Text);
                BookInfo.Add(txtBookIDSearch.Text);
                BookInfo.Add(DateTime.Today.ToString());
                if (balBook.UpdateBook(BookInfo))
                {
                    MessageBox.Show("Book Details Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                    RefreshGrid();
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
            RefreshGrid();
            //assigning values to grid view
        }

        private void RefreshGrid()
        {
            DataTable dtAllBooks = new DataTable();
            string[] filterString = new string[]
            {
                txtBookTitleSearch.Text.Trim(),
                txtBookIDSearch.Text.Trim(),
                txtAuthorSearch.Text.Trim(),
            };
            if (chkRegistered.Checked == true)
            {
                dgvBooksInfo.Columns["colISBN"].Visible = false;
                dtAllBooks = balBook.GetBookInfo(filterString);
                ClearGridView();
                LoadGrid(dtAllBooks);
            }
            else
            {
                dgvBooksInfo.Columns["colISBN"].Visible = true;
                dtAllBooks = balBook.GetAllBookInfo(filterString);
                DataTable dtAllBook = new DataTable();
                //Loading book details grid
                ClearGridView();
                dtAllBook = balBook.GetBookInfo(filterString);
                dgvBookInfoD.DataSource = dtAllBook;
                LoadGrid(dtAllBooks);
                for (int i = 0; i < dtAllBooks.Rows.Count; i++)
                {
                    //dgvBooksInfo.Rows.Add(dgvBooksInfo.Rows[i].Cells["colISBN"].Value, dtAllBooks.Rows[i]["BookDetailID"].ToString());
                    dgvBooksInfo.Rows[i].Cells["colISBN"].Value = dtAllBooks.Rows[i]["ISBN"].ToString();
                }
            }
        }

        private void dgvBooksInfo_Click(object sender, EventArgs e)
        {
            if (chkRegistered.Checked == false)
            {
                if (txtISBN.Text == string.Empty)
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
                txtEdition.Text = dgvBooksInfo.CurrentRow.Cells["colEdition"].Value.ToString();
                txtPlace.Text = dgvBooksInfo.CurrentRow.Cells["colPlace"].Value.ToString();
                txtPages.Text = dgvBooksInfo.CurrentRow.Cells["colPages"].Value.ToString();
                txtVol.Text = dgvBooksInfo.CurrentRow.Cells["colVol"].Value.ToString();
                cboCurrency.SelectedValue = Convert.ToInt32(dgvBooksInfo.CurrentRow.Cells["colCurrency"].Value.ToString());
                txtClassification.Text = dgvBooksInfo.CurrentRow.Cells["colClassification"].Value.ToString();
                txtCategory.Text = dgvBooksInfo.CurrentRow.Cells["colCategory"].Value.ToString();
                txtSubCategory.Text = dgvBooksInfo.CurrentRow.Cells["colSubCategory"].Value.ToString();
                txtSource.Text = dgvBooksInfo.CurrentRow.Cells["colSource"].Value == null ? string.Empty : dgvBooksInfo.CurrentRow.Cells["colSource"].Value.ToString();
                txtCost.Text = dgvBooksInfo.CurrentRow.Cells["colCost"].Value == null ? string.Empty : dgvBooksInfo.CurrentRow.Cells["colCost"].Value.ToString();
                txtPublisher.Text = dgvBooksInfo.CurrentRow.Cells["colPublisherName"].Value == null ? string.Empty : dgvBooksInfo.CurrentRow.Cells["colPublisherName"].Value.ToString();
                txtYear.Text = dgvBooksInfo.CurrentRow.Cells["colPublishedYear"].Value == null ? string.Empty : dgvBooksInfo.CurrentRow.Cells["colPublishedYear"].Value.ToString();

            }
        }

        //Text Changed Events
        private void txtBookIDSearch_TextChanged(object sender, EventArgs e)
        {
            ClearGridView();
            DataTable dtAllBooks = new DataTable();
            DataTable dtBooks = new DataTable();
            string[] filterString = new string[]
            {
                txtBookTitleSearch.Text.Trim(),
                txtBookIDSearch.Text.Trim(),
                txtAuthorSearch.Text.Trim(),
            };
            dtAllBooks = balBook.GetBookInfo(filterString);
            if (chkRegistered.Checked == true)
            {
                dtBooks = balBook.GetBookInfo(filterString);
                LoadGrid(dtBooks);
            }
            else
            {
                //Loading bookinfo grid that consist details
                dtBooks = balBook.GetBookInfo(filterString);
                dgvBookInfoD.DataSource = dtBooks;
                dtAllBooks = balBook.GetAllBookInfo(filterString);
                LoadGrid(dtAllBooks);
                for (int i = 0; i < dtAllBooks.Rows.Count; i++)
                {
                    //dgvBooksInfo.Rows.Add(dgvBooksInfo.Rows[i].Cells["colISBN"].Value, dtAllBooks.Rows[i]["BookDetailID"].ToString());
                    dgvBooksInfo.Rows[i].Cells["colISBN"].Value = dtAllBooks.Rows[i]["ISBN"].ToString();
                }
            }
        }

        private void LoadGrid(DataTable dtAllBooks)
        {
            for (int i = 0; i < dtAllBooks.Rows.Count; i++)
            {
                dgvBooksInfo.Rows.Add();
                dgvBooksInfo.Rows[i].Cells["colBookDetailID"].Value = dtAllBooks.Rows[i]["BookDetailID"].ToString();
                dgvBooksInfo.Rows[i].Cells["colTitle"].Value = dtAllBooks.Rows[i]["Title"].ToString();
                dgvBooksInfo.Rows[i].Cells["colAuthor"].Value = dtAllBooks.Rows[i]["Author"].ToString();
                dgvBooksInfo.Rows[i].Cells["colEdition"].Value = dtAllBooks.Rows[i]["Edition"].ToString();
                dgvBooksInfo.Rows[i].Cells["colPlace"].Value = dtAllBooks.Rows[i]["Place"].ToString();
                dgvBooksInfo.Rows[i].Cells["colPublisherName"].Value = dtAllBooks.Rows[i]["Publisher"].ToString();
                dgvBooksInfo.Rows[i].Cells["colPublishedYear"].Value = dtAllBooks.Rows[i]["publishedYear"].ToString();
                dgvBooksInfo.Rows[i].Cells["colPages"].Value = dtAllBooks.Rows[i]["Pages"].ToString();
                dgvBooksInfo.Rows[i].Cells["colVol"].Value = dtAllBooks.Rows[i]["Vol"].ToString();
                dgvBooksInfo.Rows[i].Cells["colSource"].Value = dtAllBooks.Rows[i]["Source"].ToString();
                dgvBooksInfo.Rows[i].Cells["colCost"].Value = dtAllBooks.Rows[i]["Cost"].ToString();
                dgvBooksInfo.Rows[i].Cells["colCurrency"].Value = dtAllBooks.Rows[i]["CurrID"].ToString();
                dgvBooksInfo.Rows[i].Cells["colClassification"].Value = dtAllBooks.Rows[i]["Classification"].ToString();
                dgvBooksInfo.Rows[i].Cells["colCategory"].Value = dtAllBooks.Rows[i]["Category"].ToString();
                dgvBooksInfo.Rows[i].Cells["colSubCategory"].Value = dtAllBooks.Rows[i]["SubCategory"].ToString();
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
            dgvBookInfoD.DataSource = null;
            dgvBookInfoD.Rows.Clear();
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
                if (txtAuthor.Text.Trim() == string.Empty)
                {
                    txtAuthor.Focus();
                    erpGeneral.SetError(txtAuthor, "Please Provide Author Name");
                    return true;
                }
                else if (txtBookTitle.Text.Trim() == string.Empty)
                {
                    txtBookTitle.Focus();
                    erpGeneral.SetError(txtBookTitle, "Please Provide Book Title");
                    return true;
                }
                else if (cboCurrency.SelectedValue.ToString()=="0")
                {
                    cboCurrency.Focus();
                    erpGeneral.SetError(cboCurrency, "Please Provide Currency");
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
            if (identifySelect == "Classification")
            {
                txtClassification.Text = dgvClassificationList.CurrentRow.Cells["colID"].Value.ToString();

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

        private void dgvBookInfoD_Click(object sender, EventArgs e)
        {
            if (dgvBookInfoD.Rows.Count<=0)
            {
                return;
            }
            txtBookIDSearch.Text = dgvBookInfoD.CurrentRow.Cells["bookDetailID"].Value.ToString();
        }
    }
}
