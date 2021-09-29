using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.WinForms.Forms.MainAppForms;

namespace ITToolbelt.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Properties.Settings.Default.Language == null)
            {
                Thread.CurrentThread.CurrentUICulture =
                    Thread.CurrentThread.CurrentCulture =
                        CultureInfo.InstalledUICulture;
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture =
                Thread.CurrentThread.CurrentCulture =
                    new CultureInfo(Properties.Settings.Default.Language);
            }


            bool system = ChechSystem();
            if (!system)
            {
                MessageBox.Show(Shared.Resource._004, Shared.Resource._005, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Control.CheckForIllegalCrossThreadCalls = false;

            Application.Run(new FormMain());
        }

        private static bool ChechSystem()
        {
            SystemManager systemManager = new SystemManager(GlobalVariables.ConnectInfo);
            bool checkDb = systemManager.CheckDb();
            return checkDb;
        }
    }
}
