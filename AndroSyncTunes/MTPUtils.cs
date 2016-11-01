using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WindowsPortableDevicesLib.Domain;
using WindowsPortableDevicesLib;

namespace AndroSyncTunes {
    /// <summary>
    /// This class contains method useful methods for MTP devices
    /// </summary>
    class MTPUtils {
        /// <summary>
        /// Check if file exists only in the root given
        /// </summary>
        /// <param name="root"></param>
        /// <param name="folderName"></param>
        /// <param name="createIfNotExists"></param>
        /// <param name="device"></param>
        /// <returns></returns>
        public static PortableDeviceObject checkIfFileExists(WindowsPortableDevice device, PortableDeviceObject root, String fileName) {
            PortableDeviceFolder root_folder = device.GetContents((PortableDeviceFolder)root);
            foreach (PortableDeviceObject item in root_folder.Files) if (item.Name == fileName) return item;
            return null;
        }

        /// <summary>
        /// Check if folder exists only in the given root (not recursive)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="createIfNotExists"></param>
        /// <returns>The persistent ID of the folder if exists (Or created)</returns>
        public static PortableDeviceFolder checkIfFolderExists(WindowsPortableDevice device, PortableDeviceObject root, String folderName, bool createIfNotExists) {
            PortableDeviceObject check = checkIfFileExists(device, (PortableDeviceFolder)root, folderName);
            if (check != null) return (PortableDeviceFolder)check;
            Console.WriteLine("(checkIfFolderExists) Passing to create folder :: " + root.Id + "," + folderName);
            if (createIfNotExists) {
                string new_folder_pid = device.CreateFolder(root.Id, folderName);
                return (PortableDeviceFolder)device.GetObject(root.Id, new_folder_pid);
            }
            return null;
        }

        public static void DisplayObject(PortableDeviceObject portableDeviceObject) {
            Console.WriteLine(portableDeviceObject.Name);
            if (portableDeviceObject is PortableDeviceFolder) {
                DisplayFolderContents((PortableDeviceFolder)portableDeviceObject);
            }
        }

        public static void DisplayFolderContents(PortableDeviceFolder folder) {
            foreach (var item in folder.Files) {
                Console.WriteLine(item.Name);
                if (item is PortableDeviceFolder) {
                    DisplayFolderContents((PortableDeviceFolder)item);
                }
            }
        }
    }
}
