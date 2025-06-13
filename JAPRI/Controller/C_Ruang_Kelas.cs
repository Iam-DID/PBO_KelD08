using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBO_KelD08.JAPRI.Model;
using PBO_KelD08.JAPRI.View;

namespace PBO_KelD08.JAPRI.Controller
{
    public class C_Ruang_Kelas
    {
        private C_Main_Menu mainMenu;
        public V_Ruang_Kelas_Page v_ruang_kelas;
        public C_Ruang_Kelas(C_Main_Menu mainMenu)
        {
            this.mainMenu = mainMenu;
            v_ruang_kelas = new V_Ruang_Kelas_Page(this);
        }

        public void SwitchToProfile()
        {
            mainMenu.SwitchForm(v_ruang_kelas, mainMenu.ProfileController.GetView());
        }
        public void SwitchToInfoKelas()
        {
            mainMenu.SwitchForm(v_ruang_kelas, mainMenu.InfoKelasController.GetView());
        }

        public void SwitchToInfoJadwal()
        {
            mainMenu.SwitchForm(v_ruang_kelas, mainMenu.JadwalController.GetView());
        }

        public void SwitchToGantiJadwal()
        {
            mainMenu.SwitchForm(v_ruang_kelas, mainMenu.GantiJadwalController.GetView());
        }
        public Form GetView()
        {
            return v_ruang_kelas;

        }
    }
}
