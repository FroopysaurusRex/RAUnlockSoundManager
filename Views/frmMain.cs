using System.IO;
using System.Diagnostics;
using NAudio;
using NAudio.Wave;
using NAudio.Vorbis;
using RAUnlockSoundManager.Framework;
using NVorbis;
using RAUnlockSoundManager.Views.Dialogs;
using FFMpegCore;
using FFMpegCore.Enums;

namespace RAUnlockSoundManager.Views
{
    public partial class frmMain : Form
    {

        #region Variables

        /// <summary>
        /// Local configuration object
        /// </summary>
        private ConfigurationManager.ConfigurationMaster Configuration;
        private List<string> SoundList;
        private List<string> EmulatorList;

        #endregion

        /// <summary>
        /// Main form constructor
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        #region Event Handlers

        /// <summary>
        /// Form load handler
        /// </summary>
        internal void FormLoad(object sender, EventArgs e)
        {
            ApplyConfiguration();
        }

        /// <summary>
        /// Play selected sound
        /// </summary>
        private async void btnDemo_Click(object sender, EventArgs e)
        {
            btnDemo.Enabled = false;
            //-- Get file name
            string TargetSoundFileName = Path.Combine(Configuration.SoundPath, cboUnlockSound.SelectedItem.ToString());
            //-- Handle based on file extension
            switch (Path.GetExtension(TargetSoundFileName).ToLower())
            {
                case ".mp3":
                    using (var MP3File = new Mp3FileReader(TargetSoundFileName))
                    {
                        using (var WaveOutput = new NAudio.Wave.WaveOut())
                        {
                            WaveOutput.Init(MP3File);
                            WaveOutput.Play();
                            while (WaveOutput.PlaybackState != PlaybackState.Stopped)
                            {
                                await Task.Delay(100);
                            }
                        }
                    }
                    break;
                case ".wav":
                    using (var WAVFile = new WaveFileReader(TargetSoundFileName))
                    {
                        using (var WaveOutput = new NAudio.Wave.WaveOut())
                        {
                            WaveOutput.Init(WAVFile);
                            WaveOutput.Play();
                            while (WaveOutput.PlaybackState != PlaybackState.Stopped)
                            {
                                await Task.Delay(100);
                            }
                        }
                    }
                    break;
                case ".ogg":
                    using (var OGGFile = new VorbisWaveReader(TargetSoundFileName))
                    {
                        using (var WaveOutput = new NAudio.Wave.WaveOut())
                        {
                            WaveOutput.Init(OGGFile);
                            WaveOutput.Play();
                            while (WaveOutput.PlaybackState != PlaybackState.Stopped)
                            {
                                await Task.Delay(100);
                            }
                        }
                    }
                    break;
            }
            btnDemo.Enabled = true;
        }
        /// <summary>
        /// Settings dialog
        /// </summary>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (var SettingsDialog = new dlgSettings())
            {
                if (SettingsDialog.ShowDialog() == DialogResult.OK)
                {
                    ApplyConfiguration();
                }
            }
        }
        /// <summary>
        /// Refresh list of current unlock sounds
        /// </summary>
        private void btnRefreshSounds_Click(object sender, EventArgs e)
        {
            ApplyConfiguration();
        }

