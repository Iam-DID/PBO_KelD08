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
    public partial class V_Info_Kelas_Ketua_Page : Form
    {
        C_Info_Kelas Controller;
        public V_Info_Kelas_Ketua_Page(C_Info_Kelas controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void V_Info_Kelas_Ketua_Page_Load(object sender, EventArgs e)
        {
            Data_Jadwal datajadwalfix = Controller.datakelasuser();

            ruang.Text = datajadwalfix.nama_ruangan;
            jammulai.Text = datajadwalfix.jam_mulai.ToString(@"hh\:mm"); ;
            label2.Text = datajadwalfix.jam_selesai.ToString(@"hh\:mm"); ;



            Data_Akun datakelas = Controller.GetDatakelas();
            matakuliah.Text = datakelas.nama_kelas;

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

            Data_PilihanJadwal jadwal = Controller.GetlistJadwalpengganti();
            if (jadwal != null)
            {
                ruangpengganti.Text = jadwal.nama_ruangan;
                jammulaipengganti.Text = jadwal.jam_mulai.ToString(@"hh\:mm");
                jamakhirpengganti.Text = jadwal.jam_selesai.ToString(@"hh\:mm");

                //nama.Text = namaDepan;
                //prodi.Text = akun.nama_prodi;

            }

            else
            {
                label6.Text = "";
                label4.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller.SwitchToInfoProfileKetua();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.updatenote(pesanaksprak.Text);
        }
    }


}
