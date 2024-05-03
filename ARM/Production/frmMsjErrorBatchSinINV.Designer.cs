
using DevExpress.XtraEditors;

namespace ARM.Production
{
    partial class frmMsjErrorBatchSinINV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMsjErrorBatchSinINV));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblMateriaPrimaNombre = new DevExpress.XtraEditors.LabelControl();
            this.lblInventarioActual = new DevExpress.XtraEditors.LabelControl();
            this.lblCantidadRequerida = new DevExpress.XtraEditors.LabelControl();
            this.lblCantidadPorBatch = new DevExpress.XtraEditors.LabelControl();
            this.lblBatchPermitidos = new DevExpress.XtraEditors.LabelControl();
            this.cmdConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(160, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(221, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Validacion de Cantidad de Batch";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Materia Prima:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(125, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Inventario Actual BG018:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 105);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(137, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Ultima cantidad requerida:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 161);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(88, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Batch Permitidos:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 134);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(102, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Cantidad por Batch:";
            // 
            // lblMateriaPrimaNombre
            // 
            this.lblMateriaPrimaNombre.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriaPrimaNombre.Appearance.Options.UseFont = true;
            this.lblMateriaPrimaNombre.Location = new System.Drawing.Point(167, 47);
            this.lblMateriaPrimaNombre.Name = "lblMateriaPrimaNombre";
            this.lblMateriaPrimaNombre.Size = new System.Drawing.Size(114, 13);
            this.lblMateriaPrimaNombre.TabIndex = 6;
            this.lblMateriaPrimaNombre.Text = "Materia Prima Nombre";
            // 
            // lblInventarioActual
            // 
            this.lblInventarioActual.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventarioActual.Appearance.Options.UseFont = true;
            this.lblInventarioActual.Location = new System.Drawing.Point(167, 76);
            this.lblInventarioActual.Name = "lblInventarioActual";
            this.lblInventarioActual.Size = new System.Drawing.Size(114, 13);
            this.lblInventarioActual.TabIndex = 7;
            this.lblInventarioActual.Text = "Materia Prima Nombre";
            // 
            // lblCantidadRequerida
            // 
            this.lblCantidadRequerida.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadRequerida.Appearance.Options.UseFont = true;
            this.lblCantidadRequerida.Location = new System.Drawing.Point(167, 105);
            this.lblCantidadRequerida.Name = "lblCantidadRequerida";
            this.lblCantidadRequerida.Size = new System.Drawing.Size(114, 13);
            this.lblCantidadRequerida.TabIndex = 8;
            this.lblCantidadRequerida.Text = "Materia Prima Nombre";
            // 
            // lblCantidadPorBatch
            // 
            this.lblCantidadPorBatch.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPorBatch.Appearance.Options.UseFont = true;
            this.lblCantidadPorBatch.Location = new System.Drawing.Point(167, 134);
            this.lblCantidadPorBatch.Name = "lblCantidadPorBatch";
            this.lblCantidadPorBatch.Size = new System.Drawing.Size(114, 13);
            this.lblCantidadPorBatch.TabIndex = 9;
            this.lblCantidadPorBatch.Text = "Materia Prima Nombre";
            // 
            // lblBatchPermitidos
            // 
            this.lblBatchPermitidos.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchPermitidos.Appearance.Options.UseFont = true;
            this.lblBatchPermitidos.Location = new System.Drawing.Point(167, 159);
            this.lblBatchPermitidos.Name = "lblBatchPermitidos";
            this.lblBatchPermitidos.Size = new System.Drawing.Size(121, 15);
            this.lblBatchPermitidos.TabIndex = 10;
            this.lblBatchPermitidos.Text = "Materia Prima Nombre";
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cmdConfirmar.Appearance.Options.UseFont = true;
            this.cmdConfirmar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdConfirmar.ImageOptions.SvgImage")));
            this.cmdConfirmar.Location = new System.Drawing.Point(107, 186);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(163, 43);
            this.cmdConfirmar.TabIndex = 11;
            this.cmdConfirmar.Text = "Aplicar Batch";
            this.cmdConfirmar.Click += new System.EventHandler(this.cmdConfirmar_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.cmdCerrar.Location = new System.Drawing.Point(276, 187);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(163, 43);
            this.cmdCerrar.TabIndex = 12;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmMsjErrorBatchSinINV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 236);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdConfirmar);
            this.Controls.Add(this.lblBatchPermitidos);
            this.Controls.Add(this.lblCantidadPorBatch);
            this.Controls.Add(this.lblCantidadRequerida);
            this.Controls.Add(this.lblInventarioActual);
            this.Controls.Add(this.lblMateriaPrimaNombre);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmMsjErrorBatchSinINV";
            this.Text = "Mensaje de Validación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private LabelControl labelControl5;
        private LabelControl labelControl6;
        private LabelControl lblMateriaPrimaNombre;
        private LabelControl lblInventarioActual;
        private LabelControl lblCantidadRequerida;
        private LabelControl lblCantidadPorBatch;
        private LabelControl lblBatchPermitidos;
        private SimpleButton cmdConfirmar;
        private SimpleButton cmdCerrar;
    }
}