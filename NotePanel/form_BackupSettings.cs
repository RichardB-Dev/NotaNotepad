using NotePanel.Classess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePanel
{
    public partial class form_BackupSettings : Form
    {
        Config configData;

        public form_BackupSettings(ref Config _config, bool t)
        {
            InitializeComponent();
            configData = _config;
        }

        private void Settings_BackupSettings_Load(object sender, EventArgs e)
        {
            chkbox_BackupEnabled.Checked = configData.appConfig.backup_Enabled;
            enableControllers(chkbox_BackupEnabled.Checked);
            tb_BackupLocation.Text = configData.appConfig.backup_Location;
            num_Days.Value = configData.appConfig.interval_Days;
            num_Hours.Value = configData.appConfig.interval_Hours;
            num_Minutes.Value = configData.appConfig.interval_Minutes;

        }

        #region Drag Window

        private Point MouseDownLocation;

        private void pnl_TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void pnl_TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }


        #endregion

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(num_Days.Value) + Convert.ToInt32(num_Hours.Value) + Convert.ToInt32(num_Minutes.Value) == 0)
            {
                MessageBox.Show("Please set backup interval. All values can not be 0", "Error");
                return;
            }

            if (chkbox_BackupEnabled.Checked)
            {
                configData.appConfig.interval_Days = Convert.ToInt32(num_Days.Value);
                configData.appConfig.interval_Hours = Convert.ToInt32(num_Hours.Value);
                configData.appConfig.interval_Minutes = Convert.ToInt32(num_Minutes.Value);
                configData.appConfig.backup_Location = tb_BackupLocation.Text;
            }
            configData.appConfig.backup_Enabled = chkbox_BackupEnabled.Checked;
            configData.SaveConfig();
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderSearchDialog = new FolderBrowserDialog();
            DialogResult selectedFolder = folderSearchDialog.ShowDialog();
            if (selectedFolder == DialogResult.OK)
            {
                string folderPath = folderSearchDialog.SelectedPath;
                tb_BackupLocation.Text = folderPath;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            AppConfig defaultConfig = new AppConfig();
            chkbox_BackupEnabled.Checked = true;
            num_Days.Value = defaultConfig.interval_Days;
            num_Hours.Value = defaultConfig.interval_Hours;
            num_Minutes.Value = defaultConfig.interval_Minutes;
            tb_BackupLocation.Text = defaultConfig.backup_Location;
        }

        private void chkbox_BackupEnabled_CheckedChanged(object sender, EventArgs e)
        {
            enableControllers(chkbox_BackupEnabled.Checked);
        }

        private void enableControllers(bool Enabled)
        {
            num_Days.Enabled = Enabled;
            num_Hours.Enabled = Enabled;
            num_Minutes.Enabled = Enabled;
            tb_BackupLocation.Enabled = Enabled;
        }
    }
}
