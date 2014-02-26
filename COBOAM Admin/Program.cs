using System;
using System.IO;
using System.Windows.Forms;

namespace COBOAM_Admin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static readonly string[] Config = File.ReadAllLines("Config.ini");
        public static MySql MySql;

        #region DB Connection Variables
        public static string mUN = "";
        public static string mPW;
        public static string mDB;
        public static string mHost;
        public static string mPort;
        #endregion

        public static string uName = string.Empty;
        public static string uFName = string.Empty;
        public static string uEmail = string.Empty;
        public static string uLIP = string.Empty;
        public static string uCIP = string.Empty;
        public static int uLvl;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Splash splash = new Splash(Config);
            Application.Run(splash);
            if (splash.LoginStatus)
                Application.Run(new FrmMain());
        }
    }
}
