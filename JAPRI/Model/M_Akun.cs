using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            DataTable data = Execute_With_Return($"SELECT a.akun_id, m.nama_mahasiswa " +
                                                 $"from akun a" +
                                                 $"join mahasiswa m on (a.nim=m.nim)" +
                                                 $"where username = '{username}' and password = '{password}'");
            if (data.Rows.Count == 1)
            {
                M_Session.session_name = data.Rows[0]["m.nama_lengkap"].ToString();
                M_Session.id_session = (int)data.Rows[0]["a.akun_id"];
            }
        }

        public void Insert(object item)
        {
            Data_Akun akun = item as Data_Akun;
            Execute_No_Return($"INSERT INTO Akun(nim,password,status_asprak) Values ('{akun.nim}','{akun.password}','{akun.status_asprak}')");
        }

        public void Delete(int ID)
        {

        }

        public void Update(object data, int id)
        {
        }

    }
}
