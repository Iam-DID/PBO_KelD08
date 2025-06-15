using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBO_KelD08.JAPRI.Model;
using PBO_KelD08.JAPRI.View;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PBO_KelD08.JAPRI.Controller
{
    
    public class C_Profile
    {
        private C_Main_Menu mainMenu;

        V_Setting_Profile_page v_setting_profile_page;
        V_Ganti_Password_Page v_ganti_password_page;
        M_Profil m_profil = new M_Profil();

        public V_Profil v_profil;
        public V_Profil_Ketua_Kelas_Page v_profil_ketua;

        public C_Profile(C_Main_Menu C) { 
            this.mainMenu = C;
            v_profil = new V_Profil(this);
            v_profil_ketua = new V_Profil_Ketua_Kelas_Page(this);
            v_setting_profile_page = new V_Setting_Profile_page(this);
            v_ganti_password_page = new V_Ganti_Password_Page(this);
        }

        public int getidkelas()
        {
            Data_Akun data = GetData();
            return data.id_kelas;
        }
        public void SwitchToInfoKelas()
        {
            mainMenu.SwitchForm(v_profil, mainMenu.InfoKelasController.GetView());
        }
        public void SwitchToInfoKelasKetua()
        {
            mainMenu.SwitchForm(v_profil_ketua, mainMenu.InfoKelasController.GetViewKetua());
        }

        public void SwitchToInfoJadwal()
        {
            mainMenu.SwitchForm(v_profil, mainMenu.JadwalController.GetView());
        }

        public void SwitchToRuangKelas()
        {
            mainMenu.SwitchForm(v_profil, mainMenu.RuangKelasController.GetView());
        }

        public void SwitchToGantiJadwal()
        {
            mainMenu.SwitchForm(v_profil, mainMenu.GantiJadwalController.GetView());
        }

        public Form GetViewKetua()
        {
            return v_profil_ketua;
        }

        public Form GetView()
        {
            return v_profil;

        }

        public Data_Akun GetData() {
            string namakelas = "-";
            Data_Akun akun =  null;
            DataTable Data = m_profil.GetData();
            if (Data.Rows[0]["id_kelas"] != DBNull.Value)
            {
                DataTable Data2 = m_profil.Carikelas(Convert.ToInt32(Data.Rows[0]["id_kelas"]));

                if (Data2.Rows.Count > 0)
                {
                    namakelas = Data2.Rows[0]["nama_kelas"].ToString();
                }
            }
            akun = new Data_Akun
            {
                id_akun = Convert.ToInt32(Data.Rows[0]["id_akun"]),
                nim = Data.Rows[0]["nim"].ToString(),
                password = Data.Rows[0]["password"].ToString(),
                id_kelas = Data.Rows[0]["id_kelas"] != DBNull.Value ? Convert.ToInt32(Data.Rows[0]["id_kelas"]) : 0,
                status_asprak = Convert.ToBoolean(Data.Rows[0]["status_asprak"]),
                foto_profil = Data.Rows[0]["foto_profil"] != DBNull.Value ? (byte[])Data.Rows[0]["foto_profil"] : null,
                nama_mahasiswa = Data.Rows[0]["nama_mahasiswa"].ToString(),
                nama_prodi = Data.Rows[0]["nama_prodi"].ToString(),
                nama_kelas = namakelas
            };
            return akun;
        }
        public void Updatekelas(int id_kelas) 
        {
          m_profil.Updatekelas(id_kelas, M_Session.id_session);
        }
        public void RoundPicturebox(PictureBox pb)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pb.Width, pb.Height);
            pb.Region = new Region(path);
        }

        public bool ceklengkap()
        {
            Data_Akun akun = GetData();
            if (akun.id_kelas == null || akun.id_kelas == 0 )
            {
                MessageBox.Show("Harap Lengkapi Profile Terlebih Dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }


        }
        public void updatepassword(string passwordlama,string passwordbaru, string passwordvalidation)
        {
            Data_Akun akun = GetData();
            if (string.IsNullOrEmpty(passwordlama) || string.IsNullOrEmpty(passwordbaru) || passwordbaru != passwordvalidation)
            {
                MessageBox.Show("Harap Cek Ulang Form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (passwordlama != akun.password)
                {
                    MessageBox.Show("Password Lama Salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else 
                {
                    akun.password = passwordbaru;
                    m_profil.Update(akun,M_Session.id_session);
                    MessageBox.Show("Ganti Password Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }
        public void upload_photo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Pilih Photo";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);
                m_profil.Updatephoto(imageBytes,Convert.ToInt32(M_Session.id_session));
            }

        }
        public List<Data_Kelas> Getlistkelas()
        {
            DataTable data = m_profil.getkelas();
            List<Data_Kelas> list = new List<Data_Kelas>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Data_Kelas data_kelas = new Data_Kelas
                {
                    id_kelas = (int)data.Rows[i]["id_kelas"],
                    nama_kelas = data.Rows[i]["nama_kelas"].ToString(),
                    kode_mata_kuliah = data.Rows[i]["kode_mata_kuliah"].ToString(),
                };
                list.Add(data_kelas);
            }
            return list;
        }
        public void switch_to_edit()
        {
            v_setting_profile_page = new V_Setting_Profile_page(this);
            v_setting_profile_page.ShowDialog();
        }
        public void switch_to_gantipassword()
        {
            v_ganti_password_page = new V_Ganti_Password_Page(this);
            v_ganti_password_page.ShowDialog();
        }


        

    }
}
