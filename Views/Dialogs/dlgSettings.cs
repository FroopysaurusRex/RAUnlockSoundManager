using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RAUnlockSoundManager.Framework;
using System.Security.Cryptography;

namespace RAUnlockSoundManager.Views.Dialogs
{
    public partial class dlgSettings : Form
    {
        #region Variables

        /// <summary>
        /// Local configuration object
        /// </summary>
        private ConfigurationManager.ConfigurationMaster Configuration;

        private Dictionary<string, string> CurrentState = new Dictionary<string, string>();

        #endregion

        /// <summary>
        /// Settings dialog constructor
        /// </summary>
        public dlgSettings()
        {
            InitializeComponent();
        }

        #region Event Handlers

        /// <summary>
        /// Form load handler
        /// </summary>
        internal void FormLoad(object sender, EventArgs e)
        {
            //-- Get current configuration and apply it to all fields
            Configuration = ConfigurationManager.GetConfiguration();
            txtUnlockSoundPath.Text = Configuration.SoundPath;
            txtffmpegExecutablePath.Text = Configuration.ffmpegExePath;
            CurrentState = Configuration.EmulatorExePaths;
        }

        /// <summary>
        /// Emulator index change handler
        /// </summary>
        internal void EmulatorIndexChange(object sender, EventArgs e)
        {
            if (lstEmulators.SelectedItems.Count > 0)
            {
                string Emulator = lstEmulators.SelectedItem.ToString();
                txtEmulatorExecutablePath.Text = CurrentState[Emulator];
            }
        }

        /// <summary>
        /// Handle path button click
        /// </summary>
        internal void GetPathClick(object sender, EventArgs e)
        {
            //-- Get name of sender and handle accordingly
            string ButtonPressed = ((Button)sender).Name;
            using (var ofd = new OpenFileDialog())
            {
                ofd.Multiselect = false;
                switch (ButtonPressed)
                {
                    case "btnUnlockSoundPath":
                        ofd.Title = "Select A Sound From Unlock Sound Directory";
                        ofd.Filter = "Compatible Audio Files|*.mp3;*.wav;*.ogg";
                        break;
                    case "btnffmpegExecutablePath":
                        ofd.Title = "Select ffmpeg Executable";
                        ofd.Filter = "ffmpeg Executable|ffmpeg.exe";
                        break;
                    case "btnEmulatorExecutablePath":
                        if (lstEmulators.SelectedItems.Count > 0)
                        {
                            string Emulator = lstEmulators.SelectedItem.ToString();
                            switch (Emulator)
                            {
                                case "BizHawk":
                                    ofd.Title = "Select BizHawk Executable";
                                    ofd.Filter = "BizHawk Executable|EmuHawk.exe";
                                    break;
                                case "Duckstation":
                                    ofd.Title = "Select Duckstation Executable";
                                    ofd.Filter = "Duckstation Executable|*.exe";
                                    break;
                                case "PCSX2":
                                    ofd.Title = "Select PCSX2 Executable";
                                    ofd.Filter = "PCSX2 Executable|*.exe";
                                    break;
                                case "RAP64":
                                    ofd.Title = "Select RAP64 Executable";
                                    ofd.Filter = "RAP64 Executable|RAProject64.exe";
                                    break;
                                case "RetroArch":
                                    ofd.Title = "Select RetroArch Executable";
                                    ofd.Filter = "RetroArch Executable|retroarch.exe";
                                    break;
                            }
                        }
                        break;
                }
                DialogResult result = ofd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
                {
                    switch (ButtonPressed)
                    {
                        case "btnUnlockSoundPath":
                            txtUnlockSoundPath.Text = Path.GetDirectoryName(ofd.FileName);
                            break;
                        case "btnffmpegExecutablePath":
                            txtffmpegExecutablePath.Text = ofd.FileName;
                            break;
                        case "btnEmulatorExecutablePath":
                            if (lstEmulators.SelectedItems.Count > 0)
                            {
                                txtEmulatorExecutablePath.Text = ofd.FileName;
                                string Emulator = lstEmulators.SelectedItem.ToString();
                                CurrentState[Emulator] = ofd.FileName;
                            }
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// No typing in path fields at all
        /// </summary>
        internal void NoTypingInPathFields(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Handle cancel button click
        /// </summary>
        internal void CancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Handle OK button click
        /// </summary>
        internal void OKButtonClick(object sender, EventArgs e)
        {
            //-- Update master configuration object and save
            Configuration.SoundPath = txtUnlockSoundPath.Text;
            Configuration.ffmpegExePath = txtffmpegExecutablePath.Text;
            Configuration.EmulatorExePaths = CurrentState;
            ConfigurationManager.SaveConfiguration(Configuration);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

    }
}
