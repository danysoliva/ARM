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
    public partial class frmMensajeProduccion : DevExpress.XtraEditors.XtraForm
    {
        public frmMensajeProduccion()
        {
            InitializeComponent();
            labelControl1.Text = "Existen mas de 6 Requisas en Estado: En Proceso \n Debe Completar y Cerrar Requisas para Proceder";

        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}