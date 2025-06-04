using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PBO_KelD08.Core
{
    internal class DatabaseWrapper // parents dari semua controller
    {
        // Properti credential database dan koneksinya
        private static readonly string DB_HOST = "localhost";
        private static readonly string DB_DATABASE = "JAPRI2";
        private static readonly string DB_USERNAME = "postgres";
        private static readonly string DB_PASSWORD = "syadid1306";
        private static readonly string DB_PORT = "5432";

        private static NpgsqlConnection connection;

        // Method open dan close Koneksi
        public static void openConnection() // konstruktor
        {
            connection = new NpgsqlConnection($"Host={DB_HOST};Username={DB_USERNAME};Password={DB_PASSWORD};Database={DB_DATABASE};Port={DB_PORT}");
            connection.Open();
        }

        public static void closeConnection() // konstruktor
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        public static DataTable queryExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                        command.Prepare();
                    }

                    DataTable dataTable = new DataTable();
                    using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    return dataTable;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                closeConnection();
            }
        }
    }
}
