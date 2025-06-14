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
using PBO_KelD08.JAPRI.Controller;
using PBO_KelD08.JAPRI.Model;

namespace PBO_KelD08.JAPRI.View
{
    public partial class V_Info_Kelas : Form
    {
        C_Info_Kelas Controller;
        public V_Info_Kelas(C_Info_Kelas controller)
        {
            InitializeComponent();
            this.Controller = controller;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.SwitchToProfile();
        }

        private void infokelas_Click(object sender, EventArgs e)
        {

        }

        private void jadwal_Click(object sender, EventArgs e)
        {
            Controller.SwitchToInfoJadwal();
        }

        private void ruangkelas_Click(object sender, EventArgs e)
        {
            Controller.SwitchToRuangKelas();
        }

        private void gantijadwal_Click(object sender, EventArgs e)
        {
            Controller.SwitchToGantiJadwal();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void V_Info_Kelas_Load(object sender, EventArgs e)
        {
            List<Data_Peserta_Kelas> daftarpeserta = Controller.ambilpeserta();
            Controller.setkelas();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = daftarpeserta;
            dataGridView1.Columns["no"].HeaderText = "No";
            dataGridView1.Columns["nim"].HeaderText = "NIM Mahasiswa";
            dataGridView1.Columns["nama_mahasiswa"].HeaderText = "Nama Mahasiswa";
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["id_kelas"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["No"].FillWeight = 30;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
