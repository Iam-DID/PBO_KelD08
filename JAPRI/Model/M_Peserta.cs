using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Globalization;

namespace PBO_KelD08.JAPRI.Model
{
    public class M_Peserta : AM_Connectdb, IM_Connectdb
    {
        public List<object> Get()
        { 
            return new List<object>();
        }
        public List<object> GetPeserta(int id_kelas)
        {
            DataTable data = Execute_With_Return($"SELECT pk.id, pk.nim, m.nama_mahasiswa, pk.id_kelas " +
                $"From peserta_kelas pk " +
                $"join mahasiswa m on (pk.nim=m.nim) " +
                $"where pk.id_kelas = {id_kelas} ");
            List<object> list = new List<object>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Data_Peserta_Kelas data_peserta = new Data_Peserta_Kelas
                {
                    id = (int)data.Rows[i]["id"],
                    nim = data.Rows[i]["nim"].ToString(),
                    nama_mahasiswa = data.Rows[i]["nama_mahasiswa"].ToString(),
                    id_kelas = (int)data.Rows[i]["id_kelas"],
                };
                //data_Layanan.display_price = $"Rp{data_Layanan.harga.ToString("n", CultureInfo.GetCultureInfo("id-ID"))}";
                list.Add(data_peserta);
            }
            //Conn.Close();
            return list;
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
            {  return true; }
            else {return false; }
        }
        public void Delete(int ID)
        {
            Execute_No_Return($"Delete From peserta_kelas where id = {ID}");

        }
        public DataTable Carikelas(int id_kelas)
        {
            DataTable data = Execute_With_Return("SELECT k.nama_kelas " +
                                                 "from kelas k " +
                                                 "join akun a on (a.id_kelas=k.id_kelas) " +
                                                 $"where a.id_kelas = {id_kelas} ");

            return data;
        }

        public void Update(object data, int id)
        {
        }



    }
}
