using NotePanel.Classess;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NotePanel
{
    public partial class form_Main : Form
    {

        #region Public Members

        Config configData;

        bool IsScollBarVisible = false;
        static string AppPath = AppDomain.CurrentDomain.BaseDirectory;
        string AutoSavePath = AppDomain.CurrentDomain.BaseDirectory + "NotePad_AutoSave.txt";              

        int t_Second = 1000;
        int t_Minute = 60000;
        int t_Hour = 3600000;
        int t_Day = 86400000;
        
        DateTime NextBackupTime;

        #endregion

        #region Initialise Form

        public form_Main()
        {
            //if (!File.Exists(AppPath + @"AppConfig.json")) // Create Config JSON file if does not exist
            //{
            //    form_InitialSettings form_InitialSettings = new form_InitialSettings();
            //    form_InitialSettings.Show();
            //    this.Close();
            //}

            configData = new Config();
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            if (!Directory.Exists(configData.appConfig.backup_Location))  // Create image directory if it doesnt exist
            {
                System.IO.Directory.CreateDirectory(configData.appConfig.backup_Location);
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(AutoSavePath))
            {
                tb_Main.Text = File.ReadAllText(AutoSavePath);
            }
            StartBackupTimer();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ScrollBarPosition();
        }

        #endregion
                     
        #region Controllers

        #region Top Bar

        #region Drag Window

            private Point MouseDownLocation;

            private void panel1_MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    MouseDownLocation = e.Location;
                }
            }

            private void panel1_MouseMove(object sender, MouseEventArgs e)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    this.Left = e.X + this.Left - MouseDownLocation.X;
                    this.Top = e.Y + this.Top - MouseDownLocation.Y;
                }
            }

            private const int cGrip = 100;
            private const int cCaption = 32;
            protected override void WndProc(ref Message e)
            {
                if (e.Msg == 0x84)
                {
                    Point pos = new Point(e.LParam.ToInt32());
                    pos = this.PointToClient(pos);
                    if (pos.X >= this.ClientSize.Width - cGrip &&
                        pos.Y >= this.ClientSize.Height - cGrip
                        )
                    {
                        e.Result = (IntPtr)17;
                        return;
                    }
                }
                base.WndProc(ref e);
            }

        #endregion

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuStrip1.Show(ptLowerLeft);
        }

        private void backUpNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBackUpFile();
        }

        private void openBackUpFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(configData.appConfig.backup_Location);
        }

        private void changeBackupIntervalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_BackupSettings settings_BackupInterval = new form_BackupSettings(ref configData, false);
            settings_BackupInterval.FormClosed += new FormClosedEventHandler(UpdateTimer);
            settings_BackupInterval.Show();
        }


        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_Maximize.BringToFront();

        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_Restore.BringToFront();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void tb_Main_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(AutoSavePath, tb_Main.Text.ToString());
            ScrollBarPosition();
        }

        private void timer_BackUp_Tick(object sender, EventArgs e)
        {
            if (NextBackupTime == DateTime.MinValue)
            {
                NextBackupTime = CreateNextBackupTime();
            }
            else
            {
                if (NextBackupTime <= DateTime.Now)
                {
                    NextBackupTime = CreateNextBackupTime();
                    CreateBackUpFile();
                }
            }
        }

        #endregion

        #region Functions

        private void ScrollBarPosition()
        {
            bool currentScrollBarVisibility = CheckScrollBarVisibility();

            if (IsScollBarVisible != currentScrollBarVisibility)
            {
                if (currentScrollBarVisibility)
                { 
                    pnl_ResizeCorner.Left = this.Width - 40;
                    pnl_ScrollBarBackground.Visible = true;
                }
                else
                {
                    pnl_ResizeCorner.Left = this.Width - 20;
                    pnl_ScrollBarBackground.Visible = false;
                }
                IsScollBarVisible = currentScrollBarVisibility;
            }
        }

        private bool CheckScrollBarVisibility()
        {
            // get graphics for textbox
            var g = tb_Main.CreateGraphics();
            SizeF textSize;
            if (tb_Main.WordWrap)
                // get size of text when word wrap is on
                textSize = g.MeasureString(tb_Main.Text, tb_Main.Font, tb_Main.ClientRectangle.Width);
            else
                // get size of text when word wrap is off
                textSize = g.MeasureString(tb_Main.Text, tb_Main.Font);

            textSize.Height += (tb_Main.Height / 11);
            return !((RectangleF)tb_Main.ClientRectangle).Contains((PointF)textSize);
        }

        private void CreateBackUpFile()
        {
            if (!Directory.Exists(configData.appConfig.backup_Location))  // Create image directory if it doesnt exist
            {
                System.IO.Directory.CreateDirectory(configData.appConfig.backup_Location);
            }
            File.AppendAllText(configData.appConfig.backup_Location + @"\NotesBackUp_" + DateTime.Now.ToString("yyyy-MM-dd__HH-mm-ss") + ".txt", tb_Main.Text.ToString());
        }

        private void StartBackupTimer()
        {
            timer_BackUp.Stop();
            if (configData.appConfig.backup_Enabled)
            {
                NextBackupTime = CreateNextBackupTime();
                timer_BackUp.Interval = 60000;
                timer_BackUp.Start();
            }
        }

        /// <summary>
        /// Update running timer with new config setting from the settings form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateTimer(object sender, FormClosedEventArgs e)
        {
            StartBackupTimer();
        }

        /// <summary>
        /// Create next backup time using config settings
        /// </summary>
        /// <returns></returns>
        private DateTime CreateNextBackupTime()
        {
            DateTime backupTime = DateTime.Now;
            backupTime = backupTime.AddDays(configData.appConfig.interval_Days);
            backupTime = backupTime.AddHours(configData.appConfig.interval_Hours);
            backupTime = backupTime.AddMinutes(configData.appConfig.interval_Minutes);
            return backupTime;
        }

        #endregion








    }

}
