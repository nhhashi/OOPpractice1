using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer1.MusicPlayerManager
{
    class mp3MusicPlayController : MusicPlayController
    {
        private string musicPath = string.Empty;

        public void Pause()
        {
            MessageBox.Show("mp3：一時停止します。曲名：" + this.musicPath);
        }

        public void Play()
        {
            MessageBox.Show("mp3：再生します。曲名：" + this.musicPath);
        }

        public void setMusicPath(string musicPath)
        {
            ///MessageBox.Show("mp3：楽曲パス" + musicPath);
            this.musicPath = musicPath;
        }

        public void Stop()
        {
            MessageBox.Show("mp3：停止します。曲名：" + this.musicPath);
        }
    }
}
