using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flash_led
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Globals.mForm = new MainForm();
            Globals.pCall = new PagerCall();
            Application.Run(new MainForm());
        }
        public static ApplicationConfigurationClass ApplicationConfiguration { get; }
            = new ApplicationConfigurationClass();
    }

    public class ApplicationConfigurationClass
    {
        internal void Initialize() { }
    }

    class Globals
    {
        public static MainForm mForm { get; internal set; }
        public static PagerCall pCall { get; internal set; }
    }
}
