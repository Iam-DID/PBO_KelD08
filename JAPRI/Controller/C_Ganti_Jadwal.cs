using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBO_KelD08.JAPRI.Model;
using PBO_KelD08.JAPRI.View;

namespace PBO_KelD08.JAPRI.Controller
{
    public class C_Ganti_Jadwal
    {
        private C_Main_Menu mainMenu;
        public V_Ganti_Jadwal v_ganti_jadwal;
        public C_Ganti_Jadwal(C_Main_Menu mainMenu)
        {
            this.mainMenu = mainMenu;
            v_ganti_jadwal = new V_Ganti_Jadwal(this);
        }

        public void SwitchToProfile()
        {
            mainMenu.SwitchForm(v_ganti_jadwal, mainMenu.ProfileController.GetView());
        }

        public void SwitchToInfoKelas()
        {
            mainMenu.SwitchForm(v_ganti_jadwal, mainMenu.InfoKelasController.GetView());
        }

        public void SwitchToInfoJadwal()
        {
            mainMenu.SwitchForm(v_ganti_jadwal, mainMenu.JadwalController.GetView());
        }

        public void SwitchToRuangKelas()
        {
            mainMenu.SwitchForm(v_ganti_jadwal, mainMenu.RuangKelasController.GetView());
        }


        public Form GetView()
        {
            return v_ganti_jadwal;

        }
    }
}
