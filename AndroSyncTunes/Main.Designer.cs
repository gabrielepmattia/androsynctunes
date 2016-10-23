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
            this.device_list_combobox = new System.Windows.Forms.ComboBox();
            this.select_device_label = new System.Windows.Forms.Label();
            this.refresh_devices_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // device_list_combobox
            // 
            this.device_list_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.device_list_combobox.FormattingEnabled = true;
            this.device_list_combobox.Location = new System.Drawing.Point(343, 6);
            this.device_list_combobox.Name = "device_list_combobox";
            this.device_list_combobox.Size = new System.Drawing.Size(133, 21);
            this.device_list_combobox.TabIndex = 0;
            // 
            // select_device_label
            // 
            this.select_device_label.AutoSize = true;
            this.select_device_label.Location = new System.Drawing.Point(12, 9);
            this.select_device_label.Name = "select_device_label";
            this.select_device_label.Size = new System.Drawing.Size(114, 13);
            this.select_device_label.TabIndex = 1;
            this.select_device_label.Text = "Select device to Sync:";
            // 
            // refresh_devices_button
            // 
            this.refresh_devices_button.Location = new System.Drawing.Point(262, 5);
            this.refresh_devices_button.Name = "refresh_devices_button";
            this.refresh_devices_button.Size = new System.Drawing.Size(75, 23);
            this.refresh_devices_button.TabIndex = 2;
            this.refresh_devices_button.Text = "Refresh";
            this.refresh_devices_button.UseVisualStyleBackColor = true;
            this.refresh_devices_button.Click += new System.EventHandler(this.refresh_devices_button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 245);
            this.Controls.Add(this.refresh_devices_button);
            this.Controls.Add(this.select_device_label);
            this.Controls.Add(this.device_list_combobox);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox device_list_combobox;
        private System.Windows.Forms.Label select_device_label;
        private System.Windows.Forms.Button refresh_devices_button;
    }
}

