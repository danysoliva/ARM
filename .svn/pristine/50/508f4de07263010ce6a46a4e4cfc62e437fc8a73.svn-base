using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using ARM.Classes;
using System.Data.SqlClient;

namespace ARM.Mants
{
    public partial class Mants_Bins : DevExpress.XtraEditors.XtraForm
    {
        #region Variables_Globales
        DataOperations dp = new DataOperations();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        FMOP op = new FMOP();
        #endregion

        public Mants_Bins()
        {
            InitializeComponent();
            load_combo(); cmbl_gruposBin.EditValue = 1;
            load_grid();
        }

        void load_grid()
        {       
            gridControl1.DataSource = op.ConsGral_BinsxGrupo(Convert.ToInt32(cmbl_gruposBin.EditValue.ToString()));
        }


        void load_combo() {
            cmbl_gruposBin.Properties.DataSource = op.ConsGral_GruposBins();
        }

        private void cmbl_gruposBin_EditValueChanged(object sender, EventArgs e)
        {
            load_grid();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar_Datos_Grid();
        }

        void Guardar_Datos_Grid() {
            gridView1.RefreshEditor(true);
            try
            {
                #region Guardando
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    op.Upd_MaterialPermitido_xBin(
                        Convert.ToInt32(gridView1.GetDataRow(i)["id"]), 
                        (gridView1.GetDataRow(i)["allow_rm"]==DBNull.Value? false : Convert.ToBoolean(gridView1.GetDataRow(i)["allow_rm"]) ),
                        (gridView1.GetDataRow(i)["allow_fp"] == DBNull.Value ? false : Convert.ToBoolean(gridView1.GetDataRow(i)["allow_fp"])),
                        (gridView1.GetDataRow(i)["allow_nc"] == DBNull.Value ? false : Convert.ToBoolean(gridView1.GetDataRow(i)["allow_nc"])),
                        (gridView1.GetDataRow(i)["allow_sfp"] == DBNull.Value ? false : Convert.ToBoolean(gridView1.GetDataRow(i)["allow_sfp"]))
                        );
                }
                #endregion

                #region Activando_Botones
                btn_Guardar.Visibility= DevExpress.XtraBars.BarItemVisibility.Never;
                btn_Cancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btn_Editar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always ;
                gridReadOnly(true);
                load_grid();
                #endregion

            }
            catch (Exception ex)
            {
                #region Try-Catch_Mensaje-Error
                var dialogTypeName = "System.Windows.Forms.PropertyGridInternal.GridErrorDlg";
                var dialogType = typeof(Form).Assembly.GetType(dialogTypeName);
                var dialog = (Form)Activator.CreateInstance(dialogType, new PropertyGrid());
                dialog.Text = "Error";
                dialogType.GetProperty("Message").SetValue(dialog, "Error: " + ex.Message, null);
                dialogType.GetProperty("Details").SetValue(dialog, ex.StackTrace, null);
                var result = dialog.ShowDialog();
                #endregion
            }
        }

        void gridReadOnly(Boolean allow) {
            gridView1.Columns["allow_rm"].OptionsColumn.ReadOnly = allow;
            gridView1.Columns["allow_fp"].OptionsColumn.ReadOnly = allow;
            gridView1.Columns["allow_nc"].OptionsColumn.ReadOnly = allow;
            gridView1.Columns["allow_sfp"].OptionsColumn.ReadOnly = allow;
        }


        private void btn_Salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Editar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Cancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always ; 
            btn_Guardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btn_Editar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            gridReadOnly(false);
        }

        private void btn_Guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Guardar_Datos_Grid();
        }

        private void btn_Cancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Cancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            btn_Guardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            btn_Editar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            gridReadOnly(true);
            load_grid();
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "allow_rm")
                gridView1.SetRowCellValue(e.RowHandle, "allow_rm", (bool)e.Value);

            if (e.Column.FieldName == "allow_fp")
                gridView1.SetRowCellValue(e.RowHandle, "allow_fp", (bool)e.Value);

            if (e.Column.FieldName == "allow_nc")
                gridView1.SetRowCellValue(e.RowHandle, "allow_nc", (bool)e.Value);
            
            if (e.Column.FieldName == "allow_sfp")
                gridView1.SetRowCellValue(e.RowHandle, "allow_sfp", (bool)e.Value);

        }


    }
}