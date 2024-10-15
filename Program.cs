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

            //var firstView = new FormMain();
            var firstView = new FormTarget();
            firstView.FormClosing += (_, __) => WriteAppConfig();

            Application.Run(firstView);
        }

        

        private static void ReadAppConfig()
        {
            GlobalHub.Default.IsDebugging = Properties.Settings.Default.IsDebugging;
            GlobalHub.Default.EnableLogToFile = Properties.Settings.Default.EnableLogToFile;
            BoxMain.StartPointX = Properties.Settings.Default.StartPoint.X;
            BoxMain.StartPointY = Properties.Settings.Default.StartPoint.Y;
        }

        private static void WriteAppConfig()
        {
            try
            { 
                Properties.Settings.Default.IsDebugging = GlobalHub.Default.IsDebugging;
                Properties.Settings.Default.EnableLogToFile = GlobalHub.Default.EnableLogToFile;
                Properties.Settings.Default.StartPoint = new System.Drawing.Point(BoxMain.StartPointX, BoxMain.StartPointY);


                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}
