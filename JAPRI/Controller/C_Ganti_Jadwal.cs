using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBO_KelD08.JAPRI.Model;
using PBO_KelD08.JAPRI.View;

namespace PBO_KelD08.JAPRI.Controller
{
    public class C_Ganti_Jadwal
    {
        private C_Main_Menu mainMenu;
        public V_Ganti_Jadwal v_ganti_jadwal;
        M_PilihanJadwal m_pilihanjadwal = new M_PilihanJadwal();
        public C_Ganti_Jadwal(C_Main_Menu mainMenu)
        {
            this.mainMenu = mainMenu;
            v_ganti_jadwal = new V_Ganti_Jadwal(this);
        }

        public void SwitchToProfile()
        {
            mainMenu.SwitchForm(v_ganti_jadwal, mainMenu.ProfileController.GetView());
        }

        public void SwitchToInfoKelas()
        {
            mainMenu.SwitchForm(v_ganti_jadwal, mainMenu.InfoKelasController.GetView());
        }

        public void SwitchToInfoJadwal()
        {
            mainMenu.SwitchForm(v_ganti_jadwal, mainMenu.JadwalController.GetView());
        }

        public void SwitchToRuangKelas()
        {
            mainMenu.SwitchForm(v_ganti_jadwal, mainMenu.RuangKelasController.GetView());
        }
        public Form GetView()
        {
            return v_ganti_jadwal;

        }

        bool IsBentrok(DateTime tanggal, TimeSpan mulai, TimeSpan selesai, int  id_ruangan)
        {
            var jadwalEksisting = m_pilihanjadwal.GetPilihanJadwal(tanggal, id_ruangan); //ambil dari jdwl asisten lain

            foreach (var jadwal in jadwalEksisting)
            {
                if (!(selesai <= jadwal.jam_mulai || mulai >= jadwal.jam_selesai))
                    return true;
            }

            if (IsBentrokJadwalDefault(tanggal, mulai, selesai, id_ruangan)) //ambl dari jdwl default
                return true;

            return false;
        }

        bool IsBentrokJadwalDefault(DateTime tanggal, TimeSpan mulai, TimeSpan selesai, int id_ruangan)
        {
            DataTable data = m_pilihanjadwal.GetPilihanJadwalDefault(tanggal, id_ruangan);

            foreach (DataRow row in data.Rows)
            {
                TimeSpan jamMulai = (TimeSpan)row["jam_mulai"];
                TimeSpan jamSelesai = (TimeSpan)row["jam_selesai"];

                if (!(selesai <= jamMulai || mulai >= jamSelesai))
                    return true; // bentrok
            }

            return false;
        }
        public void setpilihan()
        {
            v_ganti_jadwal.jammulai.Items.Clear();
            v_ganti_jadwal.jamselesai.Text = "";

            int id_kelas = mainMenu.ProfileController.getidkelas();
            DataTable jadwalAsli = m_pilihanjadwal.GetDurasi(id_kelas);
            DateTime tanggal = v_ganti_jadwal.dateTimePicker1.Value.Date;

            TimeSpan durasi = (TimeSpan)jadwalAsli.Rows[0]["jam_selesai"] - (TimeSpan)jadwalAsli.Rows[0]["jam_mulai"];
            TimeSpan jamBuka = new TimeSpan(7, 0, 0);
            TimeSpan jamTutup = new TimeSpan(21, 0, 0);

            int id_ruangan = Convert.ToInt32(v_ganti_jadwal.ruangan.SelectedValue);

            for (TimeSpan jamMulai = jamBuka; jamMulai + durasi <= jamTutup; jamMulai += TimeSpan.FromMinutes(30))
            {
                TimeSpan jamSelesai = jamMulai + durasi;

                if (!IsBentrok(tanggal, jamMulai, jamSelesai, id_ruangan))
                {
                    v_ganti_jadwal.jammulai.Items.Add(jamMulai.ToString(@"hh\:mm"));
                }
            }
        }
        public string HitungJamSelesai(string jamMulaiStr)
        {
            TimeSpan jamMulai = TimeSpan.Parse(jamMulaiStr);
            int id_kelas = mainMenu.ProfileController.getidkelas();
            DataTable jadwalAsli = m_pilihanjadwal.GetDurasi(id_kelas);
            TimeSpan durasi = (TimeSpan)jadwalAsli.Rows[0]["jam_selesai"] - (TimeSpan)jadwalAsli.Rows[0]["jam_mulai"];
            TimeSpan jamSelesai = jamMulai + durasi;
            return jamSelesai.ToString(@"hh\:mm");
        }
        public List<Data_Ruangan> GetlistRuangan()
        {
            DataTable data = m_pilihanjadwal.GetRuangan();
            List<Data_Ruangan> list = new List<Data_Ruangan>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Data_Ruangan data_ruangan = new Data_Ruangan
                {
                    no = i + 1,
                    id_ruangan = (int)data.Rows[i]["id_ruangan"],
                    nama_ruangan = data.Rows[i]["nama_ruangan"].ToString(),
                };
                list.Add(data_ruangan);
            }
            return list;
        }


    }
}
