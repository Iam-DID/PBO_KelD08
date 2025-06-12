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
    public partial class V_Login_Page : Form
    {
        C_LandingPage Controller;
        public V_Login_Page(C_LandingPage controller)
        {
            InitializeComponent();
            this.Controller = controller;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            Controller.login_validation();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controller.switch_to_register(this);
        }

        private void V_Login_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
