using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RAUnlockSoundManager.Framework
{
    /// <summary>
    /// Manages program configuration storage and retrieval
    /// </summary>
    public class ConfigurationManager
    {
        /// <summary>
        /// Get configuration master object or create blank one if not present
        /// </summary>
        public static ConfigurationMaster GetConfiguration()
        {
            //-- Get current configuration path and check
            string ConfigPath = Path.Combine(Directory.GetCurrentDirectory(), "Configuration.json");
            if (File.Exists(ConfigPath) == false)
            {
                using (StreamWriter ConfigStream = File.CreateText(ConfigPath))
                {
                    //-- Create new definition file based on default definitions
                    ConfigurationMaster TConfig = new ConfigurationMaster();
                    string ConfigurationData = JsonSerializer.Serialize(TConfig);
                    ConfigStream.Write(ConfigurationData);
                }
            }
            //-- Get definition file
            ConfigurationMaster MasterConfiguration = JsonSerializer.Deserialize<ConfigurationMaster>(File.ReadAllText(ConfigPath));
            //-- Return definitions file
            return MasterConfiguration;
        }
        /// <summary>
        /// Save configuration or create blank one if not present
        /// </summary>
        public static void SaveConfiguration(ConfigurationMaster MasterConfiguration)
        {
            //-- Get current target definition path and check
            string ConfigPath = Path.Combine(Directory.GetCurrentDirectory(), "Configuration.json");
            using (StreamWriter ConfigStream = File.CreateText(ConfigPath))
            {
                string ConfigurationData = JsonSerializer.Serialize(MasterConfiguration);
                ConfigStream.Write(ConfigurationData);
            }
        }
        /// <summary>
        /// Program configuration value storage area
        /// </summary>
        public class ConfigurationMaster
        {
            private string _SoundPath = "";
            /// <summary>
            /// Unlock sound path
            /// </summary>
            public string SoundPath
            {
                get
                {
                    return _SoundPath;
                }
                set
                {
                    _SoundPath = value;
                }
            }
            private string _RetroArchExePath = "";
            /// <summary>
            /// RetroArch executable path
            /// </summary>
            public string RetroArchExePath
            {
                get
                {
                    return _RetroArchExePath;
                }
                set
                {
                    _RetroArchExePath = value;
                }
            }
            private string _PCSX2ExePath = "";
            /// <summary>
            /// PCSX2 executable path
            /// </summary>
            public string PCSX2ExePath
            {
                get
                {
                    return _PCSX2ExePath;
                }
                set
                {
                    _PCSX2ExePath = value;
                }
            }
            private string _bizhawkExePath = "";
            /// <summary>
            /// bizhawk executable path
            /// </summary>
            public string bizhawkExePath
            {
                get
                {
                    return _bizhawkExePath;
                }
                set
                {
                    _bizhawkExePath = value;
                }
            }
            private string _DuckstationExePath = "";
            /// <summary>
            /// Duckstation executable path
            /// </summary>
            public string DuckstationExePath
            {
                get
                {
                    return _DuckstationExePath;
                }
                set
                {
                    _DuckstationExePath = value;
                }
            }
            private string _ffmpegExePath = "";
            /// <summary>
            /// ffmpeg executable path
            /// </summary>
            public string ffmpegExePath
            {
                get
                {
                    return _ffmpegExePath;
                }
                set
                {
                    _ffmpegExePath = value;
                }
            }
            private int _LastSoundRandom = 0;
            /// <summary>
            /// Last setting - Sound - Randomized
            /// </summary>
            public int LastSoundRandom
            {
                get
                {
                    return _LastSoundRandom;
                }
                set
                {
                    _LastSoundRandom = value;
                }
            }
            private string _LastSoundChosen = "";
            /// <summary>
            /// Last Setting - Sound - Chosen Sound
            /// </summary>
            public string LastSoundChosen
            {
                get
                {
                    return _LastSoundChosen;
                }
                set
                {
                    _LastSoundChosen = value;
                }
            }
            private string _LastEmulatorChosen = "";
            /// <summary>
            /// Last Setting - Emulator - Chosen Emulator
            /// </summary>
            public string LastEmulatorChosen
            {
                get
                {
                    return _LastEmulatorChosen;
                }
                set
                {
                    _LastEmulatorChosen = value;
                }
            }
        }
    }
}
