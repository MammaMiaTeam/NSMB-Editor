using NSMBe5.Configuration;

namespace NSMBe5.Properties
{
    /// <summary>
    /// Compatibility wrapper for the old Settings system
    /// This allows existing code to continue working with minimal changes
    /// </summary>
    public static class Settings
    {
        /// <summary>
        /// Gets the default settings instance (compatibility with old code)
        /// </summary>
        public static SettingsWrapper Default => new SettingsWrapper();
    }

    /// <summary>
    /// Wrapper that provides the same interface as the old Settings class
    /// </summary>
    public class SettingsWrapper
    {
        public bool SmallBlockOverlays
        {
            get => ConfigurationManager.Settings.SmallBlockOverlays;
            set => ConfigurationManager.Settings.SmallBlockOverlays = value;
        }

        public string LanguageFile
        {
            get => ConfigurationManager.Settings.LanguageFile;
            set => ConfigurationManager.Settings.LanguageFile = value;
        }

        public bool ShowResizeHandles
        {
            get => ConfigurationManager.Settings.ShowResizeHandles;
            set => ConfigurationManager.Settings.ShowResizeHandles = value;
        }

        public int AutoBackup
        {
            get => ConfigurationManager.Settings.AutoBackup;
            set => ConfigurationManager.Settings.AutoBackup = value;
        }

        public string BackupFiles
        {
            get => ConfigurationManager.Settings.BackupFiles;
            set => ConfigurationManager.Settings.BackupFiles = value;
        }

        public string ROMFolder
        {
            get => ConfigurationManager.Settings.ROMFolder;
            set => ConfigurationManager.Settings.ROMFolder = value;
        }

        public bool LevelMaximized
        {
            get => ConfigurationManager.Settings.LevelMaximized;
            set => ConfigurationManager.Settings.LevelMaximized = value;
        }

        public bool dlpMode
        {
            get => ConfigurationManager.Settings.DlpMode;
            set => ConfigurationManager.Settings.DlpMode = value;
        }

        public string ROMPath
        {
            get => ConfigurationManager.Settings.ROMPath;
            set => ConfigurationManager.Settings.ROMPath = value;
        }

        public int CodePatchingMethod
        {
            get => ConfigurationManager.Settings.CodePatchingMethod;
            set => ConfigurationManager.Settings.CodePatchingMethod = value;
        }

        public string UIFont
        {
            get => ConfigurationManager.Settings.UIFont;
            set => ConfigurationManager.Settings.UIFont = value;
        }

        public bool EnableRomPlugin
        {
            get => ConfigurationManager.Settings.EnableRomPlugin;
            set => ConfigurationManager.Settings.EnableRomPlugin = value;
        }

        public string EnabledPlugins
        {
            get => ConfigurationManager.Settings.EnabledPlugins;
            set => ConfigurationManager.Settings.EnabledPlugins = value;
        }

        public string RecentFiles
        {
            get => ConfigurationManager.Settings.RecentFiles;
            set => ConfigurationManager.Settings.RecentFiles = value;
        }

        /// <summary>
        /// Saves the current settings
        /// </summary>
        public void Save()
        {
            ConfigurationManager.Save();
        }
    }
}
