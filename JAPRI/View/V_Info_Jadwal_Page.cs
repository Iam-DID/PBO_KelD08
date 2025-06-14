using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBO_KelD08.JAPRI.Controller;
using PBO_KelD08.JAPRI.Model;

namespace PBO_KelD08.JAPRI.View
{
    public partial class V_Info_Jadwal_Page : Form
    {
        C_Jadwal Controller;
        public V_Info_Jadwal_Page(C_Jadwal controller)
        {
            InitializeComponent();
            this.Controller = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.SwitchToProfile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controller.SwitchToGantiJadwal();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infokelas_Click(object sender, EventArgs e)
        {
            Controller.SwitchToInfoKelas();
        }

        private void jadwal_Click(object sender, EventArgs e)
        {

        }

        private void ruangkelas_Click(object sender, EventArgs e)
        {
            Controller.SwitchToRuangKelas();
        }

        private void V_Info_Jadwal_Page_Load(object sender, EventArgs e)
        {
            List<Data_Jadwal> daftarjadwal = Controller.ambiljadwal();
            Controller.setSemester();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("no", "No");
            dataGridView1.Columns.Add("kelas", "Kelas");
            dataGridView1.Columns.Add("hari", "Hari");
            dataGridView1.Columns.Add("mulai", " Jam Mulai");
            dataGridView1.Columns.Add("selesai", "Jam Selesai");

            dataGridView1.Columns["no"].FillWeight = 30;


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var jadwal in daftarjadwal)
            {
                dataGridView1.Rows.Add(
                    jadwal.no,
                    jadwal.nama_kelas,
                    jadwal.hari,
                    jadwal.jam_mulai.ToString(@"hh\:mm"),
                    jadwal.jam_selesai.ToString(@"hh\:mm")
                );
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
