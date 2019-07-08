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
        private bool changeFolder;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            gameDirectoryChooser.Description = "Select your osu! game folder...";

            if (Properties.Settings.Default["gamePath"].ToString() == "" || changeFolder == true)
            {
                DialogResult result = gameDirectoryChooser.ShowDialog();
                if (result == DialogResult.OK)
                {
                    changeFolder = false;
                    Setup(gameDirectoryChooser.SelectedPath);
                    Properties.Settings.Default["gamePath"] = gameDirectoryChooser.SelectedPath;
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                Setup(Properties.Settings.Default["gamePath"].ToString());
            }
            
        }

        private void Setup(string directory)
        {
            if (beatmapScanner != null)
            {
                beatmapScanner = null;
            }
            beatmapScanner = new SongSorter(directory);
            if (beatmapScanner.gameDirExists())
            {
                musicPlayer = new Player();
                musicPlayer.UpdateParent(this);
                random = new Random();
                LocationLabel.Text = String.Format("Will scan songs at: {0}", directory);
                CurrentDirLabel.Text = String.Format("Current selected directory: {0}", directory);
            }
            else
            {
                MessageBox.Show("You didn't select an osu! game folder!\nPlease try again", "osu! not found!", MessageBoxButtons.OK);
                changeFolder = true;
                MainForm_Shown(this, EventArgs.Empty);
            }
            
        }

        private void MainForm_Closing(object sender, EventArgs e)
        {
            if (musicPlayer != null)
            {
                musicPlayer.StopSong();
                Properties.Settings.Default.Save();
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

        private void ChangeDirButton_Click(object sender, EventArgs e)
        {
            changeFolder = true;
            MainForm_Shown(this, EventArgs.Empty);
        }

        private void volumeSlider_VolumeChanged(object sender, EventArgs e)
        {
            musicPlayer.ChangeVolume(volumeSlider.Volume);
        }

    }
}
