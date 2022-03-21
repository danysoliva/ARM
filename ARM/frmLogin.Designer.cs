namespace ARM
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtuser = new DevExpress.XtraEditors.TextEdit();
            this.txtpassword = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnMinim = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(86, -5);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(142, 77);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "ARM";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel5.Location = new System.Drawing.Point(-3, 76);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(766, 10);
            this.panel5.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(266, -5);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(432, 77);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "PRODUCCION";
            // 
            // txtuser
            // 
            this.txtuser.EditValue = "Usuario";
            this.txtuser.Location = new System.Drawing.Point(302, 148);
            this.txtuser.Name = "txtuser";
            this.txtuser.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.txtuser.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Properties.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.txtuser.Properties.Appearance.Options.UseBackColor = true;
            this.txtuser.Properties.Appearance.Options.UseFont = true;
            this.txtuser.Properties.Appearance.Options.UseForeColor = true;
            this.txtuser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtuser.Size = new System.Drawing.Size(406, 30);
            this.txtuser.TabIndex = 1;
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // txtpassword
            // 
            this.txtpassword.EditValue = "Contraseña";
            this.txtpassword.Location = new System.Drawing.Point(302, 210);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.txtpassword.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Properties.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.txtpassword.Properties.Appearance.Options.UseBackColor = true;
            this.txtpassword.Properties.Appearance.Options.UseFont = true;
            this.txtpassword.Properties.Appearance.Options.UseForeColor = true;
            this.txtpassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtpassword.Properties.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(406, 30);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.Enter += new System.EventHandler(this.txtpassword_Enter);
            this.txtpassword.Leave += new System.EventHandler(this.txtpassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnLogin.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.ForeColor = System.Drawing.Color.LightGray;
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseBorderColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Appearance.Options.UseForeColor = true;
            this.btnLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLogin.Location = new System.Drawing.Point(302, 275);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(406, 31);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "ACCEDER";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnMinim
            // 
            this.btnMinim.Image = global::ARM.Properties.Resources.Minimize_Icon;
            this.btnMinim.Location = new System.Drawing.Point(718, 2);
            this.btnMinim.Name = "btnMinim";
            this.btnMinim.Size = new System.Drawing.Size(18, 18);
            this.btnMinim.TabIndex = 18;
            this.btnMinim.TabStop = false;
            this.btnMinim.Click += new System.EventHandler(this.btnMinim_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::ARM.Properties.Resources.Close_Icon;
            this.btnClose.Location = new System.Drawing.Point(742, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.TabIndex = 16;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 112);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(763, 354);
            this.ControlBox = false;
            this.Controls.Add(this.btnMinim);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtuser;
        private DevExpress.XtraEditors.TextEdit txtpassword;
        private System.Windows.Forms.PictureBox btnClose;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private System.Windows.Forms.PictureBox btnMinim;
    }
}