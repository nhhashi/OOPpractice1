using MusicPlayer1.MusicPlayerManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer1
{
    public partial class Form1 : Form
    {
        MusicPlayer _MusicPlayer;

        public Form1()
        {
            InitializeComponent();

            _MusicPlayer = new MusicPlayer();

            ///wav拡張子ファイル
            _MusicPlayer.changeMusicPlayState(new wavMusicPlayController());

            _MusicPlayer.setMusicPath("テスト曲だー");

            _MusicPlayer.play();
            _MusicPlayer.pause();
            _MusicPlayer.stop();
        }

        private void selectExtendState()
        {
            string extend = "wav";

            switch (extend)
            {
                case "aif":

                    _MusicPlayer.changeMusicPlayState(new aifMusicPlayController());
                    break;

                case "mid":

                    _MusicPlayer.changeMusicPlayState(new midMusicPlayController());
                    break;

                case "mp3":

                    _MusicPlayer.changeMusicPlayState(new mp3MusicPlayController());
                    break;

                case "wav":

                    _MusicPlayer.changeMusicPlayState(new wavMusicPlayController());
                    break;

                default:
                    break;
            }
        }
    }
}
