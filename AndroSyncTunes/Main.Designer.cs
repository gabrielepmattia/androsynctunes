﻿using PortableDeviceApiLib;

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
            this.device_list_combobox = new System.Windows.Forms.ComboBox();
            this.storage_label = new System.Windows.Forms.Label();
            this.refresh_devices_button = new System.Windows.Forms.Button();
            this.select_device_groupbox = new System.Windows.Forms.GroupBox();
            this.device_storage_list_combobox = new System.Windows.Forms.ComboBox();
            this.choose_sync_groupbox = new System.Windows.Forms.GroupBox();
            this.entire_library_radio = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.song_chooser_groupbox = new System.Windows.Forms.GroupBox();
            this.artists_checkedlist = new System.Windows.Forms.CheckedListBox();
            this.search_artist_textbox = new System.Windows.Forms.TextBox();
            this.artists_for_list_label = new System.Windows.Forms.Label();
            this.albums_for_list_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.albums_checkedlist = new System.Windows.Forms.CheckedListBox();
            this.genres_for_list_label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.playlists_checkedlist = new System.Windows.Forms.CheckedListBox();
            this.other_options_groupbox = new System.Windows.Forms.GroupBox();
            this.sync_checked_checkbox = new System.Windows.Forms.CheckBox();
            this.sync_music_videos_checkbox = new System.Windows.Forms.CheckBox();
            this.sync_memo_checkbox = new System.Windows.Forms.CheckBox();
            this.checked_artists_label = new System.Windows.Forms.Label();
            this.checked_albums_label = new System.Windows.Forms.Label();
            this.checked_playlist_label = new System.Windows.Forms.Label();
            this.free_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.sync_mvideo_checkbox = new System.Windows.Forms.CheckBox();
            this.sync_memo_checkboa = new System.Windows.Forms.CheckBox();
            this.select_device_groupbox.SuspendLayout();
            this.choose_sync_groupbox.SuspendLayout();
            this.song_chooser_groupbox.SuspendLayout();
            this.other_options_groupbox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.refresh_devices_button.Location = new System.Drawing.Point(207, 0);
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
            this.select_device_groupbox.Location = new System.Drawing.Point(12, 12);
            this.select_device_groupbox.Name = "select_device_groupbox";
            this.select_device_groupbox.Size = new System.Drawing.Size(257, 81);
            this.select_device_groupbox.TabIndex = 3;
            this.select_device_groupbox.TabStop = false;
            this.select_device_groupbox.Text = "1. Select device";
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
            this.choose_sync_groupbox.Location = new System.Drawing.Point(12, 99);
            this.choose_sync_groupbox.Name = "choose_sync_groupbox";
            this.choose_sync_groupbox.Size = new System.Drawing.Size(257, 57);
            this.choose_sync_groupbox.TabIndex = 4;
            this.choose_sync_groupbox.TabStop = false;
            this.choose_sync_groupbox.Text = "2. Choose what to sync";
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
            // song_chooser_groupbox
            // 
            this.song_chooser_groupbox.Controls.Add(this.checked_playlist_label);
            this.song_chooser_groupbox.Controls.Add(this.checked_albums_label);
            this.song_chooser_groupbox.Controls.Add(this.checked_artists_label);
            this.song_chooser_groupbox.Controls.Add(this.genres_for_list_label);
            this.song_chooser_groupbox.Controls.Add(this.textBox2);
            this.song_chooser_groupbox.Controls.Add(this.playlists_checkedlist);
            this.song_chooser_groupbox.Controls.Add(this.albums_for_list_label);
            this.song_chooser_groupbox.Controls.Add(this.textBox1);
            this.song_chooser_groupbox.Controls.Add(this.albums_checkedlist);
            this.song_chooser_groupbox.Controls.Add(this.artists_for_list_label);
            this.song_chooser_groupbox.Controls.Add(this.search_artist_textbox);
            this.song_chooser_groupbox.Controls.Add(this.artists_checkedlist);
            this.song_chooser_groupbox.Location = new System.Drawing.Point(275, 12);
            this.song_chooser_groupbox.Name = "song_chooser_groupbox";
            this.song_chooser_groupbox.Size = new System.Drawing.Size(589, 181);
            this.song_chooser_groupbox.TabIndex = 5;
            this.song_chooser_groupbox.TabStop = false;
            this.song_chooser_groupbox.Text = "3. Songs choser";
            // 
            // artists_checkedlist
            // 
            this.artists_checkedlist.FormattingEnabled = true;
            this.artists_checkedlist.Location = new System.Drawing.Point(6, 51);
            this.artists_checkedlist.Name = "artists_checkedlist";
            this.artists_checkedlist.Size = new System.Drawing.Size(188, 109);
            this.artists_checkedlist.TabIndex = 0;
            this.artists_checkedlist.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.artists_checkedlist_ItemCheck);
            this.artists_checkedlist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.artists_checkedlist_MouseClick);
            this.artists_checkedlist.SelectedIndexChanged += new System.EventHandler(this.artists_checkedlist_SelectedIndexChanged);
            // 
            // search_artist_textbox
            // 
            this.search_artist_textbox.Location = new System.Drawing.Point(6, 32);
            this.search_artist_textbox.Name = "search_artist_textbox";
            this.search_artist_textbox.Size = new System.Drawing.Size(188, 20);
            this.search_artist_textbox.TabIndex = 1;
            this.search_artist_textbox.Text = "Search for Artist...";
            // 
            // artists_for_list_label
            // 
            this.artists_for_list_label.AutoSize = true;
            this.artists_for_list_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artists_for_list_label.Location = new System.Drawing.Point(6, 17);
            this.artists_for_list_label.Name = "artists_for_list_label";
            this.artists_for_list_label.Size = new System.Drawing.Size(40, 12);
            this.artists_for_list_label.TabIndex = 2;
            this.artists_for_list_label.Text = "Artists";
            // 
            // albums_for_list_label
            // 
            this.albums_for_list_label.AutoSize = true;
            this.albums_for_list_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albums_for_list_label.Location = new System.Drawing.Point(200, 17);
            this.albums_for_list_label.Name = "albums_for_list_label";
            this.albums_for_list_label.Size = new System.Drawing.Size(43, 12);
            this.albums_for_list_label.TabIndex = 5;
            this.albums_for_list_label.Text = "Albums";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Search for Albums...";
            // 
            // albums_checkedlist
            // 
            this.albums_checkedlist.FormattingEnabled = true;
            this.albums_checkedlist.Location = new System.Drawing.Point(200, 51);
            this.albums_checkedlist.Name = "albums_checkedlist";
            this.albums_checkedlist.Size = new System.Drawing.Size(188, 109);
            this.albums_checkedlist.TabIndex = 3;
            this.albums_checkedlist.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.albums_checkedlist_ItemCheck);
            // 
            // genres_for_list_label
            // 
            this.genres_for_list_label.AutoSize = true;
            this.genres_for_list_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genres_for_list_label.Location = new System.Drawing.Point(394, 17);
            this.genres_for_list_label.Name = "genres_for_list_label";
            this.genres_for_list_label.Size = new System.Drawing.Size(49, 12);
            this.genres_for_list_label.TabIndex = 8;
            this.genres_for_list_label.Text = "Playlists";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(394, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Search for Playlists...";
            // 
            // playlists_checkedlist
            // 
            this.playlists_checkedlist.FormattingEnabled = true;
            this.playlists_checkedlist.Location = new System.Drawing.Point(394, 51);
            this.playlists_checkedlist.Name = "playlists_checkedlist";
            this.playlists_checkedlist.Size = new System.Drawing.Size(188, 109);
            this.playlists_checkedlist.TabIndex = 6;
            this.playlists_checkedlist.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.playlists_checkedlist_ItemCheck);
            // 
            // other_options_groupbox
            // 
            this.other_options_groupbox.Controls.Add(this.sync_memo_checkbox);
            this.other_options_groupbox.Controls.Add(this.sync_music_videos_checkbox);
            this.other_options_groupbox.Controls.Add(this.sync_checked_checkbox);
            this.other_options_groupbox.Location = new System.Drawing.Point(12, 157);
            this.other_options_groupbox.Name = "other_options_groupbox";
            this.other_options_groupbox.Size = new System.Drawing.Size(257, 70);
            this.other_options_groupbox.TabIndex = 6;
            this.other_options_groupbox.TabStop = false;
            this.other_options_groupbox.Text = "4. Other options";
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
            // checked_artists_label
            // 
            this.checked_artists_label.AutoSize = true;
            this.checked_artists_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checked_artists_label.Location = new System.Drawing.Point(6, 163);
            this.checked_artists_label.Name = "checked_artists_label";
            this.checked_artists_label.Size = new System.Drawing.Size(84, 12);
            this.checked_artists_label.TabIndex = 9;
            this.checked_artists_label.Text = "Checked items #no";
            // 
            // checked_albums_label
            // 
            this.checked_albums_label.AutoSize = true;
            this.checked_albums_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checked_albums_label.Location = new System.Drawing.Point(200, 163);
            this.checked_albums_label.Name = "checked_albums_label";
            this.checked_albums_label.Size = new System.Drawing.Size(84, 12);
            this.checked_albums_label.TabIndex = 10;
            this.checked_albums_label.Text = "Checked items #no";
            // 
            // checked_playlist_label
            // 
            this.checked_playlist_label.AutoSize = true;
            this.checked_playlist_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checked_playlist_label.Location = new System.Drawing.Point(392, 163);
            this.checked_playlist_label.Name = "checked_playlist_label";
            this.checked_playlist_label.Size = new System.Drawing.Size(84, 12);
            this.checked_playlist_label.TabIndex = 11;
            this.checked_playlist_label.Text = "Checked items #no";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(789, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sync";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 230);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(873, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selected tracks to sync:";
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
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
            this.song_chooser_groupbox.PerformLayout();
            this.other_options_groupbox.ResumeLayout(false);
            this.other_options_groupbox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox search_artist_textbox;
        private System.Windows.Forms.CheckedListBox artists_checkedlist;
        private System.Windows.Forms.Label genres_for_list_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckedListBox playlists_checkedlist;
        private System.Windows.Forms.Label albums_for_list_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox albums_checkedlist;
        private System.Windows.Forms.GroupBox other_options_groupbox;
        private System.Windows.Forms.CheckBox sync_checked_checkbox;
        private System.Windows.Forms.CheckBox sync_music_videos_checkbox;
        private System.Windows.Forms.CheckBox sync_memo_checkbox;
        private System.Windows.Forms.Label checked_playlist_label;
        private System.Windows.Forms.Label checked_albums_label;
        private System.Windows.Forms.Label checked_artists_label;
        private System.Windows.Forms.Label free_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox sync_mvideo_checkbox;
        private System.Windows.Forms.CheckBox sync_memo_checkboa;
    }
}

