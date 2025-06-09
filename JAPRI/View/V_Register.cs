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
    public partial class V_Register : Form
    {
        C_LandingPage Controller;
        public V_Register(C_LandingPage controller)
        {
            InitializeComponent();
            this.Controller = controller;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void V_Register_Load(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (password_validation.PasswordChar == '*')
            {
                password_validation.PasswordChar = '\0';
            }
            else
            {
                password_validation.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.register_validation();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

