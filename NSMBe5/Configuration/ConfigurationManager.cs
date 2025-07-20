using System;
using System.IO;
using System.Text.Json;

namespace NSMBe5.Configuration
{
    /// <summary>
    /// Configuration manager that handles JSON-based settings storage
    /// with cross-platform directory support
    /// </summary>
    public static class ConfigurationManager
    {
        private static AppSettings _settings;
        private static readonly object _lockObject = new object();
        private static string _configFilePath;

        /// <summary>
        /// Gets the current application settings
        /// </summary>
        public static AppSettings Settings
        {
            get
            {
                if (_settings == null)
                {
                    lock (_lockObject)
                    {
                        if (_settings == null)
                        {
                            LoadSettings();
                        }
                    }
                }
                return _settings;
            }
        }

        /// <summary>
        /// Gets the configuration file path based on the operating system
        /// </summary>
        private static string ConfigFilePath
        {
            get
            {
                if (_configFilePath == null)
                {
                    string configDir;
                    
                    if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                    {
                        // Windows: Use %APPDATA%/NSMBe
                        configDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NSMBe");
                    }
                    else
                    {
                        // Linux/Unix: Use XDG config directory
                        string xdgConfigHome = Environment.GetEnvironmentVariable("XDG_CONFIG_HOME");
                        if (string.IsNullOrEmpty(xdgConfigHome))
                        {
                            xdgConfigHome = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".config");
                        }
                        configDir = Path.Combine(xdgConfigHome, "NSMBe");
                    }

                    // Ensure directory exists
                    Directory.CreateDirectory(configDir);
                    
                    _configFilePath = Path.Combine(configDir, "settings.json");
                }
                return _configFilePath;
            }
        }

        /// <summary>
        /// Loads settings from the JSON file or creates default settings
        /// </summary>
        private static void LoadSettings()
        {
            try
            {
                if (File.Exists(ConfigFilePath))
                {
                    string json = File.ReadAllText(ConfigFilePath);
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                        WriteIndented = true
                    };
                    
                    _settings = JsonSerializer.Deserialize<AppSettings>(json, options);
                    
                    // Validate loaded settings (ensure non-null strings using defaults from AppSettings)
                    if (_settings != null)
                    {
                        var defaults = AppSettings.CreateDefault();
                        _settings.LanguageFile = _settings.LanguageFile ?? defaults.LanguageFile;
                        _settings.BackupFiles = _settings.BackupFiles ?? defaults.BackupFiles;
                        _settings.ROMFolder = _settings.ROMFolder ?? defaults.ROMFolder;
                        _settings.ROMPath = _settings.ROMPath ?? defaults.ROMPath;
                        _settings.UIFont = _settings.UIFont ?? defaults.UIFont;
                        _settings.EnabledPlugins = _settings.EnabledPlugins ?? defaults.EnabledPlugins;
                        _settings.RecentFiles = _settings.RecentFiles ?? defaults.RecentFiles;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error but continue with defaults
                System.Diagnostics.Debug.WriteLine($"Failed to load settings: {ex.Message}");
            }

            // If loading failed or file doesn't exist, create default settings
            if (_settings == null)
            {
                _settings = AppSettings.CreateDefault();
                Save(); // Save default settings
            }
        }

        /// <summary>
        /// Saves the current settings to the JSON file
        /// </summary>
        public static void Save()
        {
            if (_settings == null) return;

            lock (_lockObject)
            {
                try
                {
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    };

                    string json = JsonSerializer.Serialize(_settings, options);
                    File.WriteAllText(ConfigFilePath, json);
                }
                catch (Exception ex)
                {
                    // Log error but don't throw - we don't want to crash the app
                    System.Diagnostics.Debug.WriteLine($"Failed to save settings: {ex.Message}");
                    throw new InvalidOperationException($"Failed to save configuration: {ex.Message}", ex);
                }
            }
        }

        /// <summary>
        /// Resets settings to defaults
        /// </summary>
        public static void Reset()
        {
            lock (_lockObject)
            {
                _settings = AppSettings.CreateDefault();
                Save();
            }
        }

        /// <summary>
        /// Gets the default JSON configuration as an embedded resource string
        /// </summary>
        public static string GetDefaultConfigJson()
        {
            var defaultSettings = AppSettings.CreateDefault();
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            return JsonSerializer.Serialize(defaultSettings, options);
        }
    }
}
