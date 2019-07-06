using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuMusicPlayer
{
    public class song : IEquatable<song>
    {
        public string songDir { get; set; }
        public string artist { get; set; }
        public string title { get; set; }
        public string bgArt { get; set; }
        public bool isOgg { get; set; }

        public song(string songDir, string title, string artist, string bgArt)
        {
            this.songDir = songDir;
            this.artist = artist;
            this.title = title;
            this.bgArt = bgArt;
            this.isOgg = Path.GetExtension(songDir).Equals(".ogg");
        }

        public bool Equals(song other) => songDir.Equals(other.songDir);

        public override int GetHashCode() => songDir.GetHashCode();
    }
}
