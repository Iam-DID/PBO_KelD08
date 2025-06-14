using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_KelD08.JAPRI.Model
{
    public class M_Ruangan : AM_Connectdb, IM_Connectdb
    {

        public List<object> GetRuangan()
        {
            DataTable data = Execute_With_Return($"SELECT id_ruangan, nama_ruangan from ruangan");
            List<object> list = new List<object>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Data_Ruangan data_ruangan = new Data_Ruangan
                {
                    no = i + 1,
                    id_ruangan = (int)data.Rows[i]["id_ruangan"],
                    nama_ruangan = data.Rows[i]["nama_ruangan"].ToString(),
                };
                //data_Layanan.display_price = $"Rp{data_Layanan.harga.ToString("n", CultureInfo.GetCultureInfo("id-ID"))}";
                list.Add(data_ruangan);
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
