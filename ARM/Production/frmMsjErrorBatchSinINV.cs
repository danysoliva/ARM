using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM.Production
{
    public partial class frmMsjErrorBatchSinINV : DevExpress.XtraEditors.XtraForm
    {
        public bool Aplicar;
        public frmMsjErrorBatchSinINV(string pMateriaName, decimal cant_inv, decimal cant_req, decimal cant_porBatch, int batch_allow)
        {
            InitializeComponent();
            cmdConfirmar.Visible = false;
            Aplicar = false;
            lblMateriaPrimaNombre.Text = pMateriaName;
            lblInventarioActual.Text = string.Format("{0:###,##0.00 Kg}", cant_inv);
            lblCantidadRequerida.Text = string.Format("{0:###,##0.00 Kg}", cant_req);
            lblCantidadPorBatch.Text = string.Format("{0:###,##0.00 Kg}", cant_porBatch);
            lblBatchPermitidos.Text = batch_allow.ToString() + " Batch";

            if (batch_allow >= 1)
            {
                cmdConfirmar.Text = "Aplicar " + batch_allow.ToString() + "Batch";
                cmdConfirmar.Visible = true;
            }
            //else
            //{
            //    cmdConfirmar.Visible = false;
            //}
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Aplicar = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            Aplicar = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}