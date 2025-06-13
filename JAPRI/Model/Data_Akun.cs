using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_KelD08.JAPRI.Model
{
    public class Data_Akun
    {
        public int id_akun { get; set; }
        public string nim { get; set; }
        public string password { get; set; }
        public int id_kelas { get; set; }
        public bool status_asprak { get; set; }
        public byte[] foto_profil { get; set; }
        public string nama_mahasiswa { get; set; }
        public string nama_prodi { get; set; }
        public string nama_kelas { get; set; }
    }
}

