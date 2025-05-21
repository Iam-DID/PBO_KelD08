using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_KelD08
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
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
            Login Userlogin = new Login(textBox1.Text, textBox2.Text);
            bool validasi = Userlogin.LoginAkun();
            if (textBox1.Text != "" && textBox2.Text != "")
            {

                if (validasi)
                {
                    MessageBox.Show("Login Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormDashboard dashboard = new FormDashboard(textBox1.Text);
                    this.Hide();
                    dashboard.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Akun Tidak Ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Harap Isi Form Terlebih Dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister dashboard = new FormRegister();
            this.Hide();
            dashboard.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
