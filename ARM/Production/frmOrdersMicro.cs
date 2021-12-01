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
using DevExpress.XtraGrid.Views.Grid;

namespace ARM.Production
{
    public partial class frmOrdersMicro : DevExpress.XtraEditors.XtraForm
    {
        public frmOrdersMicro()
        {
            InitializeComponent();
            CargarOrdenMicros();
        }

        private void CargarOrdenMicros()
        {
            try
            {
                DataOperations op = new DataOperations();
                SqlConnection Conn = new SqlConnection(op.ConnectionStringAPMS);
                Conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_ordenes_pesaje_manual_interface", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@orden_id", idOrden);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsARM1.ordenh.Clear();
                adat.Fill(dsARM1.ordenh);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdVerDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Ver detalle
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsARM.ordenhRow)gridView.GetFocusedDataRow();

            frmDetalleMicros frm = new frmDetalleMicros(row.id);
            frm.Show();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}