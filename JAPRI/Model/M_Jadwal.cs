using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBO_KelD08.JAPRI.Controller;

namespace PBO_KelD08.JAPRI.Model
{
    public class M_Jadwal : AM_Connectdb , IM_Connectdb
    {

        public List<object> GetJadwal(int id_kelas)
        {
            DataTable dataProdi = CariProdi(id_kelas);
            int prodi = (int)dataProdi.Rows[0]["id_prodi"];

            DataTable datasemester = CariSemester(id_kelas);
            int semester = (int)datasemester.Rows[0]["semester"];

            DataTable data = Execute_With_Return($"SELECT jk.id_jadwal,k.nama_kelas, jk.hari, jk.jam_mulai, jk.jam_selesai " +
                $"From jadwal_kelas jk " +
                $"join kelas k on (jk.id_jadwal=k.id_jadwal) " +
                $"join mata_kuliah mk on (k.kode_mata_kuliah=mk.kode_mata_kuliah) " +
                $"where mk.semester = {semester} and mk.id_prodi = {prodi} ");
            List<object> list = new List<object>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Data_Jadwal data_jadwal= new Data_Jadwal
                {
                    no = i+1,
                    id_jadwal = (int)data.Rows[i]["id_jadwal"],
                    nama_kelas = data.Rows[i]["nama_kelas"].ToString(),
                    hari = data.Rows[i]["hari"].ToString(),
                    jam_mulai = (TimeSpan)data.Rows[i]["jam_mulai"],      // dari TIME PostgreSQL
                    jam_selesai = (TimeSpan)data.Rows[i]["jam_selesai"]
                };
                //data_Layanan.display_price = $"Rp{data_Layanan.harga.ToString("n", CultureInfo.GetCultureInfo("id-ID"))}";
                list.Add(data_jadwal);
            }
            //Conn.Close();
            return list;
        }
        public List<object> Get()
        {
            return new List<object>();
        }

        public void Get(string username, string password)
        {
            DataTable data = Execute_With_Return("SELECT a.id_akun, m.nama_mahasiswa, a.status_asprak " +
                                                 "from akun a " +
                                                 "join mahasiswa m on (a.nim=m.nim) " +
                                                 $"where a.nim = '{username}' and a.password = '{password}'");
            if (data.Rows.Count == 1)
            {
                M_Session.id_session = Convert.ToInt32(data.Rows[0]["id_akun"]);
                M_Session.session_name = data.Rows[0]["nama_mahasiswa"].ToString();
                M_Session.status_asprak = Convert.ToBoolean(data.Rows[0]["status_asprak"]);
                M_Session.session_status = true;
            }
        }

        public void Insert(object item)
        {
            Data_Akun akun = item as Data_Akun;
            Execute_No_Return($"INSERT INTO Akun(nim,password,status_asprak) Values ('{akun.nim}','{akun.password}','{akun.status_asprak}')");
        }

        public bool IsNimExistindb(string nim)
        {
            DataTable data = Execute_With_Return($"SELECT * FROM mahasiswa where nim = '{nim}'");
            if (data.Rows.Count != 0)
            { return true; }
            else { return false; }
        }
        public bool IsNimExist(string nim)
        {
            DataTable data = Execute_With_Return($"SELECT * FROM akun WHERE nim = '{nim}'");
            if (data.Rows.Count == 0)
            { return true; }
            else { return false; }
        }
        public void Delete(int ID)
        {
            Execute_No_Return($"Delete From peserta_kelas where id = {ID}");

        }
        public DataTable CariSemester(int id_kelas)
        {
            DataTable data = Execute_With_Return("SELECT mk.semester " +
                                                 "from mata_kuliah mk " +
                                                 "join kelas k on (mk.kode_mata_kuliah=k.kode_mata_kuliah) " +
                                                 $"where k.id_kelas = {id_kelas} ");

            return data;
        }

        public DataTable CariProdi(int id_kelas)
        {
            DataTable data = Execute_With_Return("SELECT mk.id_prodi " +
                                                 "from mata_kuliah mk " +
                                                 "join kelas k on (mk.kode_mata_kuliah=k.kode_mata_kuliah) " +
                                                 $"where k.id_kelas = {id_kelas} ");

            return data;
        }

        public void Update(object data, int id)
        {
        }
    }
}
