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
using WindowsPortableDevicesLib.Domain;
using WindowsPortableDevicesLib;

using iTunesAdminLib;
using iTunesLib;
using System.Diagnostics;

namespace AndroSyncTunes {
    public partial class Main : Form {
        public static String UNKNOWN_STRING = "Unknown";
        private iTunesApp o_iTunes;
        private Devices devices;
        // Lists
        MusicLibrary library;
        List<IITTrack> tracks_to_sync;

        public Main() {
            InitializeComponent();
            // Initialize global variables
            this.o_iTunes = new iTunesApp();
            List<String> library_albums = new List<String>();
            List<String> library_artists = new List<String>();
            this.tracks_to_sync = new List<IITTrack>();
            // Get the library
            IITLibraryPlaylist itunes_library_playlist = o_iTunes.LibraryPlaylist;
            // Generate Albums and Artist lists
            foreach (IITTrack track in itunes_library_playlist.Tracks) {
                //Console.WriteLine(track.Name);
                //Console.WriteLine("\tplaylistID::" + track.playlistID);
                //Console.WriteLine("\tsourceID::" + track.sourceID);
                //Console.WriteLine("\ttrackID::" + track.trackID);
                //Console.WriteLine("\tTrackDatabaseID::" + track.TrackDatabaseID);
                //Console.WriteLine("\tEnabled::" + track.Enabled);
                if (!library_albums.Contains(track.Album)) library_albums.Add(track.Album);
                if (!library_artists.Contains(track.Artist)) library_artists.Add(track.Artist);
            }
            this.library = new MusicLibrary(library_albums, library_artists, o_iTunes.LibrarySource.Playlists);
            updateAlbumsCheckedList();
            updateArtistCheckedList();
            updatePlaylistsCheckedList();

            this.devices = new Devices();
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
            device_storage_list_combobox.Items.Clear();
            /*
            StandardWindowsPortableDeviceService devices_service = new StandardWindowsPortableDeviceService();
            IList<WindowsPortableDevice> devices = devices_service.Devices;

            if (devices.Count == 0) {

            } else {
                int i = 0;
                foreach (WindowsPortableDevice device in devices) {
                    device.Connect();
                    device_list_combobox.Items.Insert(i++, device.DeviceModel);
                    PortableDeviceFolder device_contents = device.GetContents();
                    foreach (PortableDeviceFolder item in device_contents.Files) {
                        device_storage_list_combobox.Items.Add(item.Name);
                    }
                    device.Disconnect();
                }
            }
            */

            this.devices = new Devices();
            Console.WriteLine("============== DEVICES DEBUG ====================");
            Console.WriteLine("=> Devices");
            int ii = 0;
            foreach (WindowsPortableDevice d in this.devices.DevicesList) {
                device_list_combobox.Items.Add(d.DeviceModel);
                Console.WriteLine("==> " + d.DeviceModel);
                foreach (KeyValuePair<String, PortableDeviceObject> k in this.devices.DevicesResourcesList[ii]) {
                    device_storage_list_combobox.Items.Add(k.Key);
                    Console.WriteLine("===> " + k.Key + " value " + k.Value.PersistentId);
                }
                ii++;
            }

            if (device_list_combobox.Items.Count > 0) device_list_combobox.SelectedIndex = 0;
            if (device_storage_list_combobox.Items.Count > 0) device_storage_list_combobox.SelectedIndex = 0;
        }

        private void artists_checkedlist_ItemCheck(object sender, ItemCheckEventArgs e) {
            this.BeginInvoke((MethodInvoker)(
            () => checked_artists_label.Text = artists_checkedlist.CheckedItems.Count.ToString()));
            
        }

        private void albums_checkedlist_ItemCheck(object sender, ItemCheckEventArgs e) {
            this.BeginInvoke((MethodInvoker)(
            () => checked_albums_label.Text = albums_checkedlist.CheckedItems.Count.ToString()));
        }

        private void playlists_checkedlist_ItemCheck(object sender, ItemCheckEventArgs e) {
            this.BeginInvoke((MethodInvoker)(
            () => checked_playlist_label.Text = playlists_checkedlist.CheckedItems.Count.ToString()));
        }


        // ======================== GUI Methods ========================
        private void updateArtistCheckedList() {
            foreach (String artist in library.Artists) {
                if (artist == null) artists_checkedlist.Items.Add(UNKNOWN_STRING);
                else artists_checkedlist.Items.Add(artist);
            }
        }

        private void updateAlbumsCheckedList() {
            foreach (String album in library.Albums) {
                if (album == null) albums_checkedlist.Items.Add(UNKNOWN_STRING);
                else albums_checkedlist.Items.Add(album);
            }
        }

        private void updatePlaylistsCheckedList() {
            playlists_checkedlist.Items.Clear();
            foreach (KeyValuePair<String, IITPlaylist> playlist_pair in library.Playlists) {
                playlists_checkedlist.Items.Add(playlist_pair.Key);
            }
        }

