namespace ARM.Reports
{
    partial class IntakeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntakeReport));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.btn_GenReport = new DevExpress.XtraBars.BarButtonItem();
            this.btn_exit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_bajarExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Imprimir = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cmb_Reportes = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_reports = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dt_hasta = new DevExpress.XtraEditors.DateEdit();
            this.dt_desde = new DevExpress.XtraEditors.DateEdit();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_material_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_material_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_material_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_intake_plan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_intake_real = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_intake_diff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dif = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reports.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_GenReport,
            this.cmb_Reportes,
            this.barStaticItem1,
            this.barHeaderItem1,
            this.btn_exit,
            this.btn_bajarExcel,
            this.btn_Imprimir});
            this.barManager1.MaxItemId = 8;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_GenReport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_exit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_bajarExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Imprimir)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Glyph = global::ARM.Properties.Resources.Logo_x32;
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Reporte de Consumos";
            this.barHeaderItem1.Id = 3;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // btn_GenReport
            // 
            this.btn_GenReport.Caption = "Generar Reporte";
            this.btn_GenReport.Glyph = global::ARM.Properties.Resources.refresh_32x32;
            this.btn_GenReport.Id = 0;
            this.btn_GenReport.Name = "btn_GenReport";
            this.btn_GenReport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_GenReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_GenReport_ItemClick);
            // 
            // btn_exit
            // 
            this.btn_exit.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_exit.Caption = "Salir";
            this.btn_exit.Glyph = global::ARM.Properties.Resources.Salir_32;
            this.btn_exit.Id = 4;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_exit_ItemClick);
            // 
            // btn_bajarExcel
            // 
            this.btn_bajarExcel.Caption = "Bajar Excel";
            this.btn_bajarExcel.Id = 5;
            this.btn_bajarExcel.Name = "btn_bajarExcel";
            this.btn_bajarExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btn_bajarExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_bajarExcel_ItemClick);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Caption = "Imprimir";
            this.btn_Imprimir.Glyph = global::ARM.Properties.Resources.print_32x32;
            this.btn_Imprimir.Id = 6;
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Imprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Imprimir_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(940, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 360);
            this.barDockControlBottom.Size = new System.Drawing.Size(940, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 313);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(940, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 313);
            // 
            // cmb_Reportes
            // 
            this.cmb_Reportes.Caption = "Reporte";
            this.cmb_Reportes.Edit = this.repositoryItemComboBox1;
            this.cmb_Reportes.EditWidth = 165;
            this.cmb_Reportes.Id = 1;
            this.cmb_Reportes.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Reportes.ItemAppearance.Normal.Options.UseFont = true;
            this.cmb_Reportes.Name = "cmb_Reportes";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemComboBox1.Appearance.Options.UseFont = true;
            this.repositoryItemComboBox1.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemComboBox1.AppearanceDropDown.Options.UseFont = true;
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "Resumen Materiales",
            "Resumen de Lotes",
            "Detalle Materiales",
            "Detalle de Lotes"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.cmb_reports);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.dt_hasta);
            this.groupControl1.Controls.Add(this.dt_desde);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 47);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(940, 82);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Parametros de Reporte";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl3.Location = new System.Drawing.Point(605, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Tipo Reporte";
            this.labelControl3.Visible = false;
            // 
            // cmb_reports
            // 
            this.cmb_reports.Location = new System.Drawing.Point(694, 39);
            this.cmb_reports.MenuManager = this.barManager1;
            this.cmb_reports.Name = "cmb_reports";
            this.cmb_reports.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reports.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_reports.Properties.Appearance.Options.UseFont = true;
            this.cmb_reports.Properties.Appearance.Options.UseForeColor = true;
            this.cmb_reports.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_reports.Size = new System.Drawing.Size(227, 22);
            this.cmb_reports.TabIndex = 5;
            this.cmb_reports.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl2.Location = new System.Drawing.Point(311, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Hasta";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl1.Location = new System.Drawing.Point(12, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Desde";
            // 
            // dt_hasta
            // 
            this.dt_hasta.EditValue = null;
            this.dt_hasta.Location = new System.Drawing.Point(357, 39);
            this.dt_hasta.MenuManager = this.barManager1;
            this.dt_hasta.Name = "dt_hasta";
            this.dt_hasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_hasta.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dt_hasta.Properties.Appearance.Options.UseFont = true;
            this.dt_hasta.Properties.Appearance.Options.UseForeColor = true;
            this.dt_hasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_hasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dt_hasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_hasta.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_hasta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_hasta.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_hasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_hasta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_hasta.Size = new System.Drawing.Size(215, 22);
            this.dt_hasta.TabIndex = 2;
            // 
            // dt_desde
            // 
            this.dt_desde.EditValue = null;
            this.dt_desde.Location = new System.Drawing.Point(58, 39);
            this.dt_desde.MenuManager = this.barManager1;
            this.dt_desde.Name = "dt_desde";
            this.dt_desde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_desde.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dt_desde.Properties.Appearance.Options.UseFont = true;
            this.dt_desde.Properties.Appearance.Options.UseForeColor = true;
            this.dt_desde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_desde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dt_desde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_desde.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_desde.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_desde.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_desde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_desde.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_desde.Size = new System.Drawing.Size(222, 22);
            this.dt_desde.TabIndex = 1;
            // 
            // grd_data
            // 
            this.grd_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_data.Location = new System.Drawing.Point(0, 129);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.MenuManager = this.barManager1;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(940, 231);
            this.grd_data.TabIndex = 5;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // grdv_data
            // 
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_material_id,
            this.col_material_code,
            this.col_material_name,
            this.col_intake_plan,
            this.col_intake_real,
            this.col_intake_diff,
            this.dif});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsMenu.EnableFooterMenu = false;
            this.grdv_data.OptionsPrint.RtfPageFooter = resources.GetString("grdv_data.OptionsPrint.RtfPageFooter");
            this.grdv_data.OptionsPrint.RtfReportHeader = resources.GetString("grdv_data.OptionsPrint.RtfReportHeader");
            this.grdv_data.OptionsView.ShowFooter = true;
            // 
            // col_material_id
            // 
            this.col_material_id.Caption = "Id";
            this.col_material_id.FieldName = "material_id";
            this.col_material_id.Name = "col_material_id";
            this.col_material_id.OptionsColumn.AllowEdit = false;
            this.col_material_id.Visible = true;
            this.col_material_id.VisibleIndex = 0;
            this.col_material_id.Width = 50;
            // 
            // col_material_code
            // 
            this.col_material_code.Caption = "Código";
            this.col_material_code.FieldName = "material_code";
            this.col_material_code.Name = "col_material_code";
            this.col_material_code.OptionsColumn.AllowEdit = false;
            this.col_material_code.Visible = true;
            this.col_material_code.VisibleIndex = 1;
            this.col_material_code.Width = 150;
            // 
            // col_material_name
            // 
            this.col_material_name.Caption = "Material";
            this.col_material_name.FieldName = "material_name";
            this.col_material_name.Name = "col_material_name";
            this.col_material_name.OptionsColumn.AllowEdit = false;
            this.col_material_name.Visible = true;
            this.col_material_name.VisibleIndex = 2;
            this.col_material_name.Width = 287;
            // 
            // col_intake_plan
            // 
            this.col_intake_plan.Caption = "Cons_Planeado";
            this.col_intake_plan.DisplayFormat.FormatString = "###,###,###.00 Kg";
            this.col_intake_plan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_intake_plan.FieldName = "intake_plan";
            this.col_intake_plan.Name = "col_intake_plan";
            this.col_intake_plan.OptionsColumn.AllowEdit = false;
            this.col_intake_plan.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "intake_plan", "{0:0.##}")});
            this.col_intake_plan.Visible = true;
            this.col_intake_plan.VisibleIndex = 3;
            this.col_intake_plan.Width = 130;
            // 
            // col_intake_real
            // 
            this.col_intake_real.Caption = "Cond_Real";
            this.col_intake_real.DisplayFormat.FormatString = "###,###,###.00 Kg";
            this.col_intake_real.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_intake_real.FieldName = "intake_real";
            this.col_intake_real.Name = "col_intake_real";
            this.col_intake_real.OptionsColumn.AllowEdit = false;
            this.col_intake_real.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "intake_real", "{0:0.##}")});
            this.col_intake_real.Visible = true;
            this.col_intake_real.VisibleIndex = 4;
            this.col_intake_real.Width = 130;
            // 
            // col_intake_diff
            // 
            this.col_intake_diff.Caption = "Diferencia";
            this.col_intake_diff.DisplayFormat.FormatString = "###,###,###.00 Kg";
            this.col_intake_diff.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_intake_diff.FieldName = "intake_diff";
            this.col_intake_diff.Name = "col_intake_diff";
            this.col_intake_diff.OptionsColumn.AllowEdit = false;
            this.col_intake_diff.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "intake_diff", "{0:0.##}")});
            this.col_intake_diff.Visible = true;
            this.col_intake_diff.VisibleIndex = 5;
            this.col_intake_diff.Width = 130;
            // 
            // dif
            // 
            this.dif.Caption = "% Dif";
            this.dif.DisplayFormat.FormatString = "p4";
            this.dif.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dif.FieldName = "dif";
            this.dif.Name = "dif";
            this.dif.Visible = true;
            this.dif.VisibleIndex = 6;
            // 
            // IntakeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 383);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IntakeReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Consumos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reports.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dt_desde;
        private DevExpress.XtraEditors.DateEdit dt_hasta;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarEditItem cmb_Reportes;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarButtonItem btn_GenReport;
        private DevExpress.XtraBars.BarButtonItem btn_exit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_reports;
        private DevExpress.XtraBars.BarButtonItem btn_bajarExcel;
        private DevExpress.XtraBars.BarButtonItem btn_Imprimir;
        private DevExpress.XtraGrid.Columns.GridColumn col_material_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_material_code;
        private DevExpress.XtraGrid.Columns.GridColumn col_material_name;
        private DevExpress.XtraGrid.Columns.GridColumn col_intake_plan;
        private DevExpress.XtraGrid.Columns.GridColumn col_intake_real;
        private DevExpress.XtraGrid.Columns.GridColumn col_intake_diff;
        private DevExpress.XtraGrid.Columns.GridColumn dif;
    }
}