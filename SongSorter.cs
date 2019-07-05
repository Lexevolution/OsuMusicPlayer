using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OsuMusicPlayer
{
    public class SongSorter
    {
        private List<song> songList;
        private List<string> tempFolderList;
        private List<string> tempSongList;
        private string gameFolder;

        public SongSorter(string directory)
        {
            gameFolder = directory;
            songList = new List<song>();
            tempFolderList = new List<string>();
            tempSongList = new List<string>();
        }

        public List<song> ScanSongs()
        {
            StreamReader reader;
            string line,
                tempSongDir = "",
                tempTitle = "",
                tempArtist = "",
                tempBgDir = "";
            string songsDir = String.Concat(gameFolder, "\\Songs");
            tempFolderList.AddRange(Directory.GetDirectories(songsDir));
            foreach (string beatmap in tempFolderList)
            {
                tempSongList.Clear();
                tempSongList.AddRange(Directory.EnumerateFiles(beatmap, "*.osu"));
                foreach(string songFile in tempSongList)
                {
                    reader = new StreamReader(songFile);
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains("AudioFilename:"))
                        {
                            tempSongDir = line.Substring(15);
                            tempSongDir = String.Concat(beatmap, "\\" ,tempSongDir);
                            
                        }
                        else if (line.Contains("Title:"))
                        {
                            tempTitle = line.Substring(6);
                        }
                        else if (line.Contains("Artist:"))
                        {
                            tempArtist = line.Substring(7);
                        }
                        else if (line.Contains("//Background and Video events"))
                        {
                            try
                            {
                                tempBgDir = reader.ReadLine().Split(',')[2].Replace("\"", "");
                                tempBgDir = String.Concat(beatmap, "\\", tempBgDir);
                            }
                            catch (IndexOutOfRangeException) { tempBgDir = ""; }
                        }
                    }
                    songList.Add(new song(tempSongDir, tempTitle, tempArtist, tempBgDir));
                }
            }
            songList = songList.Distinct().ToList();
            return songList;
        }
    }
}
