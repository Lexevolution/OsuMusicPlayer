using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuMusicPlayer
{
    public partial class MainForm : Form
    {
        private SongSorter beatmapScanner;
        private Player musicPlayer;
        private List<song> incSongs, excSongs;
        private song currentSong;
        private bool songPlaying = false;
        private Random random;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            gameDirectoryChooser.Description = "Select your osu! game folder...";
            DialogResult result = gameDirectoryChooser.ShowDialog();
            if (result == DialogResult.OK)
            {
                beatmapScanner = new SongSorter(gameDirectoryChooser.SelectedPath);
                musicPlayer = new Player();
                musicPlayer.UpdateParent(this);
                random = new Random();
                LocationLabel.Text = String.Format("Will scan songs at: {0}", gameDirectoryChooser.SelectedPath);
            }
            else
            {
                Application.Exit();
            }
        }

        private void MainForm_Closing(object sender, EventArgs e)
        {
            if (musicPlayer != null)
            {
                musicPlayer.StopSong();
            }
        }

        private void ScanSongsButton_Click(object sender, EventArgs e)
        {
            SongAmountLabel.Text = "Scanning...";
            incSongs = beatmapScanner.ScanSongs();
            SongAmountLabel.Text = String.Format("{0} songs found", incSongs.Count);
        }

        private void PlayPauseButton_Click(object sender, EventArgs e)
        {
            if (incSongs != null)
            {
                if (currentSong == null)
                {
                    currentSong = incSongs[random.Next(incSongs.Count - 1)];
                    NowPlayingText.Text = String.Format("Now Playing: {0} - {1}", currentSong.artist, currentSong.title);
                    BackgroundImage.ImageLocation = currentSong.bgArt;
                }
                if (songPlaying)
                {
                    PlayPauseButton.Image = Properties.Resources.play_button;
                    songPlaying = false;
                    musicPlayer.PauseSong();
                }
                else
                {
                    PlayPauseButton.Image = Properties.Resources.pause;
                    songPlaying = true;
                    musicPlayer.PlaySong(currentSong);
                }
            }
            
        }

        public void FastForwardButton_Click(object sender, EventArgs e)
        {
            currentSong = incSongs[random.Next(incSongs.Count - 1)];
            NowPlayingText.Text = String.Format("Now Playing: {0} - {1}", currentSong.artist, currentSong.title);
            BackgroundImage.ImageLocation = currentSong.bgArt;
            musicPlayer.NextSong(currentSong);
        }

        private void volumeSlider_VolumeChanged(object sender, EventArgs e)
        {
            musicPlayer.ChangeVolume(volumeSlider.Volume);
        }

    }
}
