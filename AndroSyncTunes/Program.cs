using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroSyncTunes {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Splashscreen
            Starting.ShowSplashScreen();
            Main mainForm = new Main(); //this takes ages
            Starting.CloseForm();
            Application.Run(mainForm);
        }
    }
}
