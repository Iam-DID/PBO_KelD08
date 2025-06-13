using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBO_KelD08.JAPRI.Model;
using PBO_KelD08.JAPRI.View;

namespace PBO_KelD08.JAPRI.Controller
{
    public class C_Jadwal
    {
        private C_Main_Menu mainMenu;
        public V_Info_Jadwal_Page v_info_jadwal;
        M_Jadwal m_jadwal = new M_Jadwal();
        public C_Jadwal(C_Main_Menu mainMenu)
        {
            this.mainMenu = mainMenu;
            v_info_jadwal = new V_Info_Jadwal_Page(this);
        }

        public List<Data_Jadwal> ambiljadwal()
        {
            int id = mainMenu.ProfileController.getidkelas();
            var dataObjek = m_jadwal.GetJadwal(id);

            List<Data_Jadwal> list = new List<Data_Jadwal>();
            foreach (var item in dataObjek)
            {
                if (item is Data_Jadwal kelas)
                {
                    list.Add(kelas);
                }
            }

            return list;
        }

        public void setSemester()
        {
            int id = mainMenu.ProfileController.getidkelas();
            DataTable data = m_jadwal.CariSemester(id);

            string sms = data.Rows[0]["semester"].ToString();
            v_info_jadwal.semester.Text = sms;

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
