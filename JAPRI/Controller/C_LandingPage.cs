using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBO_KelD08.JAPRI.Model;
using PBO_KelD08.JAPRI.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBO_KelD08.JAPRI.Controller
{
    public class C_LandingPage
    {
        public V_Landing_Page v_Landing;
        public V_Login_Page v_Login;
        public V_Register_Page v_Register;
        M_Akun m_Akun = new M_Akun();

        public C_LandingPage()
        {
            v_Landing = new V_Landing_Page(this);
            v_Login = new V_Login_Page(this);
            v_Login.Location = new Point(0, 102);
            v_Register = new V_Register_Page(this);
        }

        public void login_validation()
        {
            if (string.IsNullOrEmpty(v_Login.username.Text) || string.IsNullOrEmpty(v_Login.password.Text))
            {
                MessageBox.Show("Harap Isi Form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            m_Akun.Get(v_Login.username.Text, v_Login.password.Text);
            if (M_Session.session_status)
            {
                if (M_Session.status_asprak)
                {
                    //MessageBox.Show("Login Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //asprak dashboard = new asprak();
                    //v_Login.Hide();
                    //dashboard.ShowDialog();
                    //v_Login.Close();
                }
                else
                {
                    //MessageBox.Show("Login Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Ketkel dashboard = new Ketkel();
                    //v_Login.Hide();
                    //dashboard.ShowDialog();
                    //v_Login.Close();
                }
            }
            else
            {
                MessageBox.Show("Akun Tidak Ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void register_validation()
        {
            if (string.IsNullOrEmpty(v_Register.username.Text) || string.IsNullOrEmpty(v_Register.password.Text) || v_Register.password_validation.Text != v_Register.password.Text || v_Register.peran.SelectedItem == null)
            {
                MessageBox.Show("Harap Isi Form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool nimexistindb = m_Akun.IsNimExistindb(v_Register.username.Text);
            if (nimexistindb)
            {
                bool nimexist = m_Akun.IsNimExist(v_Register.username.Text);
                if (nimexist)
                {
                    string role = v_Register.peran.SelectedItem.ToString();
                    bool status = (role == "Asisten Praktikum");

                    Data_Akun data_akun = new Data_Akun
                    {
                        nim = v_Register.username.Text,
                        password = v_Register.password.Text,
                        status_asprak = status
                    };
                    try
                    {
                        m_Akun.Insert(data_akun);
                        //v_Login = new V_Login(this);
                        //v_Login.Location = new Point(0, 102);
                        MessageBox.Show("Register Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        v_Register.Hide();
                    }
                    catch
                    {
                        MessageBox.Show("Gagal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Akun Sudah Dibuat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else 
            {
                MessageBox.Show("NIM anda Tidak terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void switch_to_register(Form form)
        {
            form.Hide();
            //v_Register.ShowDialog();
            v_Register.Show();
        }
        public void switch_to_login(Form form)
        {
            form.Hide();
            //v_Login.ShowDialog();
            v_Login.Show();
        }
    }
}

