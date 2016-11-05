namespace AndroSyncTunes {
    partial class Settings {
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.general_tabpage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.device_label = new System.Windows.Forms.Label();
            this.music_folder_textbox = new System.Windows.Forms.TextBox();
            this.music_folder_label = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.music_folder_ex_label = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.general_tabpage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.general_tabpage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(347, 119);
            this.tabControl.TabIndex = 0;
            // 
            // general_tabpage
            // 
            this.general_tabpage.Controls.Add(this.groupBox1);
            this.general_tabpage.Location = new System.Drawing.Point(4, 22);
            this.general_tabpage.Name = "general_tabpage";
            this.general_tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.general_tabpage.Size = new System.Drawing.Size(339, 93);
            this.general_tabpage.TabIndex = 0;
            this.general_tabpage.Text = "General";
            this.general_tabpage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.music_folder_ex_label);
            this.groupBox1.Controls.Add(this.device_label);
            this.groupBox1.Controls.Add(this.music_folder_textbox);
            this.groupBox1.Controls.Add(this.music_folder_label);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sync Folders";
            // 
            // device_label
            // 
            this.device_label.AutoSize = true;
            this.device_label.Location = new System.Drawing.Point(168, 19);
            this.device_label.Name = "device_label";
            this.device_label.Size = new System.Drawing.Size(52, 13);
            this.device_label.TabIndex = 2;
            this.device_label.Text = "device:\\\\";
            // 
            // music_folder_textbox
            // 
            this.music_folder_textbox.Location = new System.Drawing.Point(221, 16);
            this.music_folder_textbox.Name = "music_folder_textbox";
            this.music_folder_textbox.Size = new System.Drawing.Size(100, 20);
            this.music_folder_textbox.TabIndex = 1;
            // 
            // music_folder_label
            // 
            this.music_folder_label.AutoSize = true;
            this.music_folder_label.Location = new System.Drawing.Point(10, 19);
            this.music_folder_label.Name = "music_folder_label";
            this.music_folder_label.Size = new System.Drawing.Size(64, 13);
            this.music_folder_label.TabIndex = 0;
            this.music_folder_label.Text = "Music folder";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(280, 137);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 1;
            this.cancel_button.Text = "&Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(199, 137);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "&OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // music_folder_ex_label
            // 
            this.music_folder_ex_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.music_folder_ex_label.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.music_folder_ex_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.music_folder_ex_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.music_folder_ex_label.Location = new System.Drawing.Point(13, 39);
            this.music_folder_ex_label.Name = "music_folder_ex_label";
            this.music_folder_ex_label.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.music_folder_ex_label.Size = new System.Drawing.Size(308, 28);
            this.music_folder_ex_label.TabIndex = 4;
            this.music_folder_ex_label.Text = "Write here the name of the music folder that will be created on device. For now, " +
    "track will be synchronized with a structure like Artist/Album";
            this.music_folder_ex_label.Enter += new System.EventHandler(this.music_folder_ex_label_Enter);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 166);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.tabControl);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl.ResumeLayout(false);
            this.general_tabpage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage general_tabpage;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label device_label;
        private System.Windows.Forms.TextBox music_folder_textbox;
        private System.Windows.Forms.Label music_folder_label;
        private System.Windows.Forms.RichTextBox music_folder_ex_label;
    }
}