        /// <summary>
        /// Convert and launch
        /// </summary>
        private async void btnLaunch_Click(object sender, EventArgs e)
        {
            //-- Get user input settings
            string SourceSoundFileName = Path.Combine(Configuration.SoundPath, cboUnlockSound.SelectedItem.ToString());
            string SourceSoundFileNameExtension = Path.GetExtension(SourceSoundFileName).ToLower();
            bool RandomSoundUsed = chkRandom.Checked;
            string EmulatorUsed = cboEmulator.SelectedItem.ToString();
            if (RandomSoundUsed == true)
            {
                Random RandomSoundIndexGenerator = new Random();
                int RandomSoundIndex = RandomSoundIndexGenerator.Next(0, SoundList.Count - 1);
                SourceSoundFileName = Path.Combine(Configuration.SoundPath, SoundList[RandomSoundIndex]);
            }
            //-- Get destination and launch target
            string DestinationSoundFileName = "";
            string ProgramToLaunch = "";
            bool IsWaveFile = false;
            switch (EmulatorUsed)
            {
                case "RetroArch":
                    DestinationSoundFileName = Path.Combine(Path.GetDirectoryName(Configuration.RetroArchExePath), "assets", "sounds", "unlock.ogg");
                    ProgramToLaunch = Configuration.RetroArchExePath;
                    break;
                case "PCSX2":
                    DestinationSoundFileName = Path.Combine(Path.GetDirectoryName(Configuration.PCSX2ExePath), "resources", "sounds", "achievements", "unlock.wav");
                    ProgramToLaunch = Configuration.PCSX2ExePath;
                    IsWaveFile = true;
                    break;
                case "bizhawk":
                    DestinationSoundFileName = Path.Combine(Path.GetDirectoryName(Configuration.bizhawkExePath), "overlay", "unlock.wav");
                    ProgramToLaunch = Configuration.bizhawkExePath;
                    IsWaveFile = true;
                    break;
                case "Duckstation":
                    DestinationSoundFileName = Path.Combine(Path.GetDirectoryName(Configuration.DuckstationExePath), "resources", "sounds", "achievements", "unlock.wav");
                    ProgramToLaunch = Configuration.DuckstationExePath;
                    IsWaveFile = true;
                    break;
            }
            //-- Check if file needs conversion or move
            GlobalFFOptions.Configure(options => options.BinaryFolder = Path.GetDirectoryName(Configuration.ffmpegExePath));
            if ((SourceSoundFileNameExtension == ".mp3") || (SourceSoundFileNameExtension == ".wav" && IsWaveFile == false) || (SourceSoundFileNameExtension == ".ogg" && IsWaveFile == true))
            {
                await FFMpegArguments.FromFileInput(SourceSoundFileName).OutputToFile(DestinationSoundFileName, true).ProcessAsynchronously();
            }
            else
            {
                File.Copy(SourceSoundFileName, DestinationSoundFileName, true);
            }
            //-- Save last settings
            Configuration.LastSoundChosen = Path.GetFileName(SourceSoundFileName);
            if (RandomSoundUsed == true)
            {
                Configuration.LastSoundRandom = 1;
            }
            else
            {
                Configuration.LastSoundRandom = 0;
            }
            Configuration.LastEmulatorChosen = cboEmulator.SelectedItem.ToString();
            ConfigurationManager.SaveConfiguration(Configuration);
            //-- Play source sound
            switch (SourceSoundFileNameExtension)
            {
                case ".mp3":
                    using (var MP3File = new Mp3FileReader(SourceSoundFileName))
                    {
                        using (var WaveOutput = new NAudio.Wave.WaveOut())
                        {
                            WaveOutput.Init(MP3File);
                            WaveOutput.Play();
                            while (WaveOutput.PlaybackState != PlaybackState.Stopped)
                            {
                                await Task.Delay(100);
                            }
                        }
                    }
                    break;
                case ".wav":
                    using (var WAVFile = new WaveFileReader(SourceSoundFileName))
                    {
                        using (var WaveOutput = new NAudio.Wave.WaveOut())
                        {
                            WaveOutput.Init(WAVFile);
                            WaveOutput.Play();
                            while (WaveOutput.PlaybackState != PlaybackState.Stopped)
                            {
                                await Task.Delay(100);
                            }
                        }
                    }
                    break;
                case ".ogg":
                    using (var OGGFile = new VorbisWaveReader(SourceSoundFileName))
                    {
                        using (var WaveOutput = new NAudio.Wave.WaveOut())
                        {
                            WaveOutput.Init(OGGFile);
                            WaveOutput.Play();
                            while (WaveOutput.PlaybackState != PlaybackState.Stopped)
                            {
                                await Task.Delay(100);
                            }
                        }
                    }
                    break;
            }
            //-- Launch target program and exit
            Process.Start(ProgramToLaunch);
            Environment.Exit(0);
        }

