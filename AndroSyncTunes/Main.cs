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
using System.Threading;

using iTunesLib;
using PortableDeviceApiLib;
using WindowsPortableDevicesLib.Domain;
using WindowsPortableDevicesLib;

using AndroSyncTunes.Library;
using AndroSyncTunes.Workers;
using AndroSyncTunes.UI;

namespace AndroSyncTunes {
    public partial class Main : Form {
        //private iTunesApp o_iTunes;
        private Devices devices;
        MusicLibrary music_library;
        private IList<KeyValuePair<IWorker, Thread>> curr_jobs;
        // Lock obj
        private object finishEventLocker = new object();

        public Main() {
            InitializeComponent();
            // Instantiate the devices
            this.devices = new Devices();
            // Instantiate the libraries
            this.music_library = new MusicLibrary();
            // Update the GUI with the gathered informations
            loadLibraryDataInGUI();
            curr_jobs = new List<KeyValuePair<IWorker, Thread>>();
        }

        private void Main_Load(object sender, EventArgs e) {
            // Preload items to sync
            /*
            if (entire_library_radio.Checked) entire_library_radio_CheckedChanged(null, null);
            select_items_sync_radio_CheckedChanged(null, null);
            */
        }

        private void refresh_devices_button_Click(object sender, EventArgs e) {
            device_list_combobox.Items.Clear();
            device_storage_list_combobox.Items.Clear();

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
            music_library.clearTracksToSync();
            statusbar_label.Text = "Gathering songs...";
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
                    music_library.addPlaylistToSync(selected_playlist, sync_checked_checkbox.Checked);
                }
                // Add form the Albums
                foreach (int album_i in albums_checkedlist.CheckedIndices) {
                    music_library.addAlbumToSync(album_i, sync_checked_checkbox.Checked);
                }
                // Add from the Artists
                foreach (int artist_i in artists_checkedlist.CheckedIndices) {
                    music_library.addArtistToSync(artist_i, sync_checked_checkbox.Checked);
                }
            }
            updateTrackToSyncInfos();
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
            updateTrackToSyncInfos();
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

        private void updateTrackToSyncInfos() {
            ThreadSafeMethods.threadSafeLabelUpdate(track_to_sync_value_label, music_library.TracksToSync.Count.ToString() + " track(s)");
            ThreadSafeMethods.threadSafeLabelUpdate(size_to_sync_value_label, Math.Round((music_library.TrackToSyncSize / 1000000.0), 2) + " MB");
        }

        private void artists_checkedlist_ItemCheck(object sender, ItemCheckEventArgs e) {
            this.BeginInvoke((MethodInvoker)(() => {
                checked_artists_label.Text = artists_checkedlist.CheckedItems.Count.ToString() + " " + AndroSyncTunes.Resources.GlobalStrings.checked_items;
                ItemsToSyncAdder i = new ItemsToSyncAdder(music_library, ItemsToSyncAdder.WorkKindType.addAllTracksFromArtist, sync_checked_checkbox.Checked, e.Index);
                addingJobStarted(i);
                ThreadSafeMethods.threadSafeToolStripStatusLabelUpdate(statusStrip1, Resources.GlobalStrings.adding_items_from + " " + artists_checkedlist.Items[e.Index].ToString() + "...");
            }));
        }

        private void albums_checkedlist_ItemCheck(object sender, ItemCheckEventArgs e) {
            this.BeginInvoke((MethodInvoker)(() => {
                checked_albums_label.Text = albums_checkedlist.CheckedItems.Count.ToString() + " " + AndroSyncTunes.Resources.GlobalStrings.checked_items;
                ItemsToSyncAdder i = new ItemsToSyncAdder(music_library, ItemsToSyncAdder.WorkKindType.addAllTracksFromAlbum, sync_checked_checkbox.Checked, e.Index);
                addingJobStarted(i);
                ThreadSafeMethods.threadSafeToolStripStatusLabelUpdate(statusStrip1, Resources.GlobalStrings.adding_items_from + " " + albums_checkedlist.Items[e.Index].ToString() + "...");
            }));
        }

