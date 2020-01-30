using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePanel.Classess
{
    public class AppConfig
    {
        public bool backup_Enabled = true;
        public string backup_Location = AppDomain.CurrentDomain.BaseDirectory + "Backups";
        public int interval_Minutes = 0;
        public int interval_Hours = 8;
        public int interval_Days = 0;
    }
}