        #endregion

        #region Form Methods

        /// <summary>
        /// Apply program configuration
        /// </summary>
        internal void ApplyConfiguration()
        {
            //-- Reset fields
            cboUnlockSound.Items.Clear();
            cboEmulator.Items.Clear();
            chkRandom.Enabled = false;
            cboUnlockSound.Enabled = false;
            btnRefreshSounds.Enabled = false;
            btnDemo.Enabled = false;
            cboEmulator.Enabled = false;
            btnLaunch.Enabled = false;
            //-- Load and check primary configuration
            Configuration = ConfigurationManager.GetConfiguration();
            if (Configuration.SoundPath == "" || Configuration.ffmpegExePath == "")
            {
                MessageBox.Show("Further configuration is needed before program can be used.  Click the Settings button to configure program.", "First Time Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Directory.Exists(Configuration.SoundPath) == false)
            {
                MessageBox.Show("Unlock Sound Path could not be found.  Click the Settings button to configure program.", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (File.Exists(Configuration.ffmpegExePath) == false)
            {
                MessageBox.Show("ffmpeg.exe could not be found.  Click the Settings button to configure program.", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //-- Check and load sound list
            SoundList = new List<string>();
            foreach (string file in Directory.GetFiles(Configuration.SoundPath, "*.mp3").Union(Directory.GetFiles(Configuration.SoundPath, "*.wav")).Union(Directory.GetFiles(Configuration.SoundPath, "*.ogg")))
            {
                SoundList.Add(Path.GetFileName(file));
            }
            if (SoundList.Count == 0)
            {
                MessageBox.Show("No unlock sounds were found in the unlock sound path.  Click the Settings button to configure program or click Refresh Sounds to check again.", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnRefreshSounds.Enabled = true;
                return;
            }
            cboUnlockSound.Enabled = true;
            chkRandom.Enabled = true;
            btnDemo.Enabled = true;
            btnRefreshSounds.Enabled = true;
            cboUnlockSound.Items.AddRange(SoundList.ToArray());
            //-- Check and load emulator list
            EmulatorList = new List<string>();
            if (File.Exists(Configuration.RetroArchExePath) == true)
            {
                EmulatorList.Add("RetroArch");
            }
            if (File.Exists(Configuration.PCSX2ExePath) == true)
            {
                EmulatorList.Add("PCSX2");
            }
            if (File.Exists(Configuration.bizhawkExePath) == true)
            {
                EmulatorList.Add("bizhawk");
            }
            if (File.Exists(Configuration.DuckstationExePath) == true)
            {
                EmulatorList.Add("Duckstation");
            }
            if (EmulatorList.Count == 0)
            {
                MessageBox.Show("None of the available emulators were found in the provided paths.  Click the Settings button to configure program.", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnRefreshSounds.Enabled = true;
                return;
            }
            cboEmulator.Items.AddRange(EmulatorList.ToArray());
            //-- Load last settings if present
            chkRandom.Checked = (Configuration.LastSoundRandom == 1);
            if (SoundList.Contains(Configuration.LastSoundChosen) == true)
            {
                cboUnlockSound.SelectedIndex = SoundList.IndexOf(Configuration.LastSoundChosen);
            }
            else
            {
                cboUnlockSound.SelectedIndex = 0;
            }
            if (EmulatorList.Contains(Configuration.LastEmulatorChosen) == true)
            {
                cboEmulator.SelectedIndex = EmulatorList.IndexOf(Configuration.LastEmulatorChosen);
            }
            else
            {
                cboEmulator.SelectedIndex = 0;
            }
            cboEmulator.Enabled = true;
            btnLaunch.Enabled = true;
        }


        #endregion

    }
}