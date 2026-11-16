using System;
using System.Data.SqlClient;

namespace ARM.Classes
{
    public class OP_Production_Orders_Main_Mix
    {
        long _id;
        long _order_id;
        int _mix_num;
        string _mix_code;
        string _mix_fullCode;
        int _fp_lot_number;
        decimal _plan_kg;
        int _plan_batch;
        decimal? _real_kg;
        int? _real_batch;
        int? _start_by;
        DateTime? _start_date;
        int? _last_by;
        DateTime? _last_execution;
        int? _end_by;
        DateTime? _end_date;
        int _status;
        bool _active_mix;
        bool _allow_suspend;
        decimal? _real_oil_apply;
        bool? _activa_post_pellet;
        bool? _mixta;
        int? _bin_add_position;
        bool? _complete_teorico;
        int? _cant_batch_run;
        bool? _bit_alarma_micros;
        bool _recuperado;

        #region Propiedades
        public long id
        {
            get { return _id; }
            set
            {
                ValidarNoNull(value, nameof(id));
                _id = value;
            }
        }

        public long order_id
        {
            get { return _order_id; }
            set
            {
                ValidarNoNull(value, nameof(order_id));
                _order_id = value;
            }
        }

        public int mix_num
        {
            get { return _mix_num; }
            set
            {
                ValidarNoNull(value, nameof(mix_num));
                _mix_num = value;
            }
        }

        public string mix_code
        {
            get { return _mix_code; }
            set
            {
                ValidarNoNull(value, nameof(mix_code));
                _mix_code = value;
            }
        }

        public string mix_fullCode
        {
            get { return _mix_fullCode; }
            set
            {
                ValidarNoNull(value, nameof(mix_fullCode));
                _mix_fullCode = value;
            }
        }

        public int fp_lot_number
        {
            get { return _fp_lot_number; }
            set
            {
                ValidarNoNull(value, nameof(fp_lot_number));
                _fp_lot_number = value;
            }
        }

        public decimal plan_kg
        {
            get { return _plan_kg; }
            set
            {
                ValidarNoNull(value, nameof(plan_kg));
                _plan_kg = value;
            }
        }

        public int plan_batch
        {
            get { return _plan_batch; }
            set
            {
                ValidarNoNull(value, nameof(plan_batch));
                _plan_batch = value;
            }
        }

        public decimal? real_kg
        {
            get { return _real_kg; }
            set
            {
                ValidarNoNull(value, nameof(real_kg));
                _real_kg = value;
            }
        }

        public int? real_batch
        {
            get { return _real_batch; }
            set
            {
                ValidarNoNull(value, nameof(real_batch));
                _real_batch = value;
            }
        }

        public int? start_by
        {
            get { return _start_by; }
            set
            {
                ValidarNoNull(value, nameof(start_by));
                _start_by = value;
            }
        }

        public DateTime? start_date
        {
            get { return _start_date; }
            set
            {
                ValidarNoNull(value, nameof(start_date));
                _start_date = value;
            }
        }

        public int? last_by
        {
            get { return _last_by; }
            set
            {
                ValidarNoNull(value, nameof(last_by));
                _last_by = value;
            }
        }

        public DateTime? last_execution
        {
            get { return _last_execution; }
            set
            {
                ValidarNoNull(value, nameof(last_execution));
                _last_execution = value;
            }
        }

        public int? end_by
        {
            get { return _end_by; }
            set
            {
                ValidarNoNull(value, nameof(end_by));
                _end_by = value;
            }
        }

        public DateTime? end_date
        {
            get { return _end_date; }
            set
            {
                ValidarNoNull(value, nameof(end_date));
                _end_date = value;
            }
        }

        public int status
        {
            get { return _status; }
            set
            {
                ValidarNoNull(value, nameof(status));
                _status = value;
            }
        }

        public bool active_mix
        {
            get { return _active_mix; }
            set
            {
                ValidarNoNull(value, nameof(active_mix));
                _active_mix = value;
            }
        }

        public bool allow_suspend
        {
            get { return _allow_suspend; }
            set
            {
                ValidarNoNull(value, nameof(allow_suspend));
                _allow_suspend = value;
            }
        }

        public decimal? real_oil_apply
        {
            get { return _real_oil_apply; }
            set
            {
                ValidarNoNull(value, nameof(real_oil_apply));
                _real_oil_apply = value;
            }
        }

        public bool? activa_post_pellet
        {
            get { return _activa_post_pellet; }
            set
            {
                ValidarNoNull(value, nameof(activa_post_pellet));
                _activa_post_pellet = value;
            }
        }

        public bool? mixta
        {
            get { return _mixta; }
            set
            {
                ValidarNoNull(value, nameof(mixta));
                _mixta = value;
            }
        }

        public int? bin_add_position
        {
            get { return _bin_add_position; }
            set
            {
                ValidarNoNull(value, nameof(bin_add_position));
                _bin_add_position = value;
            }
        }

        public bool? complete_teorico
        {
            get { return _complete_teorico; }
            set
            {
                ValidarNoNull(value, nameof(complete_teorico));
                _complete_teorico = value;
            }
        }

