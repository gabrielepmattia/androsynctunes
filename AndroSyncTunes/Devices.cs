using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WindowsPortableDevicesLib.Domain;
using WindowsPortableDevicesLib;

namespace AndroSyncTunes {
    class Devices {
        private StandardWindowsPortableDeviceService devices_service;
        public IList<WindowsPortableDevice> DevicesList { get; }
        public IList<IList<PortableDeviceObject>> DevicesResourcesList { get; }

        public Devices() {
            this.devices_service = new StandardWindowsPortableDeviceService();
            this.DevicesList = devices_service.Devices;
            this.DevicesResourcesList = new List<IList<PortableDeviceObject>>();
            if (DevicesList.Count != 0) {
                int i = 0;
                foreach (WindowsPortableDevice device in DevicesList) {
                    device.Connect();
                    DevicesResourcesList.Add(new List<PortableDeviceObject>());
                    foreach (PortableDeviceFolder item in device.GetContents().Files) {
                        DevicesResourcesList[i].Add(item);
                    }
                    device.Disconnect();
                }
            }
        }

    }
}
