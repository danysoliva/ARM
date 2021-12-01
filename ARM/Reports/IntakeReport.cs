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

using ARM.Classes;
using System.Data.SqlClient;

namespace ARM.Reports
{
    public partial class IntakeReport : DevExpress.XtraEditors.XtraForm
    {
        #region Variables Globales
        // string ActiveUserCode;
        DataOperations dp = new DataOperations();
        DataTable dtDatos;
        
        FMOP fmop = new FMOP();
        #endregion

        public IntakeReport()
        {
            InitializeComponent();

            //#region Screen Selection
            //if (Screen.AllScreens.Count() > 1)
            //{
            //    switch (Screen.AllScreens.Count())
            //    {
            //        case 2:
            //            this.Location = Screen.AllScreens[1].WorkingArea.Location;
            //            break;
            //        case 3:
            //            this.Location = Screen.AllScreens[2].WorkingArea.Location;
            //            break;
            //        case 4:
            //            this.Location = Screen.AllScreens[3].WorkingArea.Location;
            //            break;
            //        case 5:
            //            this.Location = Screen.AllScreens[5].WorkingArea.Location;
            //            break;
            //        case 6://Configuración Actual Consola
            //            this.Location = Screen.AllScreens[4].WorkingArea.Location;
            //            break;
            //    }
            //}
            //#endregion
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_GenReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Convert.ToDateTime(dt_hasta.EditValue) < Convert.ToDateTime(dt_desde.EditValue)) {
                MessageBox.Show("Rango de fecha no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cargar_grid();
        }


        void cargar_grid(){
            // using System.Data.SqlClient;
            // using System.Data;
            if (dt_desde.EditValue == null || dt_hasta.EditValue == null) return;
            try
            {
                #region Parametros_SP_Entrada
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.DateTime));
                cmd.Parameters["@fecha_desde"].Value = Convert.ToDateTime(dt_desde.EditValue);
                cmd.Parameters["@fecha_hasta"].Value = Convert.ToDateTime(dt_hasta.EditValue);
                #endregion

                dtDatos = dp.APMS_Exec_SP_Get_Data("Intake_Get_SumaryRM_by_date", cmd);
                //txtCtaContable.Text = dtDatos.Rows[0]["code"].ToString();
                grd_data.DataSource = dtDatos;
            }
            catch (Exception) { throw; }       
        }

        private void btn_bajarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_data.ExportToXlsx(dialog.FileName);
            }

        }

        private void btn_Imprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                grdv_data.PrintDialog();
            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message);
            }         
            
        }

    }
}