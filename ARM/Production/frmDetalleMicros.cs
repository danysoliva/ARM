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

namespace ARM.Production
{
    public partial class frmDetalleMicros : DevExpress.XtraEditors.XtraForm
    {
        public frmDetalleMicros(int idOrden)
        {
            InitializeComponent();
            LoadDetalle(idOrden);
        }

        private void LoadDetalle(int idOrden)
        {
             
            try
            {
                DataOperations op = new DataOperations();
                SqlConnection Conn = new SqlConnection(op.ConnectionStringAPMS);
                Conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalle_orden_pesaje_micros_interface", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden_id",idOrden);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsARM1.detalle_micros.Clear();
                adat.Fill(dsARM1.detalle_micros);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}