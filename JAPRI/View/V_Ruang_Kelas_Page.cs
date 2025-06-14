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
    public partial class V_Ruang_Kelas_Page : Form
    {

        C_Ruang_Kelas Controller;
        public V_Ruang_Kelas_Page(C_Ruang_Kelas controller)
        {
            InitializeComponent();
            this.Controller = controller;
        }

        private void profil_Click(object sender, EventArgs e)
        {
            Controller.SwitchToProfile();
        }

        private void infokelas_Click(object sender, EventArgs e)
        {
            Controller.SwitchToInfoKelas();
        }

        private void jadwal_Click(object sender, EventArgs e)
        {
            Controller.SwitchToInfoJadwal();
        }

        private void ruangkelas_Click(object sender, EventArgs e)
        {

        }

        private void gantijadwal_Click(object sender, EventArgs e)
        {
            Controller.SwitchToGantiJadwal();
        }

        private void V_Ruang_Kelas_Page_Load(object sender, EventArgs e)
        {
            List<Data_Ruangan> daftarruangan = Controller.ambilruangan();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("no", "No");
            dataGridView1.Columns.Add("nama_ruangan", "Nama Ruangan");

            dataGridView1.Columns["no"].FillWeight = 30;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var ruang in daftarruangan)
            {
                dataGridView1.Rows.Add(
                    ruang.no,
                    ruang.nama_ruangan
                );
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