        public int? cant_batch_run
        {
            get { return _cant_batch_run; }
            set
            {
                ValidarNoNull(value, nameof(cant_batch_run));
                _cant_batch_run = value;
            }
        }

        public bool? bit_alarma_micros
        {
            get { return _bit_alarma_micros; }
            set
            {
                ValidarNoNull(value, nameof(bit_alarma_micros));
                _bit_alarma_micros = value;
            }
        }

        public bool Recuperado
        {
            get { return _recuperado; }
            set { _recuperado = value; }
        }
        #endregion

        public bool RecuperarRegistro(int id_mix)
        {
            Recuperado = false;

            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    con.Open();
                    string sql = @"SELECT [id]
                                          ,[order_id]
                                          ,[mix_num]
                                          ,[mix_code]
                                          ,[mix_fullCode]
                                          ,CAST([fp_lot_number] AS int) AS [fp_lot_number]
                                          ,[plan_kg]
                                          ,[plan_batch]
                                          ,[real_kg]
                                          ,[real_batch]
                                          ,[start_by]
                                          ,[start_date]
                                          ,[last_by]
                                          ,[last_execution]
                                          ,[end_by]
                                          ,[end_date]
                                          ,[status]
                                          ,[active_mix]
                                          ,[allow_suspend]
                                          ,[real_oil_apply]
                                          ,[activa_post_pellet]
                                          ,[mixta]
                                          ,[bin_add_position]
                                          ,[complete_teorico]
                                          ,[cant_batch_run]
                                          ,[bit_alarma_micros]
                                   FROM [dbo].[OP_Production_Orders_Main_Mix]
                                   WHERE [id] = @id_mix";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id_mix", id_mix);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (!dr.Read())
                                return false;

                            id = dr.GetInt64(dr.GetOrdinal("id"));
                            order_id = dr.GetInt64(dr.GetOrdinal("order_id"));
                            mix_num = dr.GetInt32(dr.GetOrdinal("mix_num"));
                            mix_code = dr.GetString(dr.GetOrdinal("mix_code"));
                            mix_fullCode = dr.GetString(dr.GetOrdinal("mix_fullCode"));
                            fp_lot_number = dr.GetInt32(dr.GetOrdinal("fp_lot_number"));
                            plan_kg = dr.GetDecimal(dr.GetOrdinal("plan_kg"));
                            plan_batch = dr.GetInt32(dr.GetOrdinal("plan_batch"));
                            AsignarDecimal(dr, "real_kg", valor => real_kg = valor);
                            AsignarEntero(dr, "real_batch", valor => real_batch = valor);
                            AsignarEntero(dr, "start_by", valor => start_by = valor);
                            AsignarFecha(dr, "start_date", valor => start_date = valor);
                            AsignarEntero(dr, "last_by", valor => last_by = valor);
                            AsignarFecha(dr, "last_execution", valor => last_execution = valor);
                            AsignarEntero(dr, "end_by", valor => end_by = valor);
                            AsignarFecha(dr, "end_date", valor => end_date = valor);
                            status = dr.GetInt32(dr.GetOrdinal("status"));
                            active_mix = dr.GetBoolean(dr.GetOrdinal("active_mix"));
                            allow_suspend = dr.GetBoolean(dr.GetOrdinal("allow_suspend"));
                            AsignarDecimal(dr, "real_oil_apply", valor => real_oil_apply = valor);
                            AsignarBit(dr, "activa_post_pellet", valor => activa_post_pellet = valor);
                            AsignarBit(dr, "mixta", valor => mixta = valor);
                            AsignarEntero(dr, "bin_add_position", valor => bin_add_position = valor);
                            AsignarBit(dr, "complete_teorico", valor => complete_teorico = valor);
                            AsignarEntero(dr, "cant_batch_run", valor => cant_batch_run = valor);
                            AsignarBit(dr, "bit_alarma_micros", valor => bit_alarma_micros = valor);
                            Recuperado = true;
                        }
                    }
                }
            }
            catch (Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }

            return Recuperado;
        }

        static void ValidarNoNull(object valor, string propiedad)
        {
            if (valor == null)
                throw new ArgumentNullException(propiedad, "No se permiten valores null.");
        }

        static void AsignarDecimal(SqlDataReader dr, string columna, Action<decimal> asignar)
        {
            int indice = dr.GetOrdinal(columna);
            if (!dr.IsDBNull(indice))
                asignar(dr.GetDecimal(indice));
        }

        static void AsignarEntero(SqlDataReader dr, string columna, Action<int> asignar)
        {
            int indice = dr.GetOrdinal(columna);
            if (!dr.IsDBNull(indice))
                asignar(dr.GetInt32(indice));
        }

        static void AsignarFecha(SqlDataReader dr, string columna, Action<DateTime> asignar)
        {
            int indice = dr.GetOrdinal(columna);
            if (!dr.IsDBNull(indice))
                asignar(dr.GetDateTime(indice));
        }

        static void AsignarBit(SqlDataReader dr, string columna, Action<bool> asignar)
        {
            int indice = dr.GetOrdinal(columna);
            if (!dr.IsDBNull(indice))
                asignar(dr.GetBoolean(indice));
        }
    }
}
