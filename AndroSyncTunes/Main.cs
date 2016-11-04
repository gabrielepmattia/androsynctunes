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

using iTunesLib;
using PortableDeviceApiLib;
using WindowsPortableDevicesLib.Domain;
using WindowsPortableDevicesLib;

using AndroSyncTunes.Library;

namespace AndroSyncTunes {
    public partial class Main : Form {
        public static String UNKNOWN_STRING = "Unknown";
        private iTunesApp o_iTunes;
        private Devices devices;
        // Lists
        MusicLibrary music_library;

        public Main() {
            InitializeComponent();
            /*
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

            */
            // Instantiate the devices
            this.devices = new Devices();
            // Instantiate the libraries
            this.music_library = new MusicLibrary();

            // Update the GUI with the gathered informations
            loadLibraryDataInGUI();
        }

        private void Main_Load(object sender, EventArgs e) {

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

        private void sync_button_Click(object sender, EventArgs e) {
            music_library.TracksToSync.Clear();
            toolStripStatusLabel2.Text = "Gathering songs...";
            // Calculate the tracks to sync
            // Check if entire library is selected
            if (entire_library_radio.Checked == true) {
                foreach (IITTrack track in music_library.Tracks) {
                    // Check if only checked is checked
                    if ((sync_checked_checkbox.Checked == true && track.Enabled == true) || sync_checked_checkbox.Checked == false) music_library.addTrackToSync(track);
                }
            } else {
                // Add from the Playlists
                //foreach(KeyValuePair<String, IITPlaylist> playlist_pair in library.Playlists) {
                foreach (int selected_playlist in playlists_checkedlist.CheckedIndices) {
                    foreach (IITTrack track in music_library.Playlists.ElementAt(selected_playlist).Tracks) {
                        if ((sync_checked_checkbox.Checked == true && track.Enabled == true) || sync_checked_checkbox.Checked == false) music_library.addTrackToSync(track);
                    }
                }
                // Add form the Albums
                foreach (int album_i in albums_checkedlist.CheckedIndices) {
                    foreach (IITTrack track in music_library.Albums.ElementAt(album_i).Tracks) {
                        if (sync_checked_checkbox.Checked && !track.Enabled) continue;
                        music_library.addTrackToSync(track);
                    }
                }
                // Add from the Artists
                foreach (int artist_i in artists_checkedlist.CheckedIndices) {
                    foreach (Album album in music_library.Artists.ElementAt(artist_i).Albums) {
                        foreach (IITTrack track in album.Tracks) {
                            if (sync_checked_checkbox.Checked && !track.Enabled) continue;
                            music_library.addTrackToSync(track);
                        }
                    }
                }
            }
            label1.Text = music_library.TracksToSync.Count.ToString();
            label1.Refresh();
            /*
            // Start syncing
            // Connect to device
            WindowsPortableDevice device = this.devices.DevicesList[device_list_combobox.SelectedIndex];
            PortableDeviceObject storage = this.devices.DevicesResourcesList[device_list_combobox.SelectedIndex][device_storage_list_combobox.SelectedIndex].Value;

            device.Connect();
            // Get the root folder obj
            
            PortableDeviceFolder root_folder_obj = MTPUtils.checkIfFolderExists(device, storage, "Musik", true);
            Console.WriteLine("[Main] root_folder_pid :: " + root_folder_obj.Id + " root_folder_obj :: " + root_folder_obj);
            foreach (IITTrack track in music_library.TracksToSync) {
                // Now enter in that folder and copy files
                toolStripStatusLabel2.Text = "Copying " + track.Name + " of " + track.Artist;
                MTPiLibraryUtils.copyTrackToGivenRootWithArtistAlbumScheme(device, (PortableDeviceFolder)root_folder_obj, track);
            }
            device.Disconnect();
            */
        }

        // ================================================ GUI Methods ================================================
        private void loadLibraryDataInGUI() {
            updateAlbumsCheckedList();
            updateArtistCheckedList();
            updatePlaylistsCheckedList();
        }

        private void updateArtistCheckedList() {
            foreach (Artist a in music_library.Artists) artists_checkedlist.Items.Add(a.Name);

        }

        private void updateAlbumsCheckedList() {
            foreach (Album a in music_library.Albums) albums_checkedlist.Items.Add(a.Name);
        }

        private void updatePlaylistsCheckedList() {
            foreach (IITPlaylist p in music_library.Playlists) playlists_checkedlist.Items.Add(p.Name);
        }

        private void artists_checkedlist_ItemCheck(object sender, ItemCheckEventArgs e) {
            this.BeginInvoke((MethodInvoker)(
            () => checked_artists_label.Text = artists_checkedlist.CheckedItems.Count.ToString() + " " + AndroSyncTunes.Resources.GlobalStrings.checked_items));

        }

        private void albums_checkedlist_ItemCheck(object sender, ItemCheckEventArgs e) {
            this.BeginInvoke((MethodInvoker)(
            () => checked_albums_label.Text = albums_checkedlist.CheckedItems.Count.ToString() + " " + AndroSyncTunes.Resources.GlobalStrings.checked_items));
        }

        private void playlists_checkedlist_ItemCheck(object sender, ItemCheckEventArgs e) {
            this.BeginInvoke((MethodInvoker)(
            () => checked_playlist_label.Text = playlists_checkedlist.CheckedItems.Count.ToString() + " " + AndroSyncTunes.Resources.GlobalStrings.checked_items));
        }

        private void entire_library_radio_CheckedChanged(object sender, EventArgs e) {
            if (((RadioButton)sender).Checked == true) song_chooser_groupbox.Enabled = false;
            else song_chooser_groupbox.Enabled = true;
        }

        private void search_artist_placeholdertextbox_TextChanged(object sender, EventArgs e) {
            artists_checkedlist.TopIndex = artists_checkedlist.FindString(search_artist_placeholdertextbox.Text);
        }

        private void search_album_placeholdertextbox_TextChanged(object sender, EventArgs e) {
            albums_checkedlist.TopIndex = albums_checkedlist.FindString(search_album_placeholdertextbox.Text);
        }

        private void search_playlist_placeholdertextbox_TextChanged(object sender, EventArgs e) {
            playlists_checkedlist.TopIndex = playlists_checkedlist.FindString(search_playlist_placeholdertextbox.Text);
        }
    }
}
