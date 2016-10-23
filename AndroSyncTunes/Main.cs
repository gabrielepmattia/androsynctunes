using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

using PortableDeviceApiLib;
using PortableDeviceConstants;
using WindowsPortableDevicesLib.Domain;
using WindowsPortableDevicesLib;
using System.Diagnostics;

namespace AndroSyncTunes {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            /*
            StandardWindowsPortableDeviceService service = new StandardWindowsPortableDeviceService();

            Console.WriteLine("Available devices:");

            IList<WindowsPortableDevice> devices = service.Devices;

            if (devices.Count == 0) {

                Console.WriteLine("No devices.");
            } else {

                int index = 0;
                foreach (WindowsPortableDevice device in devices) {

                    device.Connect();
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("{0} {1} {2}", ++index, device.DeviceModel, device.DeviceID);
                    var folder = device.GetContents();
                    foreach (var item in folder.Files) {
                        DisplayObject(item);
                    }
                    Console.WriteLine("ID::{0} PersID::{1}", folder.Files.First().Id, folder.Files.First().PersistentId);
                    device.TransferContentToDevice("C:\\Users\\gabry\\Downloads\\file.txt", folder.Files.First().Id);
                    Console.WriteLine("-------------------------------------------------------------");

                    device.Disconnect();
                }
            }
            */



            //Console.Write("Press any key to continue . . . ");
            //Console.ReadKey(true);
        }

        public static void DisplayObject(PortableDeviceObject portableDeviceObject) {
            Console.WriteLine(portableDeviceObject.Name);
            if (portableDeviceObject is PortableDeviceFolder) {
                DisplayFolderContents((PortableDeviceFolder)portableDeviceObject);
            }
        }

        public static void DisplayFolderContents(PortableDeviceFolder folder) {
            foreach (var item in folder.Files) {
                Console.WriteLine(item.Id);
                if (item is PortableDeviceFolder) {
                    DisplayFolderContents((PortableDeviceFolder)item);
                }
            }
        }

        private void Main_Load_old(object sender, EventArgs e) {
            /*
            Console.WriteLine("\n");
            // Create the client
            // Create our client information collection
            PortableDeviceApiLib.IPortableDeviceValues pValues =
                (PortableDeviceApiLib.IPortableDeviceValues)
                        new PortableDeviceTypesLib.PortableDeviceValues();

            // We have to provide at the least our name, version, revision       
            pValues.SetStringValue(
                    ref PortableDevicePKeys.WPD_CLIENT_NAME, "AndroSyncTunes");
            pValues.SetUnsignedIntegerValue(
                    ref PortableDevicePKeys.WPD_CLIENT_MAJOR_VERSION, 1);
            pValues.SetUnsignedIntegerValue(
                    ref PortableDevicePKeys.WPD_CLIENT_MINOR_VERSION, 0);
            pValues.SetUnsignedIntegerValue(
                    ref PortableDevicePKeys.WPD_CLIENT_REVISION, 2);

            PortableDeviceManager deviceManager = new PortableDeviceManager();


            deviceManager.RefreshDeviceList();
            uint cDevices = 1;
            deviceManager.GetDevices(null, ref cDevices);

            if (cDevices > 0) {
                string[] deviceIDs = new string[cDevices];
                deviceManager.GetDevices(deviceIDs, ref cDevices);
                // Create devices objects
                //IPortableDevice[] devices = new IPortableDevice[cDevices];
                //IPortableDeviceContent[] devices_contents = new IPortableDeviceContent[cDevices];
                //IPortableDeviceResources[] devices_resources = new IPortableDeviceResources[cDevices];

                for (int ndxDevices = 0; ndxDevices < cDevices; ndxDevices++) {
                    Console.WriteLine("==> Device[{0}]: {1}", ndxDevices, deviceIDs[ndxDevices]);  
                }

                // Connect at first device
                int device_chosen = 0;
                IPortableDevice device = new PortableDevice();
                IPortableDeviceContent device_contents;
                IPortableDeviceResources device_resources;
                IStream stream;

                device.Open(deviceIDs[device_chosen], pValues);
                Console.WriteLine("==> Device[{0}]: Connected", device_chosen);
                // Get the content and the resource
                device.Content(out device_contents);
                //PortableDeviceMethods.Enumerate(ref device_contents, "DEVICE", "");
                device_contents.Transfer(out device_resources);
                // Get the file
                FileStream file = new FileStream(@"C:\Users\gabry\Downloads\file.txt", FileMode.Open);
                

                // see https://msdn.microsoft.com/en-us/library/dd388994(v=vs.85).aspx
                

            } else {
                Console.WriteLine("===> No WPD devices are present!");
            }
            */
            /*WPDInterfacing.TestInterfacing instance = new WPDInterfacing.TestInterfacing();
            instance.enumerateWPDDevices();
    */
        }

        private void refresh_devices_button_Click(object sender, EventArgs e) {
            device_list_combobox.Items.Clear();
            StandardWindowsPortableDeviceService devices_service = new StandardWindowsPortableDeviceService();
            IList<WindowsPortableDevice> devices = devices_service.Devices;

            if (devices.Count == 0) {

            } else {

                int i = 0;
                foreach (WindowsPortableDevice device in devices) {
                    device.Connect();
                    device_list_combobox.Items.Insert(i++, device.DeviceModel);
                    device.Disconnect();
                }
                
            }
            device_list_combobox.SelectedIndex = 0;
        }
    }
}
