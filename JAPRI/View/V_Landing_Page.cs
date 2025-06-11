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
    public partial class V_Landing_Page : Form
    {
        C_LandingPage Controller;
        public V_Landing_Page(C_LandingPage controller)
        {
            InitializeComponent();
            this.Controller = controller;
        }

        private void LAnding_page_Load(object sender, EventArgs e)
        {

        }

        private void LAnding_page_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.switch_to_register(this);
        }

        private void login_Click(object sender, EventArgs e)
        {
            Controller.switch_to_login(this);
        }
    }
}
