using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PBO_KelD08
{
    public partial class FormDashboard : Form
    {
        string username;
        public FormDashboard(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            string nama = getnama(username);
            label2.Text = $"Halo {nama} !!";
        }

        private string getnama(string username)
        {
            NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Username=postgres;password=syadid1306;Database=JAPRI;port=5432");
            connect.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand();
            npgsqlCommand.Connection = connect;
            npgsqlCommand.CommandText = $"Select Nama_Mahasiswa from Mahasiswa Where nim = '{username}'";
            NpgsqlDataReader data = npgsqlCommand.ExecuteReader();
            bool result = data.Read();
            string nama = data["Nama_Mahasiswa"].ToString();
            data.Close();
            connect.Close();
            return nama;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
