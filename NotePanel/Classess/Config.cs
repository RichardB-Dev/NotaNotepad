using Newtonsoft.Json;
using System;
using System.IO;

namespace NotePanel.Classess
{
    public class Config
    {
        public AppConfig appConfig = new AppConfig();
        public string AppPath = AppDomain.CurrentDomain.BaseDirectory;
        public bool ConfigFileCreated = false;

        public Config()
        {

            if (!File.Exists(AppPath + @"AppConfig.json")) // Create Config JSON file if does not exist
            {
                WriteToSaveFile(); // Create file
                string windowsStartUpFolder = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                CreateShortcut("NotePanel_Shortcut", windowsStartUpFolder, AppDomain.CurrentDomain.BaseDirectory + @"\NotePanel.exe"); // Create start up shortcut
                ConfigFileCreated = true;
            }
            else
            {
                using (StreamReader r = new StreamReader(AppPath + @"AppConfig.json")) // Read saved config file
                {
                    string json = r.ReadToEnd();
                    appConfig = JsonConvert.DeserializeObject<AppConfig>(json);
                }
            }

        }

        /// <summary>
        /// Write local config data to save file
        /// </summary>
        private void WriteToSaveFile()
        {
            string writeJson = JsonConvert.SerializeObject(appConfig);
            System.IO.File.WriteAllText(AppPath + @"AppConfig.json", writeJson);
        }

        /// <summary>
        /// Add/Update frame to save file
        /// </summary>
        /// <param name="pFrame"></param>
        /// <returns></returns>
        public void SaveConfig()
        {
            WriteToSaveFile();
        }


        /// <summary>
        /// Create app shortcut
        /// </summary>
        /// <param name="shortcutName"></param>
        /// <param name="shortcutPath"></param>
        /// <param name="targetFileLocation"></param>
        public static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation)
        {
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = "Desk Frame";   // The description of the shortcut
            shortcut.TargetPath = targetFileLocation; // The path of the file that will launch when the shortcut is run
            shortcut.Save(); // Save the shortcut
        }

    }
}
