using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer1
{
    public enum MedhiaPlayState
    {
        PLAY,
        PAUSE,
        STOP
    }

    class PlayState
    {
        private static PlayState playState = new PlayState();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private PlayState()
        {
        }


        public static PlayState getInstance()
        {
            return playState;
        }


        public MedhiaPlayState medhiaPlayState
        {
            get;
            set;
        }


    }
}
