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
using System.Threading;
using System.Timers;

using DevExpress.XtraSplashScreen;

using ARM.Classes;
using System.Data.SqlClient;
//--
//using System.Windows.Forms;
//using System.Drawing;
//--
//using Npgsql;
using DevExpress.XtraGrid.Views.Grid;
using S7.Net;
using ARM.Reports;

namespace ARM.Production
{
    public partial class OP_Production_Orders_Planner : DevExpress.XtraEditors.XtraForm
    {
        #region Variables_Globales
        string ActiveUserCode;

        DataOperations dp = new DataOperations();
        DataTable dtOrdenes;
        DataTable dtEstructura;
        FMOP fmop = new FMOP();
        int IdMPSinStock;
        bool PermitirMontar_Orden;
        int Requisas_Abiertas;
        int Maximo_Permitidas;
        //Comentario
        Plc plc319;
        static CpuType plc319_CPUType = CpuType.S71500;
        static string plc319_IPAddress = "192.168.12.2";
        static Int16 plc319_Rack = 0;
        static Int16 plc319_Slot = 1;

        int idOrden     = 0;
        int idMix       = 0;
        int mix_num     = 0;
        int idStructure = 0;
        int idOrdenACS  = 0;
        int idMaterial  = 0;

        Boolean material_is_manual;
        Boolean require_alarm;
        Boolean is_postpellet;
        int idBin_Structure = 0;

        String itemType     = "";
        String codigoMP     = "";
        String mix_fullCode = "";

        string sIdle = "";
        int sStatus = 0;

        #endregion

        #region Form Contructors
        public OP_Production_Orders_Planner(string ActiveUserCode)
        {
            InitializeComponent();

            #region Screen Selection
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
            #endregion

            this.ActiveUserCode = ActiveUserCode;
            cargar_grd_ordenes();
            timerValidacionStock.Enabled = true;
            timerValidacionStock.Start();
        }
        #endregion

        #region Developer Defined Methods
        // ---------------------------------------------------------------------------------------- 
        //[ CARGA DE GRIDS ]  --------------------------------------------------------------
        private void cargar_grd_ordenes()
        {
            try
            {
                #region Parametros_SP_Entrada
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@status_ini", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@status_fin", SqlDbType.Int));
                cmd.Parameters["@status_ini"].Value = 40;
                cmd.Parameters["@status_fin"].Value = 80;
                #endregion

