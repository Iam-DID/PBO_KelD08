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

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
