using NotaNotepad.Classess;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NotaNotepad
{
    public partial class form_BackupSettings : Form
    {
               
        //***** Public Members *****
        #region Public Members

        Config configData;

        #endregion

        //***** Initialise Form *****
        #region Initialise Form

        /// <summary>
        /// Backup Setting Constructor
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="t"></param>
        public form_BackupSettings(ref Config _config)
        {
            InitializeComponent();
            configData = _config;
        }

        /// <summary>
        /// Load config setting to on screen controllers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Settings_BackupSettings_Load(object sender, EventArgs e)
        {
            //Populate controllers with config settings
            tb_BackupLocation.Text = configData.appConfig.backup_Location;
            num_Days.Value = configData.appConfig.interval_Days;
            num_Hours.Value = configData.appConfig.interval_Hours;
            num_Minutes.Value = configData.appConfig.interval_Minutes;
            chkbox_BackupEnabled.Checked = configData.appConfig.backup_Enabled;
            enableControllers(chkbox_BackupEnabled.Checked);
        }

        #endregion

        //***** Controller Handlers *****
        #region Controller Handlers

        #region Top Bar

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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        /// <summary>
        /// Toggle enable/disable interval and location controllers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkbox_BackupEnabled_CheckedChanged(object sender, EventArgs e)
        {
            enableControllers(chkbox_BackupEnabled.Checked);
        }

        /// <summary>
        /// Save Backup Settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            int days = Convert.ToInt32(num_Days.Value);
            int hours = Convert.ToInt32(num_Hours.Value);
            int minutes = Convert.ToInt32(num_Minutes.Value);

            if (days + hours + minutes == 0) // Check if interval is set to zero
            {
                MessageBox.Show("Please set backup interval. All values can not be 0", "Error");
                return;
            }

            if (chkbox_BackupEnabled.Checked) // Update interval and location if backup enabled
            {
                if (!Directory.Exists(tb_BackupLocation.Text)) // Check if location doesnt exist
                {
                    MessageBox.Show("Backup location selected does not exist!", "Backup Location Error");
                    return;
                }
                configData.appConfig.interval_Days = days;
                configData.appConfig.interval_Hours = hours;
                configData.appConfig.interval_Minutes = minutes;
                configData.appConfig.backup_Location = tb_BackupLocation.Text;
            }

            configData.appConfig.backup_Enabled = chkbox_BackupEnabled.Checked;
            configData.SaveConfig(); // Write config settings to file
            this.Close();
        }
        
        /// <summary>
        /// Open folder browser for backup location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Reset controllers to default donfig settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            AppConfig defaultConfig = new AppConfig();
            chkbox_BackupEnabled.Checked = true;
            num_Days.Value = defaultConfig.interval_Days;
            num_Hours.Value = defaultConfig.interval_Hours;
            num_Minutes.Value = defaultConfig.interval_Minutes;
            tb_BackupLocation.Text = defaultConfig.backup_Location;
        }

        #endregion

        //***** Function *****
        #region Functions

        /// <summary>
        /// Enable/disable interval and location controllers
        /// </summary>
        /// <param name="Enabled"></param>
        private void enableControllers(bool Enabled)
        {
            num_Days.Enabled = Enabled;
            num_Hours.Enabled = Enabled;
            num_Minutes.Enabled = Enabled;
            tb_BackupLocation.Enabled = Enabled;
        }

        #endregion

    }
}
