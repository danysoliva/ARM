using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ARM.Classes;

namespace ARM.Classes
{
    public class UserLogin
    {
        public GrupoUser GrupoUsuario;
        private bool recuperado;
        private int id;
        private int idGrupo;
        private string nombreUser;
        private string ADuser;
        private string pass;

        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public int Id { get => id; set => id = value; }
        public int IdGrupo { get => idGrupo; set => idGrupo = value; }
        public string NombreUser { get => nombreUser; set => nombreUser = value; }
        public string ADuser1 { get => ADuser; set => ADuser = value; }
        public string Pass { get => pass; set => pass = value; }

        public UserLogin()
        {
            GrupoUsuario = new GrupoUser();
        }

        public bool RecuperarRegistroFromUser(string pUser)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                string query = @"SELECT top 1 id, 
                                       nombre, 
	                                   id_grupo_arm,
                                       ADUser
                                FROM[ACS].dbo.conf_usuarios
                               where[ADUser] = '"+ pUser +"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    NombreUser = dr.GetString(1);
                    idGrupo = dr.GetInt32(2);
                    ADuser = dr.GetString(3);
                    recuperado = true;
                }
                dr.Close();
                conn.Close();
                
            }
            catch (Exception ec)
            {
                recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

        public bool RecuperarRegistro(int pId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                string sql = @"SELECT id, 
                                       nombre, 
	                                   id_grupo_arm
                                FROM [ACS].dbo.conf_usuarios 
                                where id =" + pId;
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    NombreUser = dr.GetString(1);
                    idGrupo = dr.GetInt32(2);
                    recuperado = true;
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ec)
            {
                recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

        public int idNivelAcceso(int Iduser, int idSistema)
        {
            int id = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();
                string sql = "sp_get_nivel_acceso_for_user";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_sistema", idSistema);
                cmd.Parameters.AddWithValue("@id_user", Iduser);
                id = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                //recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return id;
        }
    }
}
