using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PortableDeviceApiLib;
using System.Diagnostics;

namespace AndroSyncTunes {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            PortableDeviceManager deviceManager = new PortableDeviceManager();
            deviceManager.RefreshDeviceList();
            uint cDevices = 1;
            deviceManager.GetDevices(null, ref cDevices);
            if (cDevices > 0) {
                string[] deviceIDs = new string[cDevices];
                deviceManager.GetDevices(deviceIDs, ref cDevices);

                for (int ndxDevices = 0; ndxDevices < cDevices; ndxDevices++) {
                    Console.WriteLine("Device[{0}]: {1}",
                            ndxDevices + 1, deviceIDs[ndxDevices]);
                }
            } else {
                Console.WriteLine("No WPD devices are present!");
            }
        }

    }
}