        private void button1_Click(object sender, EventArgs e) {


            // Check from Playlists
            /*
            foreach (String playlist_checked_string in playlists_checkedlist.Items) {
                foreach (IITPlaylist playlist_o in o_iTunes.LibrarySource.Playlists) {
                    if (playlist_o.Name == playlist_checked_string) {
                        foreach (IITTrack track in playlist_o.Tracks) {
                            tracks_to_sync.Add(track);
                            Console.WriteLine(track.Name);
                        }
                    }
                    break;
                }
            }
            */
            /*
            foreach (IITTrack track in o_iTunes.LibraryPlaylist.Tracks) {
                // Check from Artists

                // Check from Albums

                // Check from Playlists

            }
            */
            label1.Text = tracks_to_sync.Count.ToString();
            label1.Refresh();
            /*
            WindowsPortableDevice selected_device = devices.DevicesList[device_list_combobox.SelectedIndex];
            selected_device.Connect();
            var contents = selected_device.GetContents().Files;
            String music_folder = devices.DevicesList[device_list_combobox.SelectedIndex].CreateFolder(devices.DevicesResourcesList[device_list_combobox.SelectedIndex][device_storage_list_combobox.SelectedIndex].PersistentId, "Music");
            selected_device.Disconnect();
            foreach (IITTrack track in tracks_to_sync) {
                selected_device.Connect();
                selected_device.TransferContentToDevice(((IITFileOrCDTrack)track).Location, music_folder);
                selected_device.Disconnect();
                */
        }

        private void sync_button_Click(object sender, EventArgs e) {
            tracks_to_sync.Clear();
            toolStripStatusLabel2.Text = "Gathering songs...";
            // Calculate the tracks to sync
            // Check if entire library is selected
            if (entire_library_radio.Checked == true) {
                foreach (IITTrack track in o_iTunes.LibraryPlaylist.Tracks) {
                    if (track.Kind == ITTrackKind.ITTrackKindFile) {
                        // Check if only checked is checked
                        if ((sync_checked_checkbox.Checked == true && track.Enabled == true) || sync_checked_checkbox.Checked == false) tracks_to_sync.Add(track);
                    }
                }
            } else {
                // Add from the Playlists
                //foreach(KeyValuePair<String, IITPlaylist> playlist_pair in library.Playlists) {
                foreach (int selected_playlist in playlists_checkedlist.CheckedIndices) {
                    foreach (IITTrack track in library.Playlists.ElementAt(selected_playlist).Value.Tracks) {
                        if ((sync_checked_checkbox.Checked == true && track.Enabled == true) || sync_checked_checkbox.Checked == false) tracks_to_sync.Add(track);
                    }
                }
                // Add form the Albums
                foreach (String album in albums_checkedlist.CheckedItems) {
                    foreach (IITTrack track in o_iTunes.LibraryPlaylist.Tracks) {
                        if ((track.Album == null && album != UNKNOWN_STRING) || track.Kind != ITTrackKind.ITTrackKindFile) continue;
                        if (sync_checked_checkbox.Checked && !track.Enabled) continue;
                        if (track.Album.Equals(album) && !tracks_to_sync.Contains(track)) tracks_to_sync.Add(track);
                    }
                }
                // Add from the Artists
                foreach (String artist in albums_checkedlist.CheckedItems) {
                    foreach (IITTrack track in o_iTunes.LibraryPlaylist.Tracks) {
                        if ((track.Artist == null && artist != UNKNOWN_STRING) || track.Kind != ITTrackKind.ITTrackKindFile) continue;
                        if (sync_checked_checkbox.Checked && !track.Enabled) continue;
                        if (track.Artist.Equals(artist) && !tracks_to_sync.Contains(track)) tracks_to_sync.Add(track);
                    }
                }
            }
            label1.Text = tracks_to_sync.Count.ToString();
            label1.Refresh();

            // Start syncing
            // Connect to device
            WindowsPortableDevice device = this.devices.DevicesList[device_list_combobox.SelectedIndex];
            PortableDeviceObject storage = this.devices.DevicesResourcesList[device_list_combobox.SelectedIndex][device_storage_list_combobox.SelectedIndex].Value;

            device.Connect();
            // Get the root folder obj
            PortableDeviceFolder root_folder_obj = MTPUtils.checkIfFolderExists(device, storage, "Musik", true);
            Console.WriteLine("[Main] root_folder_pid :: " + root_folder_obj.Id + " root_folder_obj :: " + root_folder_obj);
            foreach (IITTrack track in tracks_to_sync) {
                // Now enter in that folder and copy files
                toolStripStatusLabel2.Text = "Copying " + track.Name + " of " + track.Artist;
                MTPiLibraryUtils.copyTrackToGivenRootWithArtistAlbumScheme(device, (PortableDeviceFolder)root_folder_obj, track);
            }
            device.Disconnect();
        }

        private void entire_library_radio_CheckedChanged(object sender, EventArgs e) {
            if (((RadioButton)sender).Checked == true) song_chooser_groupbox.Enabled = false;
            else song_chooser_groupbox.Enabled = true;
        }
    }
}
