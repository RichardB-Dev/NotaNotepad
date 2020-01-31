namespace NotePanel
{
    partial class form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Main));
            this.tb_Main = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backUpNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBackUpFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackupIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.pnl_TopBar = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.pnl_ScrollBarBackground = new System.Windows.Forms.Panel();
            this.pnl_ResizeCorner = new System.Windows.Forms.Panel();
            this.timer_BackUp = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.pnl_TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Main
            // 
            this.tb_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tb_Main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Main.ForeColor = System.Drawing.SystemColors.Menu;
            this.tb_Main.Location = new System.Drawing.Point(12, 43);
            this.tb_Main.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.tb_Main.Name = "tb_Main";
            this.tb_Main.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tb_Main.Size = new System.Drawing.Size(458, 487);
            this.tb_Main.TabIndex = 0;
            this.tb_Main.Text = "";
            this.tb_Main.TextChanged += new System.EventHandler(this.tb_Main_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backUpNowToolStripMenuItem,
            this.openBackUpFolderToolStripMenuItem,
            this.changeBackupIntervalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(242, 82);
            // 
            // backUpNowToolStripMenuItem
            // 
            this.backUpNowToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.backUpNowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backUpNowToolStripMenuItem.Image")));
            this.backUpNowToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.backUpNowToolStripMenuItem.Name = "backUpNowToolStripMenuItem";
            this.backUpNowToolStripMenuItem.ShowShortcutKeys = false;
            this.backUpNowToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.backUpNowToolStripMenuItem.Text = "Backup Now";
            this.backUpNowToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.backUpNowToolStripMenuItem.Click += new System.EventHandler(this.backUpNowToolStripMenuItem_Click);
            // 
            // openBackUpFolderToolStripMenuItem
            // 
            this.openBackUpFolderToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openBackUpFolderToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.openBackUpFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openBackUpFolderToolStripMenuItem.Image")));
            this.openBackUpFolderToolStripMenuItem.Name = "openBackUpFolderToolStripMenuItem";
            this.openBackUpFolderToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.openBackUpFolderToolStripMenuItem.Text = "Open Backup Folder";
            this.openBackUpFolderToolStripMenuItem.Click += new System.EventHandler(this.openBackUpFolderToolStripMenuItem_Click);
            // 
            // changeBackupIntervalToolStripMenuItem
            // 
            this.changeBackupIntervalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.changeBackupIntervalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changeBackupIntervalToolStripMenuItem.Image")));
            this.changeBackupIntervalToolStripMenuItem.Name = "changeBackupIntervalToolStripMenuItem";
            this.changeBackupIntervalToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.changeBackupIntervalToolStripMenuItem.Text = "Change Backup Settings";
            this.changeBackupIntervalToolStripMenuItem.Click += new System.EventHandler(this.changeBackupIntervalToolStripMenuItem_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Menu.BackgroundImage")));
            this.btn_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Menu.FlatAppearance.BorderSize = 0;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Menu.Location = new System.Drawing.Point(0, 0);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(37, 32);
            this.btn_Menu.TabIndex = 3;
            this.btn_Menu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // pnl_TopBar
            // 
            this.pnl_TopBar.BackColor = System.Drawing.Color.Gray;
            this.pnl_TopBar.Controls.Add(this.btn_Minimize);
            this.pnl_TopBar.Controls.Add(this.btn_Close);
            this.pnl_TopBar.Controls.Add(this.btn_Menu);
            this.pnl_TopBar.Controls.Add(this.btn_Maximize);
            this.pnl_TopBar.Controls.Add(this.btn_Restore);
            this.pnl_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_TopBar.Name = "pnl_TopBar";
            this.pnl_TopBar.Size = new System.Drawing.Size(470, 32);
            this.pnl_TopBar.TabIndex = 4;
            this.pnl_TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pnl_TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.BackgroundImage")));
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Minimize.Location = new System.Drawing.Point(356, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(38, 32);
            this.btn_Minimize.TabIndex = 6;
            this.btn_Minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Close.Location = new System.Drawing.Point(432, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(38, 32);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Maximize.BackgroundImage")));
            this.btn_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Maximize.Location = new System.Drawing.Point(394, 0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(38, 32);
            this.btn_Maximize.TabIndex = 5;
            this.btn_Maximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Restore.BackgroundImage")));
            this.btn_Restore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Restore.FlatAppearance.BorderSize = 0;
            this.btn_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restore.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Restore.Location = new System.Drawing.Point(394, 0);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(38, 32);
            this.btn_Restore.TabIndex = 7;
            this.btn_Restore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // pnl_ScrollBarBackground
            // 
            this.pnl_ScrollBarBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ScrollBarBackground.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_ScrollBarBackground.Location = new System.Drawing.Point(453, 25);
            this.pnl_ScrollBarBackground.Name = "pnl_ScrollBarBackground";
            this.pnl_ScrollBarBackground.Size = new System.Drawing.Size(17, 517);
            this.pnl_ScrollBarBackground.TabIndex = 5;
            this.pnl_ScrollBarBackground.Visible = false;
            // 
            // pnl_ResizeCorner
            // 
            this.pnl_ResizeCorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ResizeCorner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_ResizeCorner.BackgroundImage")));
            this.pnl_ResizeCorner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_ResizeCorner.Location = new System.Drawing.Point(450, 522);
            this.pnl_ResizeCorner.Name = "pnl_ResizeCorner";
            this.pnl_ResizeCorner.Size = new System.Drawing.Size(16, 16);
            this.pnl_ResizeCorner.TabIndex = 6;
            // 
            // timer_BackUp
            // 
            this.timer_BackUp.Interval = 60000;
            this.timer_BackUp.Tick += new System.EventHandler(this.timer_BackUp_Tick);
            // 
            // form_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(470, 542);
            this.Controls.Add(this.pnl_ResizeCorner);
            this.Controls.Add(this.tb_Main);
            this.Controls.Add(this.pnl_TopBar);
            this.Controls.Add(this.pnl_ScrollBarBackground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "form_Main";
            this.Load += new System.EventHandler(this.form_Main_Load);
            this.Resize += new System.EventHandler(this.form_Main_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnl_TopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb_Main;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backUpNowToolStripMenuItem;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Panel pnl_TopBar;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.Panel pnl_ScrollBarBackground;
        private System.Windows.Forms.Panel pnl_ResizeCorner;
        private System.Windows.Forms.Timer timer_BackUp;
        private System.Windows.Forms.ToolStripMenuItem openBackUpFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBackupIntervalToolStripMenuItem;
    }
}