                grd_Orders.DataSource = null; 
                grd_Orders.DataSource = dp.APMS_Exec_SP_Get_Data("OP_Get_Orders_Mix_by_Status", cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido un error al cargar la informacion de ordenes de producción\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_grd_ordenes_estructuras()
        {
            try
            {
                grd_Structure.DataSource = fmop.apms_get_order_structure_per_mix(idOrden, mix_num);
                //cargar_grd_ordenes_estructuras();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido un error al cargar la informacion de estructura de producción\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_grd_comentarios() {
            try
            {
                grd_Comments.DataSource = dp.APMS_GetSelectData("SELECT cast(created_date as date) fecha, created_date hora, note as 'nota' FROM OP_Production_Orders_mix_note where order_mix_id=" + idMix).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido un error al cargar la informacion de comentarios del mezclado. \n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void cargar_grd_eventos()
        {
            try
            {
                grd_Events.DataSource = dp.APMS_GetSelectData("SELECT cast(created_date as date) fecha, created_date hora, event as 'evento' FROM OP_Production_Orders_mix_event where order_mix_id=" + idMix).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido un error al cargar la informacion de eventos del mezclado. \n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------


        bool PermiteFinalizar(int vMixID)
        {
            bool Permite = false;
            try
            {
                string sql = @"SELECT [mix_num]
                                FROM [APMS].[dbo].[OP_Production_Orders_Main_Mix]
                                where [id] = " + vMixID;
                int mix_num = dp.APMS_Do_SmallOperationInt(sql);

                string sql2 = @"SELECT status
                                FROM [APMS].[dbo].[OP_Production_Orders_Main_Mix]
                                where [id] =  " + vMixID;
                int status = dp.APMS_Do_SmallOperationInt(sql2);

                if (mix_num == 1)
                {
                    sStatus = status;

                    //if (idle1 == false && ActiveMix1)
                    if (status == 70)
                        Permite = false;
                    else
                        Permite = true;   
                }
                if (mix_num == 2)
                {
                    sStatus = status;
                    if (status == 70)
                        Permite = false;
                    else
                        Permite = true;
                    
                }
            }
            catch (Exception ec) { throw new Exception(ec.Message); }
            return Permite;
        }


        bool PermiteSuspender(int vMixID)
        {
            bool Permite = false;
            try
            {
                //DataTable dtTEMP = new DataTable();
                //dtTEMP = dp.APMS_GetSelectData(@"SELECT Coalesce(allow_suspend,0) allow_suspend FROM [OP_Production_Orders_Main_Mix] where id=" + vMixID).Tables[0];
                //return Convert.ToBoolean(dtTEMP.Rows[0]["allow_suspend"]);
                string sql = @"SELECT [mix_num]
                                FROM [APMS].[dbo].[OP_Production_Orders_Main_Mix]
                                where [id] = "+ vMixID;
                int mix_num = dp.APMS_Do_SmallOperationInt(sql);

                string sql2 = @"SELECT status
                                FROM [APMS].[dbo].[OP_Production_Orders_Main_Mix]
                                where [id] =  " + vMixID;
                int status = dp.APMS_Do_SmallOperationInt(sql2);
                //Permite = false;

                if (mix_num == 1)
                {
                    plc319 = new Plc(plc319_CPUType, plc319_IPAddress, plc319_Rack, plc319_Slot);

                    //if (plc319.IsConnected)
                    //{
                        if (!plc319.IsConnected)
                            plc319.Open();

                    bool idle1;// = (bool)plc319.Read("db414.dbx1.0");
                    idle1 = Convert.ToBoolean(plc319.Read("db414.dbx1.0"));
                    sIdle = Convert.ToInt32(idle1).ToString();
                    sStatus = status;

                    if (idle1 == false && status == 70)
                        Permite = true;
                    //}
                }
                if (mix_num == 2)
                {
                    plc319 = new Plc(plc319_CPUType, plc319_IPAddress, plc319_Rack, plc319_Slot);

                    //if (plc319.IsAvailable)
                    //{
                        if (!plc319.IsConnected)
                            plc319.Open();

                    bool idle2;// = (bool)plc319.Read("DB414.dbx3.0");
                    
                    idle2 = Convert.ToBoolean(plc319.Read("DB414.dbx3.0"));
                    sIdle = Convert.ToInt32(idle2).ToString();
                    sStatus = status;

                    if (idle2 == false && status == 70)
                        Permite = true;
                    //}
                }
            }
            catch (Exception ec) { throw new Exception(ec.Message);}

            //if (!Permite)
            //{
            //    DialogResult r = MessageBox.Show("No se permite desmontar el mezclado, aún hay un pesaje activo. ¿Desea Ingresar una Autorización para forzar el desmontaje?",
            //                                     "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            //    if (r != DialogResult.Yes)
            //        Permite = false;
            //}
            return Permite;
        }

        void registrarEvento(String evento)
        {
            Utils.Comment_Add form = new Utils.Comment_Add();
            #region Insertar Eventos
            try
            {
                #region Parametros_SP_Entrada
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@order_mix_id", SqlDbType.BigInt));
                cmd.Parameters.Add(new SqlParameter("@event", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@created_by", SqlDbType.Int));
                cmd.Parameters["@order_mix_id"].Value = idMix;
                cmd.Parameters["@event"].Value = evento;
                cmd.Parameters["@created_by"].Value = ActiveUserCode;
                #endregion

                dp.APMS_Exec_SP_Get_Data("OP_Production_Orders_Mix_Insert_Event", cmd);
                cargar_grd_eventos();
            }
            catch (Exception) { throw; }
            #endregion
        }

        Boolean existe_MaterialSinTolva()
        {
            //Control: Si no hay registros no prosigue
            if (grdv_Structure.DataRowCount <= 0) return false;

            //Recorre grid, buscando las lineas que quedaron con la columna en blanco o null
            for (int i = 0; i < grdv_Structure.DataRowCount; i++)
            {
                DataRow row = grdv_Structure.GetDataRow(i);
                if (Convert.ToInt32(row["bin_id"]) == 0 && !Convert.ToBoolean(row["material_is_manual"]))
                    return true;
            }
            return false;
        }


        /// <summary>
        /// Cambia Status a los MIX de las OP
        /// </summary>
        /// <param name="order_mix_id">Numero de la Orden de Producción</param>
        /// <param name="mix_num">1=Primer Mesclado, 2=Segundo Mesclado</param>
        /// <param name="status">50=Activar, 60=Suspender</param>
        void setStatus_OP_mix(int mix_id, int status)    // Seteando Status de MIX de OP ..
        {
            //if (status != 50 & status != 60 & status != 95) return;
            try
            {
                #region Parametros_SP_Entrada
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@mix_id", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
                cmd.Parameters["@mix_id"].Value = mix_id;
                cmd.Parameters["@status"].Value = status;
                #endregion

                dp.APMS_Exec_SP_Get_Data("OP_Set_Mix_Status_by_MixID", cmd);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void set_active_mix_OP_mix(int mix_id, int status)    // Seteando Status Active_mix MIX de OP ..
        {
            try
            {
                #region Parametros_SP_Entrada
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@mix_id", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
                cmd.Parameters["@mix_id"].Value = mix_id;
                cmd.Parameters["@status"].Value = status;
                #endregion

                //Gestion de micros mediante recetario con plc
                try
                {
                    plc319 = new Plc(plc319_CPUType, plc319_IPAddress, plc319_Rack, plc319_Slot);

                    if (plc319.IsAvailable)
                    {
                        if (!plc319.IsConnected)
                            plc319.Open();
                        else
                            return;

                        //Obtener en que mezclado estan las tolvas adicionales WL7 y WL8
                        bool wl7_wl8_al_primero = (bool)plc319.Read("db567.dbx0.2");

                        //Definimos el id Mezclado donde se va a guardar
                        int wl7_wl8_position = 2;

                        if (wl7_wl8_al_primero)//true primer mezclado
                            wl7_wl8_position = 1;

                        //Vamos a leer el bit
                        bool check_micro_in_mix1 = (bool)plc319.Read("db536.dbx0.2");
                        if (check_micro_in_mix1)
                        {
                            //Obtener el mix num
                            //int mix_num = dp.APMS_Do_SmallOperationInt("SELECT [mix_num] FROM [dbo].[OP_Production_Orders_Main_Mix] where id = " + mix_id);
                            int order_id = dp.APMS_Do_SmallOperationInt("SELECT [order_id] FROM [APMS].[dbo].[OP_Production_Orders_Main_Mix] where id = " + mix_id);

                            //Update Order Mixta
                            dp.APMS_Do_SmallOperation("UPDATE [dbo].[OP_Production_Orders_Main_Mix] SET [mixta] = 1, [bin_add_position] = " +
                                                     Convert.ToInt32(wl7_wl8_al_primero ? 1 : 0) + " WHERE [order_id] = " + order_id);
                            //dp.APMS_Do_SmallOperation("UPDATE [dbo].[OP_Production_Orders_Main_Mix] SET [mixta] = 1, [bin_add_position] = " + 
                            //                          wl7_wl8_al_primero + " WHERE [order_id] = " + order_id + " and mix_num = 1;");
                        }
                        else
                        {
                            //Obtener el mix num
                            //int mix_num = dp.APMS_Do_SmallOperationInt("SELECT [mix_num] FROM [dbo].[OP_Production_Orders_Main_Mix] where id = " + mix_id);
                            int order_id = dp.APMS_Do_SmallOperationInt("SELECT [order_id] FROM [APMS].[dbo].[OP_Production_Orders_Main_Mix] where id = " + mix_id);

                            //Update Order NO Mixta
                            dp.APMS_Do_SmallOperation("UPDATE [dbo].[OP_Production_Orders_Main_Mix] SET [mixta] = 0, [bin_add_position] = " +
                                                        Convert.ToInt32(wl7_wl8_al_primero ? 1 : 0) + " WHERE [order_id] = " + order_id);
                            //dp.APMS_Do_SmallOperation("UPDATE [dbo].[OP_Production_Orders_Main_Mix] SET [mixta] = 0, [bin_add_position] = "+ 
                            //                            wl7_wl8_al_primero +" WHERE [order_id] = " + order_id + " and mix_num = 1;");
                        }

                        //Udpate de las tolvas nuevas
                        if (wl7_wl8_al_primero)
                        {
                            //Vamos a setear en el mix A
                            int order_id = dp.APMS_Do_SmallOperationInt("SELECT [order_id] FROM [APMS].[dbo].[OP_Production_Orders_Main_Mix] where id = " + mix_id);
                            string query_up = "EXEC	[dbo].[st_order_update_mix_wl7_wl8] @order_id = " + order_id + ",@mix_num = 1";
                            dp.APMS_Do_SmallOperation(query_up);
                        }
                        else
                        {
                            //Vamos a setear en el mix B
                            int order_id = dp.APMS_Do_SmallOperationInt("SELECT [order_id] FROM [APMS].[dbo].[OP_Production_Orders_Main_Mix] where id = " + mix_id);
                            string query_up = "EXEC	[dbo].[st_order_update_mix_wl7_wl8] @order_id = " + order_id + ",@mix_num = 2";
                            dp.APMS_Do_SmallOperation(query_up);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //SEND E-MAIL Message on Service Failure.
                    MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dp.APMS_Exec_SP_Get_Data("OP_Set_activeMix_sts_by_MixID", cmd);
            }
            catch (Exception) { throw; }
        }

        void set_allow_suspend_OP_mix(int mix_id, int status)    // Seteando Status allow_suspend MIX de OP ..
        {
            try
            {
                #region Parametros_SP_Entrada
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@mix_id", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
                cmd.Parameters["@mix_id"].Value = mix_id;
                cmd.Parameters["@status"].Value = status;
                #endregion

                dp.APMS_Exec_SP_Get_Data("OP_Set_allow_suspend_sts_by_MixID", cmd);
            }
            catch (Exception) { throw; }
        }

        //void set_sts_xOrden_Odoo(string orden, int status)
        //{
        //    try
        //    {
        //        NpgsqlCommand cmd = new NpgsqlCommand();
        //        cmd.Parameters.Add(new NpgsqlParameter(":orden", DbType.AnsiString));
        //        cmd.Parameters.Add(new NpgsqlParameter(":status", DbType.Int32));

        //        cmd.Parameters[":orden"].Value  = orden ;
        //        cmd.Parameters[":status"].Value = status ;

        //        dp.ODOO_Exec_SP("x_sp_set_sts_OrdenProd", cmd);
        //    }
        //    catch (Exception ex)
        //    {
        //        #region Try-Catch_Mensaje-Error
        //        var dialogTypeName = "System.Windows.Forms.PropertyGridInternal.GridErrorDlg";
        //        var dialogType = typeof(Form).Assembly.GetType(dialogTypeName);
        //        var dialog = (Form)Activator.CreateInstance(dialogType, new PropertyGrid());
        //        dialog.Text = "Error";
        //        dialogType.GetProperty("Message").SetValue(dialog, "Error: " + ex.Message, null);
        //        dialogType.GetProperty("Details").SetValue(dialog, ex.StackTrace, null);
        //        var result = dialog.ShowDialog();
        //        #endregion
        //    }

        //}


        /// <summary>
        /// Revisa si ya existe un MIX de la OP con status indicado
        /// </summary>
        /// <param name="order_id">Numero de OP</param>
        /// <param name="mix_num">1=Primer Mesclado, 2=Segundo Mesclado</param>
        /// <param name="status">50=Activado, 60=Suspendido</param>
        /// <returns></returns>
        bool existenOP_Mix_Status(int mix_num, int status)    // Existe Mesclado con STS ..
        {
            #region query
            String query = String.Format(@"SELECT Count(*) cantidad FROM OP_Production_Orders_Main_Mix where mix_num= {0} and status= {1}"
                , mix_num
                , status
                );
            #endregion

            DataTable dtTEMP = new DataTable();
            dtTEMP = dp.APMS_GetSelectData(query).Tables[0];

            return (Convert.ToInt32(dtTEMP.Rows[0]["cantidad"]) > 0 ? true : false);
        }

        int getStatus_OP_mix(int vMixID)    // Existe Mesclado con STS ..
        {
            try
            {
                #region Parametros_SP_Entrada
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@mix_id", SqlDbType.Int));
                cmd.Parameters["@mix_id"].Value = idMix;
                #endregion

                DataTable dtTEMP= dp.APMS_Exec_SP_Get_Data("OP_Get_Mix_Status_by_MixID", cmd);
                return Convert.ToInt32(dtTEMP.Rows[0]["status"]); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido un error al cargar la informacion de ordenes de producción\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

        }

        int getStatus_activeMix_Sts_mix(int vMixID)    // Existe Mesclado con STS ..
        {
            try
            {
                #region Parametros_SP_Entrada
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@mix_id", SqlDbType.Int));
                cmd.Parameters["@mix_id"].Value = idMix;
                #endregion

                DataTable dtTEMP = dp.APMS_Exec_SP_Get_Data("OP_Get_activeMix_sts_by_MixID", cmd);
                return Convert.ToInt32(dtTEMP.Rows[0]["active_mix"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido un error al leer el active_mix del mezclado.\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

        }

        #endregion
        // ------------------------------------------------------------------------------------------------------------------------------------ 
        #region Form Events




        //[Grid Eventos]--------------------------------------------------------------------------------
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                #region Aginando idMix, idOrden, mix_num
                if (e.FocusedRowHandle >= 0)
                {

                    idOrden      = int.Parse(grdv_Orders.GetDataRow(e.FocusedRowHandle)["order_id"].ToString());
                    idMix        = int.Parse(grdv_Orders.GetDataRow(e.FocusedRowHandle)["mix_id"].ToString());
                    mix_num      = int.Parse(grdv_Orders.GetDataRow(e.FocusedRowHandle)["mix_num"].ToString());
                    idOrdenACS   = int.Parse(grdv_Orders.GetDataRow(e.FocusedRowHandle)["acs_id"].ToString());
                    mix_fullCode = grdv_Orders.GetDataRow(e.FocusedRowHandle)["mix_fullCode"].ToString();

                    grp_Structure.Text = string.Format("Estructura Mezclado: {0}", grdv_Orders.GetDataRow(e.FocusedRowHandle)["mix_fullCode"].ToString());

                    cargar_grd_ordenes_estructuras();
                    cargar_grd_comentarios();
                    cargar_grd_eventos();
                    CargarOrdenMicros(idOrden);
                }
                #endregion
            }
            catch { }
        }

        private void CargarOrdenMicros(int idOrden)
        {
            try
            {
                DataOperations op = new DataOperations();
                SqlConnection Conn = new SqlConnection(op.ConnectionStringAPMS);
                Conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalle_orden_pesaje_micros_interfacev3", Conn);
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

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            #region AutorRow_Color_Diferente
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                e.Appearance.BackColor = Color.FromArgb(200, 255, 255, 204);
            }
            #endregion
        }

        private void gridView2_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            #region AutorRow_Color_Diferente
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                e.Appearance.BackColor = Color.FromArgb(200, 255, 255, 204);
            }
            #endregion
        }

        private void grdv_Structure_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            #region Aginando idStructure
            if (e.FocusedRowHandle >= 0)
            {
                idStructure        = int.Parse(grdv_Structure.GetDataRow(e.FocusedRowHandle)["record_id"].ToString());
                idBin_Structure    = int.Parse(grdv_Structure.GetDataRow(e.FocusedRowHandle)["bin_id"].ToString());
                material_is_manual = Convert.ToBoolean(grdv_Structure.GetDataRow(e.FocusedRowHandle)["material_is_manual"]);
                require_alarm      = Convert.ToBoolean(grdv_Structure.GetDataRow(e.FocusedRowHandle)["require_alarm"]);
                is_postpellet      = Convert.ToBoolean(grdv_Structure.GetDataRow(e.FocusedRowHandle)["is_postpellet"]);
                idMaterial         = Convert.ToInt32(grdv_Structure.GetDataRow(e.FocusedRowHandle)["item_id"]);
                itemType           = (grdv_Structure.GetDataRow(e.FocusedRowHandle)["item_type"]).ToString();
                codigoMP           = (grdv_Structure.GetDataRow(e.FocusedRowHandle)["item_code"]).ToString();
                //bool a = grdv_Structure.Columns["post_pellet_cant"].OptionsColumn.AllowEdit;
            }
            #endregion
        }
        //----------------------------------------------------------------------------------------------



        //----------------------------------------------------------------------------------------------
        private void btn_Actualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cargar_grd_ordenes();
            cargar_grd_ordenes_estructuras();
            cargar_grd_comentarios();
            cargar_grd_eventos();
        }

        private void btn_Activar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Solo se activaran los que active_mix=0 y que status=50 o
            // status=60
       
            //setStatus_OP_mix(idMix, 70);
            if (PermitirMontar(idMix) == 0)
            {
                if (grdv_Orders.GetVisibleIndex(grdv_Orders.FocusedRowHandle) <= 0) return;      // Nuevo 2017-03-06
                if (Convert.ToInt32(grdv_Orders.RowCount) <= 0) return;


                String mensaje = "";
                int mixStatus = getStatus_OP_mix(idMix);

                //if (mixStatus == 95) mensaje = "La orden no se puede activar, tiene estado finalizado manual.";
                //if (mixStatus == 90) mensaje = "La orden no se puede activar, tiene estado finalizado automático.";
                //if (getStatus_OP_mix(idMix) == 50)     mensaje = "La orden ya se encuentra activa.";
                //if (getStatus_OP_mix(idMix) > 60)      mensaje = "La orden no se puede activar, ya está en proceso."; 
                if (existenOP_Mix_Status(mix_num, 70)) mensaje = "No se puede activar, hay otro mezclado activo.";      // Nuevo 2017-03-06
                if (mensaje == "" & getStatus_activeMix_Sts_mix(idMix) == 1) mensaje = "El mezclado ya se encuentra activo.";
                if (mensaje == "" & mixStatus != 50 & mixStatus != 60) mensaje = "El estado del mezclado no permite activar.";
                if (mensaje == "" & existe_MaterialSinTolva()) mensaje = "El mezclado tiene un material sin tolva asignada.\nDebe marcar como manual en caso que sea así.";

                if (mensaje != "")
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    registrarEvento("[Activando] " + mensaje);
                    btn_Actualizar.PerformClick();
                    return;
                }


                //Validacion 6 Requisas


                try
                {
                    SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_validacion_requisas_abiertas_montar_orden_PRD", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        PermitirMontar_Orden = dr.GetBoolean(0);
                        Requisas_Abiertas = dr.GetInt32(1);
                        Maximo_Permitidas = dr.GetInt32(2);

                    }
                    dr.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }

                if (PermitirMontar_Orden == false)
                {
                    if (PermitirMontar_Orden == false)
                    {
                        frmMensajeProduccion frm = new frmMensajeProduccion(Requisas_Abiertas, Maximo_Permitidas);
                        frm.ShowDialog();
                        return;

                    }
                }

                DialogResult resultado = MessageBox.Show("¿Esta realmente seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado != System.Windows.Forms.DialogResult.Yes) return;

                #region Wait Window...
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                Thread.Sleep(300);
                SplashScreenManager.CloseForm();
                #endregion


                set_active_mix_OP_mix(idMix, 70);    // active_mix= 1
                registrarEvento("[Activando] Enviado a producir correctamente.");
                //btn_Actualizar.PerformClick();
                IdMPSinStock = 0;

                cargar_grd_ordenes();
                cargar_grd_ordenes_estructuras();
                cargar_grd_comentarios();
                cargar_grd_eventos();
            }
            else
            {
                MateriaPrima mp1 = new MateriaPrima();
                if (mp1.RecuperarRegistro(IdMPSinStock))
                {
                    MessageBox.Show("No hay Inventario en la Bodega BG018 (Producción), de la Materia Prima: " + mp1.ItemCode + " - " + mp1.Nombre + ". " +
                                    "No se permite operar una orden sin inventario en Kardex en BG018!"
                                   ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private int PermitirMontar(Int64 pIdMainMix)
        {
            int idmp_ = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_activate_suspension_order_out_stock_scada", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_main_mix", pIdMainMix);
                IdMPSinStock = idmp_ = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return idmp_;
        }

        private void btn_Suspender_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Convert.ToInt32(grdv_Orders.RowCount) <= 0) return;

            string mensaje = "";
            if (getStatus_OP_mix(idMix)== 60) mensaje = "La orden ya está en estado suspendido.";
            //if (getStatus_activeMix_Sts_mix(idMix) == 0) mensaje = "El mezclado no está activo, no se puede suspender.";
            if (!PermiteSuspender(idMix))                mensaje = "El mezclado no permite suspender. El mezclado aun esta activo!!\n"+
                                                                    "El valor de idle es: " + sIdle + "\n" +
                                                                    "El valor de status es: " + sStatus;
            if (getStatus_OP_mix(idMix) != 70)           mensaje = "El estado del mezclado no permite suspender.";
            //if (!ValidarMezcladoPermiteSuspender(idMix)) mensaje = "El estado del mezclado no permite suspender.";

            if (mensaje != "")
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                registrarEvento("[Suspendiendo] " + mensaje);
                btn_Actualizar.PerformClick();
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Esta realmente seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != System.Windows.Forms.DialogResult.Yes) return;

            setStatus_OP_mix(idMix, 60);
            //set_active_mix_OP_mix(idMix, 0);    // active_mix= 0

            registrarEvento("[Suspendiendo] Mezclado suspendido correctamente.");

            #region Wait Window...
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            Thread.Sleep(200);
            SplashScreenManager.CloseForm();
            #endregion

            btn_Actualizar.PerformClick();
        }

       

        private void btn_Finalizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Convert.ToInt32(grdv_Orders.RowCount) <= 0) return;

            string mensaje = "";
            //if (getStatus_OP_mix(idMix) == 90 || getStatus_OP_mix(idMix) == 95) mensaje = "La orden ya se encuentra cerrada." ;
            
            // Si Status=70 solo permite finalizar si active_mix=1 Y
            // allow_suspend=1
            //if (getStatus_OP_mix(idMix) == 70 & getStatus_activeMix_Sts_mix(idMix) != 1 & !PermiteSuspender(idMix)) mensaje = "El mezclado .";
            if (getStatus_OP_mix(idMix) == 70) mensaje = "La orden está activa, primero debe suspender antes de finalizar.";
            if (!PermiteFinalizar(idMix) && getStatus_OP_mix(idMix) != 70) mensaje = "No se puede finalizar el mezclado.";

            //DialogResult r = MessageBox.Show("¿Está seguro de finalizar ésta orden? \nLa orden pasará a estado 80...", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mensaje != "")
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                registrarEvento("[Finalizando] " + mensaje);
                btn_Actualizar.PerformClick();
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Esta realmente seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != System.Windows.Forms.DialogResult.Yes) return;

            // Seteando valores en tablas:
            setStatus_OP_mix(idMix, 95);
            //set_active_mix_OP_mix(idMix, 0);
            //set_allow_suspend_OP_mix(idMix, 0);

            //if (mix_fullCode.EndsWith("S")) set_sts_xOrden_Odoo(mix_fullCode.Substring(0, 10), 95); // Marcará como finalizado cuando se finalice el Mix-2 "S" 
            // ---------------------------------

            registrarEvento("[Finalizando] Mezclado finalizado manualmente.");
            btn_Actualizar.PerformClick();
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        //----------------------------------------------------------------------------------------------



        private void btn_Produce_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Activar_ItemClick(sender, e);
        }

        private void btn_StandBy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Suspender_ItemClick(sender, e);
        }

        private void btn_FinishOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Finalizar_ItemClick(sender, e);
        }

        private void btn_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Actualizar_ItemClick(sender, e);
        }

        private void grdv_Orders_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu_Ordenes.ShowPopup(Cursor.Position);
            }
        }

        private void grdv_Structure_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu_Estructura.ShowPopup(Cursor.Position);
            }
        }

