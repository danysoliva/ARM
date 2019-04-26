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
using EasyModbus;

namespace ARM.DUO
{
    public partial class Modbus_Test : DevExpress.XtraEditors.XtraForm
    {
        string server = "127.0.0.1";
        int port = 502;

        #region Developer Defined Functions

        private DataTable get_boolean_datatable() 
        {
            DataTable table = new DataTable();
            table.Columns.Add("address", System.Type.GetType("System.Int32"));
            table.Columns.Add("value", System.Type.GetType("System.Boolean"));

            return table;
        }

        private DataTable get_int_datatable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("address", System.Type.GetType("System.Int32"));
            table.Columns.Add("value", System.Type.GetType("System.Int32"));

            return table;
        }

        private DataTable read_coils() 
        {
            try
            {
                md_client.Connect();
                DataTable coils = get_boolean_datatable();
                bool[] coils_array = md_client.ReadCoils((int.Parse(txt_read_InitAddress.Text.ToString())-1), int.Parse(txt_read_Values.Text.ToString()));

                for (int i = 0; i < coils_array.Length; i++) 
                {
                    DataRow row = coils.NewRow();
                    row["address"] = (i + 1);
                    row["value"] = coils_array[i];
                    coils.Rows.Add(row);
                    coils.AcceptChanges();
                }

                md_client.Disconnect();
                return coils;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private DataTable read_discrete_inputs()
        {
            try
            {
                md_client.Connect();
                DataTable discrete_inputs = get_boolean_datatable();
                bool[] inputs_array = md_client.ReadDiscreteInputs((int.Parse(txt_read_InitAddress.Text.ToString())-1), int.Parse(txt_read_Values.Text.ToString()));
                int initAddress = (int.Parse(txt_read_InitAddress.Text.ToString()));


                foreach (bool item in inputs_array)
                {
                    DataRow row = discrete_inputs.NewRow();
                    row["address"] = initAddress++;
                    row["value"] = item;
                    discrete_inputs.Rows.Add(row);
                    discrete_inputs.AcceptChanges();
                }

                md_client.Disconnect();
                return discrete_inputs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private DataTable read_input_records()
        {
            try
            {
                md_client.Connect();
                DataTable input_records = get_int_datatable();
                int[] inputs_array = md_client.ReadInputRegisters((int.Parse(txt_read_InitAddress.Text.ToString())-1), int.Parse(txt_read_Values.Text.ToString()));
                int initAddress = (int.Parse(txt_read_InitAddress.Text.ToString()));


                foreach (int item in inputs_array)
                {
                    DataRow row = input_records.NewRow();
                    row["address"] = initAddress++;
                    row["value"] = item;
                    input_records.Rows.Add(row);
                    input_records.AcceptChanges();
                }

                md_client.Disconnect();
                return input_records;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private DataTable read_holding_records()
        {
            try
            {
                md_client.Connect();
                DataTable holding_records = get_int_datatable();
                int[] holdings_array = md_client.ReadHoldingRegisters((int.Parse(txt_read_InitAddress.Text.ToString())-1), int.Parse(txt_read_Values.Text.ToString()));
                int initAddress = (int.Parse(txt_read_InitAddress.Text.ToString()));


                foreach (int item in holdings_array)
                {
                    DataRow row = holding_records.NewRow();
                    row["address"] = initAddress++;
                    row["value"] = item;
                    holding_records.Rows.Add(row);
                    holding_records.AcceptChanges();
                }

                md_client.Disconnect();
                return holding_records;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        #endregion

        ModbusClient md_client;
        public Modbus_Test()
        {
            InitializeComponent();
        }

        private void Modbus_Test_Load(object sender, EventArgs e)
        {
            md_client = new ModbusClient(server, port);
        }

        private void btn_ReadValues_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                switch (rd_read.SelectedIndex) 
                {
                    case 0:
                        grdv_readpane.Columns.Clear();
                        grd_readpane.DataSource = null;
                        grd_readpane.DataSource = read_discrete_inputs();
                        grd_readpane.EndUpdate();
                        break;
                    case 1:
                        grdv_readpane.Columns.Clear();
                        grd_readpane.DataSource = null;
                        grd_readpane.DataSource = read_coils();
                        grd_readpane.EndUpdate();
                        break;
                    case 2:
                        grdv_readpane.Columns.Clear();
                        grd_readpane.DataSource = null;
                        grd_readpane.DataSource = read_input_records();
                        grd_readpane.EndUpdate();
                        break;
                    case 3:
                        grdv_readpane.Columns.Clear();
                        grd_readpane.DataSource = null;
                        grd_readpane.DataSource = read_holding_records();
                        grd_readpane.EndUpdate();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}