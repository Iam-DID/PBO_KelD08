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
    public partial class V_Setting_Profile_page : Form
    {
        C_Profile Controller;
        public V_Setting_Profile_page(C_Profile controller)
        {
            InitializeComponent();
            this.Controller = controller;
        }

        private void V_Setting_Profile_page_Load(object sender, EventArgs e)
        {
            List<Data_Kelas> kelasList = Controller.Getlistkelas();
            Data_Akun akun = Controller.GetData();

            if (akun != null)
            {
                nama.Text = akun.nama_mahasiswa;
                nim.Text = akun.nim;
                prodi.Text = akun.nama_prodi;
            }
            kelaspraktikum.DataSource = null;
            kelaspraktikum.DataSource = kelasList;
            kelaspraktikum.DisplayMember = "nama_kelas";  
            kelaspraktikum.ValueMember = "id_kelas";     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void batal_Click(object sender, EventArgs e)
        {

        }
        private void ubah_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin melanjutkan?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (kelaspraktikum.SelectedItem != null)
                {
                    Data_Akun akun = Controller.GetData();
                    int selectedId = Convert.ToInt32(kelaspraktikum.SelectedValue);
                    if (akun.id_kelas == 0)
                    {
                        Controller.Updatekelas(selectedId);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kelas Telah Dipilih dan Tidak Bisa Diganti", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
            this.Close();
        }

        private void batal_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
