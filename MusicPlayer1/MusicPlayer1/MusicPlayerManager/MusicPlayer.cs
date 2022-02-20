using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer1.MusicPlayerManager
{
    class MusicPlayer
    {
        ///
        private MusicPlayController musicPlayState = null;

        /// <summary>
        /// 再生状態
        /// </summary>
        MedhiaPlayState medhiaPlayState = MedhiaPlayState.STOP;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="musicPlayController"></param>
        public void changeMusicPlayState(MusicPlayController musicPlayState)
        {
            ///取得した拡張子情報
            this.musicPlayState = musicPlayState;
        }

        public void setMusicPath(string path)
        {
            this.musicPlayState.setMusicPath(path);
        }

        public void play()
        {
            this.musicPlayState.Play();

            PlayState.getInstance().medhiaPlayState = MedhiaPlayState.PLAY;
        }

        public void pause()
        {
            this.musicPlayState.Pause();

            PlayState.getInstance().medhiaPlayState = MedhiaPlayState.PAUSE;
        }

        public void stop()
        {
            this.musicPlayState.Stop();

            PlayState.getInstance().medhiaPlayState = MedhiaPlayState.STOP;
        }
    }
}
