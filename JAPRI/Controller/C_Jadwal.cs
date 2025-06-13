using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBO_KelD08.JAPRI.View;

namespace PBO_KelD08.JAPRI.Controller
{
    public class C_Jadwal
    {
        private C_Main_Menu mainMenu;
        public V_Info_Jadwal_Page v_info_jadwal;
        public C_Jadwal(C_Main_Menu mainMenu)
        {
            this.mainMenu = mainMenu;
            v_info_jadwal = new V_Info_Jadwal_Page(this);
        }

        public void SwitchToProfile()
        {
            mainMenu.SwitchForm(v_info_jadwal, mainMenu.ProfileController.GetView());
        }

        public void SwitchToInfoKelas()
        {
            mainMenu.SwitchForm(v_info_jadwal, mainMenu.InfoKelasController.GetView());
        }

        public void SwitchToRuangKelas()
        {
            mainMenu.SwitchForm(v_info_jadwal, mainMenu.RuangKelasController.GetView());
        }

        public void SwitchToGantiJadwal()
        {
            mainMenu.SwitchForm(v_info_jadwal, mainMenu.GantiJadwalController.GetView());
        }
        public Form GetView()
        {
            return v_info_jadwal;

        }
    }
}
