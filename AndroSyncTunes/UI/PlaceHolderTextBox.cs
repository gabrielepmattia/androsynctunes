﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;

namespace AndroSyncTunes.UI {
    /// <summary>
    /// This class is from the answer http://stackoverflow.com/questions/11873378/adding-placeholder-text-to-textbox/37292579#37292579
    /// </summary>
    public class PlaceHolderTextBox : TextBox {

        bool isPlaceHolder = true;
        string _placeHolderText;
        public string PlaceHolderText {
            get { return _placeHolderText; }
            set {
                _placeHolderText = value;
                setPlaceholder();
            }
        }

        //when the control loses focus, the placeholder is shown
        private void setPlaceholder() {
            if (string.IsNullOrEmpty(this.Text)) {
                this.Text = PlaceHolderText;
                this.ForeColor = Color.Gray;
                this.Font = new Font(this.Font, FontStyle.Regular);
                isPlaceHolder = true;
            }
        }

        //when the control is focused, the placeholder is removed
        private void removePlaceHolder() {

            if (isPlaceHolder) {
                this.Text = "";
                this.ForeColor = System.Drawing.SystemColors.WindowText;
                this.Font = new Font(this.Font, FontStyle.Regular);
                isPlaceHolder = false;
            }
        }
        public PlaceHolderTextBox() {
            GotFocus += removePlaceHolder;
            LostFocus += setPlaceholder;
        }

        private void setPlaceholder(object sender, EventArgs e) {
            setPlaceholder();
        }

        private void removePlaceHolder(object sender, EventArgs e) {
            removePlaceHolder();
        }
    }
}
