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
    public partial class V_Ganti_Jadwal : Form
    {
        C_Ganti_Jadwal Controller;
        public V_Ganti_Jadwal(C_Ganti_Jadwal controller)
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
            Controller.SwitchToInfoKelas();
        }

        private void jadwal_Click(object sender, EventArgs e)
        {
            Controller.SwitchToInfoJadwal();
        }

        private void ruangkelas_Click(object sender, EventArgs e)
        {
            Controller.SwitchToRuangKelas();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void V_Ganti_Jadwal_Load(object sender, EventArgs e)
        {
            List<Data_Ruangan> ruanganList = Controller.GetlistRuangan();
            //Data_Akun akun = Controller.GetData();
            ruangan.DataSource = null;
            ruangan.DataSource = ruanganList;
            ruangan.DisplayMember = "nama_ruangan"; 
            ruangan.ValueMember = "id_ruangan";     
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Controller.setpilihan();
        }

        private void ruangan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void jammulai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jammulai.SelectedItem != null)
            {
                string jamMulaiDipilih = jammulai.SelectedItem.ToString();
                jamselesai.Text = Controller.HitungJamSelesai(jamMulaiDipilih);
            }
        }

        private void jamselesai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

