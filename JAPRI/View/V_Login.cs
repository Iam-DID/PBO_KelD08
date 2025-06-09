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

namespace PBO_KelD08
{
    public partial class V_Login : Form
    {
        C_LandingPage Controller;
        public V_Login(C_LandingPage controller)
        {
            InitializeComponent();
            this.Controller = controller;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.login_validation();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controller.switch_to_register();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '*')
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }
        }

        private void V_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
