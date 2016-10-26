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
        public static String checkIfFileExists(PortableDeviceFolder root, String fileName) {
            foreach (PortableDeviceFolder subfolder in root.Files) {
                if (subfolder.Name == fileName) return subfolder.PersistentId;
            }
            return null;
        }

        /// <summary>
        /// Check if folder exists only in the given root (not recursive)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="createIfNotExists"></param>
        /// <returns>The persistent ID of the folder if exsist (Or created)</returns>
        public static String checkIfFolderExists(PortableDeviceFolder root, String folderName, bool createIfNotExists, WindowsPortableDevice device) {
            checkIfFileExists(root, folderName);
            if (createIfNotExists) return device.CreateFolder(root.PersistentId, folderName);
            return null;
        }
    }
}
