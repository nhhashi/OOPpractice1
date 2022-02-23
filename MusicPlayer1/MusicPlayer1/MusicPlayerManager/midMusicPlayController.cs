using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayer1.MusicPlayerManager
{
    class midMusicPlayController : MusicPlayController
    {
        private string musicPath = string.Empty;

        ///音楽プレイヤーインスタンス
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        private static double mediaCurrentPos = 0;

        public void Pause()
        {
            MessageBox.Show("mid：一時停止します。曲名：" + this.musicPath);

            ///再生中メディアの現在位置を取得する
            mediaCurrentPos = player.controls.currentPosition;
        }

        public void Play()
        {
            MessageBox.Show("mid：再生します。曲名：" + this.musicPath);

            player.URL = this.musicPath;
            player.controls.currentPosition = mediaCurrentPos;
            player.controls.play();
        }

        public void setMusicPath(string musicPath)
        {

            this.musicPath = musicPath;
        }

        public void Stop()
        {
            MessageBox.Show("mid：停止します。曲名：" + this.musicPath);

            ///音楽の停止を実施する
            mediaCurrentPos = 0;
            player.controls.stop();
        }

        ~midMusicPlayController()
        {
            MessageBox.Show("mid : デストラクタ作動");
        }
    }
}
