using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using iTunesLib;
using WindowsPortableDevicesLib.Domain;
using WindowsPortableDevicesLib;

namespace AndroSyncTunes {
    /// <summary>
    /// This class contains methods for interfacing/syncing iTunes with MTP devices
    /// </summary>
    class MTPiLibraryUtils {
        /// <summary>
        /// This method copy a track to device using the scheme, given a track called track.mp3
        ///     root/Artist/Album/track.mp3
        /// This tree structure will be parametrized one day, I hope.    
        /// </summary>
        /// <param name="device"></param>
        /// <param name="root"></param>
        /// <param name="track"></param>
        public static void copyTrackToGivenRootWithArtistAlbumScheme(WindowsPortableDevice device, PortableDeviceFolder root, IITTrack track) {
            // Get/Create artist folder
            PortableDeviceFolder artist_folder = MTPUtils.checkIfFolderExists(device, root, track.Artist, true);
            // Get/Create album folder
            PortableDeviceFolder album_folder = MTPUtils.checkIfFolderExists(device, artist_folder, track.Album, true);
            // Start the transfer
            if (MTPUtils.checkIfFileExists(device, album_folder, System.IO.Path.GetFileName(((IITFileOrCDTrack)track).Location)) == null) {
                Console.WriteLine("(copyTrackToGivenRootWithArtistAlbumScheme) copying :: " + System.IO.Path.GetFileName(((IITFileOrCDTrack)track).Location));
                device.TransferContentToDevice(((IITFileOrCDTrack)track).Location, album_folder.Id);
            } else Console.WriteLine("(copyTrackToGivenRootWithArtistAlbumScheme) File exists :: " + System.IO.Path.GetFileName(((IITFileOrCDTrack)track).Location));
        }
    }
}
