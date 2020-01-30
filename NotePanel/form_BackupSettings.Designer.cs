namespace NotePanel
{
    partial class form_BackupSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_BackupSettings));
            this.num_Days = new System.Windows.Forms.NumericUpDown();
            this.num_Hours = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_Minutes = new System.Windows.Forms.NumericUpDown();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pnl_TopBar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_BackupLocation = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.chkbox_BackupEnabled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_Days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Minutes)).BeginInit();
            this.pnl_TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // num_Days
            // 
            this.num_Days.BackColor = System.Drawing.SystemColors.Control;
            this.num_Days.Location = new System.Drawing.Point(73, 121);
            this.num_Days.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num_Days.Name = "num_Days";
            this.num_Days.Size = new System.Drawing.Size(67, 22);
            this.num_Days.TabIndex = 0;
            // 
            // num_Hours
            // 
            this.num_Hours.BackColor = System.Drawing.SystemColors.Control;
            this.num_Hours.Location = new System.Drawing.Point(240, 121);
            this.num_Hours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num_Hours.Name = "num_Hours";
            this.num_Hours.Size = new System.Drawing.Size(67, 22);
            this.num_Hours.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(16, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(177, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(336, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Minutes";
            // 
            // num_Minutes
            // 
            this.num_Minutes.BackColor = System.Drawing.SystemColors.Control;
            this.num_Minutes.Location = new System.Drawing.Point(413, 121);
            this.num_Minutes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num_Minutes.Name = "num_Minutes";
            this.num_Minutes.Size = new System.Drawing.Size(67, 22);
            this.num_Minutes.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Save.Location = new System.Drawing.Point(315, 337);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(165, 50);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Close.Location = new System.Drawing.Point(467, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(51, 39);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pnl_TopBar
            // 
            this.pnl_TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.pnl_TopBar.Controls.Add(this.label3);
            this.pnl_TopBar.Controls.Add(this.btn_Close);
            this.pnl_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_TopBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_TopBar.Name = "pnl_TopBar";
            this.pnl_TopBar.Size = new System.Drawing.Size(517, 39);
            this.pnl_TopBar.TabIndex = 8;
            this.pnl_TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_TopBar_MouseDown);
            this.pnl_TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_TopBar_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(15, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Backup Interval:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(19, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(420, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "__________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(15, 216);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Backup Location:";
            // 
            // tb_BackupLocation
            // 
            this.tb_BackupLocation.BackColor = System.Drawing.SystemColors.Control;
            this.tb_BackupLocation.Location = new System.Drawing.Point(24, 263);
            this.tb_BackupLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_BackupLocation.Name = "tb_BackupLocation";
            this.tb_BackupLocation.Size = new System.Drawing.Size(371, 22);
            this.tb_BackupLocation.TabIndex = 13;
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Search.Location = new System.Drawing.Point(404, 261);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(76, 27);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Reset.Location = new System.Drawing.Point(24, 337);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(165, 50);
            this.btn_Reset.TabIndex = 15;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // chkbox_BackupEnabled
            // 
            this.chkbox_BackupEnabled.AutoSize = true;
            this.chkbox_BackupEnabled.ForeColor = System.Drawing.SystemColors.Control;
            this.chkbox_BackupEnabled.Location = new System.Drawing.Point(352, 61);
            this.chkbox_BackupEnabled.Name = "chkbox_BackupEnabled";
            this.chkbox_BackupEnabled.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkbox_BackupEnabled.Size = new System.Drawing.Size(133, 21);
            this.chkbox_BackupEnabled.TabIndex = 16;
            this.chkbox_BackupEnabled.Text = "Backup Enabled";
            this.chkbox_BackupEnabled.UseVisualStyleBackColor = true;
            this.chkbox_BackupEnabled.CheckedChanged += new System.EventHandler(this.chkbox_BackupEnabled_CheckedChanged);
            // 
            // form_BackupSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(517, 402);
            this.Controls.Add(this.chkbox_BackupEnabled);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_BackupLocation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnl_TopBar);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_Minutes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_Hours);
            this.Controls.Add(this.num_Days);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_BackupSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_BackupSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Minutes)).EndInit();
            this.pnl_TopBar.ResumeLayout(false);
            this.pnl_TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_Days;
        private System.Windows.Forms.NumericUpDown num_Hours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_Minutes;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel pnl_TopBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_BackupLocation;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.CheckBox chkbox_BackupEnabled;
    }
}