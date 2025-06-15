using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_KelD08.JAPRI.Model
{
    public class Data_PilihanJadwal
    {
        public int id { get; set; }
        public int id_pilihan {  get; set; }

        public int id_kelas {  get; set; }
        public string status { get; set; }
        public DateTime tanggal { get; set; }
        public TimeSpan jam_mulai { get; set; }
        public TimeSpan jam_selesai { get; set; }
        public int id_ruangan { get; set; }
        public string nama_ruangan { get; set; }
        public string note {  get; set; }
    }
}
