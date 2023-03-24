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

namespace RAUnlockSoundManager.Views.Dialogs
{
    public partial class dlgSettings : Form
    {
        #region Variables

        /// <summary>
        /// Local configuration object
        /// </summary>
        private ConfigurationManager.ConfigurationMaster Configuration;

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
            txtRetroArchExecutablePath.Text = Configuration.RetroArchExePath;
            txtPCSX2ExecutablePath.Text = Configuration.PCSX2ExePath;
            txtbizhawkExecutablePath.Text = Configuration.bizhawkExePath;
            txtDuckstationExecutablePath.Text = Configuration.DuckstationExePath;
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
                    case "btnRetroArchExecutablePath":
                        ofd.Title = "Select RetroArch Executable";
                        ofd.Filter = "RetroArch Executable|retroarch.exe";
                        break;
                    case "btnPCSX2ExecutablePath":
                        ofd.Title = "Select PCSX2 Executable";
                        ofd.Filter = "PCSX2 Executable|*.exe";
                        break;
                    case "btnbizhawkExecutablePath":
                        ofd.Title = "Select bizhawk Executable";
                        ofd.Filter = "bizhawk Executable|*.exe";
                        break;
                    case "btnDuckstationExecutablePath":
                        ofd.Title = "Select Duckstation Executable";
                        ofd.Filter = "Duckstation Executable|*.exe";
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
                        case "btnRetroArchExecutablePath":
                            txtRetroArchExecutablePath.Text = ofd.FileName;
                            break;
                        case "btnPCSX2ExecutablePath":
                            txtPCSX2ExecutablePath.Text = ofd.FileName;
                            break;
                        case "btnbizhawkExecutablePath":
                            txtbizhawkExecutablePath.Text = ofd.FileName;
                            break;
                        case "btnDuckstationExecutablePath":
                            txtDuckstationExecutablePath.Text = ofd.FileName;
                            break;
                    }
                }
            }
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
            Configuration.RetroArchExePath = txtRetroArchExecutablePath.Text;
            Configuration.PCSX2ExePath = txtPCSX2ExecutablePath.Text;
            Configuration.bizhawkExePath = txtbizhawkExecutablePath.Text;
            Configuration.DuckstationExePath = txtDuckstationExecutablePath.Text;
            ConfigurationManager.SaveConfiguration(Configuration);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

    }
}
