using S7.Net;
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


namespace ARM.DUO
{
    public partial class Siemens_Comm_Library : DevExpress.XtraEditors.XtraForm
    {
        #region Developer Private Variables

        Plc S7_300_315;

        string S7_300_315_IPAddress = "";

        #endregion

        #region Developer Definen Methods

        private void Connect_PLC() 
        {
            try
            {
                if (!S7_300_315.IsConnected)
                {
                    S7_300_315.Open();
                    txt_cpu_address.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Ya estas conectado con esta CPU", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Disconect_PLC() 
        {
            try
            {
                if (S7_300_315.IsConnected)
                {
                    S7_300_315.Close();
                    txt_cpu_address.Enabled = true;
                }
                else
                {
                    MessageBox.Show("La CPU no esta conectada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Check_PLC_Availability() 
        {
            try
            {
                if (S7_300_315.IsAvailable)
                {
                    lbl_available.Text = "LA CPU ESTA DISPONIBLE";
                    lbl_available.ForeColor = System.Drawing.Color.Green;
                }
                else 
                {
                    lbl_available.Text = "LA CPU NO ESTA DISPONIBLE";
                    lbl_available.ForeColor = System.Drawing.Color.Red;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Check_PLC_Connectivity()
        {
            try
            {
                if (S7_300_315.IsConnected)
                {
                    lbl_connected.Text = "LA CPU ESTA CONECTADA";
                    lbl_connected.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lbl_connected.Text = "LA CPU NO ESTA CONECTADA";
                    lbl_connected.ForeColor = System.Drawing.Color.Red;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PLC_Read_Values()
        {
            try
            {

                //DB1
                bool DBX0_0 = (bool)S7_300_315.Read("DB1.DBX0.0"); //For Boolean Values
                int DBW2_0 = (ushort)S7_300_315.Read("DB1.DBW2.0"); // For INT Values
                Int16 DBW4_0_DEC = Int16.Parse(((ushort)S7_300_315.Read("DB1.DBW4.0")).ToString()); //For Word Values
                string DBW4_0_HEX = DBW4_0_DEC.ToString("X"); //Word Values to Decimal
                Int32 DBD6_0_DEC = Int32.Parse(((uint)S7_300_315.Read("DB1.DBD6.0")).ToString()); //For DWord Values
                string DBD6_0_HEX = DBD6_0_DEC.ToString("X"); //DWord Values to Decimal
                double DBD10_0 = ((uint)S7_300_315.Read("DB1.DBD10.0")).ConvertToDouble(); //For Real Values To Double

                //DB2
                bool DB2_DBX0_0 = (bool)S7_300_315.Read("DB2.DBX0.0");
                bool DB2_DBX0_1 = (bool)S7_300_315.Read("DB2.DBX0.1");
                bool DB2_DBX0_2 = (bool)S7_300_315.Read("DB2.DBX0.2");
                bool DB2_DBX0_3 = (bool)S7_300_315.Read("DB2.DBX0.3");
                bool DB2_DBX0_4 = (bool)S7_300_315.Read("DB2.DBX0.4");

                //ts_boolean_value.IsOn = DBX0_0;
                //txt_int_value.EditValue = DBW2_0;
                //txt_Word.Text = (string.Format("DEC: {0}    HEX: {1}", DBW4_0_DEC, DBW4_0_HEX));
                //txt_DWord.Text = (string.Format("DEC: {0}    HEX: {1}", DBD6_0_DEC, DBD6_0_HEX));
                //txt_Real.EditValue = DBD10_0;

                DataTable table = new DataTable();
                table.Columns.Add("datablock");
                table.Columns.Add("value");

                //DB1
                DataRow row = table.NewRow();
                //row["datablock"] = "DB1.DBX0.0";
                //row["value"] = DBX0_0.ToString();
                //table.Rows.Add(row);
                //table.AcceptChanges();

                row = table.NewRow();
                row["datablock"] = "DB1.DBW2.0";
                row["value"] = DBW2_0.ToString();
                table.Rows.Add(row);
                table.AcceptChanges();

                row = table.NewRow();
                row["datablock"] = "DB1.DBW4.0";
                row["value"] = (string.Format("DEC: {0}    HEX: {1}", DBW4_0_DEC, DBW4_0_HEX));
                table.Rows.Add(row);
                table.AcceptChanges();

                row = table.NewRow();
                row["datablock"] = "DB1.DBD6.0";
                row["value"] = (string.Format("DEC: {0}    HEX: {1}", DBD6_0_DEC, DBD6_0_HEX));
                table.Rows.Add(row);
                table.AcceptChanges();

                row = table.NewRow();
                row["datablock"] = "DB1.DBD10.0";
                row["value"] = DBD10_0.ToString();
                table.Rows.Add(row);
                table.AcceptChanges();

                //DB2
                row = table.NewRow();
                row["datablock"] = "DB2.DBX0.0";
                row["value"] = DB2_DBX0_0.ToString();
                table.Rows.Add(row);
                table.AcceptChanges();

                row = table.NewRow();
                row["datablock"] = "DB2.DBX0.1";
                row["value"] = DB2_DBX0_1.ToString();
                table.Rows.Add(row);
                table.AcceptChanges();

                row = table.NewRow();
                row["datablock"] = "DB2.DBX0.2";
                row["value"] = DB2_DBX0_2.ToString();
                table.Rows.Add(row);
                table.AcceptChanges();

                row = table.NewRow();
                row["datablock"] = "DB2.DBX0.3";
                row["value"] = DB2_DBX0_3.ToString();
                table.Rows.Add(row);
                table.AcceptChanges();

                row = table.NewRow();
                row["datablock"] = "DB2.DBX0.4";
                row["value"] = DB2_DBX0_4.ToString();
                table.Rows.Add(row);
                table.AcceptChanges();

                ts_DBX00.IsOn = DB2_DBX0_0;
                ts_DBX01.IsOn = DB2_DBX0_1;
                ts_DBX02.IsOn = DB2_DBX0_2;
                ts_DBX03.IsOn = DB2_DBX0_3;
                ts_DBX04.IsOn = DB2_DBX0_4;

                grd_data.DataSource = null;
                grd_data.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PLC_Write_Values()
        {
            try
            {
                bool DBX0_0 = ts_boolean_value.IsOn;
                short DBW2_0 = (short)int.Parse(txt_int_value.Text.ToString());
                short DBW4_0 = (short)int.Parse(txt_Word.Text.ToString());
                int DBD6_0 =  int.Parse(txt_DWord.Text.ToString());
                double DBD10_0 = Convert.ToDouble(txt_Real.EditValue);

                S7_300_315.Write("DB1.DBX0.0", DBX0_0);
                S7_300_315.Write("DB1.DBW2.0", DBW2_0.ConvertToUshort());
                S7_300_315.Write("DB1.DBW4.0", DBW4_0.ConvertToUshort());
                S7_300_315.Write("DB1.DBD6.0", DBD6_0.ConvertToUInt());
                S7_300_315.Write("DB1.DBD10.0", DBD10_0.ConvertToUInt());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        public Siemens_Comm_Library()
        {
            InitializeComponent();
        }

        private void Siemens_Comm_Library_Load(object sender, EventArgs e)
        {
            try
            {
                S7_300_315_IPAddress = "192.168.0.1";
                S7_300_315 = new Plc(CpuType.S7300, S7_300_315_IPAddress, 0, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_cpu_address_EditValueChanged(object sender, EventArgs e)
        {
            S7_300_315_IPAddress = txt_cpu_address.Text.ToString();
            S7_300_315 = new Plc(CpuType.S7300, S7_300_315_IPAddress, 0, 2);
        }

        private void btn_checkAvailability_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Check_PLC_Availability();
        }

        private void btn_connect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Connect_PLC();
            Check_PLC_Connectivity();
        }

        private void btn_disconect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Disconect_PLC();
            Check_PLC_Connectivity();
        }

        private void btn_readValues_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PLC_Read_Values();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PLC_Write_Values();
        }

        private void ts_DBX00_Toggled(object sender, EventArgs e)
        {
            try
            {
                S7_300_315.Write("DB2.DBX0.0", ts_DBX00.IsOn);
                PLC_Read_Values();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ts_DBX01_Toggled(object sender, EventArgs e)
        {
            try
            {
                S7_300_315.Write("DB2.DBX0.1", ts_DBX01.IsOn);
                PLC_Read_Values();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ts_DBX02_Toggled(object sender, EventArgs e)
        {
            try
            {
                S7_300_315.Write("DB2.DBX0.2", ts_DBX02.IsOn);
                PLC_Read_Values();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ts_DBX03_Toggled(object sender, EventArgs e)
        {
            try
            {
                S7_300_315.Write("DB2.DBX0.3", ts_DBX03.IsOn);
                PLC_Read_Values();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ts_DBX04_Toggled(object sender, EventArgs e)
        {
            try
            {
                S7_300_315.Write("DB2.DBX0.4", ts_DBX04.IsOn);
                PLC_Read_Values();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}