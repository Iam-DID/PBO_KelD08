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
                    no=i+1,
                    id = (int)data.Rows[i]["id"],
                    nim = data.Rows[i]["nim"].ToString(),
                    nama_mahasiswa = data.Rows[i]["nama_mahasiswa"].ToString(),
                    id_kelas = (int)data.Rows[i]["id_kelas"],
                };
                list.Add(data_peserta);
            }
            return list;
        }

        public void Insert(object item)
        {

        }

        public void Delete(int ID)
        {

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
