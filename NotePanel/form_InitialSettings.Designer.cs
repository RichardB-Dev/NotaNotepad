namespace NotePanel
{
    partial class form_InitialSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_InitialSettings));
            this.pnl_TopBar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.radbtn_15min = new System.Windows.Forms.RadioButton();
            this.radbtn_1hour = new System.Windows.Forms.RadioButton();
            this.radbtn_8hours = new System.Windows.Forms.RadioButton();
            this.radbtn_24hours = new System.Windows.Forms.RadioButton();
            this.radbtn_Custom = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.num_Minutes = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.num_Hours = new System.Windows.Forms.NumericUpDown();
            this.num_Days = new System.Windows.Forms.NumericUpDown();
            this.grpbox_CustomInterval = new System.Windows.Forms.GroupBox();
            this.pnl_TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Days)).BeginInit();
            this.grpbox_CustomInterval.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_TopBar
            // 
            this.pnl_TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.pnl_TopBar.Controls.Add(this.label3);
            this.pnl_TopBar.Controls.Add(this.btn_Close);
            this.pnl_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_TopBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_TopBar.Name = "pnl_TopBar";
            this.pnl_TopBar.Size = new System.Drawing.Size(710, 32);
            this.pnl_TopBar.TabIndex = 9;
            this.pnl_TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_TopBar_MouseDown);
            this.pnl_TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_TopBar_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(13, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Set Backup Interval";
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Close.Location = new System.Drawing.Point(674, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(36, 32);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // radbtn_15min
            // 
            this.radbtn_15min.AutoSize = true;
            this.radbtn_15min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_15min.ForeColor = System.Drawing.SystemColors.Control;
            this.radbtn_15min.Location = new System.Drawing.Point(237, 171);
            this.radbtn_15min.Name = "radbtn_15min";
            this.radbtn_15min.Size = new System.Drawing.Size(112, 24);
            this.radbtn_15min.TabIndex = 10;
            this.radbtn_15min.Text = "15 Minutes";
            this.radbtn_15min.UseVisualStyleBackColor = true;
            this.radbtn_15min.CheckedChanged += new System.EventHandler(this.radbtn_15min_CheckedChanged);
            // 
            // radbtn_1hour
            // 
            this.radbtn_1hour.AutoSize = true;
            this.radbtn_1hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_1hour.ForeColor = System.Drawing.SystemColors.Control;
            this.radbtn_1hour.Location = new System.Drawing.Point(237, 198);
            this.radbtn_1hour.Name = "radbtn_1hour";
            this.radbtn_1hour.Size = new System.Drawing.Size(81, 24);
            this.radbtn_1hour.TabIndex = 11;
            this.radbtn_1hour.Text = "1 Hour";
            this.radbtn_1hour.UseVisualStyleBackColor = true;
            this.radbtn_1hour.CheckedChanged += new System.EventHandler(this.radbtn_1hour_CheckedChanged);
            // 
            // radbtn_8hours
            // 
            this.radbtn_8hours.AutoSize = true;
            this.radbtn_8hours.Checked = true;
            this.radbtn_8hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_8hours.ForeColor = System.Drawing.SystemColors.Control;
            this.radbtn_8hours.Location = new System.Drawing.Point(237, 225);
            this.radbtn_8hours.Name = "radbtn_8hours";
            this.radbtn_8hours.Size = new System.Drawing.Size(161, 24);
            this.radbtn_8hours.TabIndex = 12;
            this.radbtn_8hours.TabStop = true;
            this.radbtn_8hours.Text = "8 Hours (Default)";
            this.radbtn_8hours.UseVisualStyleBackColor = true;
            this.radbtn_8hours.CheckedChanged += new System.EventHandler(this.radbtn_8hours_CheckedChanged);
            // 
            // radbtn_24hours
            // 
            this.radbtn_24hours.AutoSize = true;
            this.radbtn_24hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_24hours.ForeColor = System.Drawing.SystemColors.Control;
            this.radbtn_24hours.Location = new System.Drawing.Point(237, 252);
            this.radbtn_24hours.Name = "radbtn_24hours";
            this.radbtn_24hours.Size = new System.Drawing.Size(99, 24);
            this.radbtn_24hours.TabIndex = 13;
            this.radbtn_24hours.Text = "24 Hours";
            this.radbtn_24hours.UseVisualStyleBackColor = true;
            this.radbtn_24hours.CheckedChanged += new System.EventHandler(this.radbtn_24hours_CheckedChanged);
            // 
            // radbtn_Custom
            // 
            this.radbtn_Custom.AutoSize = true;
            this.radbtn_Custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_Custom.ForeColor = System.Drawing.SystemColors.Control;
            this.radbtn_Custom.Location = new System.Drawing.Point(237, 279);
            this.radbtn_Custom.Name = "radbtn_Custom";
            this.radbtn_Custom.Size = new System.Drawing.Size(88, 24);
            this.radbtn_Custom.TabIndex = 14;
            this.radbtn_Custom.Text = "Custom";
            this.radbtn_Custom.UseVisualStyleBackColor = true;
            this.radbtn_Custom.CheckedChanged += new System.EventHandler(this.radbtn_Custom_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(257, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Set your routine backup. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(11, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(678, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = " This is how frequenly your notes will be automatically backed up to seperate bac" +
    "kup files.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(32, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(631, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "All backups can be viewed by clicking \"Open Backup Folder\" in the Notepanel Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(79, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Backup Interval:";
            // 
            // btn_Ok
            // 
            this.btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Ok.Location = new System.Drawing.Point(271, 344);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(169, 50);
            this.btn_Ok.TabIndex = 19;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(42, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Minutes";
            // 
            // num_Minutes
            // 
            this.num_Minutes.BackColor = System.Drawing.SystemColors.Control;
            this.num_Minutes.Location = new System.Drawing.Point(119, 99);
            this.num_Minutes.Margin = new System.Windows.Forms.Padding(4);
            this.num_Minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_Minutes.Name = "num_Minutes";
            this.num_Minutes.Size = new System.Drawing.Size(67, 27);
            this.num_Minutes.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(42, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(42, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Days";
            // 
            // num_Hours
            // 
            this.num_Hours.BackColor = System.Drawing.SystemColors.Control;
            this.num_Hours.Location = new System.Drawing.Point(119, 64);
            this.num_Hours.Margin = new System.Windows.Forms.Padding(4);
            this.num_Hours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.num_Hours.Name = "num_Hours";
            this.num_Hours.Size = new System.Drawing.Size(67, 27);
            this.num_Hours.TabIndex = 21;
            this.num_Hours.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // num_Days
            // 
            this.num_Days.BackColor = System.Drawing.SystemColors.Control;
            this.num_Days.Location = new System.Drawing.Point(119, 29);
            this.num_Days.Margin = new System.Windows.Forms.Padding(4);
            this.num_Days.Name = "num_Days";
            this.num_Days.Size = new System.Drawing.Size(67, 27);
            this.num_Days.TabIndex = 20;
            // 
            // grpbox_CustomInterval
            // 
            this.grpbox_CustomInterval.Controls.Add(this.label8);
            this.grpbox_CustomInterval.Controls.Add(this.label6);
            this.grpbox_CustomInterval.Controls.Add(this.num_Days);
            this.grpbox_CustomInterval.Controls.Add(this.num_Minutes);
            this.grpbox_CustomInterval.Controls.Add(this.num_Hours);
            this.grpbox_CustomInterval.Controls.Add(this.label7);
            this.grpbox_CustomInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox_CustomInterval.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpbox_CustomInterval.Location = new System.Drawing.Point(443, 171);
            this.grpbox_CustomInterval.Name = "grpbox_CustomInterval";
            this.grpbox_CustomInterval.Size = new System.Drawing.Size(235, 146);
            this.grpbox_CustomInterval.TabIndex = 26;
            this.grpbox_CustomInterval.TabStop = false;
            this.grpbox_CustomInterval.Text = " Custom Interval ";
            this.grpbox_CustomInterval.Visible = false;
            // 
            // form_InitialSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(710, 407);
            this.Controls.Add(this.grpbox_CustomInterval);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radbtn_Custom);
            this.Controls.Add(this.radbtn_24hours);
            this.Controls.Add(this.radbtn_8hours);
            this.Controls.Add(this.radbtn_1hour);
            this.Controls.Add(this.radbtn_15min);
            this.Controls.Add(this.pnl_TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_InitialSettings";
            this.Text = "form_InitialSettings";
            this.pnl_TopBar.ResumeLayout(false);
            this.pnl_TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Days)).EndInit();
            this.grpbox_CustomInterval.ResumeLayout(false);
            this.grpbox_CustomInterval.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_TopBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.RadioButton radbtn_15min;
        private System.Windows.Forms.RadioButton radbtn_1hour;
        private System.Windows.Forms.RadioButton radbtn_8hours;
        private System.Windows.Forms.RadioButton radbtn_24hours;
        private System.Windows.Forms.RadioButton radbtn_Custom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_Minutes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown num_Hours;
        private System.Windows.Forms.NumericUpDown num_Days;
        private System.Windows.Forms.GroupBox grpbox_CustomInterval;
    }
}