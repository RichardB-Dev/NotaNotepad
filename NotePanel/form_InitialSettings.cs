using NotePanel.Classess;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NotePanel
{
    public partial class form_InitialSettings : Form
    {

        //***** Public Members *****
        #region Public Members

        Config configData = new Config();

        #endregion

        //***** Initialise Form *****
        #region Initialise Form

        public form_InitialSettings()
        {
            InitializeComponent();
        }

        private void form_InitialSettings_Load(object sender, EventArgs e)
        {

            this.BringToFront();
        }

        #endregion

        //***** Controllers *****
        #region Controllers

        #region Top bar

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

        #region Interval Options

        private void radbtn_15min_CheckedChanged(object sender, EventArgs e)
        {
            SetIntervalTime(0,0,15);
        }

        private void radbtn_1hour_CheckedChanged(object sender, EventArgs e)
        {
            SetIntervalTime(0, 1, 0);
        }

        private void radbtn_8hours_CheckedChanged(object sender, EventArgs e)
        {
            SetIntervalTime(0, 8, 0);
        }

        private void radbtn_24hours_CheckedChanged(object sender, EventArgs e)
        {
            SetIntervalTime(1, 0, 0);
        }

        private void radbtn_Custom_CheckedChanged(object sender, EventArgs e)
        {
            grpbox_CustomInterval.Visible = radbtn_Custom.Checked;
        }

        #endregion

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (radbtn_Custom.Checked)
            {
                if (Convert.ToInt32(num_Days.Value) + Convert.ToInt32(num_Hours.Value) + Convert.ToInt32(num_Minutes.Value) == 0)
                {
                    MessageBox.Show("Please set backup interval. All values can not be 0", "Error");
                    return;
                }

                SetIntervalTime(
                    Convert.ToInt32(num_Days.Value),
                    Convert.ToInt32(num_Hours.Value),
                    Convert.ToInt32(num_Minutes.Value));
            }
            configData.SaveConfig();
            Application.Restart();
        }

        #endregion

        //***** Function *****
        #region Functions

        private void SetIntervalTime(int _days = 0, int _hours = 0, int _minutes = 0)
        {
            configData.appConfig.interval_Days = _days;
            configData.appConfig.interval_Hours = _hours;
            configData.appConfig.interval_Minutes = _minutes;
        }

        #endregion
    }
}
