using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBO_KelD08.JAPRI.View;

namespace PBO_KelD08.JAPRI.Controller
{
    public class C_Info_Kelas
    {
        private C_Main_Menu mainMenu;
        public V_Info_Kelas v_info_kelas;
        public C_Info_Kelas(C_Main_Menu mainMenu)
        {
            this.mainMenu = mainMenu;
            v_info_kelas = new V_Info_Kelas(this);
        }

        public void SwitchToProfile()
        {
            mainMenu.SwitchForm(v_info_kelas, mainMenu.ProfileController.GetView());
        }

        public void SwitchToInfoJadwal()
        {
            mainMenu.SwitchForm(v_info_kelas, mainMenu.JadwalController.GetView());
        }

        public void SwitchToRuangKelas()
        {
            mainMenu.SwitchForm(v_info_kelas, mainMenu.RuangKelasController.GetView());
        }

        public void SwitchToGantiJadwal()
        {
            mainMenu.SwitchForm(v_info_kelas, mainMenu.GantiJadwalController.GetView());
        }
        public Form GetView()
        {
            return v_info_kelas;

        }
    }
}
