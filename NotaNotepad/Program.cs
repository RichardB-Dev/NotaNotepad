using System;
using System.IO;
using System.Windows.Forms;

namespace NotaNotepad
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            if (Environment.OSVersion.Version.Major == 6){

                SetProcessDPIAware();
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"AppConfig.json")) // Create Config JSON file if does not exist
            {
                Application.Run(new form_InitialSettings());
            }
            else
            {
                Application.Run(new form_Main());
            }            
        }


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();



    }
}
