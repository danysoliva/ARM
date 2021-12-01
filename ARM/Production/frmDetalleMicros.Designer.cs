namespace ARM.Production
{
    partial class frmDetalleMicros
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleMicros));
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsARM1 = new ARM.Production.dsARM();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPesoporBatch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBatchPlan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVerDetalle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsARM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Detalle de Orden";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_micros";
            this.gridControl1.DataSource = this.dsARM1;
            this.gridControl1.Location = new System.Drawing.Point(2, 51);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdVerDetalle});
            this.gridControl1.Size = new System.Drawing.Size(848, 439);
            this.gridControl1.TabIndex = 2;
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
            this.colMaterial,
            this.colPesoporBatch,
            this.colTotal,
            this.colBatchPlan,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMaterial
            // 
            this.colMaterial.FieldName = "Material";
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.OptionsColumn.AllowEdit = false;
            this.colMaterial.Visible = true;
            this.colMaterial.VisibleIndex = 0;
            // 
            // colPesoporBatch
            // 
            this.colPesoporBatch.FieldName = "Peso por Batch";
            this.colPesoporBatch.Name = "colPesoporBatch";
            this.colPesoporBatch.OptionsColumn.AllowEdit = false;
            this.colPesoporBatch.Visible = true;
            this.colPesoporBatch.VisibleIndex = 1;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 2;
            // 
            // colBatchPlan
            // 
            this.colBatchPlan.FieldName = "Batch Plan";
            this.colBatchPlan.Name = "colBatchPlan";
            this.colBatchPlan.OptionsColumn.AllowEdit = false;
            this.colBatchPlan.Visible = true;
            this.colBatchPlan.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Cant. Batch";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // cmdVerDetalle
            // 
            this.cmdVerDetalle.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdVerDetalle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.cmdVerDetalle.Name = "cmdVerDetalle";
            this.cmdVerDetalle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Image = global::ARM.Properties.Resources.cancel2_32;
            this.cmdCerrar.Location = new System.Drawing.Point(776, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(75, 45);
            this.cmdCerrar.TabIndex = 4;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmDetalleMicros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 496);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmDetalleMicros";
            this.Text = "Detalle Micros";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsARM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVerDetalle;
        private dsARM dsARM1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoporBatch;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colBatchPlan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Button cmdCerrar;
    }
}