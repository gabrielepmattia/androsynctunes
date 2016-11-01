using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WindowsPortableDevicesLib.Domain;
using WindowsPortableDevicesLib;

namespace AndroSyncTunes {
    /// <summary>
    /// This class is an abstraction for connected MTP devices
    /// </summary>
    class Devices {
        private StandardWindowsPortableDeviceService devices_service;
        /// <summary>
        /// Array of devices, created when object is created
        /// </summary>
        public IList<WindowsPortableDevice> DevicesList { get; }
        /// <summary>
        /// List of list of key pair (string, string) = (Name, PersistentID) of the main resources for a device
        /// </summary>
        public IList<IList<KeyValuePair<String, PortableDeviceObject>>> DevicesResourcesList { get; }

        public Devices() {
            this.devices_service = new StandardWindowsPortableDeviceService();
            this.DevicesList = devices_service.Devices;
            this.DevicesResourcesList = new List<IList<KeyValuePair<String, PortableDeviceObject>>>();
            if (DevicesList.Count != 0) {
                int i = 0;
                foreach (WindowsPortableDevice device in DevicesList) {
                    device.Connect();
                    this.DevicesResourcesList.Add(new List<KeyValuePair<String, PortableDeviceObject>>());
                    foreach (PortableDeviceFolder item in device.GetContents().Files) {
                        DevicesResourcesList[i].Add(new KeyValuePair<string, PortableDeviceObject>(item.Name, item));
                    }
                    device.Disconnect();
                }
            }
        }

    }
}
