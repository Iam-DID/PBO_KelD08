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
    public partial class V_Ganti_Password_Page : Form
    {
        C_Profile Controller;
        public V_Ganti_Password_Page(C_Profile controller)
        {
            InitializeComponent();
            this.Controller = controller;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void V_Ganti_Password_Page_Load(object sender, EventArgs e)
        {

        }

        private void ubah_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ubah_Click_1(object sender, EventArgs e)
        {       
            Controller.updatepassword();
            this.Close();
        }
    }
}