        //-----------------------------------------------------------------------------------------------//
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void btn_AddComment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (InputBox("Nuevo Comentario", "Comentario:", ref comentario) != DialogResult.OK) return;
            Utils.Comment_Add form = new Utils.Comment_Add();
            if (form.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            if (form.Comment.Trim() == "") return;

            #region Insertar Notas OP
            try
            {
                #region Parametros_SP_Entrada
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@order_mix_id", SqlDbType.BigInt));
                cmd.Parameters.Add(new SqlParameter("@note", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@created_by", SqlDbType.Int));
                cmd.Parameters["@order_mix_id"].Value = idMix;
                cmd.Parameters["@note"].Value = form.Comment;
                cmd.Parameters["@created_by"].Value = ActiveUserCode;
                #endregion

                dp.APMS_Exec_SP_Get_Data("OP_Production_Orders_Mix_Insert_Note", cmd);
                cargar_grd_comentarios();
            }
            catch (Exception) { throw; }
            #endregion
        }

        private void grdv_Comments_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            #region AutorRow_Color_Diferente
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                e.Appearance.BackColor = Color.FromArgb(200, 255, 255, 204);
            }
            #endregion
        }

        private void grdv_Events_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            #region AutorRow_Color_Diferente
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                e.Appearance.BackColor = Color.FromArgb(200, 255, 255, 204);
            }
            #endregion
        }

        private void btn_MarcarManual_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idBin_Structure > 0)
            {
                MessageBox.Show("El material ya está asignado a un Bin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (material_is_manual)
            {
                MessageBox.Show("¡El material ya está de forma Manual!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                #region Parametros_SP_Entrada
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@material_id", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
                cmd.Parameters["@material_id"].Value = idStructure;
                cmd.Parameters["@status"].Value = material_is_manual ? 0 : 1;  // Si tiene 0 pasa a 1, y viceversa.
                #endregion

                dp.APMS_Exec_SP_Get_Data("OP_Structure_Set_Material_is_Manual", cmd);
            }
            catch (Exception) { throw; }
            cargar_grd_ordenes_estructuras();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            String query = "UPDATE OP_Production_Orders_Main_Mix SET allow_suspend= 1";
            try
            {
                dp.APMS_DoSmallDBOperation(query);
            }
            catch (Exception) { throw; }
        }

        private void btn_MarcarAlarma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idBin_Structure > 0)
            {
                MessageBox.Show("El material ya tiene asignado a un Bin..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!material_is_manual)
            {
                MessageBox.Show("Solo se pueden activar alarmas a materia Manuales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                #region Parametros_SP_Entrada
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@material_id", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
                cmd.Parameters["@material_id"].Value = idStructure;
                cmd.Parameters["@status"].Value = require_alarm ? 0 : 1;  // Si tiene 0 pasa a 1, y viceversa.
                #endregion

                dp.APMS_Exec_SP_Get_Data("OP_Structure_Set_Require_Alarm", cmd);
            }
            catch (Exception) { throw; }
            cargar_grd_ordenes_estructuras();
        }

        private void OP_Production_Orders_Planner_Load(object sender, EventArgs e)
        {
            if (Classes.Globals.CTS_ServerName == "Servidor de Desarrollo") barHeaderItem1.Appearance.BackColor = Color.Aqua;
            //timerValidacionStock.Enabled = true;
            //timerValidacionStock.Start();
        }

        private void barStaticItem1_ItemDoubleClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void btn_Details_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OP_Production_Orders_Details form = new OP_Production_Orders_Details(idOrdenACS);
            form.ShowDialog();
        }

        private void btnc_Details_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Details_ItemClick(sender,e);
        }

        private void btn_IntakeReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reports.IntakeReport form = new Reports.IntakeReport();
            form.Show();
        }

        private void btn_IntakeLiveReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reports.IntakeViewer form = new Reports.IntakeViewer();
            form.Show();
        }

        private void btn_esPostpellet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void btn_espospelet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if( !(itemType=="RM" & (idMaterial==31 || idMaterial==36))) // 36 Aceite de Tilapia, 31 Aceite de Pescado
            if (!(itemType == "RM" & codigoMP.Substring(0,4)=="1004")) // 36 Aceite de Tilapia, 31 Aceite de Pescado
            {
                MessageBox.Show("Solo se permite marcar como Pospelet los liquidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                #region Parametros_SP_Entrada
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@material_id", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
                cmd.Parameters["@material_id"].Value = idStructure;
                cmd.Parameters["@status"].Value = is_postpellet ? 0 : 1;  // Si tiene 0 pasa a 1, y viceversa.
                #endregion

                dp.APMS_Exec_SP_Get_Data("OP_Structure_Set_is_postpellet", cmd);
            }
            catch (Exception) { throw; }
            cargar_grd_ordenes_estructuras();
        }

        private void btn_DetalleBatch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Reports.IntakeBatchViewer form = new Reports.IntakeBatchViewer();
            IntakeBatchViewerFull form = new IntakeBatchViewerFull();
            form.Show();
        }

        private void grdv_Orders_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void grdv_Structure_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //
            if (e.Column.FieldName == "")
            {

            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GestionPostPellet();
            //gridView.SetFocusedRowCellValue("kg_batch", postP);
        }

        void GestionPostPellet()
        {
            var gridView = (GridView)grd_Structure.FocusedView;
            var row = gridView.GetFocusedDataRow();

            if (Convert.ToInt64(row["estado"]) < 70)
            {
                if (Convert.ToInt64(row["material_group"]) == 3)//3 indica material group de Liquidos
                {
                    decimal valor_Form = Convert.ToDecimal(row["kg_batch"]);
                    string val = "";
                    InputBox("Cant. para Postpellet", "Indique la cantidad que se va aplicar en postpellet", ref val);

                    decimal postP = 0;
                    try
                    {
                        postP = Convert.ToDecimal(val);
                    }
                    catch
                    {
                        MessageBox.Show("Debe ingresar un numero valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (postP <= valor_Form)
                    {
                        //Update en la estructura
                        try
                        {
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                            conn.Open();
                            idStructure = int.Parse(row["record_id"].ToString());
                            string sql = "";
                            if (postP > 0)
                            {
                                sql = @"UPDATE [dbo].[OP_Production_Orders_Structure]
                                         SET [is_postpellet] = 1
                                            ,[cant_postpellet] = cast('" + postP + "' as decimal(10,2))," +
                                                "[cant_mezcla] = cast('" + (valor_Form - postP).ToString() + "' as decimal(10,2)) " +
                                              " WHERE id = " + idStructure;
                            }
                            else
                            {
                                sql = @"UPDATE [dbo].[OP_Production_Orders_Structure]
                                         SET [is_postpellet] = 0
                                            ,[cant_postpellet] = cast('" + postP + "' as decimal(10,2))," +
                                                "[cant_mezcla] = cast('" + (valor_Form - postP).ToString() + "' as decimal(10,2)) " +
                                              " WHERE id = " + idStructure;
                            }
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            cargar_grd_ordenes_estructuras();
                        }
                        catch (Exception ec)
                        {
                            MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No puede ingresar un valor mayor al de la formula!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Solo se puede dividir la cantidad a dosificar en postpellet para Materiales de tipo liquidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Solo se permite modificar la cantidad en postpellet cuando la orden esta desmontada!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOrdersMicro frm = new frmOrdersMicro();
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Revertir poner en manual el material
            if (material_is_manual)
            {
                try
                {
                    #region Parametros_SP_Entrada
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@material_id", SqlDbType.Int));
                    //cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
                    cmd.Parameters["@material_id"].Value = idStructure;
                    //cmd.Parameters["@status"].Value = material_is_manual ? 0 : 1;  // Si tiene 0 pasa a 1, y viceversa.
                    #endregion

                    dp.APMS_Exec_SP_Get_Data("OP_Structure_Set_Material_is_Manual_revert", cmd);
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
                cargar_grd_ordenes_estructuras();
            }
            else
            {
                MessageBox.Show("El material no esta seteado en MANUAL, No se ejecuto ninguna accion!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //-----------------------------------------------------------------------------------------------//

        #endregion

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            GestionPostPellet();
        }

        private void timerValidacionStock_Tick(object sender, EventArgs e)
        {
            //sp_get_activate_suspension_out_stock
            //if (ValidacionInventariosPRD())
            //{

            //}

            cargar_grd_ordenes();
        }

        private bool ValidacionInventariosPRD()
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_activate_suspension_out_stock", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                r = Convert.ToBoolean(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return r;
        }
    }
}