namespace Library
{
    partial class frmImportBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlClose = new System.Windows.Forms.Panel();
            this._CloseButton = new Library.ButtonZ();
            this.ofdBookExcel = new System.Windows.Forms.OpenFileDialog();
            this.btnImport = new IncLibrary.IncButton();
            this.pnlImportingDetails = new System.Windows.Forms.Panel();
            this.dgvBooksInfo = new System.Windows.Forms.DataGridView();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPublishedYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlClose.SuspendLayout();
            this.pnlImportingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClose
            // 
            this.pnlClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlClose.Controls.Add(this._CloseButton);
            this.pnlClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClose.Location = new System.Drawing.Point(0, 0);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(1361, 25);
            this.pnlClose.TabIndex = 61;
            // 
            // _CloseButton
            // 
            this._CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._CloseButton.DisplayText = "X";
            this._CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CloseButton.ForeColor = System.Drawing.Color.White;
            this._CloseButton.Location = new System.Drawing.Point(1333, 0);
            this._CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this._CloseButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this._CloseButton.Name = "_CloseButton";
            this._CloseButton.Size = new System.Drawing.Size(28, 25);
            this._CloseButton.TabIndex = 2;
            this._CloseButton.Text = "X";
            this._CloseButton.TextLocation_X = 6;
            this._CloseButton.TextLocation_Y = 1;
            this._CloseButton.UseVisualStyleBackColor = true;
            this._CloseButton.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // ofdBookExcel
            // 
            this.ofdBookExcel.FileName = "openFileDialog1";
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnImport.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnImport.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnImport.Location = new System.Drawing.Point(0, 25);
            this.btnImport.Name = "btnImport";
            this.btnImport.NextControl = null;
            this.btnImport.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnImport.PreviousControl = null;
            this.btnImport.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnImport.Size = new System.Drawing.Size(1361, 39);
            this.btnImport.TabIndex = 62;
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // pnlImportingDetails
            // 
            this.pnlImportingDetails.Controls.Add(this.dgvBooksInfo);
            this.pnlImportingDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImportingDetails.Location = new System.Drawing.Point(0, 64);
            this.pnlImportingDetails.Name = "pnlImportingDetails";
            this.pnlImportingDetails.Size = new System.Drawing.Size(1361, 545);
            this.pnlImportingDetails.TabIndex = 63;
            // 
            // dgvBooksInfo
            // 
            this.dgvBooksInfo.AllowUserToAddRows = false;
            this.dgvBooksInfo.AllowUserToDeleteRows = false;
            this.dgvBooksInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvBooksInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooksInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBooksInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooksInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colISBN,
            this.colBookDetailID,
            this.colTitle,
            this.colAuthor,
            this.colEdition,
            this.colPlace,
            this.colPublisherName,
            this.colPublishedYear,
            this.colPages,
            this.colVol,
            this.colSource,
            this.colCost,
            this.colCurrency,
            this.colClassification,
            this.colCategory,
            this.colSubCategory});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBooksInfo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBooksInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooksInfo.EnableHeadersVisualStyles = false;
            this.dgvBooksInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvBooksInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvBooksInfo.Name = "dgvBooksInfo";
            this.dgvBooksInfo.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooksInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBooksInfo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvBooksInfo.Size = new System.Drawing.Size(1361, 545);
            this.dgvBooksInfo.TabIndex = 1;
            // 
            // colISBN
            // 
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            this.colISBN.Visible = false;
            // 
            // colBookDetailID
            // 
            this.colBookDetailID.HeaderText = "Book ID";
            this.colBookDetailID.Name = "colBookDetailID";
            this.colBookDetailID.ReadOnly = true;
            this.colBookDetailID.Width = 95;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 175;
            // 
            // colAuthor
            // 
            this.colAuthor.HeaderText = "Author";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            this.colAuthor.Width = 110;
            // 
            // colEdition
            // 
            this.colEdition.HeaderText = "Edition";
            this.colEdition.Name = "colEdition";
            this.colEdition.ReadOnly = true;
            this.colEdition.Visible = false;
            // 
            // colPlace
            // 
            this.colPlace.HeaderText = "Place";
            this.colPlace.Name = "colPlace";
            this.colPlace.ReadOnly = true;
            this.colPlace.Visible = false;
            // 
            // colPublisherName
            // 
            this.colPublisherName.HeaderText = "Publisher Name";
            this.colPublisherName.Name = "colPublisherName";
            this.colPublisherName.ReadOnly = true;
            this.colPublisherName.Visible = false;
            // 
            // colPublishedYear
            // 
            this.colPublishedYear.HeaderText = "Published Year";
            this.colPublishedYear.Name = "colPublishedYear";
            this.colPublishedYear.ReadOnly = true;
            this.colPublishedYear.Visible = false;
            // 
            // colPages
            // 
            this.colPages.HeaderText = "Pages";
            this.colPages.Name = "colPages";
            this.colPages.ReadOnly = true;
            this.colPages.Visible = false;
            // 
            // colVol
            // 
            this.colVol.HeaderText = "Vol";
            this.colVol.Name = "colVol";
            this.colVol.ReadOnly = true;
            this.colVol.Visible = false;
            // 
            // colSource
            // 
            this.colSource.HeaderText = "Source";
            this.colSource.Name = "colSource";
            this.colSource.ReadOnly = true;
            this.colSource.Visible = false;
            // 
            // colCost
            // 
            this.colCost.HeaderText = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.ReadOnly = true;
            this.colCost.Visible = false;
            // 
            // colCurrency
            // 
            this.colCurrency.HeaderText = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.ReadOnly = true;
            this.colCurrency.Visible = false;
            // 
            // colClassification
            // 
            this.colClassification.HeaderText = "Classification";
            this.colClassification.Name = "colClassification";
            this.colClassification.ReadOnly = true;
            this.colClassification.Visible = false;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 70;
            // 
            // colSubCategory
            // 
            this.colSubCategory.HeaderText = "S-Category";
            this.colSubCategory.Name = "colSubCategory";
            this.colSubCategory.ReadOnly = true;
            this.colSubCategory.Width = 80;
            // 
            // frmImportBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1361, 609);
            this.ControlBox = false;
            this.Controls.Add(this.pnlImportingDetails);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.pnlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login";
            this.pnlClose.ResumeLayout(false);
            this.pnlImportingDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClose;
        private ButtonZ _CloseButton;
        private System.Windows.Forms.OpenFileDialog ofdBookExcel;
        private IncLibrary.IncButton btnImport;
        private System.Windows.Forms.Panel pnlImportingDetails;
        private System.Windows.Forms.DataGridView dgvBooksInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPublisherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPublishedYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPages;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubCategory;
    }
}

