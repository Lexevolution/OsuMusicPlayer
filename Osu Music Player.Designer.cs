namespace OsuMusicPlayer
{
    partial class MainForm
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
            this.gameDirectoryChooser = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ScanPage = new System.Windows.Forms.TabPage();
            this.SongAmountLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.ScanSongsButton = new System.Windows.Forms.Button();
            this.PlayPage = new System.Windows.Forms.TabPage();
            this.BackgroundImage = new System.Windows.Forms.PictureBox();
            this.NowPlayingText = new System.Windows.Forms.Label();
            this.volumeSlider = new NAudio.Gui.VolumeSlider();
            this.FastForwardButton = new System.Windows.Forms.PictureBox();
            this.PlayPauseButton = new System.Windows.Forms.PictureBox();
            this.ExportPage = new System.Windows.Forms.TabPage();
            this.OptionsPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.ScanPage.SuspendLayout();
            this.PlayPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FastForwardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPauseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // gameDirectoryChooser
            // 
            this.gameDirectoryChooser.ShowNewFolderButton = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.ScanPage);
            this.tabControl1.Controls.Add(this.PlayPage);
            this.tabControl1.Controls.Add(this.ExportPage);
            this.tabControl1.Controls.Add(this.OptionsPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 572);
            this.tabControl1.TabIndex = 0;
            // 
            // ScanPage
            // 
            this.ScanPage.Controls.Add(this.SongAmountLabel);
            this.ScanPage.Controls.Add(this.LocationLabel);
            this.ScanPage.Controls.Add(this.ScanSongsButton);
            this.ScanPage.Location = new System.Drawing.Point(4, 22);
            this.ScanPage.Name = "ScanPage";
            this.ScanPage.Padding = new System.Windows.Forms.Padding(3);
            this.ScanPage.Size = new System.Drawing.Size(412, 546);
            this.ScanPage.TabIndex = 0;
            this.ScanPage.Text = "Scan";
            this.ScanPage.UseVisualStyleBackColor = true;
            // 
            // SongAmountLabel
            // 
            this.SongAmountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SongAmountLabel.Location = new System.Drawing.Point(8, 446);
            this.SongAmountLabel.Name = "SongAmountLabel";
            this.SongAmountLabel.Size = new System.Drawing.Size(395, 23);
            this.SongAmountLabel.TabIndex = 2;
            this.SongAmountLabel.Text = "0 songs found";
            this.SongAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocationLabel
            // 
            this.LocationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationLabel.Location = new System.Drawing.Point(8, 100);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(395, 75);
            this.LocationLabel.TabIndex = 1;
            this.LocationLabel.Text = "Will scan songs at:";
            this.LocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScanSongsButton
            // 
            this.ScanSongsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScanSongsButton.Location = new System.Drawing.Point(165, 246);
            this.ScanSongsButton.Name = "ScanSongsButton";
            this.ScanSongsButton.Size = new System.Drawing.Size(75, 23);
            this.ScanSongsButton.TabIndex = 0;
            this.ScanSongsButton.Text = "Scan Songs";
            this.ScanSongsButton.UseVisualStyleBackColor = true;
            this.ScanSongsButton.Click += new System.EventHandler(this.ScanSongsButton_Click);
            // 
            // PlayPage
            // 
            this.PlayPage.Controls.Add(this.BackgroundImage);
            this.PlayPage.Controls.Add(this.NowPlayingText);
            this.PlayPage.Controls.Add(this.volumeSlider);
            this.PlayPage.Controls.Add(this.FastForwardButton);
            this.PlayPage.Controls.Add(this.PlayPauseButton);
            this.PlayPage.Location = new System.Drawing.Point(4, 22);
            this.PlayPage.Name = "PlayPage";
            this.PlayPage.Padding = new System.Windows.Forms.Padding(3);
            this.PlayPage.Size = new System.Drawing.Size(412, 546);
            this.PlayPage.TabIndex = 1;
            this.PlayPage.Text = "Play";
            this.PlayPage.UseVisualStyleBackColor = true;
            // 
            // BackgroundImage
            // 
            this.BackgroundImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundImage.Location = new System.Drawing.Point(9, 96);
            this.BackgroundImage.Name = "BackgroundImage";
            this.BackgroundImage.Size = new System.Drawing.Size(397, 275);
            this.BackgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackgroundImage.TabIndex = 4;
            this.BackgroundImage.TabStop = false;
            // 
            // NowPlayingText
            // 
            this.NowPlayingText.Location = new System.Drawing.Point(6, 19);
            this.NowPlayingText.Name = "NowPlayingText";
            this.NowPlayingText.Size = new System.Drawing.Size(400, 74);
            this.NowPlayingText.TabIndex = 3;
            this.NowPlayingText.Text = "Now Playing: ";
            // 
            // volumeSlider
            // 
            this.volumeSlider.AllowDrop = true;
            this.volumeSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeSlider.Location = new System.Drawing.Point(8, 377);
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(395, 28);
            this.volumeSlider.TabIndex = 2;
            this.volumeSlider.VolumeChanged += new System.EventHandler(this.volumeSlider_VolumeChanged);
            // 
            // FastForwardButton
            // 
            this.FastForwardButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FastForwardButton.Image = global::OsuMusicPlayer.Properties.Resources.fast_forward;
            this.FastForwardButton.Location = new System.Drawing.Point(213, 411);
            this.FastForwardButton.Name = "FastForwardButton";
            this.FastForwardButton.Size = new System.Drawing.Size(80, 80);
            this.FastForwardButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FastForwardButton.TabIndex = 1;
            this.FastForwardButton.TabStop = false;
            this.FastForwardButton.Click += new System.EventHandler(this.FastForwardButton_Click);
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayPauseButton.Image = global::OsuMusicPlayer.Properties.Resources.play_button;
            this.PlayPauseButton.Location = new System.Drawing.Point(103, 411);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(80, 80);
            this.PlayPauseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayPauseButton.TabIndex = 0;
            this.PlayPauseButton.TabStop = false;
            this.PlayPauseButton.Click += new System.EventHandler(this.PlayPauseButton_Click);
            // 
            // ExportPage
            // 
            this.ExportPage.Location = new System.Drawing.Point(4, 22);
            this.ExportPage.Name = "ExportPage";
            this.ExportPage.Size = new System.Drawing.Size(412, 546);
            this.ExportPage.TabIndex = 2;
            this.ExportPage.Text = "Export";
            this.ExportPage.UseVisualStyleBackColor = true;
            // 
            // OptionsPage
            // 
            this.OptionsPage.Location = new System.Drawing.Point(4, 22);
            this.OptionsPage.Name = "OptionsPage";
            this.OptionsPage.Size = new System.Drawing.Size(412, 546);
            this.OptionsPage.TabIndex = 3;
            this.OptionsPage.Text = "Options";
            this.OptionsPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 570);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Osu! Music Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.ScanPage.ResumeLayout(false);
            this.PlayPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FastForwardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPauseButton)).EndInit();
            this.ResumeLayout(false);

        }

        private void VolumeSlider_VolumeChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog gameDirectoryChooser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ScanPage;
        private System.Windows.Forms.TabPage PlayPage;
        private System.Windows.Forms.TabPage ExportPage;
        private System.Windows.Forms.Button ScanSongsButton;
        private System.Windows.Forms.TabPage OptionsPage;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label SongAmountLabel;
        private System.Windows.Forms.PictureBox PlayPauseButton;
        private System.Windows.Forms.PictureBox FastForwardButton;
        private NAudio.Gui.VolumeSlider volumeSlider;
        private System.Windows.Forms.Label NowPlayingText;
        private System.Windows.Forms.PictureBox BackgroundImage;
    }
}

