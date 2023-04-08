namespace RAUnlockSoundManager.Views.Dialogs
{
    partial class dlgSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgSettings));
            this.grpUnlockSoundPath = new System.Windows.Forms.GroupBox();
            this.btnUnlockSoundPath = new System.Windows.Forms.Button();
            this.txtUnlockSoundPath = new System.Windows.Forms.TextBox();
            this.grpffmpegExecutablePath = new System.Windows.Forms.GroupBox();
            this.btnffmpegExecutablePath = new System.Windows.Forms.Button();
            this.txtffmpegExecutablePath = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpEmulatorExecutablePaths = new System.Windows.Forms.GroupBox();
            this.lstEmulators = new System.Windows.Forms.ListBox();
            this.btnEmulatorExecutablePath = new System.Windows.Forms.Button();
            this.txtEmulatorExecutablePath = new System.Windows.Forms.TextBox();
            this.grpUnlockSoundPath.SuspendLayout();
            this.grpffmpegExecutablePath.SuspendLayout();
            this.grpEmulatorExecutablePaths.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUnlockSoundPath
            // 
            this.grpUnlockSoundPath.Controls.Add(this.btnUnlockSoundPath);
            this.grpUnlockSoundPath.Controls.Add(this.txtUnlockSoundPath);
            this.grpUnlockSoundPath.Location = new System.Drawing.Point(12, 12);
            this.grpUnlockSoundPath.Name = "grpUnlockSoundPath";
            this.grpUnlockSoundPath.Size = new System.Drawing.Size(611, 54);
            this.grpUnlockSoundPath.TabIndex = 0;
            this.grpUnlockSoundPath.TabStop = false;
            this.grpUnlockSoundPath.Text = "Unlock Sound Path";
            // 
            // btnUnlockSoundPath
            // 
            this.btnUnlockSoundPath.Location = new System.Drawing.Point(572, 22);
            this.btnUnlockSoundPath.Name = "btnUnlockSoundPath";
            this.btnUnlockSoundPath.Size = new System.Drawing.Size(33, 23);
            this.btnUnlockSoundPath.TabIndex = 1;
            this.btnUnlockSoundPath.Text = "...";
            this.btnUnlockSoundPath.UseVisualStyleBackColor = true;
            this.btnUnlockSoundPath.Click += new System.EventHandler(this.GetPathClick);
            // 
            // txtUnlockSoundPath
            // 
            this.txtUnlockSoundPath.Location = new System.Drawing.Point(6, 22);
            this.txtUnlockSoundPath.Name = "txtUnlockSoundPath";
            this.txtUnlockSoundPath.Size = new System.Drawing.Size(560, 23);
            this.txtUnlockSoundPath.TabIndex = 1;
            // 
            // grpffmpegExecutablePath
            // 
            this.grpffmpegExecutablePath.Controls.Add(this.btnffmpegExecutablePath);
            this.grpffmpegExecutablePath.Controls.Add(this.txtffmpegExecutablePath);
            this.grpffmpegExecutablePath.Location = new System.Drawing.Point(12, 72);
            this.grpffmpegExecutablePath.Name = "grpffmpegExecutablePath";
            this.grpffmpegExecutablePath.Size = new System.Drawing.Size(611, 54);
            this.grpffmpegExecutablePath.TabIndex = 5;
            this.grpffmpegExecutablePath.TabStop = false;
            this.grpffmpegExecutablePath.Text = "ffmpeg Executable Path";
            // 
            // btnffmpegExecutablePath
            // 
            this.btnffmpegExecutablePath.Location = new System.Drawing.Point(572, 22);
            this.btnffmpegExecutablePath.Name = "btnffmpegExecutablePath";
            this.btnffmpegExecutablePath.Size = new System.Drawing.Size(33, 23);
            this.btnffmpegExecutablePath.TabIndex = 1;
            this.btnffmpegExecutablePath.Text = "...";
            this.btnffmpegExecutablePath.UseVisualStyleBackColor = true;
            this.btnffmpegExecutablePath.Click += new System.EventHandler(this.GetPathClick);
            // 
            // txtffmpegExecutablePath
            // 
            this.txtffmpegExecutablePath.Location = new System.Drawing.Point(6, 22);
            this.txtffmpegExecutablePath.Name = "txtffmpegExecutablePath";
            this.txtffmpegExecutablePath.Size = new System.Drawing.Size(560, 23);
            this.txtffmpegExecutablePath.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(468, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(549, 290);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OKButtonClick);
            // 
            // grpEmulatorExecutablePaths
            // 
            this.grpEmulatorExecutablePaths.Controls.Add(this.lstEmulators);
            this.grpEmulatorExecutablePaths.Controls.Add(this.btnEmulatorExecutablePath);
            this.grpEmulatorExecutablePaths.Controls.Add(this.txtEmulatorExecutablePath);
            this.grpEmulatorExecutablePaths.Location = new System.Drawing.Point(12, 132);
            this.grpEmulatorExecutablePaths.Name = "grpEmulatorExecutablePaths";
            this.grpEmulatorExecutablePaths.Size = new System.Drawing.Size(611, 152);
            this.grpEmulatorExecutablePaths.TabIndex = 8;
            this.grpEmulatorExecutablePaths.TabStop = false;
            this.grpEmulatorExecutablePaths.Text = "Emulator Executable Paths";
            // 
            // lstEmulators
            // 
            this.lstEmulators.FormattingEnabled = true;
            this.lstEmulators.ItemHeight = 15;
            this.lstEmulators.Items.AddRange(new object[] {
            "BizHawk",
            "Duckstation",
            "PCSX2",
            "RAP64",
            "RetroArch"});
            this.lstEmulators.Location = new System.Drawing.Point(6, 22);
            this.lstEmulators.Name = "lstEmulators";
            this.lstEmulators.Size = new System.Drawing.Size(144, 124);
            this.lstEmulators.TabIndex = 2;
            this.lstEmulators.SelectedIndexChanged += new System.EventHandler(this.EmulatorIndexChange);
            // 
            // btnEmulatorExecutablePath
            // 
            this.btnEmulatorExecutablePath.Location = new System.Drawing.Point(572, 22);
            this.btnEmulatorExecutablePath.Name = "btnEmulatorExecutablePath";
            this.btnEmulatorExecutablePath.Size = new System.Drawing.Size(33, 23);
            this.btnEmulatorExecutablePath.TabIndex = 1;
            this.btnEmulatorExecutablePath.Text = "...";
            this.btnEmulatorExecutablePath.UseVisualStyleBackColor = true;
            this.btnEmulatorExecutablePath.Click += new System.EventHandler(this.GetPathClick);
            // 
            // txtEmulatorExecutablePath
            // 
            this.txtEmulatorExecutablePath.Location = new System.Drawing.Point(156, 22);
            this.txtEmulatorExecutablePath.Name = "txtEmulatorExecutablePath";
            this.txtEmulatorExecutablePath.Size = new System.Drawing.Size(410, 23);
            this.txtEmulatorExecutablePath.TabIndex = 1;
            // 
            // dlgSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(636, 320);
            this.Controls.Add(this.grpEmulatorExecutablePaths);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpffmpegExecutablePath);
            this.Controls.Add(this.grpUnlockSoundPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormLoad);
            this.grpUnlockSoundPath.ResumeLayout(false);
            this.grpUnlockSoundPath.PerformLayout();
            this.grpffmpegExecutablePath.ResumeLayout(false);
            this.grpffmpegExecutablePath.PerformLayout();
            this.grpEmulatorExecutablePaths.ResumeLayout(false);
            this.grpEmulatorExecutablePaths.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpUnlockSoundPath;
        private Button btnUnlockSoundPath;
        private TextBox txtUnlockSoundPath;
        private GroupBox grpffmpegExecutablePath;
        private Button btnffmpegExecutablePath;
        private TextBox txtffmpegExecutablePath;
        private Button btnCancel;
        private Button btnOK;
        private GroupBox grpEmulatorExecutablePaths;
        private ListBox lstEmulators;
        private Button btnEmulatorExecutablePath;
        private TextBox txtEmulatorExecutablePath;
    }
}