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
        V_Profil v_profil;
        V_Setting_Profile_page v_setting_profile_page;
        M_Profil m_profil = new M_Profil();

        public C_Profile() { 
            v_profil = new V_Profil(this);
            v_setting_profile_page = new V_Setting_Profile_page(this);
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
        public void Updatekelas() 
        {
            if (v_setting_profile_page.kelaspraktikum.SelectedItem != null)
            {
                int selectedId = Convert.ToInt32(v_setting_profile_page.kelaspraktikum.SelectedValue);
                //MessageBox.Show("ID yang dipilih: " + selectedId);
                m_profil.Updatekelas(selectedId, M_Session.id_session);
            }
        }
        //public void show_photo(Data_Akun akun,PictureBox foto)
        //{
        //    if (akun.foto_profil != null)
        //    {
        //        using (MemoryStream ms = new MemoryStream(akun.foto_profil))
        //        {
        //            foto.Image = Image.FromStream(ms);
        //        }
        //    }
        //    else
        //    {
        //        //foto.Image = Properties.Resources.Foto_Default;
        //    }
        //}
        public void RoundPicturebox(PictureBox pb)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pb.Width, pb.Height);
            pb.Region = new Region(path);
        }
        public void updatepassword()
        {

        }
        public void upload_photo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Pilih Photo";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //string imagePath = openFileDialog.FileName;
                byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);
                m_profil.Updatephoto(imageBytes,Convert.ToInt32(M_Session.id_session));
                //v_profil.RefreshForm();
                //pictureBox1.Image = Image.FromFile(imagePath);
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                // (Opsional) Simpan path ke variable jika mau disimpan nanti
                // string selectedImagePath = imagePath;
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
                //data_Layanan.display_price = $"Rp{data_Layanan.harga.ToString("n", CultureInfo.GetCultureInfo("id-ID"))}";
                list.Add(data_kelas);
            }
            //Conn.Close();
            return list;
        }
        public void switch_to_edit()
        {
            //v_Register.ShowDialog();
            v_setting_profile_page = new V_Setting_Profile_page(this);
            v_setting_profile_page.ShowDialog();
        }

    }
}
