using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PBO_KelD08.JAPRI.Model
{
    public abstract class AM_Connectdb
    {
        protected string db = "Host=localhost;Username=postgres;password=syadid1306;Database=JAPRI;port=5432";
        private NpgsqlConnection Conn;
        protected NpgsqlConnection conn
        {
            get
            {
                return Conn;
            }
            set
            {
                if (Conn != null)
                {
                    Conn.Close();
                    Conn.Dispose();
                    Conn = null;
                }
                Conn = value;
                Conn.Open();
            }
        }

        public void Execute_No_Return(string Querry)
        {
            using (conn = new NpgsqlConnection(db))
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = Querry;
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable Execute_With_Return(string Querry)
        {
            using (conn = new NpgsqlConnection(db))
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = Querry;
                DataTable Data = new DataTable();
                Data.Load(cmd.ExecuteReader());
                return Data;
            }
        }

        public void Execute_No_Return1(string query, Dictionary<string, object> parameters)
        {
            using (conn = new NpgsqlConnection(db))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //public DataTable Execute_With_Return(NpgsqlCommand Querry)
        //{
        //    using (conn = new NpgsqlConnection(db))
        //    {
        //        Querry.Connection = conn;
        //        DataTable Data = new DataTable();
        //        Data.Load(Querry.ExecuteReader());
        //        return Data;
        //    }
        //}
    }
}
