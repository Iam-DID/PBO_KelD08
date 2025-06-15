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
    public partial class V_Profil : Form
    {
        C_Profile Controller;
        public V_Profil(C_Profile controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void V_Profil_Load(object sender, EventArgs e)

        {
            Controller.RoundPicturebox(foto);
            Data_Akun akun = Controller.GetData();
            byte[] fotoprofil = akun.foto_profil as byte[];

            if (akun != null)
            {
                string namaDepan = akun.nama_mahasiswa.Split(' ')[0];
                nama.Text = namaDepan;
                nim.Text = akun.nim;
                prodi.Text = akun.nama_prodi;
                kelaspraktikum.Text = akun.nama_kelas;
                password.Text = "********";

                if (akun.foto_profil != null)
                {
                    using (MemoryStream ms = new MemoryStream(fotoprofil))
                    {
                        foto.Image = Image.FromStream(ms);
                    }
                }
            }
            else
            {
                MessageBox.Show("Data akun tidak ditemukan");
            }


            if (akun != null)
            {
                string namaDepan = akun.nama_mahasiswa.Split(' ')[0];
                nama.Text = namaDepan;
                prodi.Text = akun.nama_prodi;

            }
        }

        public void RefreshForm()
        {
            Data_Akun akun = Controller.GetData();
            if (akun != null)
            {
                string namaDepan = akun.nama_mahasiswa.Split(' ')[0];
                nama.Text = namaDepan;
                prodi.Text = akun.nama_prodi;
                kelaspraktikum.Text = akun.nama_kelas;

                if (akun.foto_profil != null && akun.foto_profil.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(akun.foto_profil))
                    {
                        (foto).Image = Image.FromStream(ms);
                    }
                }
            }
        }

        private void nama_Click(object sender, EventArgs e)
        {

        }

        private void updatephoto_Click(object sender, EventArgs e)
        {
            Controller.upload_photo();
            RefreshForm();
        }

        private void setingprofil_Click(object sender, EventArgs e)
        {
            Controller.switch_to_edit();
            RefreshForm();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gantipassword_Click(object sender, EventArgs e)
        {
            Controller.switch_to_gantipassword();
            RefreshForm();
        }

        private void infokelas_Click(object sender, EventArgs e)
        {
            bool cek = Controller.ceklengkap();
            if (cek)
            {
                Controller.SwitchToInfoKelas();
            }
        }

        private void jadwal_Click(object sender, EventArgs e)
        {
            bool cek = Controller.ceklengkap();
            if (cek)
            {
                Controller.SwitchToInfoJadwal();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool cek = Controller.ceklengkap();
            if (cek)
            {
                Controller.SwitchToRuangKelas();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool cek = Controller.ceklengkap();
            if (cek)
            {
                Controller.SwitchToGantiJadwal();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void foto_Click(object sender, EventArgs e)
        {

        }
    }
}
