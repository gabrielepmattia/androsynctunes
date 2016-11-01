using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WindowsPortableDevicesLib.Domain;
using WindowsPortableDevicesLib;

namespace AndroSyncTunes {
    class MTPUtils {
        /// <summary>
        /// Check if file exists only in the root given
        /// </summary>
        /// <param name="root"></param>
        /// <param name="folderName"></param>
        /// <param name="createIfNotExists"></param>
        /// <param name="device"></param>
        /// <returns></returns>
        public static String checkIfFileExists(PortableDeviceObject root, String fileName, WindowsPortableDevice device) {
            PortableDeviceFolder root_folder = device.GetContents((PortableDeviceFolder)root);
            foreach (PortableDeviceObject item in root_folder.Files) if (item.Name == fileName) return item.PersistentId;
            return null;
        }

        /// <summary>
        /// Check if folder exists only in the given root (not recursive)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="createIfNotExists"></param>
        /// <returns>The persistent ID of the folder if exsist (Or created)</returns>
        public static String checkIfFolderExists(PortableDeviceObject root, String folderName, bool createIfNotExists, WindowsPortableDevice device) {
            String check = checkIfFileExists((PortableDeviceFolder)root, folderName, device);
            if (check != null) return check;
            Console.WriteLine("Passing to create folder :: " + root.PersistentId + "," + folderName);
            if (createIfNotExists) return device.CreateFolder(root.Id, folderName);
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
        /*
        public static void _CheckIfFolderExist(PortableDeviceFolder folder) {
            foreach (var item in folder.Files) {
                Console.WriteLine(item.Name);
                if (item is PortableDeviceFolder) {
                    CheckIfFolderExist((PortableDeviceFolder)item);
                }
            }
        }
        */
    }
}
