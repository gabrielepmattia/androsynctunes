using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Management;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AndroSyncTunes {
    public partial class Starting : Form {
        public Starting() {
            InitializeComponent();
        }

        //Delegate for cross thread call to close
        private delegate void CloseDelegate();

        //The type of form to be displayed as the splash screen.
        private static Starting starting;

        static public void ShowSplashScreen() {
            // Make sure it is only launched once.
            if (starting != null) return;
            Thread thread = new Thread(new ThreadStart(Starting.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static private void ShowForm() {
            starting = new Starting();
            Application.Run(starting);
        }

        static public void CloseForm() {
            starting.Invoke(new CloseDelegate(Starting.CloseFormInternal));
        }

        static private void CloseFormInternal() {
            starting.Close();
        }


    }
}
