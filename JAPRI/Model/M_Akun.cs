using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBO_KelD08.JAPRI.Model
{
    public class M_Akun : AM_Connectdb, IM_Connectdb
    {
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
            {  return true; }
            else {return false; }
        }
        public void Delete(int ID)
        {

        }

        public void Update(object data, int id)
        {
            Data_Akun akun = data as Data_Akun;
            Execute_No_Return($"Update Akun set foto_profil ={akun.foto_profil} where id_akun = {id})");
        }

        public void Updatekelas(object data, int id)
        {
            Data_Akun akun = data as Data_Akun;
            Execute_No_Return($"Update Akun set id_kelas = {akun.id_kelas} where id_akun = {id})");
        }

    }
}
