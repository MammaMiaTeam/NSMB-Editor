using System;
using System.Collections.Generic;

namespace NSMBe5.Configuration
{
    /// <summary>
    /// Application configuration settings model
    /// </summary>
    public class AppSettings
    {
        public bool SmallBlockOverlays { get; set; } = false;
        public string LanguageFile { get; set; } = "English";
        public bool ShowResizeHandles { get; set; } = true;
        public int AutoBackup { get; set; } = 5;
        public string BackupFiles { get; set; } = "";
        public string ROMFolder { get; set; } = "";
        public bool LevelMaximized { get; set; } = false;
        public bool DlpMode { get; set; } = false;
        public string ROMPath { get; set; } = "";
        public int CodePatchingMethod { get; set; } = 0;
        public string UIFont { get; set; } = "Microsoft Sans Serif";
        public bool EnableRomPlugin { get; set; } = false;
        public string EnabledPlugins { get; set; } = "";
        public string RecentFiles { get; set; } = "";

        /// <summary>
        /// Creates a new instance with default values
        /// </summary>
        public static AppSettings CreateDefault()
        {
            return new AppSettings();
        }
    }
}
