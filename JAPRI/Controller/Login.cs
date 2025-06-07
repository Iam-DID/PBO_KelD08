using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PBO_KelD08.JAPRI.Controller
{
    public class Login
    {
        private string username;
        private string password;
        //private string nama;
        public Login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public bool LoginAkun()
        {
            NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Username=postgres;password=syadid1306;Database=JAPRI;port=5432");
            connect.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand();
            npgsqlCommand.Connection = connect;
            npgsqlCommand.CommandText = $"Select * from Asisten_Praktikum Where nim = '{username}' and password = '{password}'";
            NpgsqlDataReader data = npgsqlCommand.ExecuteReader();
            bool result = data.Read();
            data.Close();
            if (result)
            {
                connect.Close();
                return true;
            }
            else
            {
                npgsqlCommand.CommandText = $"Select * from Ketua_Kelas Where nim = '{username}' and password = '{password}'";
                NpgsqlDataReader data2 = npgsqlCommand.ExecuteReader();
                bool result2 = data2.Read();
                data2.Close();
                if (result2)
                {
                    connect.Close();
                    return true;
                }
                else
                {
                    connect.Close();
                    return false;
                }

            }

        }


    }
}
