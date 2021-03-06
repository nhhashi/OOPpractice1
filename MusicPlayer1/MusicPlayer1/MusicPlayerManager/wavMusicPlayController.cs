using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MusicPlayer1.MusicPlayerManager
{
    class wavMusicPlayController : MusicPlayController
    {
        private string musicPath = string.Empty;

        private SoundPlayer player;
        

        public void Pause()
        {
            MessageBox.Show("wav：一時停止します。曲名：" + this.musicPath);
            
        }

        public void Play()
        {
            MessageBox.Show("wav：再生します。曲名：" + this.musicPath);

            ///再生する
            player = new SoundPlayer(this.musicPath);
            player.Play();
        }

        public void setMusicPath(string musicPath)
        {
            ///MessageBox.Show("wav：楽曲パス" + musicPath);
            this.musicPath = musicPath;
        }

        public void Stop()
        {
            MessageBox.Show("wav：停止します。曲名：" + this.musicPath);

            player.Stop();
        }
    }
}
