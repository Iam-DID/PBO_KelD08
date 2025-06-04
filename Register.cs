using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Npgsql;

namespace PBO_KelD08
{
    public class Register
    {
        private string username;
        private string password;
        private string role;
        public Register(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public bool Cek_Akun()
        {
            NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Username=postgres;password=syadid1306;Database=JAPRI;port=5432");
            connect.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand();
            npgsqlCommand.Connection = connect;
            npgsqlCommand.CommandText = $"Select * from Mahasiswa Where nim = '{username}'";
            NpgsqlDataReader cek_nim = npgsqlCommand.ExecuteReader();
            bool result_cek = cek_nim.Read();
            connect.Close();
            return result_cek;
        }

        public bool TambahAkun()
        {
            bool validasi_password = password.Length == 8 &&
                                     //Regex.IsMatch(password, "[A-Z]") &&
                                     //Regex.IsMatch(password, "[a-z]") &&
                                     Regex.IsMatch(password, "[0-9]");
                                    //Regex.IsMatch(password, "[^a-zA-Z0-9]");

            if (validasi_password)
            {
                if (role == "Asisten Praktikum")
                {
                    NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Username=postgres;password=syadid1306;Database=JAPRI;port=5432");
                    connect.Open();
                    NpgsqlCommand npgsqlCommand = new NpgsqlCommand();
                    npgsqlCommand.Connection = connect;
                    npgsqlCommand.CommandText = $"INSERT INTO Asisten_praktikum (nim, password) Values ('{username}','{password}')";
                    try
                    {
                        npgsqlCommand.ExecuteNonQuery();
                        connect.Close();
                        return true;
                    }
                    catch
                    {
                        connect.Close();
                        return false;
                    }
                }
                else 
                {
                    NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Username=postgres;password=syadid1306;Database=JAPRI;port=5432");
                    connect.Open();
                    NpgsqlCommand npgsqlCommand = new NpgsqlCommand();
                    npgsqlCommand.Connection = connect;
                    npgsqlCommand.CommandText = $"INSERT INTO ketua_kelas (nim, password) Values ('{username}','{password}')";
                    try
                    {
                        npgsqlCommand.ExecuteNonQuery();
                        connect.Close();
                        return true;
                    }
                    catch
                    {
                        connect.Close();
                        return false;
                    }
                }


                //NpgsqlCommand npgsqlCommand = new NpgsqlCommand();
                //npgsqlCommand.Connection = connect;
                //npgsqlCommand.CommandText = $"insert into Asisten_praktikum (nim,password) values ({username},{password})";
                //NpgsqlDataReader data = npgsqlCommand.ExecuteReader();
                //bool result = data.Read();
                //return result;
            }
            else { return false; }
        }
    }
}
