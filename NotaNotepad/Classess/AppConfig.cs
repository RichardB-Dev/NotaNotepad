using System;
using System.Drawing;

namespace NotaNotepad.Classess
{
    public class AppConfig
    {
        public bool backup_Enabled = true;
        public string backup_Location = AppDomain.CurrentDomain.BaseDirectory + "Backups";
        public int interval_Minutes = 0;
        public int interval_Hours = 8;
        public int interval_Days = 0;
        public Color background_Color = Color.FromArgb(51,51,51);
        public Color foreground_Color = Color.FromArgb(253, 253, 253);
    }
}
