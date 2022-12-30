namespace ARM
{
    partial class Main_Form
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ARM.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_formulas = new DevExpress.XtraBars.BarButtonItem();
            this.btn_plan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.sub_formulas = new DevExpress.XtraBars.BarSubItem();
            this.btn_planProd = new DevExpress.XtraBars.BarButtonItem();
            this.btn_aqua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_agri = new DevExpress.XtraBars.BarButtonItem();
            this.btn_plc_test = new DevExpress.XtraBars.BarButtonItem();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.sub_planProduccion = new DevExpress.XtraBars.BarSubItem();
            this.btn_ProductionOrders = new DevExpress.XtraBars.BarButtonItem();
            this.sub_Mantos = new DevExpress.XtraBars.BarSubItem();
            this.btn_BinMaintenance = new DevExpress.XtraBars.BarButtonItem();
            this.btn_AllowedMaterials = new DevExpress.XtraBars.BarButtonItem();
            this.sub_reportes = new DevExpress.XtraBars.BarSubItem();
            this.btn_BatchReport = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ShiftReport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.rd_menu = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rd_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_formulas,
            this.btn_plan,
            this.barButtonItem1,
            this.barButtonItem2,
            this.sub_formulas,
            this.btn_planProd,
            this.btn_aqua,
            this.btn_agri,
            this.btn_plc_test,
            this.barLargeButtonItem1,
            this.barButtonItem3,
            this.barButtonItem4,
            this.sub_planProduccion,
            this.sub_Mantos,
            this.sub_reportes,
            this.btn_ProductionOrders,
            this.btn_BinMaintenance,
            this.btn_AllowedMaterials,
            this.btn_BatchReport,
            this.btn_ShiftReport,
            this.barButtonItem5});
            this.barManager1.MaxItemId = 21;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(566, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 239);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(566, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 239);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(566, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 239);
            // 
            // btn_formulas
            // 
            this.rd_menu.SetAutoSize(this.btn_formulas, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.btn_formulas.Caption = "Formulas";
            this.btn_formulas.Id = 0;
            this.btn_formulas.Name = "btn_formulas";
            // 
            // btn_plan
            // 
            this.rd_menu.SetAutoSize(this.btn_plan, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.btn_plan.Caption = "Plan";
            this.btn_plan.Id = 1;
            this.btn_plan.Name = "btn_plan";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // sub_formulas
            // 
            this.rd_menu.SetAutoSize(this.sub_formulas, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.sub_formulas.Caption = "Formulas";
            this.sub_formulas.Id = 4;
            this.sub_formulas.ImageOptions.Image = global::ARM.Properties.Resources.formula_x64;
            this.sub_formulas.Name = "sub_formulas";
            this.sub_formulas.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_planProd
            // 
            this.rd_menu.SetAutoSize(this.btn_planProd, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.btn_planProd.Caption = "Plan Producción";
            this.btn_planProd.Id = 5;
            this.btn_planProd.ImageOptions.Image = global::ARM.Properties.Resources.factory_x64;
            this.btn_planProd.Name = "btn_planProd";
            // 
            // btn_aqua
            // 
            this.rd_menu.SetAutoSize(this.btn_aqua, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.btn_aqua.Caption = "División Aqua";
            this.btn_aqua.Id = 6;
            this.btn_aqua.ImageOptions.Image = global::ARM.Properties.Resources.LogoAqua_x64;
            this.btn_aqua.Name = "btn_aqua";
            this.btn_aqua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_aqua_ItemClick);
            // 
            // btn_agri
            // 
            this.rd_menu.SetAutoSize(this.btn_agri, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.btn_agri.Caption = "División Agri";
            this.btn_agri.Id = 7;
            this.btn_agri.Name = "btn_agri";
            // 
            // btn_plc_test
            // 
            this.rd_menu.SetAutoSize(this.btn_plc_test, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.btn_plc_test.Caption = "PLC Comunication Test";
            this.btn_plc_test.Id = 8;
            this.btn_plc_test.ImageOptions.Image = global::ARM.Properties.Resources.circuit_on_64;
            this.btn_plc_test.Name = "btn_plc_test";
            this.btn_plc_test.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_plc_test_ItemClick);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "barLargeButtonItem1";
            this.barLargeButtonItem1.Id = 9;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barButtonItem3
            // 
            this.rd_menu.SetAutoSize(this.barButtonItem3, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.barButtonItem3.Caption = "Plan de Producción";
            this.barButtonItem3.Id = 10;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.rd_menu.SetAutoSize(this.barButtonItem4, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.barButtonItem4.Caption = "Mantenimientos";
            this.barButtonItem4.Id = 11;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // sub_planProduccion
            // 
            this.rd_menu.SetAutoSize(this.sub_planProduccion, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.sub_planProduccion.Caption = "Plan de Producción";
            this.sub_planProduccion.Id = 12;
            this.sub_planProduccion.ImageOptions.Image = global::ARM.Properties.Resources.factory_x64;
            this.sub_planProduccion.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ProductionOrders)});
            this.sub_planProduccion.Name = "sub_planProduccion";
            this.sub_planProduccion.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.sub_planProduccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btn_ProductionOrders
            // 
            this.rd_menu.SetAutoSize(this.btn_ProductionOrders, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.btn_ProductionOrders.Caption = "Ordenes de Producción";
            this.btn_ProductionOrders.Id = 15;
            this.btn_ProductionOrders.Name = "btn_ProductionOrders";
            this.btn_ProductionOrders.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ProductionOrders_ItemClick);
            // 
            // sub_Mantos
            // 
            this.rd_menu.SetAutoSize(this.sub_Mantos, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.sub_Mantos.Caption = "Mantenimientos";
            this.sub_Mantos.Id = 13;
            this.sub_Mantos.ImageOptions.Image = global::ARM.Properties.Resources.maintenance_64;
            this.sub_Mantos.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_BinMaintenance),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_AllowedMaterials)});
            this.sub_Mantos.Name = "sub_Mantos";
            this.sub_Mantos.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // btn_BinMaintenance
            // 
            this.rd_menu.SetAutoSize(this.btn_BinMaintenance, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.btn_BinMaintenance.Caption = "Tolvas, Silos y Tanques";
            this.btn_BinMaintenance.Id = 16;
            this.btn_BinMaintenance.ImageOptions.Image = global::ARM.Properties.Resources.Silos_x48;
            this.btn_BinMaintenance.Name = "btn_BinMaintenance";
            this.btn_BinMaintenance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_BinMaintenance_ItemClick);
            // 
            // btn_AllowedMaterials
            // 
            this.rd_menu.SetAutoSize(this.btn_AllowedMaterials, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.btn_AllowedMaterials.Caption = "Materiales Permitidos";
            this.btn_AllowedMaterials.Id = 17;
            this.btn_AllowedMaterials.ImageOptions.Image = global::ARM.Properties.Resources.Silos_MP_x48;
            this.btn_AllowedMaterials.Name = "btn_AllowedMaterials";
            this.btn_AllowedMaterials.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_AllowedMaterials_ItemClick);
            // 
            // sub_reportes
            // 
            this.rd_menu.SetAutoSize(this.sub_reportes, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.sub_reportes.Caption = "Reportes";
            this.sub_reportes.Id = 14;
            this.sub_reportes.ImageOptions.Image = global::ARM.Properties.Resources.LogoAqua_x64;
            this.sub_reportes.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_BatchReport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ShiftReport)});
            this.sub_reportes.Name = "sub_reportes";
            this.sub_reportes.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.sub_reportes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btn_BatchReport
            // 
            this.rd_menu.SetAutoSize(this.btn_BatchReport, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.btn_BatchReport.Caption = "Reporte de Batch";
            this.btn_BatchReport.Id = 18;
            this.btn_BatchReport.Name = "btn_BatchReport";
            // 
            // btn_ShiftReport
            // 
            this.rd_menu.SetAutoSize(this.btn_ShiftReport, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.btn_ShiftReport.Caption = "Reporte de Turno";
            this.btn_ShiftReport.Id = 19;
            this.btn_ShiftReport.Name = "btn_ShiftReport";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Salir";
            this.barButtonItem5.Id = 20;
            this.barButtonItem5.ImageOptions.Image = global::ARM.Properties.Resources.cancel2_48;
            this.barButtonItem5.ImageOptions.LargeImage = global::ARM.Properties.Resources.cancel2_48;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // rd_menu
            // 
            this.rd_menu.CloseOnOuterMouseClick = false;
            this.rd_menu.Glyph = global::ARM.Properties.Resources.LogoLimp_x32;
            this.rd_menu.InnerRadius = 5;
            this.rd_menu.ItemAutoSize = DevExpress.XtraBars.Ribbon.RadialMenuItemAutoSize.Spring;
            this.rd_menu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.sub_planProduccion),
            new DevExpress.XtraBars.LinkPersistInfo(this.sub_Mantos),
            new DevExpress.XtraBars.LinkPersistInfo(this.sub_reportes),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5)});
            this.rd_menu.Manager = this.barManager1;
            this.rd_menu.Name = "rd_menu";
            this.rd_menu.CloseUp += new System.EventHandler(this.rd_menu_CloseUp);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 239);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aquafeed Recepie Manager";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rd_menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Ribbon.RadialMenu rd_menu;
        private DevExpress.XtraBars.BarButtonItem btn_formulas;
        private DevExpress.XtraBars.BarButtonItem btn_plan;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem sub_formulas;
        private DevExpress.XtraBars.BarButtonItem btn_aqua;
        private DevExpress.XtraBars.BarButtonItem btn_agri;
        private DevExpress.XtraBars.BarButtonItem btn_planProd;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btn_plc_test;
        private DevExpress.XtraBars.BarSubItem sub_planProduccion;
        private DevExpress.XtraBars.BarButtonItem btn_ProductionOrders;
        private DevExpress.XtraBars.BarSubItem sub_Mantos;
        private DevExpress.XtraBars.BarButtonItem btn_BinMaintenance;
        private DevExpress.XtraBars.BarButtonItem btn_AllowedMaterials;
        private DevExpress.XtraBars.BarSubItem sub_reportes;
        private DevExpress.XtraBars.BarButtonItem btn_BatchReport;
        private DevExpress.XtraBars.BarButtonItem btn_ShiftReport;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;

    }
}

