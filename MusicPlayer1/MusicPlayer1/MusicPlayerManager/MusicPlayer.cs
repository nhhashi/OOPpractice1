using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer1.MusicPlayerManager
{
    class MusicPlayer
    {
        ///MusicPlayControllerインターフェース型の変数
        private MusicPlayController musicPlayState = null;

        /// <summary>
        /// 状態インスタンス取得関数
        /// </summary>
        /// <param name="musicPlayController"></param>
        public void changeMusicPlayState(MusicPlayController musicPlayState)
        {
            ///取得した拡張子情報
            this.musicPlayState = musicPlayState;
        }

        /// <summary>
        /// パスの取得関数
        /// </summary>
        /// <param name="path"></param>
        public void setMusicPath(string path)
        {
            this.musicPlayState.setMusicPath(path);
        }

        /// <summary>
        /// 再生関数
        /// </summary>
        public void play()
        {
            this.musicPlayState.Play();

            PlayState.getInstance().medhiaPlayState = MedhiaPlayState.PLAY;
        }

        /// <summary>
        /// 一時停止関数
        /// </summary>
        public void pause()
        {
            this.musicPlayState.Pause();

            PlayState.getInstance().medhiaPlayState = MedhiaPlayState.PAUSE;
        }

        /// <summary>
        /// 停止関数
        /// </summary>
        public void stop()
        {
            this.musicPlayState.Stop();

            PlayState.getInstance().medhiaPlayState = MedhiaPlayState.STOP;
        }
    }
}
