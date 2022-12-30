using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM.Classes
{
    public class MateriaPrima
    {
        public MateriaPrima() { }

        public int IdRM_ACS;
        public int IdRM_APMS;
        public string Nombre;
        public string ItemCode;
        public bool Recuperado;

        public bool RecuperarRegistro(int pIdRM_ACS)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_master_raw_material_class", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_rm_acs", pIdRM_ACS);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdRM_ACS = dr.GetInt32(0);
                    IdRM_APMS = dr.GetInt32(1);
                    Nombre = dr.GetString(2);
                    ItemCode = dr.GetString(3);
                    Recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return Recuperado;
        }

    }
}
