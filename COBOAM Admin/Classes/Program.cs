using System;
using System.IO;
using System.Web;
using System.Windows.Forms;
using COBOAM_Admin.Forms;
using COBOAM_Admin.Properties;

namespace COBOAM_Admin.Classes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public const string CFileName = "Config.xml";
        public static bool ConfigExist;
        public static MySql MySql;

        #region MySQL Database Info
        public static string mUN = "";
        public static string mPW;
        public static string mDB;
        public static string mHost;
        public static string mPort;
        #endregion

        #region FTP Info
        public static string fHost;
        public static int fPort;
        public static string fUN;
        public static string fPW;
        #endregion

        #region SMTP Info
        public static string sHost;
        public static int sPort;
        public static string sUN;
        public static string sPW;
        #endregion

        public static string uName = string.Empty;
        public static string uFName = string.Empty;
        public static string uEmail = string.Empty;
        public static string uLIP = string.Empty;
        public static string uCIP = string.Empty;
        public static int uLvl;

        #region Auto Login
        public static int aLE;
        public static string aUN;
        public static string aPW;
        #endregion


        [STAThread]
        static void Main()
        {
            //Settings.Default.coboamConnectionString += "Password: lolblackppl23";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists(Application.StartupPath + "\\" + CFileName))
                ConfigExist = true;
            Splash splash = new Splash();
            Application.Run(splash);
            if (splash.LoginStatus)
                Application.Run(new FrmMain());
        }
    }
}
