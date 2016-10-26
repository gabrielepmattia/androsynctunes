using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WindowsPortableDevicesLib.Domain;
using WindowsPortableDevicesLib;

namespace AndroSyncTunes {
    class Devices {
        private StandardWindowsPortableDeviceService devices_service;
        /// <summary>
        /// Array of devices, created when object is created
        /// </summary>
        public IList<WindowsPortableDevice> DevicesList { get; }
        /// <summary>
        /// Array of the persistent IDs of every first level root (for example an Android device can have External and Internal memory)
        /// </summary>
        public IList<IList<String>> DevicesResourcesList { get; }

        public Devices() {
            this.devices_service = new StandardWindowsPortableDeviceService();
            this.DevicesList = devices_service.Devices;
            this.DevicesResourcesList = new List<IList<String>>();
            if (DevicesList.Count != 0) {
                int i = 0;
                foreach (WindowsPortableDevice device in DevicesList) {
                    device.Connect();
                    DevicesResourcesList.Add(new List<String>());
                    foreach (PortableDeviceFolder item in device.GetContents().Files) {
                        DevicesResourcesList[i].Add(item.PersistentId);
                    }
                    device.Disconnect();
                }
            }
        }

    }
}
