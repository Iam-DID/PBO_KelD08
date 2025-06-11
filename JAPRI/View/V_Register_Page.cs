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
    public partial class V_Register_Page : Form
    {
        C_LandingPage Controller;
        public V_Register_Page(C_LandingPage controller)
        {
            InitializeComponent();
            this.Controller = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.register_validation();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controller.switch_to_login(this);
        }
    }
}
