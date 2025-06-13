using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_KelD08.JAPRI.Model
{
    public class Data_Jadwal
    {
        public int no { get; set; }
        public int id_jadwal;
        public string nama_kelas;
        public string hari;
        public TimeSpan jam_mulai;
        public TimeSpan jam_selesai;



    }
}
