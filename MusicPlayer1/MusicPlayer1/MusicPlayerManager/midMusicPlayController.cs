using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer1.MusicPlayerManager
{
    class midMusicPlayController : MusicPlayController
    {
        private string musicPath = string.Empty;

        public void Pause()
        {
            MessageBox.Show("mid：一時停止します。曲名：" + this.musicPath);
        }

        public void Play()
        {
            MessageBox.Show("mid：再生します。曲名：" + this.musicPath);
        }

        public void setMusicPath(string musicPath)
        {

            this.musicPath = musicPath;
        }

        public void Stop()
        {
            MessageBox.Show("mid：停止します。曲名：" + this.musicPath);
        }
    }
}
