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
        int Requisas_Abiertas = 0;
        int Maximo_Permitidas = 0;
        public frmMensajeProduccion(int pRequ_Abiertas, int pMaximo_permitidas)
        {
            InitializeComponent();
            Requisas_Abiertas = pRequ_Abiertas;
            Maximo_Permitidas = pMaximo_permitidas;

            labelControl1.Text = "Deben Cerrar Requisas para Proceder \nMaximo de Requisas En Proceso Permitidas: " + Maximo_Permitidas.ToString() +"\nRequisas Abiertas: "+ Requisas_Abiertas;
            
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