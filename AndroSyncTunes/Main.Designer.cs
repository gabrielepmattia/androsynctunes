using PortableDeviceApiLib;

namespace AndroSyncTunes {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.device_list_combobox = new System.Windows.Forms.ComboBox();
            this.storage_label = new System.Windows.Forms.Label();
            this.refresh_devices_button = new System.Windows.Forms.Button();
            this.select_device_groupbox = new System.Windows.Forms.GroupBox();
            this.free_label = new System.Windows.Forms.Label();
            this.device_storage_list_combobox = new System.Windows.Forms.ComboBox();
            this.choose_sync_groupbox = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.entire_library_radio = new System.Windows.Forms.RadioButton();
            this.song_chooser_groupbox = new System.Windows.Forms.GroupBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.music_tabPage = new System.Windows.Forms.TabPage();
            this.search_playlist_placeholdertextbox = new AndroSyncTunes.UI.PlaceHolderTextBox();
            this.artists_checkedlist = new System.Windows.Forms.CheckedListBox();
            this.search_album_placeholdertextbox = new AndroSyncTunes.UI.PlaceHolderTextBox();
            this.artists_for_list_label = new System.Windows.Forms.Label();
            this.search_artist_placeholdertextbox = new AndroSyncTunes.UI.PlaceHolderTextBox();
            this.albums_checkedlist = new System.Windows.Forms.CheckedListBox();
            this.checked_playlist_label = new System.Windows.Forms.Label();
            this.albums_for_list_label = new System.Windows.Forms.Label();
            this.checked_albums_label = new System.Windows.Forms.Label();
            this.playlists_checkedlist = new System.Windows.Forms.CheckedListBox();
            this.checked_artists_label = new System.Windows.Forms.Label();
            this.genres_for_list_label = new System.Windows.Forms.Label();
            this.other_options_groupbox = new System.Windows.Forms.GroupBox();
            this.sync_memo_checkbox = new System.Windows.Forms.CheckBox();
            this.sync_music_videos_checkbox = new System.Windows.Forms.CheckBox();
            this.sync_checked_checkbox = new System.Windows.Forms.CheckBox();
            this.sync_button = new System.Windows.Forms.Button();
            this.track_to_sync_label = new System.Windows.Forms.Label();
            this.sync_mvideo_checkbox = new System.Windows.Forms.CheckBox();
            this.sync_memo_checkboa = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.file_toolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sync_report_groupbox = new System.Windows.Forms.GroupBox();
            this.size_to_sync_value_label = new System.Windows.Forms.Label();
            this.size_to_sync_label = new System.Windows.Forms.Label();
            this.track_to_sync_value_label = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.select_device_groupbox.SuspendLayout();
            this.choose_sync_groupbox.SuspendLayout();
            this.song_chooser_groupbox.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.music_tabPage.SuspendLayout();
            this.other_options_groupbox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.sync_report_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // device_list_combobox
            // 
            this.device_list_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.device_list_combobox.FormattingEnabled = true;
            this.device_list_combobox.Location = new System.Drawing.Point(6, 19);
            this.device_list_combobox.Name = "device_list_combobox";
            this.device_list_combobox.Size = new System.Drawing.Size(177, 21);
            this.device_list_combobox.TabIndex = 0;
            // 
            // storage_label
            // 
            this.storage_label.AutoSize = true;
            this.storage_label.Location = new System.Drawing.Point(6, 49);
            this.storage_label.Name = "storage_label";
            this.storage_label.Size = new System.Drawing.Size(44, 13);
            this.storage_label.TabIndex = 1;
            this.storage_label.Text = "Storage";
            // 
            // refresh_devices_button
            // 
            this.refresh_devices_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_devices_button.Location = new System.Drawing.Point(202, 0);
            this.refresh_devices_button.Name = "refresh_devices_button";
            this.refresh_devices_button.Size = new System.Drawing.Size(50, 21);
            this.refresh_devices_button.TabIndex = 2;
            this.refresh_devices_button.Text = "&Refresh";
            this.refresh_devices_button.UseVisualStyleBackColor = true;
            this.refresh_devices_button.Click += new System.EventHandler(this.refresh_devices_button_Click);
            // 
            // select_device_groupbox
            // 
            this.select_device_groupbox.Controls.Add(this.free_label);
            this.select_device_groupbox.Controls.Add(this.device_storage_list_combobox);
            this.select_device_groupbox.Controls.Add(this.storage_label);
            this.select_device_groupbox.Controls.Add(this.refresh_devices_button);
            this.select_device_groupbox.Controls.Add(this.device_list_combobox);
            this.select_device_groupbox.Location = new System.Drawing.Point(12, 25);
            this.select_device_groupbox.Name = "select_device_groupbox";
            this.select_device_groupbox.Size = new System.Drawing.Size(257, 81);
            this.select_device_groupbox.TabIndex = 3;
            this.select_device_groupbox.TabStop = false;
            this.select_device_groupbox.Text = "1. Select device";
            // 
            // free_label
            // 
            this.free_label.AutoSize = true;
            this.free_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.free_label.Location = new System.Drawing.Point(205, 32);
            this.free_label.Name = "free_label";
            this.free_label.Size = new System.Drawing.Size(34, 12);
            this.free_label.TabIndex = 5;
            this.free_label.Text = "FREE";
            // 
            // device_storage_list_combobox
            // 
            this.device_storage_list_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.device_storage_list_combobox.FormattingEnabled = true;
            this.device_storage_list_combobox.Location = new System.Drawing.Point(53, 46);
            this.device_storage_list_combobox.Name = "device_storage_list_combobox";
            this.device_storage_list_combobox.Size = new System.Drawing.Size(130, 21);
            this.device_storage_list_combobox.TabIndex = 4;
            // 
            // choose_sync_groupbox
            // 
            this.choose_sync_groupbox.Controls.Add(this.radioButton1);
            this.choose_sync_groupbox.Controls.Add(this.entire_library_radio);
            this.choose_sync_groupbox.Location = new System.Drawing.Point(12, 107);
            this.choose_sync_groupbox.Name = "choose_sync_groupbox";
            this.choose_sync_groupbox.Size = new System.Drawing.Size(257, 57);
            this.choose_sync_groupbox.TabIndex = 4;
            this.choose_sync_groupbox.TabStop = false;
            this.choose_sync_groupbox.Text = "2. Choose what to sync";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(119, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "Select items to sync";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // entire_library_radio
            // 
            this.entire_library_radio.AutoSize = true;
            this.entire_library_radio.Checked = true;
            this.entire_library_radio.Location = new System.Drawing.Point(6, 19);
            this.entire_library_radio.Name = "entire_library_radio";
            this.entire_library_radio.Size = new System.Drawing.Size(206, 17);
            this.entire_library_radio.TabIndex = 0;
            this.entire_library_radio.TabStop = true;
            this.entire_library_radio.Text = "Sync the entire library with your device";
            this.entire_library_radio.UseVisualStyleBackColor = true;
            this.entire_library_radio.CheckedChanged += new System.EventHandler(this.entire_library_radio_CheckedChanged);
            // 
            // song_chooser_groupbox
            // 
            this.song_chooser_groupbox.Controls.Add(this.mainTabControl);
            this.song_chooser_groupbox.Enabled = false;
            this.song_chooser_groupbox.Location = new System.Drawing.Point(275, 25);
            this.song_chooser_groupbox.Name = "song_chooser_groupbox";
            this.song_chooser_groupbox.Size = new System.Drawing.Size(613, 308);
            this.song_chooser_groupbox.TabIndex = 5;
            this.song_chooser_groupbox.TabStop = false;
            this.song_chooser_groupbox.Text = "3. Items chooser";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.music_tabPage);
            this.mainTabControl.Location = new System.Drawing.Point(6, 19);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(597, 282);
            this.mainTabControl.TabIndex = 12;
            // 
            // music_tabPage
            // 
            this.music_tabPage.Controls.Add(this.search_playlist_placeholdertextbox);
            this.music_tabPage.Controls.Add(this.artists_checkedlist);
            this.music_tabPage.Controls.Add(this.search_album_placeholdertextbox);
            this.music_tabPage.Controls.Add(this.artists_for_list_label);
            this.music_tabPage.Controls.Add(this.search_artist_placeholdertextbox);
            this.music_tabPage.Controls.Add(this.albums_checkedlist);
            this.music_tabPage.Controls.Add(this.checked_playlist_label);
            this.music_tabPage.Controls.Add(this.albums_for_list_label);
            this.music_tabPage.Controls.Add(this.checked_albums_label);
            this.music_tabPage.Controls.Add(this.playlists_checkedlist);
            this.music_tabPage.Controls.Add(this.checked_artists_label);
            this.music_tabPage.Controls.Add(this.genres_for_list_label);
            this.music_tabPage.Location = new System.Drawing.Point(4, 22);
            this.music_tabPage.Name = "music_tabPage";
            this.music_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.music_tabPage.Size = new System.Drawing.Size(589, 256);
            this.music_tabPage.TabIndex = 0;
            this.music_tabPage.Text = "Music";
            this.music_tabPage.UseVisualStyleBackColor = true;
            // 
            // search_playlist_placeholdertextbox
            // 
            this.search_playlist_placeholdertextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.search_playlist_placeholdertextbox.ForeColor = System.Drawing.Color.Gray;
            this.search_playlist_placeholdertextbox.Location = new System.Drawing.Point(394, 20);
            this.search_playlist_placeholdertextbox.Name = "search_playlist_placeholdertextbox";
            this.search_playlist_placeholdertextbox.PlaceHolderText = "Search for playlists...";
            this.search_playlist_placeholdertextbox.Size = new System.Drawing.Size(188, 20);
            this.search_playlist_placeholdertextbox.TabIndex = 11;
            this.search_playlist_placeholdertextbox.Text = "Search for playlists...";
            this.search_playlist_placeholdertextbox.TextChanged += new System.EventHandler(this.search_playlist_placeholdertextbox_TextChanged);
            // 
            // artists_checkedlist
            // 
            this.artists_checkedlist.FormattingEnabled = true;
            this.artists_checkedlist.Location = new System.Drawing.Point(6, 39);
            this.artists_checkedlist.Name = "artists_checkedlist";
            this.artists_checkedlist.Size = new System.Drawing.Size(188, 199);
            this.artists_checkedlist.TabIndex = 0;
            this.artists_checkedlist.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.artists_checkedlist_ItemCheck);
            // 
            // search_album_placeholdertextbox
            // 
            this.search_album_placeholdertextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.search_album_placeholdertextbox.ForeColor = System.Drawing.Color.Gray;
            this.search_album_placeholdertextbox.Location = new System.Drawing.Point(200, 20);
            this.search_album_placeholdertextbox.Name = "search_album_placeholdertextbox";
            this.search_album_placeholdertextbox.PlaceHolderText = "Search for albums...";
            this.search_album_placeholdertextbox.Size = new System.Drawing.Size(188, 20);
            this.search_album_placeholdertextbox.TabIndex = 11;
            this.search_album_placeholdertextbox.Text = "Search for albums...";
            this.search_album_placeholdertextbox.TextChanged += new System.EventHandler(this.search_album_placeholdertextbox_TextChanged);
            // 
            // artists_for_list_label
            // 
            this.artists_for_list_label.AutoSize = true;
            this.artists_for_list_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artists_for_list_label.Location = new System.Drawing.Point(6, 5);
            this.artists_for_list_label.Name = "artists_for_list_label";
            this.artists_for_list_label.Size = new System.Drawing.Size(40, 12);
            this.artists_for_list_label.TabIndex = 2;
            this.artists_for_list_label.Text = "Artists";
            // 
            // search_artist_placeholdertextbox
            // 
            this.search_artist_placeholdertextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.search_artist_placeholdertextbox.ForeColor = System.Drawing.Color.Gray;
            this.search_artist_placeholdertextbox.Location = new System.Drawing.Point(6, 20);
            this.search_artist_placeholdertextbox.Name = "search_artist_placeholdertextbox";
            this.search_artist_placeholdertextbox.PlaceHolderText = "Search for artists..";
            this.search_artist_placeholdertextbox.Size = new System.Drawing.Size(188, 20);
            this.search_artist_placeholdertextbox.TabIndex = 12;
            this.search_artist_placeholdertextbox.Text = "Search for artists...";
            this.search_artist_placeholdertextbox.TextChanged += new System.EventHandler(this.search_artist_placeholdertextbox_TextChanged);
            // 
            // albums_checkedlist
            // 
            this.albums_checkedlist.FormattingEnabled = true;
            this.albums_checkedlist.Location = new System.Drawing.Point(200, 39);
            this.albums_checkedlist.Name = "albums_checkedlist";
            this.albums_checkedlist.Size = new System.Drawing.Size(188, 199);
            this.albums_checkedlist.TabIndex = 3;
            this.albums_checkedlist.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.albums_checkedlist_ItemCheck);
            // 
            // checked_playlist_label
            // 
            this.checked_playlist_label.AutoSize = true;
            this.checked_playlist_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checked_playlist_label.Location = new System.Drawing.Point(394, 241);
            this.checked_playlist_label.Name = "checked_playlist_label";
            this.checked_playlist_label.Size = new System.Drawing.Size(78, 12);
            this.checked_playlist_label.TabIndex = 11;
            this.checked_playlist_label.Text = "0 checked item(s)";
            // 
            // albums_for_list_label
            // 
            this.albums_for_list_label.AutoSize = true;
            this.albums_for_list_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albums_for_list_label.Location = new System.Drawing.Point(200, 5);
            this.albums_for_list_label.Name = "albums_for_list_label";
            this.albums_for_list_label.Size = new System.Drawing.Size(43, 12);
            this.albums_for_list_label.TabIndex = 5;
            this.albums_for_list_label.Text = "Albums";
            // 
            // checked_albums_label
            // 
            this.checked_albums_label.AutoSize = true;
            this.checked_albums_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checked_albums_label.Location = new System.Drawing.Point(200, 241);
            this.checked_albums_label.Name = "checked_albums_label";
            this.checked_albums_label.Size = new System.Drawing.Size(78, 12);
            this.checked_albums_label.TabIndex = 10;
            this.checked_albums_label.Text = "0 checked item(s)";
            // 
            // playlists_checkedlist
            // 
            this.playlists_checkedlist.FormattingEnabled = true;
            this.playlists_checkedlist.Location = new System.Drawing.Point(394, 39);
            this.playlists_checkedlist.Name = "playlists_checkedlist";
            this.playlists_checkedlist.Size = new System.Drawing.Size(188, 199);
            this.playlists_checkedlist.TabIndex = 6;
            this.playlists_checkedlist.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.playlists_checkedlist_ItemCheck);
            // 
            // checked_artists_label
            // 
            this.checked_artists_label.AutoSize = true;
            this.checked_artists_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checked_artists_label.Location = new System.Drawing.Point(6, 241);
            this.checked_artists_label.Name = "checked_artists_label";
            this.checked_artists_label.Size = new System.Drawing.Size(78, 12);
            this.checked_artists_label.TabIndex = 9;
            this.checked_artists_label.Text = "0 checked item(s)";
            // 
            // genres_for_list_label
            // 
            this.genres_for_list_label.AutoSize = true;
            this.genres_for_list_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genres_for_list_label.Location = new System.Drawing.Point(394, 5);
            this.genres_for_list_label.Name = "genres_for_list_label";
            this.genres_for_list_label.Size = new System.Drawing.Size(49, 12);
            this.genres_for_list_label.TabIndex = 8;
            this.genres_for_list_label.Text = "Playlists";
            // 
            // other_options_groupbox
            // 
            this.other_options_groupbox.Controls.Add(this.sync_memo_checkbox);
            this.other_options_groupbox.Controls.Add(this.sync_music_videos_checkbox);
            this.other_options_groupbox.Controls.Add(this.sync_checked_checkbox);
            this.other_options_groupbox.Location = new System.Drawing.Point(12, 165);
            this.other_options_groupbox.Name = "other_options_groupbox";
            this.other_options_groupbox.Size = new System.Drawing.Size(257, 70);
            this.other_options_groupbox.TabIndex = 6;
            this.other_options_groupbox.TabStop = false;
            this.other_options_groupbox.Text = "4. Other options";
            // 
            // sync_memo_checkbox
            // 
            this.sync_memo_checkbox.AutoSize = true;
            this.sync_memo_checkbox.Location = new System.Drawing.Point(6, 49);
            this.sync_memo_checkbox.Name = "sync_memo_checkbox";
            this.sync_memo_checkbox.Size = new System.Drawing.Size(137, 17);
            this.sync_memo_checkbox.TabIndex = 9;
            this.sync_memo_checkbox.Text = "Sync also voice memos";
            this.sync_memo_checkbox.UseVisualStyleBackColor = true;
            // 
            // sync_music_videos_checkbox
            // 
            this.sync_music_videos_checkbox.AutoSize = true;
            this.sync_music_videos_checkbox.Location = new System.Drawing.Point(6, 34);
            this.sync_music_videos_checkbox.Name = "sync_music_videos_checkbox";
            this.sync_music_videos_checkbox.Size = new System.Drawing.Size(136, 17);
            this.sync_music_videos_checkbox.TabIndex = 8;
            this.sync_music_videos_checkbox.Text = "Sync also music videos";
            this.sync_music_videos_checkbox.UseVisualStyleBackColor = true;
            // 
            // sync_checked_checkbox
            // 
            this.sync_checked_checkbox.AutoSize = true;
            this.sync_checked_checkbox.Location = new System.Drawing.Point(6, 19);
            this.sync_checked_checkbox.Name = "sync_checked_checkbox";
            this.sync_checked_checkbox.Size = new System.Drawing.Size(148, 17);
            this.sync_checked_checkbox.TabIndex = 7;
            this.sync_checked_checkbox.Text = "Sync only checked songs";
            this.sync_checked_checkbox.UseVisualStyleBackColor = true;
            // 
            // sync_button
            // 
            this.sync_button.Location = new System.Drawing.Point(180, 0);
            this.sync_button.Name = "sync_button";
            this.sync_button.Size = new System.Drawing.Size(75, 23);
            this.sync_button.TabIndex = 7;
            this.sync_button.Text = "Sync";
            this.sync_button.UseVisualStyleBackColor = true;
            this.sync_button.Click += new System.EventHandler(this.sync_button_Click);
            // 
            // track_to_sync_label
            // 
            this.track_to_sync_label.AutoSize = true;
            this.track_to_sync_label.Location = new System.Drawing.Point(6, 29);
            this.track_to_sync_label.Name = "track_to_sync_label";
            this.track_to_sync_label.Size = new System.Drawing.Size(80, 13);
            this.track_to_sync_label.TabIndex = 9;
            this.track_to_sync_label.Text = "Tracks to sync:";
            // 
            // sync_mvideo_checkbox
            // 
            this.sync_mvideo_checkbox.AutoSize = true;
            this.sync_mvideo_checkbox.Location = new System.Drawing.Point(6, 34);
            this.sync_mvideo_checkbox.Name = "sync_mvideo_checkbox";
            this.sync_mvideo_checkbox.Size = new System.Drawing.Size(136, 17);
            this.sync_mvideo_checkbox.TabIndex = 8;
            this.sync_mvideo_checkbox.Text = "Sync also music videos";
            this.sync_mvideo_checkbox.UseVisualStyleBackColor = true;
            // 
            // sync_memo_checkboa
            // 
            this.sync_memo_checkboa.AutoSize = true;
            this.sync_memo_checkboa.Location = new System.Drawing.Point(6, 49);
            this.sync_memo_checkboa.Name = "sync_memo_checkboa";
            this.sync_memo_checkboa.Size = new System.Drawing.Size(137, 17);
            this.sync_memo_checkboa.TabIndex = 9;
            this.sync_memo_checkboa.Text = "Sync also voice memos";
            this.sync_memo_checkboa.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(898, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel2.Text = "Ready!";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_toolStripDropDownButton,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(898, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // file_toolStripDropDownButton
            // 
            this.file_toolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.file_toolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.file_toolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("file_toolStripDropDownButton.Image")));
            this.file_toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_toolStripDropDownButton.Name = "file_toolStripDropDownButton";
            this.file_toolStripDropDownButton.ShowDropDownArrow = false;
            this.file_toolStripDropDownButton.Size = new System.Drawing.Size(29, 22);
            this.file_toolStripDropDownButton.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(44, 22);
            this.toolStripDropDownButton1.Text = "&About";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.instructionsToolStripMenuItem.Text = "&Instructions";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.creditsToolStripMenuItem.Text = "&Credits";
            // 
            // sync_report_groupbox
            // 
            this.sync_report_groupbox.Controls.Add(this.size_to_sync_value_label);
            this.sync_report_groupbox.Controls.Add(this.size_to_sync_label);
            this.sync_report_groupbox.Controls.Add(this.track_to_sync_value_label);
            this.sync_report_groupbox.Controls.Add(this.sync_button);
            this.sync_report_groupbox.Controls.Add(this.track_to_sync_label);
            this.sync_report_groupbox.Location = new System.Drawing.Point(12, 237);
            this.sync_report_groupbox.Name = "sync_report_groupbox";
            this.sync_report_groupbox.Size = new System.Drawing.Size(257, 96);
            this.sync_report_groupbox.TabIndex = 12;
            this.sync_report_groupbox.TabStop = false;
            this.sync_report_groupbox.Text = "5. Review&&Sync";
            // 
            // size_to_sync_value_label
            // 
            this.size_to_sync_value_label.Location = new System.Drawing.Point(92, 42);
            this.size_to_sync_value_label.Name = "size_to_sync_value_label";
            this.size_to_sync_value_label.Size = new System.Drawing.Size(159, 13);
            this.size_to_sync_value_label.TabIndex = 16;
            this.size_to_sync_value_label.Text = "0";
            this.size_to_sync_value_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // size_to_sync_label
            // 
            this.size_to_sync_label.AutoSize = true;
            this.size_to_sync_label.Location = new System.Drawing.Point(6, 42);
            this.size_to_sync_label.Name = "size_to_sync_label";
            this.size_to_sync_label.Size = new System.Drawing.Size(67, 13);
            this.size_to_sync_label.TabIndex = 15;
            this.size_to_sync_label.Text = "Size to sync:";
            // 
            // track_to_sync_value_label
            // 
            this.track_to_sync_value_label.Location = new System.Drawing.Point(92, 29);
            this.track_to_sync_value_label.Name = "track_to_sync_value_label";
            this.track_to_sync_value_label.Size = new System.Drawing.Size(159, 13);
            this.track_to_sync_value_label.TabIndex = 14;
            this.track_to_sync_value_label.Text = "0";
            this.track_to_sync_value_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 336);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(877, 10);
            this.progressBar1.TabIndex = 13;
            // 
            // search_playlist_placeholdertextbox
            // 
            this.search_playlist_placeholdertextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.search_playlist_placeholdertextbox.ForeColor = System.Drawing.Color.Gray;
            this.search_playlist_placeholdertextbox.Location = new System.Drawing.Point(394, 20);
            this.search_playlist_placeholdertextbox.Name = "search_playlist_placeholdertextbox";
            this.search_playlist_placeholdertextbox.PlaceHolderText = "Search for playlists...";
            this.search_playlist_placeholdertextbox.Size = new System.Drawing.Size(188, 20);
            this.search_playlist_placeholdertextbox.TabIndex = 11;
            this.search_playlist_placeholdertextbox.Text = "Search for playlists...";
            this.search_playlist_placeholdertextbox.TextChanged += new System.EventHandler(this.search_playlist_placeholdertextbox_TextChanged);
            // 
            // search_album_placeholdertextbox
            // 
            this.search_album_placeholdertextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.search_album_placeholdertextbox.ForeColor = System.Drawing.Color.Gray;
            this.search_album_placeholdertextbox.Location = new System.Drawing.Point(200, 20);
            this.search_album_placeholdertextbox.Name = "search_album_placeholdertextbox";
            this.search_album_placeholdertextbox.PlaceHolderText = "Search for albums...";
            this.search_album_placeholdertextbox.Size = new System.Drawing.Size(188, 20);
            this.search_album_placeholdertextbox.TabIndex = 11;
            this.search_album_placeholdertextbox.Text = "Search for albums...";
            this.search_album_placeholdertextbox.TextChanged += new System.EventHandler(this.search_album_placeholdertextbox_TextChanged);
            // 
            // search_artist_placeholdertextbox
            // 
            this.size_to_sync_value_label.Location = new System.Drawing.Point(92, 42);
            this.size_to_sync_value_label.Name = "size_to_sync_value_label";
            this.size_to_sync_value_label.Size = new System.Drawing.Size(159, 13);
            this.size_to_sync_value_label.TabIndex = 16;
            this.size_to_sync_value_label.Text = "0";
            this.size_to_sync_value_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // track_to_sync_value_label
            // 
            this.track_to_sync_value_label.Location = new System.Drawing.Point(92, 29);
            this.track_to_sync_value_label.Name = "track_to_sync_value_label";
            this.track_to_sync_value_label.Size = new System.Drawing.Size(159, 13);
            this.track_to_sync_value_label.TabIndex = 14;
            this.track_to_sync_value_label.Text = "0";
            this.track_to_sync_value_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 336);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(877, 10);
            this.progressBar1.TabIndex = 13;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 371);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.sync_report_groupbox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.other_options_groupbox);
            this.Controls.Add(this.song_chooser_groupbox);
            this.Controls.Add(this.choose_sync_groupbox);
            this.Controls.Add(this.select_device_groupbox);
            this.Name = "Main";
            this.Text = "AndroSyncTunes";
            this.Load += new System.EventHandler(this.Main_Load);
            this.select_device_groupbox.ResumeLayout(false);
            this.select_device_groupbox.PerformLayout();
            this.choose_sync_groupbox.ResumeLayout(false);
            this.choose_sync_groupbox.PerformLayout();
            this.song_chooser_groupbox.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.music_tabPage.ResumeLayout(false);
            this.music_tabPage.PerformLayout();
            this.other_options_groupbox.ResumeLayout(false);
            this.other_options_groupbox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.sync_report_groupbox.ResumeLayout(false);
            this.sync_report_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox device_list_combobox;
        private System.Windows.Forms.Label storage_label;
        private System.Windows.Forms.Button refresh_devices_button;
        private System.Windows.Forms.GroupBox select_device_groupbox;
        private System.Windows.Forms.ComboBox device_storage_list_combobox;
        private System.Windows.Forms.GroupBox choose_sync_groupbox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton entire_library_radio;
        private System.Windows.Forms.GroupBox song_chooser_groupbox;
        private System.Windows.Forms.Label artists_for_list_label;
        private System.Windows.Forms.CheckedListBox artists_checkedlist;
        private System.Windows.Forms.Label genres_for_list_label;
        private System.Windows.Forms.CheckedListBox playlists_checkedlist;
        private System.Windows.Forms.Label albums_for_list_label;
        private System.Windows.Forms.CheckedListBox albums_checkedlist;
        private System.Windows.Forms.GroupBox other_options_groupbox;
        private System.Windows.Forms.CheckBox sync_checked_checkbox;
        private System.Windows.Forms.CheckBox sync_music_videos_checkbox;
        private System.Windows.Forms.CheckBox sync_memo_checkbox;
        private System.Windows.Forms.Label checked_playlist_label;
        private System.Windows.Forms.Label checked_albums_label;
        private System.Windows.Forms.Label checked_artists_label;
        private System.Windows.Forms.Label free_label;
        private System.Windows.Forms.Button sync_button;

        private System.Windows.Forms.Label track_to_sync_label;
        private System.Windows.Forms.CheckBox sync_mvideo_checkbox;
        private System.Windows.Forms.CheckBox sync_memo_checkboa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private UI.PlaceHolderTextBox search_artist_placeholdertextbox;
        private UI.PlaceHolderTextBox search_album_placeholdertextbox;
        private UI.PlaceHolderTextBox search_playlist_placeholdertextbox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton file_toolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage music_tabPage;
        private System.Windows.Forms.GroupBox sync_report_groupbox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label track_to_sync_value_label;
        private System.Windows.Forms.Label size_to_sync_value_label;
        private System.Windows.Forms.Label size_to_sync_label;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

