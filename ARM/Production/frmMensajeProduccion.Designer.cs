
namespace ARM.Production
{
    partial class frmMensajeProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMensajeProduccion));
            this.msjBoxIcon = new System.Windows.Forms.PictureBox();
            this.cmdAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.msjBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // msjBoxIcon
            // 
            this.msjBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("msjBoxIcon.Image")));
            this.msjBoxIcon.Location = new System.Drawing.Point(12, 146);
            this.msjBoxIcon.Name = "msjBoxIcon";
            this.msjBoxIcon.Size = new System.Drawing.Size(147, 141);
            this.msjBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.msjBoxIcon.TabIndex = 9;
            this.msjBoxIcon.TabStop = false;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAceptar.Appearance.Options.UseFont = true;
            this.cmdAceptar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAceptar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAceptar.ImageOptions.Image")));
            this.cmdAceptar.Location = new System.Drawing.Point(251, 209);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(221, 81);
            this.cmdAceptar.TabIndex = 10;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(692, 91);
            this.labelControl1.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Interval = 2800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(12, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(692, 41);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "**BLOQUEO**";
            // 
            // frmMensajeProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 304);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.msjBoxIcon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMensajeProduccion";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.msjBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox msjBoxIcon;
        private DevExpress.XtraEditors.SimpleButton cmdAceptar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}