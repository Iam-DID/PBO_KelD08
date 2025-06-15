using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBO_KelD08.JAPRI.Controller;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PBO_KelD08.JAPRI.Model
{
    public class M_PilihanJadwal : AM_Connectdb, IM_Connectdb
    {

        public List<Data_PilihanJadwal> GetPilihanJadwal(DateTime tanggal, int id_ruangan)
        {
            string tanggalStr = tanggal.ToString("yyyy-MM-dd");
            DataTable data = Execute_With_Return($"SELECT pjk.tanggal, pjk.jam_mulai, pjk.jam_selesai, pjk.id_ruangan, r.nama_ruangan " +
                $"FROM pilihan_jadwal_asisten pjk " +
                $"join ruangan r on ( pjk.id_ruangan=r.id_ruangan) " +
                $"WHERE pjk.tanggal = '{tanggalStr}' AND pjk.id_ruangan = {id_ruangan}");

            List<Data_PilihanJadwal> list = new List<Data_PilihanJadwal>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Data_PilihanJadwal data_pilihanjadwal = new Data_PilihanJadwal
                {
                    tanggal = Convert.ToDateTime(data.Rows[i]["tanggal"]),
                    jam_mulai = (TimeSpan)data.Rows[i]["jam_mulai"],
                    jam_selesai = (TimeSpan)data.Rows[i]["jam_selesai"],
                    id_ruangan = (int)data.Rows[i]["id_ruangan"],
                    nama_ruangan = data.Rows[i]["nama_ruangan"].ToString(),
                };
                list.Add(data_pilihanjadwal);
            }
            return list;
        }

        public DataTable GetPilihanJadwalDefault(DateTime tanggal, int id_ruangan)
        {
            string hari = tanggal.ToString("dddd", new CultureInfo("id-ID")); // ex : "Senin"
            DataTable data = Execute_With_Return($"SELECT jk.jam_mulai, jk.jam_selesai FROM jadwal_kelas jk WHERE jk.hari = '{hari}' AND jk.id_ruangan = {id_ruangan}");
            return data;
        }
        public DataTable GetRuangan()
        {
            DataTable data = Execute_With_Return($"SELECT id_ruangan, nama_ruangan from ruangan");
            return data;
        }
        public List<object> Get()
        {
            return new List<object>();
        }

        public void Insert(object item)
        {
            Data_PilihanJadwal akun = item as Data_PilihanJadwal;
            Execute_No_Return($"INSERT INTO pilihan_jadwal_asisten(id_kelas,id_ruangan,tanggal,status,jam_mulai,jam_selesai) " +
                $"Values ({akun.id_kelas},{akun.id_ruangan},'{akun.tanggal}','Pending','{akun.jam_mulai}','{akun.jam_selesai}')");
        }

        public bool cekexist(Data_PilihanJadwal data) 
        {
            DateTime tanggal = data.tanggal;
            int offsetHari = (int)tanggal.DayOfWeek - (int)DayOfWeek.Monday;
            if (offsetHari < 0) offsetHari += 7;

            DateTime tanggalawal = tanggal.AddDays(-offsetHari);

            string awalMinggu = tanggalawal.ToString("yyyy-MM-dd");// Senin
            string akhirMinggu = tanggalawal.AddDays(6).ToString("yyyy-MM-dd");     // Minggu

            //string tglAwal = awalMinggu.ToString("yyyy-MM-dd");
            //string tglAkhir = akhirMinggu.ToString("yyyy-MM-dd");

            DataTable jadwal= Execute_With_Return($"Select * from pilihan_jadwal_asisten where tanggal between '{awalMinggu}' and '{akhirMinggu}' and id_kelas= {data.id_kelas}");
            if (jadwal.Rows.Count != 0)
            { return false; }
            else { return true; }
        }

        public List<Data_PilihanJadwal> ambiljadwal(int id)
        {
            DataTable jadwal = Execute_With_Return($"Select pjk.id_pilihan, pjk.tanggal,pjk.jam_mulai,pjk.jam_selesai,r.nama_ruangan from pilihan_jadwal_asisten pjk " +
                $"join ruangan r on (pjk.id_ruangan=r.id_ruangan) " +
                $"where id_kelas= {id}");
            List<Data_PilihanJadwal> list = new List<Data_PilihanJadwal>();

            for (int i = 0; i < jadwal.Rows.Count; i++)
            {
                Data_PilihanJadwal data_jadwal = new Data_PilihanJadwal

                {
                    id_pilihan = Convert.ToInt32(jadwal.Rows[i]["id_pilihan"]),
                    id_kelas = id,
                    tanggal = Convert.ToDateTime(jadwal.Rows[i]["tanggal"]),
                    jam_mulai = (TimeSpan)jadwal.Rows[i]["jam_mulai"],
                    jam_selesai = (TimeSpan)jadwal.Rows[i]["jam_selesai"],
                    nama_ruangan = jadwal.Rows[i]["nama_ruangan"].ToString(),
                };
                list.Add(data_jadwal);
            }
            return list;
        }
        public void Delete(int ID)
        {
            Execute_No_Return($"DELETE FROM pilihan_jadwal_asisten WHERE id_pilihan = {ID}");
        }
        public DataTable GetDurasi(int id)
        {
            DataTable data = Execute_With_Return("Select jk.jam_mulai, jk.jam_selesai " +
                "From jadwal_kelas jk " +
                "join kelas k on (jk.id_jadwal=k.id_jadwal) " +
                $"where k.id_kelas = {id}");

            return data;

        }
        public void Update(object data, int id)
        {
        }
    }
    }
