using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AndroSyncTunes {
    public partial class Settings : Form {
        public Settings() {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e) {
            music_folder_textbox.Text = Properties.Settings.Default.device_music_folder;
        }

        private void ok_button_Click(object sender, EventArgs e) {
            if (music_folder_textbox.Text.Trim() != "") Properties.Settings.Default.device_music_folder = music_folder_textbox.Text.Trim();
            Properties.Settings.Default.Save();
            Close();
        }

        private void cancel_button_Click(object sender, EventArgs e) {
            Close();
        }

        private void music_folder_ex_label_Enter(object sender, EventArgs e) {
            ActiveControl = null;
        }
    }
}