        private void playlists_checkedlist_ItemCheck(object sender, ItemCheckEventArgs e) {
            this.BeginInvoke((MethodInvoker)(() => {
                checked_playlist_label.Text = playlists_checkedlist.CheckedItems.Count.ToString() + " " + AndroSyncTunes.Resources.GlobalStrings.checked_items;
                ItemsToSyncAdder i = new ItemsToSyncAdder(music_library, ItemsToSyncAdder.WorkKindType.addAllTracksFromPlaylist, sync_checked_checkbox.Checked, e.Index);
                addingJobStarted(i);
                ThreadSafeMethods.threadSafeToolStripStatusLabelUpdate(statusStrip1, Resources.GlobalStrings.adding_items_from + " " + albums_checkedlist.Items[e.Index].ToString() + "...");
            }));
        }

        private void entire_library_radio_CheckedChanged(object sender, EventArgs e) {
            if (((RadioButton)sender).Checked == true) {
                //abortAllJobs();
                song_chooser_groupbox.Enabled = false;
                ItemsToSyncAdder i = new ItemsToSyncAdder(music_library, ItemsToSyncAdder.WorkKindType.addEntireLibrary, sync_checked_checkbox.Checked);
                addingJobStarted(i);
                ThreadSafeMethods.threadSafeToolStripStatusLabelUpdate(statusStrip1, Resources.GlobalStrings.adding_entire_library);
            } else {
                song_chooser_groupbox.Enabled = true;
            }
        }

        private void select_items_sync_radio_CheckedChanged(object sender, EventArgs e) {
            if (((RadioButton)sender).Checked == true) {
                //abortAllJobs();
                music_library.clearTracksToSync();
                // Add from the Playlists
                foreach (int selected_playlist in playlists_checkedlist.CheckedIndices) music_library.addPlaylistToSync(selected_playlist, sync_checked_checkbox.Checked);
                // Add form the Albums
                foreach (int album_i in albums_checkedlist.CheckedIndices) music_library.addAlbumToSync(album_i, sync_checked_checkbox.Checked);
                // Add from the Artists
                foreach (int artist_i in artists_checkedlist.CheckedIndices) music_library.addArtistToSync(artist_i, sync_checked_checkbox.Checked);
                updateTrackToSyncInfos();
            }
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

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
            Settings settings_form = new Settings();
            settings_form.ShowDialog();
        }

        // ===== JOBS Methods 

        private void addingJobFinishedHandler(object sender, EventArgs e) {
            lock (finishEventLocker) {
                for (int i = 0; i < curr_jobs.Count; i++) if (sender == curr_jobs[i].Key) curr_jobs.RemoveAt(i);
                if (curr_jobs.Count == 0) uiBusyStop();
                updateTrackToSyncInfos();
                ThreadSafeMethods.threadSafeToolStripStatusLabelUpdate(statusStrip1, Resources.GlobalStrings.ready);
            }
        }

        private void addingJobStarted(ItemsToSyncAdder job) {
            if (curr_jobs.Count == 0) uiBusyStart();
            job.AddingFinished += addingJobFinishedHandler;
            Thread t = new Thread(job.DoWork);
            curr_jobs.Add(new KeyValuePair<IWorker, Thread>(job, t));
            t.Start();
        }

        private void abortAllJobs() {
            ThreadSafeMethods.threadSafeToolStripStatusLabelUpdate(statusStrip1, "Aborting all jobs...");
            for (int i = 0; i < curr_jobs.Count; i++) { curr_jobs[i].Value.Abort(); curr_jobs.RemoveAt(i); }
            ThreadSafeMethods.threadSafeToolStripStatusLabelUpdate(statusStrip1, Resources.GlobalStrings.ready);
            uiBusyStop();
        }

        // ==== UI Methods

        private void uiBusyStart() {
            ThreadSafeMethods.threadSafeEnableProgessBar(progressBar1, true);
            ThreadSafeMethods.threadSafeSetStyleProgessBar(progressBar1, ProgressBarStyle.Marquee);
            ThreadSafeMethods.threadSafeButtonEnableDisable(sync_button, false);
        }
        private void uiBusyStop() {
            ThreadSafeMethods.threadSafeSetStyleProgessBar(progressBar1, ProgressBarStyle.Blocks);
            ThreadSafeMethods.threadSafeEnableProgessBar(progressBar1, false);
            ThreadSafeMethods.threadSafeButtonEnableDisable(sync_button, true);
        }
    }
}
