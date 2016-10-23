using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndroSyncTunes {
    class PortableDeviceMethods {
        public static void Enumerate(ref PortableDeviceApiLib.IPortableDeviceContent pContent, string parentID, string indent) {
            //
            // Output object ID
            //
            Console.WriteLine(indent + parentID);

            indent += "    ";

            //
            // Enumerate children (if any)
            //
            PortableDeviceApiLib.IEnumPortableDeviceObjectIDs pEnum;
            pContent.EnumObjects(0, parentID, null, out pEnum);

            uint cFetched = 0;
            do {
                string objectID;
                pEnum.Next(1, out objectID, ref cFetched);

                if (cFetched > 0) {
                    //
                    // Recurse into children
                    //
                    Enumerate(ref pContent, objectID, indent);
                }
            } while (cFetched > 0);
        }
    }
}
