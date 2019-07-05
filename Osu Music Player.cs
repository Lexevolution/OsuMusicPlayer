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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DialogResult result = gameDirectoryChooser.ShowDialog();
            if (result == DialogResult.OK)
            {
                beatmapScanner = new SongSorter(gameDirectoryChooser.SelectedPath);
            }
        }
    }
}
