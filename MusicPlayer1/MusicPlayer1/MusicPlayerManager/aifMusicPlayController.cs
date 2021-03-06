using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MusicPlayer1.MusicPlayerManager
{
    class aifMusicPlayController : MusicPlayController
    {
        private string musicPath = string.Empty;

        private SoundPlayer player;

        public void Pause()
        {
            MessageBox.Show("aif：一時停止します。曲名：" + this.musicPath);
        }

        public void Play()
        {
            MessageBox.Show("aif：再生します。曲名：" + this.musicPath);

            ///再生する
            player = new SoundPlayer(this.musicPath);
            player.Play();
        }

        public void setMusicPath(string musicPath)
        {
            this.musicPath = musicPath;
        }

        public void Stop()
        {
            MessageBox.Show("aif：停止します。曲名：" + this.musicPath);

            player.Stop();
        }
    }
}
