using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_KelD08.JAPRI.Controller
{
    public class C_Main_Menu
    {
        //public C_LandingPage LandingController { get; set; }
        public C_Profile ProfileController { get; private set; }
        public C_Info_Kelas InfoKelasController { get; private set; }
        public C_Jadwal JadwalController { get; private set; }
        public C_Ruang_Kelas RuangKelasController { get; private set; }
        public C_Ganti_Jadwal GantiJadwalController { get; private set; }

        public C_Main_Menu()
        {
            // Inject this ke semua controller
            //LandingController = new C_LandingPage();
            ProfileController = new C_Profile(this);
            InfoKelasController = new C_Info_Kelas(this);
            JadwalController = new C_Jadwal(this);
            RuangKelasController = new C_Ruang_Kelas(this);
            GantiJadwalController = new C_Ganti_Jadwal(this);
        }

        public void SwitchForm(Form current, Form next)
        {
            current.Hide();
            next.Show();
        }
    }
}
