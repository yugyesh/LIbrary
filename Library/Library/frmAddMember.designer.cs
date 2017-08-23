namespace Library
{
    partial class frmAddMember
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.incLabel5 = new IncLibrary.IncLabel();
            this.incLabel6 = new IncLibrary.IncLabel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.incLabel2 = new IncLibrary.IncLabel();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.incLabel1 = new IncLibrary.IncLabel();
            this.incLabel3 = new IncLibrary.IncLabel();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.incLabel21 = new IncLibrary.IncLabel();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.incLabel23 = new IncLibrary.IncLabel();
            this.incLabel24 = new IncLibrary.IncLabel();
            this.btnSave = new IncLibrary.IncButton();
            this.incLabel7 = new IncLibrary.IncLabel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.incLabel8 = new IncLibrary.IncLabel();
            this.incLabel9 = new IncLibrary.IncLabel();
            this.grpContactInfo = new System.Windows.Forms.GroupBox();
            this.txtEmail = new IncLibrary.EmailTextbox();
            this.grpTeacher = new System.Windows.Forms.GroupBox();
            this.incLabel11 = new IncLibrary.IncLabel();
            this.txtMajorSubject = new System.Windows.Forms.TextBox();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.incLabel13 = new IncLibrary.IncLabel();
            this.incLabel14 = new IncLibrary.IncLabel();
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.incLabel15 = new IncLibrary.IncLabel();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.incLabel16 = new IncLibrary.IncLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordConform = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.incLabel17 = new IncLibrary.IncLabel();
            this.incLabel18 = new IncLibrary.IncLabel();
            this.incLabel19 = new IncLibrary.IncLabel();
            this.cboMemberType = new System.Windows.Forms.ComboBox();
            this.incLabel4 = new IncLibrary.IncLabel();
            this.picMember = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new IncLibrary.IncButton();
            this.fileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.erpGeneral = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvAllMember = new System.Windows.Forms.DataGridView();
            this.btnGet = new IncLibrary.IncButton();
            this.btnClear = new IncLibrary.IncButton();
            this._CloseButton = new Library.ButtonZ();
            this.colMemberType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajorSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlClose.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpStudent.SuspendLayout();
            this.grpContactInfo.SuspendLayout();
            this.grpTeacher.SuspendLayout();
            this.grpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMember)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClose
            // 
            this.pnlClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlClose.Controls.Add(this._CloseButton);
            this.pnlClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClose.Location = new System.Drawing.Point(0, 0);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(1361, 41);
            this.pnlClose.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.incLabel5);
            this.groupBox1.Controls.Add(this.incLabel6);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtMiddleName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.incLabel2);
            this.groupBox1.Controls.Add(this.cboGender);
            this.groupBox1.Controls.Add(this.cboStatus);
            this.groupBox1.Controls.Add(this.incLabel1);
            this.groupBox1.Controls.Add(this.incLabel3);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(4, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // incLabel5
            // 
            this.incLabel5.AutoSize = true;
            this.incLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel5.Location = new System.Drawing.Point(43, 300);
            this.incLabel5.Name = "incLabel5";
            this.incLabel5.Readonly = false;
            this.incLabel5.Size = new System.Drawing.Size(48, 17);
            this.incLabel5.TabIndex = 25;
            this.incLabel5.Text = "Status";
            this.incLabel5.ValueByOrchestrator = "Status";
            // 
            // incLabel6
            // 
            this.incLabel6.AutoSize = true;
            this.incLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel6.Location = new System.Drawing.Point(19, 188);
            this.incLabel6.Name = "incLabel6";
            this.incLabel6.Readonly = false;
            this.incLabel6.Size = new System.Drawing.Size(76, 17);
            this.incLabel6.TabIndex = 26;
            this.incLabel6.Text = "Last Name";
            this.incLabel6.ValueByOrchestrator = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLastName.Location = new System.Drawing.Point(109, 180);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(174, 26);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMiddleName.Location = new System.Drawing.Point(109, 123);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(174, 26);
            this.txtMiddleName.TabIndex = 1;
            this.txtMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.Location = new System.Drawing.Point(109, 66);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(174, 26);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // incLabel2
            // 
            this.incLabel2.AutoSize = true;
            this.incLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel2.Location = new System.Drawing.Point(37, 242);
            this.incLabel2.Name = "incLabel2";
            this.incLabel2.Readonly = false;
            this.incLabel2.Size = new System.Drawing.Size(56, 17);
            this.incLabel2.TabIndex = 23;
            this.incLabel2.Text = "Gender";
            this.incLabel2.ValueByOrchestrator = "Gender";
            // 
            // cboGender
            // 
            this.cboGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGender.ForeColor = System.Drawing.SystemColors.Window;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(109, 237);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(174, 26);
            this.cboGender.TabIndex = 3;
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(109, 296);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(174, 26);
            this.cboStatus.TabIndex = 4;
            // 
            // incLabel1
            // 
            this.incLabel1.AutoSize = true;
            this.incLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel1.Location = new System.Drawing.Point(5, 127);
            this.incLabel1.Name = "incLabel1";
            this.incLabel1.Readonly = false;
            this.incLabel1.Size = new System.Drawing.Size(90, 17);
            this.incLabel1.TabIndex = 23;
            this.incLabel1.Text = "Middle Name";
            this.incLabel1.ValueByOrchestrator = "Middle Name";
            // 
            // incLabel3
            // 
            this.incLabel3.AutoSize = true;
            this.incLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel3.Location = new System.Drawing.Point(19, 66);
            this.incLabel3.Name = "incLabel3";
            this.incLabel3.Readonly = false;
            this.incLabel3.Size = new System.Drawing.Size(76, 17);
            this.incLabel3.TabIndex = 23;
            this.incLabel3.Text = "First Name";
            this.incLabel3.ValueByOrchestrator = "First Name";
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.incLabel21);
            this.grpStudent.Controls.Add(this.txtSection);
            this.grpStudent.Controls.Add(this.txtStudentID);
            this.grpStudent.Controls.Add(this.cboClass);
            this.grpStudent.Controls.Add(this.incLabel23);
            this.grpStudent.Controls.Add(this.incLabel24);
            this.grpStudent.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            this.grpStudent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpStudent.Location = new System.Drawing.Point(420, 281);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(335, 337);
            this.grpStudent.TabIndex = 6;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student Information";
            this.grpStudent.Visible = false;
            // 
            // incLabel21
            // 
            this.incLabel21.AutoSize = true;
            this.incLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel21.Location = new System.Drawing.Point(46, 191);
            this.incLabel21.Name = "incLabel21";
            this.incLabel21.Readonly = false;
            this.incLabel21.Size = new System.Drawing.Size(42, 17);
            this.incLabel21.TabIndex = 26;
            this.incLabel21.Text = "Class";
            this.incLabel21.ValueByOrchestrator = "Class";
            // 
            // txtSection
            // 
            this.txtSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSection.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSection.Location = new System.Drawing.Point(109, 127);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(174, 26);
            this.txtSection.TabIndex = 1;
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtStudentID.Location = new System.Drawing.Point(109, 66);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(174, 26);
            this.txtStudentID.TabIndex = 0;
            // 
            // cboClass
            // 
            this.cboClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cboClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClass.ForeColor = System.Drawing.SystemColors.Window;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(109, 188);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(174, 26);
            this.cboClass.TabIndex = 2;
            // 
            // incLabel23
            // 
            this.incLabel23.AutoSize = true;
            this.incLabel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel23.Location = new System.Drawing.Point(33, 130);
            this.incLabel23.Name = "incLabel23";
            this.incLabel23.Readonly = false;
            this.incLabel23.Size = new System.Drawing.Size(55, 17);
            this.incLabel23.TabIndex = 23;
            this.incLabel23.Text = "Section";
            this.incLabel23.ValueByOrchestrator = "Section";
            // 
            // incLabel24
            // 
            this.incLabel24.AutoSize = true;
            this.incLabel24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel24.Location = new System.Drawing.Point(14, 69);
            this.incLabel24.Name = "incLabel24";
            this.incLabel24.Readonly = false;
            this.incLabel24.Size = new System.Drawing.Size(74, 17);
            this.incLabel24.TabIndex = 23;
            this.incLabel24.Text = "Student ID";
            this.incLabel24.ValueByOrchestrator = "Student ID";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnSave.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSave.Location = new System.Drawing.Point(1204, 577);
            this.btnSave.Name = "btnSave";
            this.btnSave.NextControl = null;
            this.btnSave.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnSave.PreviousControl = null;
            this.btnSave.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnSave.Size = new System.Drawing.Size(110, 39);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // incLabel7
            // 
            this.incLabel7.AutoSize = true;
            this.incLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel7.Location = new System.Drawing.Point(44, 154);
            this.incLabel7.Name = "incLabel7";
            this.incLabel7.Readonly = false;
            this.incLabel7.Size = new System.Drawing.Size(47, 17);
            this.incLabel7.TabIndex = 32;
            this.incLabel7.Text = "E-Mail";
            this.incLabel7.ValueByOrchestrator = "E-Mail";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPhone.Location = new System.Drawing.Point(125, 94);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(174, 26);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Location = new System.Drawing.Point(125, 44);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(174, 26);
            this.txtAddress.TabIndex = 0;
            // 
            // incLabel8
            // 
            this.incLabel8.AutoSize = true;
            this.incLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel8.Location = new System.Drawing.Point(46, 102);
            this.incLabel8.Name = "incLabel8";
            this.incLabel8.Readonly = false;
            this.incLabel8.Size = new System.Drawing.Size(49, 17);
            this.incLabel8.TabIndex = 30;
            this.incLabel8.Text = "Phone";
            this.incLabel8.ValueByOrchestrator = "Phone";
            // 
            // incLabel9
            // 
            this.incLabel9.AutoSize = true;
            this.incLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel9.Location = new System.Drawing.Point(35, 50);
            this.incLabel9.Name = "incLabel9";
            this.incLabel9.Readonly = false;
            this.incLabel9.Size = new System.Drawing.Size(60, 17);
            this.incLabel9.TabIndex = 31;
            this.incLabel9.Text = "Address";
            this.incLabel9.ValueByOrchestrator = "Address";
            // 
            // grpContactInfo
            // 
            this.grpContactInfo.Controls.Add(this.txtEmail);
            this.grpContactInfo.Controls.Add(this.incLabel9);
            this.grpContactInfo.Controls.Add(this.incLabel7);
            this.grpContactInfo.Controls.Add(this.incLabel8);
            this.grpContactInfo.Controls.Add(this.txtAddress);
            this.grpContactInfo.Controls.Add(this.txtPhone);
            this.grpContactInfo.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            this.grpContactInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpContactInfo.Location = new System.Drawing.Point(4, 423);
            this.grpContactInfo.Name = "grpContactInfo";
            this.grpContactInfo.Size = new System.Drawing.Size(365, 195);
            this.grpContactInfo.TabIndex = 1;
            this.grpContactInfo.TabStop = false;
            this.grpContactInfo.Text = "Contact Information";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(125, 144);
            this.txtEmail.Mandatory = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.NextControl = null;
            this.txtEmail.PreviousControl = null;
            this.txtEmail.ReadonlyByOrchestrator = false;
            this.txtEmail.Size = new System.Drawing.Size(174, 26);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Value_Orchestrator = "";
            // 
            // grpTeacher
            // 
            this.grpTeacher.Controls.Add(this.incLabel11);
            this.grpTeacher.Controls.Add(this.txtMajorSubject);
            this.grpTeacher.Controls.Add(this.txtTeacherID);
            this.grpTeacher.Controls.Add(this.cboDepartment);
            this.grpTeacher.Controls.Add(this.incLabel13);
            this.grpTeacher.Controls.Add(this.incLabel14);
            this.grpTeacher.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            this.grpTeacher.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpTeacher.Location = new System.Drawing.Point(420, 281);
            this.grpTeacher.Name = "grpTeacher";
            this.grpTeacher.Size = new System.Drawing.Size(335, 337);
            this.grpTeacher.TabIndex = 5;
            this.grpTeacher.TabStop = false;
            this.grpTeacher.Text = "Teacher Information";
            this.grpTeacher.Visible = false;
            // 
            // incLabel11
            // 
            this.incLabel11.AutoSize = true;
            this.incLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel11.Location = new System.Drawing.Point(19, 206);
            this.incLabel11.Name = "incLabel11";
            this.incLabel11.Readonly = false;
            this.incLabel11.Size = new System.Drawing.Size(82, 17);
            this.incLabel11.TabIndex = 26;
            this.incLabel11.Text = "Department";
            this.incLabel11.ValueByOrchestrator = "Department";
            // 
            // txtMajorSubject
            // 
            this.txtMajorSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtMajorSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMajorSubject.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMajorSubject.Location = new System.Drawing.Point(111, 142);
            this.txtMajorSubject.Name = "txtMajorSubject";
            this.txtMajorSubject.Size = new System.Drawing.Size(174, 26);
            this.txtMajorSubject.TabIndex = 1;
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtTeacherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTeacherID.Location = new System.Drawing.Point(111, 82);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.ReadOnly = true;
            this.txtTeacherID.Size = new System.Drawing.Size(174, 26);
            this.txtTeacherID.TabIndex = 0;
            // 
            // cboDepartment
            // 
            this.cboDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.SystemColors.Window;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(111, 202);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(174, 26);
            this.cboDepartment.TabIndex = 2;
            // 
            // incLabel13
            // 
            this.incLabel13.AutoSize = true;
            this.incLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel13.Location = new System.Drawing.Point(7, 145);
            this.incLabel13.Name = "incLabel13";
            this.incLabel13.Readonly = false;
            this.incLabel13.Size = new System.Drawing.Size(94, 17);
            this.incLabel13.TabIndex = 23;
            this.incLabel13.Text = "Major Subject";
            this.incLabel13.ValueByOrchestrator = "Major Subject";
            // 
            // incLabel14
            // 
            this.incLabel14.AutoSize = true;
            this.incLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel14.Location = new System.Drawing.Point(27, 84);
            this.incLabel14.Name = "incLabel14";
            this.incLabel14.Readonly = false;
            this.incLabel14.Size = new System.Drawing.Size(74, 17);
            this.incLabel14.TabIndex = 23;
            this.incLabel14.Text = "TeacherID";
            this.incLabel14.ValueByOrchestrator = "TeacherID";
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.incLabel15);
            this.grpUser.Controls.Add(this.cboRole);
            this.grpUser.Controls.Add(this.incLabel16);
            this.grpUser.Controls.Add(this.txtPassword);
            this.grpUser.Controls.Add(this.txtPasswordConform);
            this.grpUser.Controls.Add(this.txtUserName);
            this.grpUser.Controls.Add(this.txtUserID);
            this.grpUser.Controls.Add(this.incLabel17);
            this.grpUser.Controls.Add(this.incLabel18);
            this.grpUser.Controls.Add(this.incLabel19);
            this.grpUser.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            this.grpUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpUser.Location = new System.Drawing.Point(420, 281);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(335, 337);
            this.grpUser.TabIndex = 4;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "User Information";
            this.grpUser.Visible = false;
            // 
            // incLabel15
            // 
            this.incLabel15.AutoSize = true;
            this.incLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel15.Location = new System.Drawing.Point(83, 167);
            this.incLabel15.Name = "incLabel15";
            this.incLabel15.Readonly = false;
            this.incLabel15.Size = new System.Drawing.Size(37, 17);
            this.incLabel15.TabIndex = 28;
            this.incLabel15.Text = "Role";
            this.incLabel15.ValueByOrchestrator = "Role";
            // 
            // cboRole
            // 
            this.cboRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cboRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRole.ForeColor = System.Drawing.SystemColors.Window;
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(135, 165);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(174, 26);
            this.cboRole.TabIndex = 2;
            // 
            // incLabel16
            // 
            this.incLabel16.AutoSize = true;
            this.incLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel16.Location = new System.Drawing.Point(51, 219);
            this.incLabel16.Name = "incLabel16";
            this.incLabel16.Readonly = false;
            this.incLabel16.Size = new System.Drawing.Size(69, 17);
            this.incLabel16.TabIndex = 26;
            this.incLabel16.Text = "Password";
            this.incLabel16.ValueByOrchestrator = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Location = new System.Drawing.Point(135, 216);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(174, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // txtPasswordConform
            // 
            this.txtPasswordConform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtPasswordConform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConform.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPasswordConform.Location = new System.Drawing.Point(135, 267);
            this.txtPasswordConform.Name = "txtPasswordConform";
            this.txtPasswordConform.PasswordChar = '*';
            this.txtPasswordConform.Size = new System.Drawing.Size(174, 26);
            this.txtPasswordConform.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUserName.Location = new System.Drawing.Point(135, 114);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(174, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUserID.Location = new System.Drawing.Point(135, 63);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(174, 26);
            this.txtUserID.TabIndex = 0;
            // 
            // incLabel17
            // 
            this.incLabel17.AutoSize = true;
            this.incLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel17.Location = new System.Drawing.Point(6, 271);
            this.incLabel17.Name = "incLabel17";
            this.incLabel17.Readonly = false;
            this.incLabel17.Size = new System.Drawing.Size(118, 17);
            this.incLabel17.TabIndex = 23;
            this.incLabel17.Text = "Retype Password";
            this.incLabel17.ValueByOrchestrator = "Retype Password";
            // 
            // incLabel18
            // 
            this.incLabel18.AutoSize = true;
            this.incLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel18.Location = new System.Drawing.Point(41, 115);
            this.incLabel18.Name = "incLabel18";
            this.incLabel18.Readonly = false;
            this.incLabel18.Size = new System.Drawing.Size(79, 17);
            this.incLabel18.TabIndex = 23;
            this.incLabel18.Text = "User Name";
            this.incLabel18.ValueByOrchestrator = "User Name";
            // 
            // incLabel19
            // 
            this.incLabel19.AutoSize = true;
            this.incLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel19.Location = new System.Drawing.Point(69, 63);
            this.incLabel19.Name = "incLabel19";
            this.incLabel19.Readonly = false;
            this.incLabel19.Size = new System.Drawing.Size(51, 17);
            this.incLabel19.TabIndex = 23;
            this.incLabel19.Text = "UserID";
            this.incLabel19.ValueByOrchestrator = "UserID";
            // 
            // cboMemberType
            // 
            this.cboMemberType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cboMemberType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMemberType.ForeColor = System.Drawing.SystemColors.Window;
            this.cboMemberType.FormattingEnabled = true;
            this.cboMemberType.Location = new System.Drawing.Point(518, 58);
            this.cboMemberType.Name = "cboMemberType";
            this.cboMemberType.Size = new System.Drawing.Size(174, 25);
            this.cboMemberType.TabIndex = 2;
            this.cboMemberType.SelectedIndexChanged += new System.EventHandler(this.cboMemberType_SelectedIndexChanged);
            // 
            // incLabel4
            // 
            this.incLabel4.AutoSize = true;
            this.incLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel4.Location = new System.Drawing.Point(417, 60);
            this.incLabel4.Name = "incLabel4";
            this.incLabel4.Readonly = false;
            this.incLabel4.Size = new System.Drawing.Size(95, 17);
            this.incLabel4.TabIndex = 37;
            this.incLabel4.Text = "Member Type";
            this.incLabel4.ValueByOrchestrator = "Member Type";
            // 
            // picMember
            // 
            this.picMember.Location = new System.Drawing.Point(526, 109);
            this.picMember.Name = "picMember";
            this.picMember.Size = new System.Drawing.Size(131, 126);
            this.picMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMember.TabIndex = 38;
            this.picMember.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBrowse.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnBrowse.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnBrowse.Location = new System.Drawing.Point(523, 243);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.NextControl = null;
            this.btnBrowse.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnBrowse.PreviousControl = null;
            this.btnBrowse.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnBrowse.Size = new System.Drawing.Size(134, 25);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // erpGeneral
            // 
            this.erpGeneral.ContainerControl = this;
            // 
            // dgvAllMember
            // 
            this.dgvAllMember.AllowUserToAddRows = false;
            this.dgvAllMember.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvAllMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMemberType,
            this.colFirstName,
            this.colMiddleName,
            this.colLastName,
            this.colGenderID,
            this.colStatusID,
            this.colAddress,
            this.colPhone,
            this.colEmail,
            this.colUserID,
            this.colUserName,
            this.colPassword,
            this.colRoleID,
            this.colMajorSubject,
            this.colDepartmentID,
            this.colClassID,
            this.colSectionName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllMember.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllMember.EnableHeadersVisualStyles = false;
            this.dgvAllMember.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvAllMember.Location = new System.Drawing.Point(817, 58);
            this.dgvAllMember.Name = "dgvAllMember";
            this.dgvAllMember.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllMember.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllMember.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvAllMember.Size = new System.Drawing.Size(532, 484);
            this.dgvAllMember.TabIndex = 39;
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGet.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnGet.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGet.Location = new System.Drawing.Point(1088, 579);
            this.btnGet.Name = "btnGet";
            this.btnGet.NextControl = null;
            this.btnGet.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnGet.PreviousControl = null;
            this.btnGet.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnGet.Size = new System.Drawing.Size(110, 39);
            this.btnGet.TabIndex = 7;
            this.btnGet.Text = "Get";
            this.btnGet.Click += new System.EventHandler(this.btnGetAllMember_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnClear.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClear.Location = new System.Drawing.Point(959, 577);
            this.btnClear.Name = "btnClear";
            this.btnClear.NextControl = null;
            this.btnClear.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnClear.PreviousControl = null;
            this.btnClear.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnClear.Size = new System.Drawing.Size(110, 39);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // _CloseButton
            // 
            this._CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._CloseButton.DisplayText = "X";
            this._CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CloseButton.ForeColor = System.Drawing.Color.White;
            this._CloseButton.Location = new System.Drawing.Point(1324, 6);
            this._CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this._CloseButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this._CloseButton.Name = "_CloseButton";
            this._CloseButton.Size = new System.Drawing.Size(31, 27);
            this._CloseButton.TabIndex = 1;
            this._CloseButton.Text = "X";
            this._CloseButton.TextLocation_X = 6;
            this._CloseButton.TextLocation_Y = 1;
            this._CloseButton.UseVisualStyleBackColor = true;
            this._CloseButton.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // colMemberType
            // 
            this.colMemberType.HeaderText = "MemberType";
            this.colMemberType.Name = "colMemberType";
            this.colMemberType.ReadOnly = true;
            // 
            // colFirstName
            // 
            this.colFirstName.HeaderText = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            this.colFirstName.Visible = false;
            // 
            // colMiddleName
            // 
            this.colMiddleName.HeaderText = "MiddleName";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.ReadOnly = true;
            this.colMiddleName.Visible = false;
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.Visible = false;
            // 
            // colGenderID
            // 
            this.colGenderID.HeaderText = "GenderID";
            this.colGenderID.Name = "colGenderID";
            this.colGenderID.ReadOnly = true;
            this.colGenderID.Visible = false;
            // 
            // colStatusID
            // 
            this.colStatusID.HeaderText = "StatusID";
            this.colStatusID.Name = "colStatusID";
            this.colStatusID.ReadOnly = true;
            this.colStatusID.Visible = false;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Visible = false;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.Visible = false;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Visible = false;
            // 
            // colUserID
            // 
            this.colUserID.HeaderText = "UserID";
            this.colUserID.Name = "colUserID";
            this.colUserID.ReadOnly = true;
            this.colUserID.Visible = false;
            // 
            // colUserName
            // 
            this.colUserName.HeaderText = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            this.colUserName.Visible = false;
            // 
            // colPassword
            // 
            this.colPassword.HeaderText = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.ReadOnly = true;
            this.colPassword.Visible = false;
            // 
            // colRoleID
            // 
            this.colRoleID.HeaderText = "Role";
            this.colRoleID.Name = "colRoleID";
            this.colRoleID.ReadOnly = true;
            this.colRoleID.Visible = false;
            // 
            // colMajorSubject
            // 
            this.colMajorSubject.HeaderText = "Major Subject";
            this.colMajorSubject.Name = "colMajorSubject";
            this.colMajorSubject.ReadOnly = true;
            this.colMajorSubject.Visible = false;
            // 
            // colDepartmentID
            // 
            this.colDepartmentID.HeaderText = "DepartmentID";
            this.colDepartmentID.Name = "colDepartmentID";
            this.colDepartmentID.ReadOnly = true;
            this.colDepartmentID.Visible = false;
            // 
            // colClassID
            // 
            this.colClassID.HeaderText = "Class ID";
            this.colClassID.Name = "colClassID";
            this.colClassID.ReadOnly = true;
            this.colClassID.Visible = false;
            // 
            // colSectionName
            // 
            this.colSectionName.HeaderText = "Section Name";
            this.colSectionName.Name = "colSectionName";
            this.colSectionName.ReadOnly = true;
            this.colSectionName.Visible = false;
            // 
            // frmAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1361, 630);
            this.ControlBox = false;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvAllMember);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picMember);
            this.Controls.Add(this.grpStudent);
            this.Controls.Add(this.incLabel4);
            this.Controls.Add(this.cboMemberType);
            this.Controls.Add(this.grpTeacher);
            this.Controls.Add(this.grpContactInfo);
            this.Controls.Add(this.grpUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlClose);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmAddMember_Load);
            this.pnlClose.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.grpContactInfo.ResumeLayout(false);
            this.grpContactInfo.PerformLayout();
            this.grpTeacher.ResumeLayout(false);
            this.grpTeacher.PerformLayout();
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonZ _CloseButton;
        private System.Windows.Forms.Panel pnlClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private IncLibrary.IncLabel incLabel5;
        private IncLibrary.IncLabel incLabel6;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private IncLibrary.IncLabel incLabel2;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboStatus;
        private IncLibrary.IncLabel incLabel1;
        private IncLibrary.IncButton btnSave;
        private IncLibrary.IncLabel incLabel3;
        private IncLibrary.IncLabel incLabel7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private IncLibrary.IncLabel incLabel8;
        private IncLibrary.IncLabel incLabel9;
        private System.Windows.Forms.GroupBox grpContactInfo;
        private IncLibrary.EmailTextbox txtEmail;
        private System.Windows.Forms.GroupBox grpStudent;
        private IncLibrary.IncLabel incLabel21;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.ComboBox cboClass;
        private IncLibrary.IncLabel incLabel23;
        private IncLibrary.IncLabel incLabel24;
        private System.Windows.Forms.GroupBox grpTeacher;
        private IncLibrary.IncLabel incLabel11;
        private System.Windows.Forms.TextBox txtMajorSubject;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.ComboBox cboDepartment;
        private IncLibrary.IncLabel incLabel13;
        private IncLibrary.IncLabel incLabel14;
        private System.Windows.Forms.GroupBox grpUser;
        private IncLibrary.IncLabel incLabel16;
        private System.Windows.Forms.TextBox txtPasswordConform;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserID;
        private IncLibrary.IncLabel incLabel17;
        private IncLibrary.IncLabel incLabel18;
        private IncLibrary.IncLabel incLabel19;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cboMemberType;
        private IncLibrary.IncLabel incLabel4;
        private System.Windows.Forms.PictureBox picMember;
        private IncLibrary.IncButton btnBrowse;
        private System.Windows.Forms.OpenFileDialog fileDialogPhoto;
        private IncLibrary.IncLabel incLabel15;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.ErrorProvider erpGeneral;
        private System.Windows.Forms.DataGridView dgvAllMember;
        private IncLibrary.IncButton btnGet;
        private IncLibrary.IncButton btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajorSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionName;
    }
}

