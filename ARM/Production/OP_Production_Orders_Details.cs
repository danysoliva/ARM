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

namespace ARM.Production
{
    public partial class OP_Production_Orders_Details : DevExpress.XtraEditors.XtraForm
    {
        #region Developer Defined Variables

        DataOperations dp = new DataOperations();
        FMOP fmop = new FMOP();
        int acs_id = 0;
        DataTable datos;

        #endregion

        public OP_Production_Orders_Details(int acs_id)
        {
            InitializeComponent();

            this.acs_id = acs_id;
        }

        private void OP_Production_Orders_Details_Load(object sender, EventArgs e)
        {
            try
            {
                datos = fmop.acs_get_order_detail(acs_id);

                string campo = "";
                if(datos.Rows.Count >= 1)
                {
                    //ORDER RELATED (8)
                    txtPlan_Code.Text = datos.Rows[0]["plan_code"].ToString();
                    txtPlanName.Text = datos.Rows[0]["plan_name"].ToString();
                    //campo = datos.Rows[0]["order_id"].ToString();
                    txtProductionOrder.Text = datos.Rows[0]["order_code"].ToString();
                    txtLotNumber.Text = datos.Rows[0]["order_lot"].ToString();
                    txtParadas.Text = datos.Rows[0]["order_plan_batch"].ToString();
                    txtKg.Text = datos.Rows[0]["order_plan_kg"].ToString();
                    txtSacos.Text = datos.Rows[0]["order_plan_bag"].ToString();

                    //FINISHED PRODUCT RELATED (6)
                    txtptcode.Text = datos.Rows[0]["pt_code"].ToString();
                    txtptname.Text = datos.Rows[0]["pt_name"].ToString();
                    txtptpellet.Text = datos.Rows[0]["pt_pellet_size"].ToString();
                    txtptbag.Text = datos.Rows[0]["pt_bag_size"].ToString();
                    txtptspecie.Text = datos.Rows[0]["pt_specie"].ToString();
                    txtptfamily.Text = datos.Rows[0]["pt_family"].ToString();

                    //FORMULA RELATED (5)
                    txtfmid.Text = datos.Rows[0]["fml_id"].ToString();
                    fmcode.Text = datos.Rows[0]["fml_code"].ToString();
                    fmversion.Text = datos.Rows[0]["fml_version"].ToString();
                    fmname.Text = datos.Rows[0]["fml_name"].ToString();
                    fmduedate.Text = datos.Rows[0]["fml_due_date"].ToString();
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Ha ocurrido un error, contacta al departamento de sistemas.\nDetalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}