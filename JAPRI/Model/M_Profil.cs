using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_KelD08.JAPRI.Model
{
    public class M_Profil : AM_Connectdb, IM_Connectdb
    {
        public DataTable GetData()
        {
            DataTable data = Execute_With_Return("SELECT a.id_akun, a.nim, a.password, a.id_kelas, a.status_asprak, a.foto_profil, m.nama_mahasiswa, p.nama_prodi " +
                                                 "from akun a " +
                                                 "join mahasiswa m on (a.nim=m.nim) " +
                                                 "join prodi p on (m.id_prodi=p.id_prodi)" +
                                                 $"where a.id_Akun = {M_Session.id_session} ");
            return data;
        }
        public DataTable Carikelas(int id_kelas)
        {
            DataTable data = Execute_With_Return("SELECT k.nama_kelas " +
                                                 "from kelas k " +
                                                 "join akun a on (a.id_kelas=k.id_kelas) " +
                                                 "join mata_kuliah mk on (k.kode_mata_kuliah=mk.kode_mata_kuliah) " +
                                                 $"where a.id_kelas = {id_kelas} and mk.status_praktikum = True ");

            return data;
        }
        public DataTable getkelas()
        {
            if (M_Session.status_asprak)
            {
                DataTable data = Execute_With_Return("Select * from kelas");
                return data;
            }
            else
            {
                DataTable data = Execute_With_Return("Select k.id_kelas, k.nama_kelas, k.kode_mata_kuliah " +
                    "from kelas k " +
                    "join peserta_kelas pk on (k.id_kelas=pk.id_kelas) " +
                    "join mahasiswa m on (pk.nim=m.nim) " +
                    "join akun a on (m.nim=a.nim) " +
                    $"where a.id_akun = {M_Session.id_session} ");
                return data;
            }
        }
        
        public List<object> Get()
        { return new List<object>(); }

        public void Insert(object obj) { }

        public void Delete(int id) { }

        public void Update(object data, int id)
        {
            Data_Akun akun = data as Data_Akun;
            Execute_No_Return($"Update Akun set password = '{akun.password}' where id_akun = {id}");
        }
        public void Updatephoto(byte[] data, int id)
        {
            string query = "UPDATE Akun SET foto_profil = @foto WHERE id_akun = @id";
            var parameters = new Dictionary<string, object>
            {
            { "@foto", data },
            { "@id", id }
             };
            Execute_No_Return1(query, parameters);
        }

        public void Updatekelas(int id_kelas,int id_akun)
        {
            Execute_No_Return($"Update Akun set id_kelas = {id_kelas} where id_akun = {id_akun}");
        }
        //public void Updatekelas(object data, int id)
        //{
        //    Data_Akun akun = data as Data_Akun;
        //    Execute_No_Return($"Update Akun set id_kelas = {akun.id_kelas} where id_akun = {id})");
        //}
    }
}
