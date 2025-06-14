using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    jam_selesai = (TimeSpan)data.Rows[i]["jam_mulai"],
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
            Data_Akun akun = item as Data_Akun;
            Execute_No_Return($"INSERT INTO Akun(nim,password,status_asprak) Values ('{akun.nim}','{akun.password}','{akun.status_asprak}')");
        }
        public void Delete(int ID)
        {
            Execute_No_Return($"Delete From peserta_kelas where id = {ID}");

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
