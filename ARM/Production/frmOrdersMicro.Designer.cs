namespace ARM.Production
{
    partial class frmOrdersMicro
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdersMicro));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsARM1 = new ARM.Production.dsARM();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLotePT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVerDetalle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsARM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "ordenh";
            this.gridControl1.DataSource = this.dsARM1;
            this.gridControl1.Location = new System.Drawing.Point(-1, 54);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdVerDetalle});
            this.gridControl1.Size = new System.Drawing.Size(755, 415);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsARM1
            // 
            this.dsARM1.DataSetName = "dsARM";
            this.dsARM1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.gridColumn1,
            this.colCodigoOrden,
            this.colFecha,
            this.colLotePT,
            this.gridColumn2,
            this.gridColumn3,
            this.colestado,
            this.colVerDetalle});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "# Orden";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // colCodigoOrden
            // 
            this.colCodigoOrden.FieldName = "Codigo Orden";
            this.colCodigoOrden.Name = "colCodigoOrden";
            this.colCodigoOrden.OptionsColumn.AllowEdit = false;
            this.colCodigoOrden.Visible = true;
            this.colCodigoOrden.VisibleIndex = 2;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 3;
            // 
            // colLotePT
            // 
            this.colLotePT.FieldName = "Lote PT";
            this.colLotePT.Name = "colLotePT";
            this.colLotePT.OptionsColumn.AllowEdit = false;
            this.colLotePT.Visible = true;
            this.colLotePT.VisibleIndex = 4;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Cant. Batch";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "Cod. Estado";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 7;
            // 
            // colVerDetalle
            // 
            this.colVerDetalle.Caption = "Ver Detalle";
            this.colVerDetalle.ColumnEdit = this.cmdVerDetalle;
            this.colVerDetalle.Name = "colVerDetalle";
            this.colVerDetalle.Visible = true;
            this.colVerDetalle.VisibleIndex = 8;
            // 
            // cmdVerDetalle
            // 
            this.cmdVerDetalle.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdVerDetalle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.cmdVerDetalle.Name = "cmdVerDetalle";
            this.cmdVerDetalle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdVerDetalle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdVerDetalle_ButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalle de Micro Ingredientes Manuales por Orden de Producción";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Image = global::ARM.Properties.Resources.cancel2_32;
            this.cmdCerrar.Location = new System.Drawing.Point(679, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(75, 45);
            this.cmdCerrar.TabIndex = 2;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmOrdersMicro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 467);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmOrdersMicro";
            this.Text = "Micro Ingredientes Manuales";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsARM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private dsARM dsARM1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoOrden;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colLotePT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colVerDetalle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVerDetalle;
        private System.Windows.Forms.Button cmdCerrar;
    }
}