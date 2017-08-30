namespace Library
{
    partial class frmSearchBooks
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
            this.pnlClose = new System.Windows.Forms.Panel();
            this._CloseButton = new Library.ButtonZ();
            this.radBurrowed = new System.Windows.Forms.RadioButton();
            this.radLost = new System.Windows.Forms.RadioButton();
            this.radAvailable = new System.Windows.Forms.RadioButton();
            this.pnlRadio = new System.Windows.Forms.Panel();
            this.pnlClose.SuspendLayout();
            this.pnlRadio.SuspendLayout();
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
            // radBurrowed
            // 
            this.radBurrowed.AutoSize = true;
            this.radBurrowed.Location = new System.Drawing.Point(261, 16);
            this.radBurrowed.Name = "radBurrowed";
            this.radBurrowed.Size = new System.Drawing.Size(70, 17);
            this.radBurrowed.TabIndex = 62;
            this.radBurrowed.TabStop = true;
            this.radBurrowed.Text = "Burrowed";
            this.radBurrowed.UseVisualStyleBackColor = true;
            // 
            // radLost
            // 
            this.radLost.AutoSize = true;
            this.radLost.Location = new System.Drawing.Point(468, 16);
            this.radLost.Name = "radLost";
            this.radLost.Size = new System.Drawing.Size(45, 17);
            this.radLost.TabIndex = 63;
            this.radLost.TabStop = true;
            this.radLost.Text = "Lost";
            this.radLost.UseVisualStyleBackColor = true;
            // 
            // radAvailable
            // 
            this.radAvailable.AutoSize = true;
            this.radAvailable.Location = new System.Drawing.Point(83, 16);
            this.radAvailable.Name = "radAvailable";
            this.radAvailable.Size = new System.Drawing.Size(68, 17);
            this.radAvailable.TabIndex = 64;
            this.radAvailable.TabStop = true;
            this.radAvailable.Text = "Available";
            this.radAvailable.UseVisualStyleBackColor = true;
            // 
            // pnlRadio
            // 
            this.pnlRadio.Controls.Add(this.radLost);
            this.pnlRadio.Controls.Add(this.radAvailable);
            this.pnlRadio.Controls.Add(this.radBurrowed);
            this.pnlRadio.Location = new System.Drawing.Point(141, 31);
            this.pnlRadio.Name = "pnlRadio";
            this.pnlRadio.Size = new System.Drawing.Size(621, 50);
            this.pnlRadio.TabIndex = 65;
            // 
            // frmSearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1361, 609);
            this.ControlBox = false;
            this.Controls.Add(this.pnlRadio);
            this.Controls.Add(this.pnlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlClose.ResumeLayout(false);
            this.pnlRadio.ResumeLayout(false);
            this.pnlRadio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClose;
        private ButtonZ _CloseButton;
        private System.Windows.Forms.RadioButton radBurrowed;
        private System.Windows.Forms.RadioButton radLost;
        private System.Windows.Forms.RadioButton radAvailable;
        private System.Windows.Forms.Panel pnlRadio;
    }
}

