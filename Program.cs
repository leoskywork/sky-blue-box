using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SkyBlueBox
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ReadAppConfig();

            var main = new Main();
            main.FormClosing += (_, __) => WriteAppConfig();
            Application.Run(main);
        }

        

        private static void ReadAppConfig()
        {
            GlobalHub.Default.StartPointX = Properties.Settings.Default.StartPoint.X;
            GlobalHub.Default.StartPointY = Properties.Settings.Default.StartPoint.Y;
            GlobalHub.Default.IsDebugging = Properties.Settings.Default.IsDebugging;
            GlobalHub.Default.EnableLogToFile = Properties.Settings.Default.EnableLogToFile;
        }

        private static void WriteAppConfig()
        {
            try
            { 
                Properties.Settings.Default.StartPoint = new System.Drawing.Point(GlobalHub.Default.StartPointX, GlobalHub.Default.StartPointY);
                Properties.Settings.Default.IsDebugging = GlobalHub.Default.IsDebugging;
                Properties.Settings.Default.EnableLogToFile = GlobalHub.Default.EnableLogToFile;


                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}
