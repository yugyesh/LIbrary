namespace Library
{
    partial class frmUserInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlClose = new System.Windows.Forms.Panel();
            this.dgvUserInfo = new System.Windows.Forms.DataGridView();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.incLabel3 = new IncLibrary.IncLabel();
            this.lblBurrowerName = new IncLibrary.IncLabel();
            this.btnUpdateStaus = new IncLibrary.IncButton();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnClear = new IncLibrary.IncButton();
            this.erpGeneral = new System.Windows.Forms.ErrorProvider(this.components);
            this._CloseButton = new Library.ButtonZ();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsertype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonalDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).BeginInit();
            this.pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClose
            // 
            this.pnlClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlClose.Controls.Add(this.txtUserId);
            this.pnlClose.Controls.Add(this._CloseButton);
            this.pnlClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClose.Location = new System.Drawing.Point(0, 0);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(580, 25);
            this.pnlClose.TabIndex = 61;
            // 
            // dgvUserInfo
            // 
            this.dgvUserInfo.AllowUserToAddRows = false;
            this.dgvUserInfo.AllowUserToDeleteRows = false;
            this.dgvUserInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserName,
            this.colUsertype,
            this.colStatus,
            this.colPassword,
            this.colPersonalDetailID,
            this.colUserID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserInfo.EnableHeadersVisualStyles = false;
            this.dgvUserInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvUserInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvUserInfo.Name = "dgvUserInfo";
            this.dgvUserInfo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvUserInfo.Size = new System.Drawing.Size(547, 339);
            this.dgvUserInfo.TabIndex = 62;
            this.dgvUserInfo.Click += new System.EventHandler(this.dgvUserInfo_Click);
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUserInfo.Controls.Add(this.dgvUserInfo);
            this.pnlUserInfo.Location = new System.Drawing.Point(10, 93);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(551, 343);
            this.pnlUserInfo.TabIndex = 63;
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cboStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(413, 57);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(148, 24);
            this.cboStatus.TabIndex = 66;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(94, 54);
            this.txtUserName.MaxLength = 500;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(150, 23);
            this.txtUserName.TabIndex = 67;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // incLabel3
            // 
            this.incLabel3.AutoSize = true;
            this.incLabel3.BackColor = System.Drawing.Color.Red;
            this.incLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel3.Location = new System.Drawing.Point(328, 60);
            this.incLabel3.Name = "incLabel3";
            this.incLabel3.Readonly = false;
            this.incLabel3.Size = new System.Drawing.Size(79, 17);
            this.incLabel3.TabIndex = 68;
            this.incLabel3.Text = "New Status";
            this.incLabel3.ValueByOrchestrator = "New Status";
            // 
            // lblBurrowerName
            // 
            this.lblBurrowerName.AutoSize = true;
            this.lblBurrowerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBurrowerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBurrowerName.Location = new System.Drawing.Point(12, 57);
            this.lblBurrowerName.Name = "lblBurrowerName";
            this.lblBurrowerName.Readonly = false;
            this.lblBurrowerName.Size = new System.Drawing.Size(79, 17);
            this.lblBurrowerName.TabIndex = 69;
            this.lblBurrowerName.Text = "User Name";
            this.lblBurrowerName.ValueByOrchestrator = "User Name";
            // 
            // btnUpdateStaus
            // 
            this.btnUpdateStaus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnUpdateStaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStaus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdateStaus.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnUpdateStaus.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnUpdateStaus.Location = new System.Drawing.Point(87, 442);
            this.btnUpdateStaus.Name = "btnUpdateStaus";
            this.btnUpdateStaus.NextControl = null;
            this.btnUpdateStaus.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnUpdateStaus.PreviousControl = null;
            this.btnUpdateStaus.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnUpdateStaus.Size = new System.Drawing.Size(123, 32);
            this.btnUpdateStaus.TabIndex = 71;
            this.btnUpdateStaus.Text = "Change Status";
            this.btnUpdateStaus.Click += new System.EventHandler(this.btnUpdateStaus_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.txtUserId.ForeColor = System.Drawing.Color.White;
            this.txtUserId.Location = new System.Drawing.Point(256, 3);
            this.txtUserId.MaxLength = 500;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(70, 18);
            this.txtUserId.TabIndex = 65;
            this.txtUserId.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnClear.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClear.Location = new System.Drawing.Point(227, 442);
            this.btnClear.Name = "btnClear";
            this.btnClear.NextControl = null;
            this.btnClear.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnClear.PreviousControl = null;
            this.btnClear.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnClear.Size = new System.Drawing.Size(119, 32);
            this.btnClear.TabIndex = 71;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // erpGeneral
            // 
            this.erpGeneral.ContainerControl = this;
            // 
            // _CloseButton
            // 
            this._CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._CloseButton.DisplayText = "X";
            this._CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CloseButton.ForeColor = System.Drawing.Color.White;
            this._CloseButton.Location = new System.Drawing.Point(552, 0);
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
            // colUserName
            // 
            this.colUserName.HeaderText = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            this.colUserName.Width = 150;
            // 
            // colUsertype
            // 
            this.colUsertype.HeaderText = "User Type";
            this.colUsertype.Name = "colUsertype";
            this.colUsertype.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colPassword
            // 
            this.colPassword.HeaderText = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.ReadOnly = true;
            this.colPassword.Width = 150;
            // 
            // colPersonalDetailID
            // 
            this.colPersonalDetailID.HeaderText = "PersonalDetailID";
            this.colPersonalDetailID.Name = "colPersonalDetailID";
            this.colPersonalDetailID.ReadOnly = true;
            this.colPersonalDetailID.Visible = false;
            // 
            // colUserID
            // 
            this.colUserID.HeaderText = "UserID";
            this.colUserID.Name = "colUserID";
            this.colUserID.ReadOnly = true;
            this.colUserID.Visible = false;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(580, 486);
            this.ControlBox = false;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdateStaus);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.incLabel3);
            this.Controls.Add(this.lblBurrowerName);
            this.Controls.Add(this.pnlUserInfo);
            this.Controls.Add(this.pnlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmUserInfo_Load);
            this.pnlClose.ResumeLayout(false);
            this.pnlClose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).EndInit();
            this.pnlUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlClose;
        private ButtonZ _CloseButton;
        private System.Windows.Forms.DataGridView dgvUserInfo;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtUserName;
        private IncLibrary.IncLabel incLabel3;
        private IncLibrary.IncLabel lblBurrowerName;
        private IncLibrary.IncButton btnUpdateStaus;
        private System.Windows.Forms.TextBox txtUserId;
        private IncLibrary.IncButton btnClear;
        private System.Windows.Forms.ErrorProvider erpGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsertype;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonalDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
    }
}

