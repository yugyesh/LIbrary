using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using BussinessLayer;
using Common;
namespace Library
{
    public partial class frmImportBooks : Form
    {
        public frmImportBooks ()
        {
            InitializeComponent();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BALBook balBook = new BALBook();
        BALHelper balHelper = new BALHelper();
        private void btnImport_Click(object sender, EventArgs e)
        {
            //adding Filter to Dialog box
            ofdBookExcel.Filter = "Excel Worksheets 2003(*.xls)|*.xls|Excel Worksheets 2007(*.xlsx)|*.xlsx";
            string filePath;
            DataTable dt = new DataTable();
            if (ofdBookExcel.ShowDialog()==DialogResult.OK)
            {
                filePath = ofdBookExcel.FileName;
                //Creating Excel Application Instance
                Excel.Application exApp = new Excel.Application();
                //opening excel file
                Excel.Workbook exWorkBook = exApp.Workbooks.Open(filePath);
                //counting number of sheets in the excel file
                int noOfSheet = exWorkBook.Sheets.Count;
                //Creating List
                List<string> bookDetails = new List<string>();
                for (int i = 1; i <= noOfSheet; i++)
                {
                    //Creating instance of excel sheet
                    Excel.Worksheet exSheet = exWorkBook.Sheets[i];
                    //Elemeniting empty rows and columns
                    exSheet.Rows.ClearFormats();
                    exSheet.Rows.ClearFormats();
                    //Finding used range
                    Excel.Range range = exSheet.UsedRange;
                    //finding no of rows and columns
                    int rowCount = range.Rows.Count;
                    int colCount = range.Columns.Count;
                    for (int j = 2; j <= rowCount; j++)
                    {
                        bookDetails.Clear();
                        for (int k = 1; k < colCount; k++)
                        {
                            string text = exSheet.Cells[j, k].Value == null ? string.Empty : exSheet.Cells[j, k].Value.ToString();
                            bookDetails.Add(text);
                        }
                        if (balBook.CheckBookDetails(bookDetails))
                        {
                            dt.Rows.Clear();
                            //retriving currency id
                            int lastBookNo = balBook.CountBookDetails();
                            bookDetails[0] = Helper.GetBookID(bookDetails[2], bookDetails[1], lastBookNo);
                            bookDetails[11] = balHelper.GetCurrencyID(bookDetails[11]);
                            dt = balBook.GetCategoryClassificationID(bookDetails[12]);
                            bookDetails.Add(dt.Rows[0]["CategoryID"].ToString());
                            bookDetails.Add(dt.Rows[0]["ClassificationID"].ToString());
                            balBook.AddBookDetails(bookDetails);
                        }
                        //DataTable dt = new DataTable();
                        //dt=ConvertToDatatable(bookDetails);
                    }
                    //cleanup
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    //rule of thumb for releasing com objects:
                    //  never use two dots, all COM objects must be referenced and released individually
                    //  ex: [somthing].[something].[something] is bad

                    //release com objects to fully kill excel process from running in the background
                    Marshal.ReleaseComObject(range);
                    Marshal.ReleaseComObject(exSheet);
                }
                //close and release
                object misValue = System.Reflection.Missing.Value;
                exWorkBook.Close(false, misValue, misValue);
                Marshal.ReleaseComObject(exWorkBook);

                //quit and release
                exApp.Quit();
                Marshal.ReleaseComObject(exApp);
                MessageBox.Show("Books Imported successfully","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private static DataTable ConvertToDatatable<T>(List<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    table.Columns.Add(prop.Name, prop.PropertyType.GetGenericArguments()[0]);
                else
                    table.Columns.Add(prop.Name, prop.PropertyType);
            }

            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }
}
