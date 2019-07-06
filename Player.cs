using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;//This one
using NAudio.Vorbis;//This one
using NAudio.Wave;
using NVorbis;//This one

namespace OsuMusicPlayer
{
    public class Player
    {
        private WaveOutEvent audioOutput;
        private AudioFileReader audioFile;
        private VorbisWaveReader oggReader;
        private MainForm parent;
        private song currentSong;

        public Player()
        {
            audioOutput = new WaveOutEvent();
            audioOutput.PlaybackStopped += AudioOutput_PlaybackStopped;
        }

        private void AudioOutput_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (audioOutput.PlaybackState == PlaybackState.Stopped)
            {
                parent.FastForwardButton_Click(this, new EventArgs());
            }
        }

        public void PlaySong(song song)
        {
            if (audioFile == null && oggReader == null)
            {
                currentSong = song;
                if (song.isOgg)
                {
                    oggReader = new VorbisWaveReader(song.songDir);
                    audioOutput.Init(oggReader);
                }
                else
                {
                    audioFile = new AudioFileReader(song.songDir);
                    audioOutput.Init(audioFile);
                }
                audioOutput.Play();
            }
            else
            {
                audioOutput.Play();
            }
        }

        public void UpdateParent (MainForm window)
        {
            parent = window;
        }

        public void PauseSong()
        {
            audioOutput.Pause();
        }

        public void NextSong(song song)
        {
            StopSong();
            PlaySong(song);
        }

        public void StopSong()
        {
            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
            if (oggReader != null)
            {
                oggReader.Dispose();
                oggReader = null;
            }
            audioOutput.Stop();
        }

        public void ChangeVolume(float percent)
        {
            if (audioOutput != null)
            {
                audioOutput.Volume = percent;
            }
        }
    }
}
