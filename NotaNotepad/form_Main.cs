using NotaNotepad.Classess;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NotaNotepad
{
    public partial class form_Main : Form
    {

        #region Public Members

        Config configData;
        bool IsScollBarVisible = false;
        static string AppPath = AppDomain.CurrentDomain.BaseDirectory;
        string AutoSavePath = AppDomain.CurrentDomain.BaseDirectory + "NotePad_AutoSave.txt";     
        DateTime NextBackupTime;

        #endregion

        #region Initialise Form

        /// <summary>
        /// Main Form Constructor
        /// </summary>
        public form_Main()
        {            
            InitializeComponent();
            configData = new Config();

            ChangeColor(configData.appConfig.background_Color, configData.appConfig.foreground_Color, false);

            this.SetStyle(ControlStyles.ResizeRedraw, true); // Set form style to resizable
            if (!Directory.Exists(configData.appConfig.backup_Location))  // Create image directory if it doesnt exist
            {
                Directory.CreateDirectory(configData.appConfig.backup_Location);
            }
        }

        private void form_Main_Load(object sender, EventArgs e)
        {
            if (File.Exists(AutoSavePath)) // If autosave file exists, load text
            {
                rtb_Main.Text = File.ReadAllText(AutoSavePath);
            }
            StartBackupTimer();

        
        }

        private void form_Main_Resize(object sender, EventArgs e)
        {
            SetScrollBarLayout();
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
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
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
            form_BackupSettings settings_BackupInterval = new form_BackupSettings(ref configData);
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

        #region Color Options

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(51, 51, 51), Color.FromArgb(253, 253, 253));
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.White, Color.Black);
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(255, 255, 128), Color.Black);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.LightBlue, Color.Black);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.LightPink, Color.Black);
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.LightGreen, Color.Black);
        }

        private void blackGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Black, Color.Lime);
        }

        private void ChangeColor(Color cBackground, Color cforeground, bool UpdateConfig = true)
        {
            if (UpdateConfig)
            {
                configData.appConfig.background_Color = cBackground;
                configData.appConfig.foreground_Color = cforeground;
                configData.SaveConfig();
            }

            this.BackColor = cBackground;
            rtb_Main.BackColor = cBackground;
            rtb_Main.ForeColor = cforeground;
        }

        #endregion

        #region RightClick - Paste/Cut/Copy

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(rtb_Main.SelectedText))
            {
                Clipboard.SetText(rtb_Main.SelectedText);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_Main.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                var selectionIndex = rtb_Main.SelectionStart;
                rtb_Main.Text = rtb_Main.Text.Insert(selectionIndex, Clipboard.GetText(TextDataFormat.Text).ToString());
                rtb_Main.SelectionStart = selectionIndex + Clipboard.GetText(TextDataFormat.Text).ToString().Length;
            }
        }

        #endregion

        private void rtb_Main_TextChanged(object sender, EventArgs e)
        {

            if (rtb_Main.ForeColor == configData.appConfig.foreground_Color) {
                rtb_Main.ForeColor = Color.FromArgb(configData.appConfig.foreground_Color.ToArgb() + 1);
            }
            else
            {
                rtb_Main.ForeColor = configData.appConfig.foreground_Color;
            }

            File.WriteAllText(AutoSavePath, rtb_Main.Text.ToString());
            SetScrollBarLayout();
        }

        private void rtb_Main_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
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

        /// <summary>
        /// Depending on scrollbar visibility, adjust controller positions and visibility 
        /// </summary>
        private void SetScrollBarLayout()
        {
            // Get scrollbar visibility
            bool currentScrollBarVisibility = CheckScrollBarVisibility();

            //If visibility does not match last saved visibility, update layout
            if (IsScollBarVisible != currentScrollBarVisibility)
            {
                if (currentScrollBarVisibility) 
                { 
                    pnl_ResizeCorner.Left = this.Width - 42;
                    pnl_ScrollBarBackground.Visible = true;
                }
                else
                {
                    pnl_ResizeCorner.Left = this.Width - 22;
                    pnl_ScrollBarBackground.Visible = false;
                }

                // Save current scrollbar state
                IsScollBarVisible = currentScrollBarVisibility; 
            }
        }

        /// <summary>
        /// Check is scrollbar visible
        /// </summary>
        /// <returns></returns>
        private bool CheckScrollBarVisibility()
        {            
            var g = rtb_Main.CreateGraphics(); // Create a Graphics object for the textbox.
            SizeF textSize;

            if (rtb_Main.WordWrap)
                // Get size of text when word wrap is on
                textSize = g.MeasureString(rtb_Main.Text, rtb_Main.Font, rtb_Main.ClientRectangle.Width);
            else
                // Get size of text when word wrap is off
                textSize = g.MeasureString(rtb_Main.Text, rtb_Main.Font);

            // Fix for controller error: Approximate size inconsistency difference 
            textSize.Height += (rtb_Main.Height / 11); 

            return !((RectangleF)rtb_Main.ClientRectangle).Contains((PointF)textSize);
        }

        /// <summary>
        /// Create new routine backup file
        /// </summary>
        private void CreateBackUpFile()
        {
            if (!Directory.Exists(configData.appConfig.backup_Location))  // Create image directory if it doesnt exist
            {
                Directory.CreateDirectory(configData.appConfig.backup_Location);
            }
            // Save Notepad text to text file
            File.AppendAllText(configData.appConfig.backup_Location + @"\NotesBackUp_" + DateTime.Now.ToString("yyyy-MM-dd__HH-mm-ss") + ".txt", rtb_Main.Text.ToString());
        }

        /// <summary>
        /// Start Backup Routine
        /// </summary>
        private void StartBackupTimer()
        {
            timer_BackUp.Stop();
            if (configData.appConfig.backup_Enabled) // Start timer if backup config setting is enabled
            {
                NextBackupTime = CreateNextBackupTime(); // Get and save next backup time
                timer_BackUp.Start();
            }
        }

        /// <summary>
        /// Linked to Settings Form close event
        /// Update running timer with new config setting from the settings form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateTimer(object sender, FormClosedEventArgs e)
        {
            StartBackupTimer();
        }

        /// <summary>
        /// Get next backup time using config settings
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
