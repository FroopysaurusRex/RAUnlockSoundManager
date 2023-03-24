namespace RAUnlockSoundManager.Views
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpUnlockSound = new System.Windows.Forms.GroupBox();
            this.btnRefreshSounds = new System.Windows.Forms.Button();
            this.btnDemo = new System.Windows.Forms.Button();
            this.cboUnlockSound = new System.Windows.Forms.ComboBox();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.grpEmulator = new System.Windows.Forms.GroupBox();
            this.cboEmulator = new System.Windows.Forms.ComboBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.grpUnlockSound.SuspendLayout();
            this.grpEmulator.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUnlockSound
            // 
            this.grpUnlockSound.Controls.Add(this.btnRefreshSounds);
            this.grpUnlockSound.Controls.Add(this.btnDemo);
            this.grpUnlockSound.Controls.Add(this.cboUnlockSound);
            this.grpUnlockSound.Controls.Add(this.chkRandom);
            this.grpUnlockSound.Location = new System.Drawing.Point(12, 12);
            this.grpUnlockSound.Name = "grpUnlockSound";
            this.grpUnlockSound.Size = new System.Drawing.Size(267, 78);
            this.grpUnlockSound.TabIndex = 0;
            this.grpUnlockSound.TabStop = false;
            this.grpUnlockSound.Text = "Unlock Sound";
            // 
            // btnRefreshSounds
            // 
            this.btnRefreshSounds.Location = new System.Drawing.Point(160, 18);
            this.btnRefreshSounds.Name = "btnRefreshSounds";
            this.btnRefreshSounds.Size = new System.Drawing.Size(101, 23);
            this.btnRefreshSounds.TabIndex = 2;
            this.btnRefreshSounds.Text = "Refresh Sounds";
            this.btnRefreshSounds.UseVisualStyleBackColor = true;
            this.btnRefreshSounds.Click += new System.EventHandler(this.btnRefreshSounds_Click);
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(232, 47);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(29, 23);
            this.btnDemo.TabIndex = 4;
            this.btnDemo.Text = "♫";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // cboUnlockSound
            // 
            this.cboUnlockSound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnlockSound.FormattingEnabled = true;
            this.cboUnlockSound.Location = new System.Drawing.Point(6, 47);
            this.cboUnlockSound.Name = "cboUnlockSound";
            this.cboUnlockSound.Size = new System.Drawing.Size(220, 23);
            this.cboUnlockSound.TabIndex = 3;
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Location = new System.Drawing.Point(6, 22);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(71, 19);
            this.chkRandom.TabIndex = 1;
            this.chkRandom.Text = "Random";
            this.chkRandom.UseVisualStyleBackColor = true;
            // 
            // grpEmulator
            // 
            this.grpEmulator.Controls.Add(this.cboEmulator);
            this.grpEmulator.Location = new System.Drawing.Point(12, 96);
            this.grpEmulator.Name = "grpEmulator";
            this.grpEmulator.Size = new System.Drawing.Size(267, 53);
            this.grpEmulator.TabIndex = 1;
            this.grpEmulator.TabStop = false;
            this.grpEmulator.Text = "Emulator";
            // 
            // cboEmulator
            // 
            this.cboEmulator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmulator.FormattingEnabled = true;
            this.cboEmulator.Location = new System.Drawing.Point(6, 22);
            this.cboEmulator.Name = "cboEmulator";
            this.cboEmulator.Size = new System.Drawing.Size(255, 23);
            this.cboEmulator.TabIndex = 5;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 155);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLaunch.Location = new System.Drawing.Point(204, 155);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(75, 23);
            this.btnLaunch.TabIndex = 7;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(292, 187);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.grpEmulator);
            this.Controls.Add(this.grpUnlockSound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RA Unlock Sound Manager";
            this.Load += new System.EventHandler(this.FormLoad);
            this.grpUnlockSound.ResumeLayout(false);
            this.grpUnlockSound.PerformLayout();
            this.grpEmulator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpUnlockSound;
        private Button btnRefreshSounds;
        private Button btnDemo;
        private ComboBox cboUnlockSound;
        private CheckBox chkRandom;
        private GroupBox grpEmulator;
        private ComboBox cboEmulator;
        private Button btnSettings;
        private Button btnLaunch;
    }
}