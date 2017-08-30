namespace Library
{
    partial class frmChangePassword
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
            this.txtPasswordConform = new System.Windows.Forms.TextBox();
            this.incLabel3 = new IncLibrary.IncLabel();
            this.txtPasswordNew = new System.Windows.Forms.TextBox();
            this.incLabel2 = new IncLibrary.IncLabel();
            this.txtPasswordCurrent = new System.Windows.Forms.TextBox();
            this.incLabel1 = new IncLibrary.IncLabel();
            this.pnlConformPassword = new System.Windows.Forms.Panel();
            this.btnCancle = new IncLibrary.IncButton();
            this.btnSave = new IncLibrary.IncButton();
            this.incLabel4 = new IncLibrary.IncLabel();
            this.erpGeneral = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlClose = new System.Windows.Forms.Panel();
            this._CloseButton = new Library.ButtonZ();
            this.pnlConformPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpGeneral)).BeginInit();
            this.pnlClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPasswordConform
            // 
            this.txtPasswordConform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtPasswordConform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConform.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPasswordConform.Location = new System.Drawing.Point(177, 158);
            this.txtPasswordConform.MaxLength = 500;
            this.txtPasswordConform.Name = "txtPasswordConform";
            this.txtPasswordConform.PasswordChar = '*';
            this.txtPasswordConform.Size = new System.Drawing.Size(202, 26);
            this.txtPasswordConform.TabIndex = 2;
            // 
            // incLabel3
            // 
            this.incLabel3.AutoSize = true;
            this.incLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel3.Location = new System.Drawing.Point(45, 162);
            this.incLabel3.Name = "incLabel3";
            this.incLabel3.Readonly = false;
            this.incLabel3.Size = new System.Drawing.Size(126, 17);
            this.incLabel3.TabIndex = 29;
            this.incLabel3.Text = "Conform Password";
            this.incLabel3.ValueByOrchestrator = "Conform Password";
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtPasswordNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordNew.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPasswordNew.Location = new System.Drawing.Point(177, 95);
            this.txtPasswordNew.MaxLength = 500;
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.PasswordChar = '*';
            this.txtPasswordNew.Size = new System.Drawing.Size(202, 26);
            this.txtPasswordNew.TabIndex = 1;
            // 
            // incLabel2
            // 
            this.incLabel2.AutoSize = true;
            this.incLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel2.Location = new System.Drawing.Point(71, 99);
            this.incLabel2.Name = "incLabel2";
            this.incLabel2.Readonly = false;
            this.incLabel2.Size = new System.Drawing.Size(100, 17);
            this.incLabel2.TabIndex = 30;
            this.incLabel2.Text = "New Password";
            this.incLabel2.ValueByOrchestrator = "New Password";
            // 
            // txtPasswordCurrent
            // 
            this.txtPasswordCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtPasswordCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordCurrent.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPasswordCurrent.Location = new System.Drawing.Point(177, 32);
            this.txtPasswordCurrent.MaxLength = 500;
            this.txtPasswordCurrent.Name = "txtPasswordCurrent";
            this.txtPasswordCurrent.PasswordChar = '*';
            this.txtPasswordCurrent.Size = new System.Drawing.Size(202, 26);
            this.txtPasswordCurrent.TabIndex = 0;
            // 
            // incLabel1
            // 
            this.incLabel1.AutoSize = true;
            this.incLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel1.Location = new System.Drawing.Point(51, 36);
            this.incLabel1.Name = "incLabel1";
            this.incLabel1.Readonly = false;
            this.incLabel1.Size = new System.Drawing.Size(120, 17);
            this.incLabel1.TabIndex = 31;
            this.incLabel1.Text = "Current Password";
            this.incLabel1.ValueByOrchestrator = "Current Password";
            // 
            // pnlConformPassword
            // 
            this.pnlConformPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlConformPassword.Controls.Add(this.btnCancle);
            this.pnlConformPassword.Controls.Add(this.btnSave);
            this.pnlConformPassword.Controls.Add(this.incLabel1);
            this.pnlConformPassword.Controls.Add(this.txtPasswordConform);
            this.pnlConformPassword.Controls.Add(this.txtPasswordCurrent);
            this.pnlConformPassword.Controls.Add(this.incLabel3);
            this.pnlConformPassword.Controls.Add(this.incLabel2);
            this.pnlConformPassword.Controls.Add(this.txtPasswordNew);
            this.pnlConformPassword.Location = new System.Drawing.Point(36, 67);
            this.pnlConformPassword.Name = "pnlConformPassword";
            this.pnlConformPassword.Size = new System.Drawing.Size(460, 280);
            this.pnlConformPassword.TabIndex = 0;
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancle.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnCancle.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCancle.Location = new System.Drawing.Point(243, 219);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.NextControl = null;
            this.btnCancle.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnCancle.PreviousControl = null;
            this.btnCancle.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnCancle.Size = new System.Drawing.Size(98, 34);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnSave.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSave.Location = new System.Drawing.Point(111, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.NextControl = null;
            this.btnSave.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnSave.PreviousControl = null;
            this.btnSave.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnSave.Size = new System.Drawing.Size(98, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // incLabel4
            // 
            this.incLabel4.AutoSize = true;
            this.incLabel4.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            this.incLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel4.Location = new System.Drawing.Point(184, 38);
            this.incLabel4.Name = "incLabel4";
            this.incLabel4.Readonly = false;
            this.incLabel4.Size = new System.Drawing.Size(150, 26);
            this.incLabel4.TabIndex = 33;
            this.incLabel4.Text = "Change Password";
            this.incLabel4.ValueByOrchestrator = "Change Password";
            // 
            // erpGeneral
            // 
            this.erpGeneral.ContainerControl = this;
            // 
            // pnlClose
            // 
            this.pnlClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlClose.Controls.Add(this._CloseButton);
            this.pnlClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClose.Location = new System.Drawing.Point(0, 0);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(533, 25);
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
            this._CloseButton.Location = new System.Drawing.Point(505, 0);
            this._CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this._CloseButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this._CloseButton.Name = "_CloseButton";
            this._CloseButton.Size = new System.Drawing.Size(28, 25);
            this._CloseButton.TabIndex = 2;
            this._CloseButton.Text = "X";
            this._CloseButton.TextLocation_X = 6;
            this._CloseButton.TextLocation_Y = 1;
            this._CloseButton.UseVisualStyleBackColor = true;
            this._CloseButton.Click += new System.EventHandler(this._CloseButton_Click_1);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(533, 386);
            this.ControlBox = false;
            this.Controls.Add(this.pnlClose);
            this.Controls.Add(this.incLabel4);
            this.Controls.Add(this.pnlConformPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlConformPassword.ResumeLayout(false);
            this.pnlConformPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpGeneral)).EndInit();
            this.pnlClose.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPasswordConform;
        private IncLibrary.IncLabel incLabel3;
        private System.Windows.Forms.TextBox txtPasswordNew;
        private IncLibrary.IncLabel incLabel2;
        private System.Windows.Forms.TextBox txtPasswordCurrent;
        private IncLibrary.IncLabel incLabel1;
        private System.Windows.Forms.Panel pnlConformPassword;
        private IncLibrary.IncButton btnCancle;
        private IncLibrary.IncButton btnSave;
        private IncLibrary.IncLabel incLabel4;
        private System.Windows.Forms.ErrorProvider erpGeneral;
        private System.Windows.Forms.Panel pnlClose;
        private ButtonZ _CloseButton;
    }
}

