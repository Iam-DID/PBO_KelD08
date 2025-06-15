using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBO_KelD08.JAPRI.Controller;

namespace PBO_KelD08.JAPRI.View
{
    public partial class V_Info_Kelas_Ketua_Page : Form
    {
        C_Info_Kelas Controller;
        public V_Info_Kelas_Ketua_Page(C_Info_Kelas controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void V_Info_Kelas_Ketua_Page_Load(object sender, EventArgs e)
        {

        }
    }


}
