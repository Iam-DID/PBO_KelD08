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
    }
}
