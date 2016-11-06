using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AndroSyncTunes.UI {
    class ThreadSafeMethods {
        public static void threadSafeButtonEnableDisable(Button button, bool enabled) {
            if (button.InvokeRequired) {
                button.BeginInvoke((MethodInvoker)delegate () {
                    button.Enabled = enabled;
                });
            } else {
                button.Enabled = enabled;
            }
        }

        public static void threadSafeButtonCaptionUpdate(Button button, String caption) {
            if (button.InvokeRequired) {
                button.BeginInvoke((MethodInvoker)delegate () {
                    button.Text = caption;
                });
            } else {
                button.Text = caption;
            }
        }

        public static void threadSafeButtonColorUpdate(Button button, Color color) {
            if (button.InvokeRequired) {
                button.BeginInvoke((MethodInvoker)delegate () {
                    button.BackColor = color;
                });
            } else {
                button.BackColor = color;
            }
        }

        public static void threadSafeLabelUpdate(Label label, String text) {
            if (label.InvokeRequired) {
                label.BeginInvoke((MethodInvoker)delegate () {
                    label.Text = text;
                });
            } else {
                label.Text = text;
            }
        }

        public static void threadSafeLabelColorUpdate(Label label, Color color) {
            if (label.InvokeRequired) {
                label.BeginInvoke((MethodInvoker)delegate () {
                    label.ForeColor = color;
                });
            } else {
                label.ForeColor = color;
            }
        }

        public static void threadSafeToolStripStatusLabelUpdate(ToolStrip toolStrip, String text) {
            if (toolStrip.InvokeRequired) {
                toolStrip.BeginInvoke((MethodInvoker)delegate () {
                    ToolStripItem[] items = toolStrip.Items.Find("statusbar_label", true);
                    ToolStripLabel label = (ToolStripLabel)items[0];
                    label.Text = text;
                    toolStrip.Update();
                });
            } else {
                ToolStripItem[] items = toolStrip.Items.Find("statusbar_label", true);
                ToolStripLabel label = (ToolStripLabel)items[0];
                label.Text = text;
                toolStrip.Update();
            }
        }

        /// <summary>
        /// Add a row to Grid View safely
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="data"></param>
        public static void threadSafeAddRowDataGridView(DataGridView dataGridView, int index, String[] data) {
            if (dataGridView.InvokeRequired) {
                dataGridView.BeginInvoke((MethodInvoker)delegate () {
                    dataGridView.Rows.Add(index, data[0], data[1], data[2], data[3], data[4]);
                });
            } else {
                dataGridView.Rows.Add(data);
            }
        }

        /// <summary>
        /// Replace the cell number 'cell' at the row number 'row' with data
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="row"></param>
        /// <param name="cell"></param>
        /// <param name="data"></param>
        public static void threadSafeEditCellDataGridView(DataGridView dataGridView, int row, int cell, String data) {
            if (dataGridView.InvokeRequired) {
                dataGridView.BeginInvoke((MethodInvoker)delegate () {
                    dataGridView.Rows[row].Cells[cell].Value = data;
                });
            } else {
                dataGridView.Rows[row].Cells[cell].Value = data;
            }
        }

        public static void threadSafePrepareDataGridView(DataGridView dataGridView) {
            if (dataGridView.InvokeRequired) {
                dataGridView.BeginInvoke((MethodInvoker)delegate () {
                    dataGridView.Rows.Clear();
                    dataGridView.Refresh();
                });
            } else {
                dataGridView.Rows.Clear();
                dataGridView.Refresh();
            }
        }

        public static void threadSafeSetEnabledDataGridView(DataGridView dataGridView, bool enabled) {
            if (dataGridView.InvokeRequired) {
                dataGridView.BeginInvoke((MethodInvoker)delegate () {
                    dataGridView.Enabled = enabled;
                });
            } else {
                dataGridView.Enabled = enabled;
            }
        }

        public static void threadSafeRefreshDataGridView(DataGridView dataGridView) {
            if (dataGridView.InvokeRequired) {
                dataGridView.BeginInvoke((MethodInvoker)delegate () {
                    dataGridView.Refresh();
                    dataGridView.Update();
                });
            } else {
                dataGridView.Refresh();
                dataGridView.Update();
            }
        }

        public static void threadSafeSetDataSourceDataGridView(DataGridView dataGridView, object source) {
            if (dataGridView.InvokeRequired) {
                dataGridView.BeginInvoke((MethodInvoker)delegate () {
                    dataGridView.DataSource = source;
                });
            } else {
                dataGridView.DataSource = source;
            }
        }

        public static void threadSafeColorRowDataGridView(DataGridView dataGridView, int index, Color color) {
            if (dataGridView.InvokeRequired) {
                dataGridView.BeginInvoke((MethodInvoker)delegate () {
                    dataGridView.Rows[index].DefaultCellStyle.BackColor = color;
                });
            } else {
                dataGridView.Rows[index].DefaultCellStyle.BackColor = color;
            }
        }

        public static String threadSafeGetCellDataGridView(DataGridView dataGridView, int row, int col) {
            String str = "";
            if (row >= dataGridView.RowCount) return str;
            if (dataGridView.InvokeRequired) {
                dataGridView.BeginInvoke((MethodInvoker)delegate () {
                    str = dataGridView.Rows[row].Cells[col].Value.ToString();
                });
            } else {
                str = dataGridView.Rows[row].Cells[col].Value.ToString();
            }
            return str;
        }

        public static void threadSafeRefreshProgessBar(ProgressBar progressBar) {
            if (progressBar.InvokeRequired) {
                progressBar.BeginInvoke((MethodInvoker)delegate () {
                    progressBar.Refresh();

                });
            } else {
                progressBar.Refresh();
            }
        }

        public static void threadSafeSetStyleProgessBar(ProgressBar progressBar, ProgressBarStyle style) {
            if (progressBar.InvokeRequired) {
                progressBar.BeginInvoke((MethodInvoker)delegate () {
                    progressBar.Style = style;

                });
            } else {
                progressBar.Style = style;
            }
        }

        public static void threadSafeEnableProgessBar(ProgressBar progressBar, bool enabled) {
            if (progressBar.InvokeRequired) {
                progressBar.BeginInvoke((MethodInvoker)delegate () {
                    progressBar.Enabled = enabled;

                });
            } else {
                progressBar.Enabled = enabled;
            }
        }

        public static void threadSafeSetMaximumProgessBar(ProgressBar progressBar, int max) {
            if (progressBar.InvokeRequired) {
                progressBar.BeginInvoke((MethodInvoker)delegate () {
                    progressBar.Maximum = max;

                });
            } else {
                progressBar.Maximum = max;
            }
        }

        public static void threadSafeUpdateProgessBar(ProgressBar progressBar, int progress) {
            if (progressBar.InvokeRequired) {
                progressBar.BeginInvoke((MethodInvoker)delegate () {
                    progressBar.Value = progress;
                });
            } else {
                progressBar.Value = progress;
            }
        }

        public static void threadSafeCheckBoxEnableDisable(CheckBox checkBox, bool enabled) {
            if (checkBox.InvokeRequired) {
                checkBox.BeginInvoke((MethodInvoker)delegate () {
                    checkBox.Enabled = enabled;
                });
            } else {
                checkBox.Enabled = enabled;
            }
        }

        public static void threadSafeGroupBoxEnabled(GroupBox groupBox, bool enabled) {
            if (groupBox.InvokeRequired) {
                groupBox.BeginInvoke((MethodInvoker)delegate () {
                    groupBox.Enabled = enabled;
                });
            } else {
                groupBox.Enabled = enabled;
            }
        }

        public static void threadSafeSetComboBoxIndex(ComboBox combobox, int index) {
            if (combobox.InvokeRequired) {
                combobox.BeginInvoke((MethodInvoker)delegate () {
                    combobox.SelectedIndex = index;
                });
            } else {
                combobox.SelectedIndex = index;
            }
        }
    }
}
