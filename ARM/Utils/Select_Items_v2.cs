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


namespace ARM.Utils
{
    public partial class Select_Items_v2 : DevExpress.XtraEditors.XtraForm
    {
        #region Variables_Globales
        DataOperations dp = new DataOperations();
        DataTable datos;
        String sistema = "";

        //gets
        public int getID;
        public String getCol1, getCol2;

        //sets
        public String setQuery;

        int selected_id = 0;
        String selected_col1, selected_col2;
        #endregion

        /// <summary>
        /// -- Seleccionar Parametrizable --
        /// </summary>
        /// <param name="Query"> Query deberá traer: ID, Col1, Col2 (Opcional) </param>
        /// <param name="Col1"> El título de 2da columna  </param>
        /// <param name="Col2"> El título de 2da columna (opcional) </param>
        /// <returns></returns>
        public Select_Items_v2(String Query, String Col1, String Col2)
        {
            InitializeComponent();
            gridView1.Columns[1].Caption = Col1;
            gridView1.Columns[2].Caption = Col2;
            if (Col2 == "") gridView1.Columns[2].Visible = false;

            this.setQuery = Query;
            Load_Data();
        }

        /// <summary>
        /// -- Seleccionar Parametrizable --
        /// </summary>
        /// <param name="Query"> Query deberá traer: ID, Col1, Col2 (Opcional) </param>
        /// <param name="Col1"> El título de 2da columna  </param>
        /// <param name="Col2"> El título de 2da columna (opcional) </param>
        /// <param name="sistema"> Sistema: odoo, acs </param>
        /// <returns></returns>
        public Select_Items_v2(String Query, String Col1, String Col2, String sistema)
        {
            InitializeComponent();
            gridView1.Columns[1].Caption = Col1;
            gridView1.Columns[2].Caption = Col2;
            if (Col2 == "") gridView1.Columns[2].Visible = false;

            this.setQuery = Query;
            this.sistema = sistema;
            Load_Data();
        }



        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            #region Seleccionando_Registro..
            int lin = gridView1.GetVisibleIndex(gridView1.FocusedRowHandle);
            if (lin < 0) return;
            //getID = Convert.ToInt32(datos.Tables[0].Rows[lin]["id"].ToString());
            //getCol1 = datos.Tables[0].Rows[lin][1].ToString();
            //getCol2 = gridView1.Columns[2].Visible == true ? datos.Tables[0].Rows[lin][2].ToString() : "";

            getID = selected_id;
            getCol1 = selected_col1;
            getCol2 = gridView1.Columns[2].Visible == true ? selected_col2 : "";
            #endregion

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();

        }

        private void btnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void Load_Data()
        {
            datos = dp.APMS_GetSelectData(setQuery).Tables[0];
            gridControl1.DataSource = datos;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            btnSeleccionar.PerformClick();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                selected_id = int.Parse(gridView1.GetDataRow(e.FocusedRowHandle)[0].ToString());
                selected_col1 = gridView1.GetDataRow(e.FocusedRowHandle)[1].ToString();
                selected_col2 = gridView1.GetDataRow(e.FocusedRowHandle)[2].ToString();
            }
        }
    }
}