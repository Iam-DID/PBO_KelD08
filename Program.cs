using PBO_KelD08.JAPRI;
using PBO_KelD08.JAPRI.Controller;
using PBO_KelD08.JAPRI.View;

namespace PBO_KelD08
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //C_LandingPage c_LandingPage = new C_LandingPage();
            //Application.Run(c_LandingPage.v_Login);

            asprak asprak = new asprak();
            Application.Run(asprak);
        }
    }
}